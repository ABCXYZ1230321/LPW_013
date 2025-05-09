using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace ADB_Form
{
    public partial class tabPage1 : Form
    {
        public tabPage1()
        {
            InitializeComponent();
        }

        private void tabPage1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LPW;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Contacts";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridContacts.DataSource = dt;

                string query1 = "SELECT * FROM Messages";
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, conn);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                dataGridSMS.DataSource = dt1;

                string query2 = "SELECT * FROM CallLogs";
                SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                dataGridLogs.DataSource = dt2;

                string query3 = "SELECT * FROM DeviceInfo";
                SqlDataAdapter adapter3 = new SqlDataAdapter(query3, conn);
                DataTable dt3 = new DataTable();
                adapter3.Fill(dt3);
                dataGridContacts.DataSource = dt3;*/
        }
        
    }
}
    


    public class ContactExtractor
    {
        public void ExtractContactsAndInsertToDb(string filePath, SqlConnection conn)
        {
            try
            {
                conn.Open();
                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    string contactName = ExtractContactName(line);
                    string contactNumber = ExtractContactNumber(line);

                    InsertContactToDb(contactName, contactNumber, conn);
                }

                Console.WriteLine("Contacts extracted and inserted successfully.");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private string ExtractContactName(string line)
        {
            int nameStartIndex = line.IndexOf("display_name=") + "display_name=".Length;
            int nameEndIndex = line.IndexOf(",", nameStartIndex);
            return line.Substring(nameStartIndex, nameEndIndex - nameStartIndex);
        }

        private string ExtractContactNumber(string line)
        {
            int numberStartIndex = line.IndexOf("number=") + "number=".Length;
            return line.Substring(numberStartIndex).Trim(); 
        }

        private void InsertContactToDb(string contactName, string contactNumber, SqlConnection conn)
        {
            string query = "INSERT INTO Contacts (Name, PhoneNumber) VALUES (@Name, @Phone)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", contactName);
                cmd.Parameters.AddWithValue("@Phone", contactNumber);

               
                cmd.ExecuteNonQuery();
            }
        }
    }
public class MessageExtractor
    {
        public void ExtractMessagesAndInsertToDb(string filePath, SqlConnection conn)
        {
            try
            {

                conn.Open();
                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    string sender = ExtractSender(line);
                    string messageContent = ExtractMessageContent(line);
                    DateTime timestamp = ExtractTimestamp(line);

                    InsertMessageToDb(sender, messageContent, timestamp, conn);
                }

                Console.WriteLine("Messages extracted and inserted successfully.");

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private string ExtractSender(string line)
        {
            int senderStartIndex = line.IndexOf("address=") + "address=".Length;
            int senderEndIndex = line.IndexOf(",", senderStartIndex);
            return line.Substring(senderStartIndex, senderEndIndex - senderStartIndex);
        }

        private string ExtractMessageContent(string line)
        {
            int bodyStartIndex = line.IndexOf("body=") + "body=".Length;
            int bodyEndIndex = line.IndexOf(",", bodyStartIndex);
            return line.Substring(bodyStartIndex, bodyEndIndex - bodyStartIndex);
        }

        private DateTime ExtractTimestamp(string line)
        {
            int timestampStartIndex = line.IndexOf("date=") + "date=".Length;
            int timestampEndIndex = line.IndexOf(",", timestampStartIndex);
            long timestamp = long.Parse(line.Substring(timestampStartIndex, timestampEndIndex - timestampStartIndex));
            return DateTimeOffset.FromUnixTimeMilliseconds(timestamp).DateTime; 
        }

        private void InsertMessageToDb(string sender, string messageContent, DateTime timestamp, SqlConnection conn)
        {
            string query = "INSERT INTO Messages (Sender, MessageContent, Timestamp) " +
                           "VALUES (@Sender, @MessageContent, @Timestamp)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Sender", sender);
                cmd.Parameters.AddWithValue("@MessageContent", messageContent);
                cmd.Parameters.AddWithValue("@Timestamp", timestamp);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public class CallLogExtractor
    {
        public void ExtractCallLogsAndInsertToDb(string filePath, SqlConnection conn)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                conn.Open();
                foreach (var line in lines)
                {
                    string phoneNumber = ExtractPhoneNumber(line);
                    string callType = ExtractCallType(line);
                    string duration = ExtractDuration(line);

                    InsertCallLogToDb(phoneNumber, callType, duration, conn);
                }
                conn.Close();

                Console.WriteLine("Call logs extracted and inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private string ExtractPhoneNumber(string line)
        {
            int start = line.IndexOf("number=") + "number=".Length;
            int end = line.IndexOf(",", start);
            return line.Substring(start, end - start);
        }

        private string ExtractCallType(string line)
        {
            int start = line.IndexOf("type=") + "type=".Length;
            int end = line.IndexOf(",", start);
            return line.Substring(start, end - start);
        }

        private string ExtractDuration(string line)
        {
            int start = line.IndexOf("duration=") + "duration=".Length;
            return line.Substring(start).Trim();
        }

        private void InsertCallLogToDb(string phone, string type, string duration, SqlConnection conn)
        {
            string query = "INSERT INTO CallLogsTable (PhoneNumber, CallType, Duration) VALUES (@Phone, @Type, @Duration)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public class DeviceInfoExtractor
    {
        public void ExtractDeviceInfoAndInsertToDb(string cpuFilePath, string memFilePath, SqlConnection conn)
        {
            try
            {
                string cpuInfo = File.ReadAllText(cpuFilePath).Trim();
                string memInfo = File.ReadAllText(memFilePath).Trim();

                InsertDeviceInfoToDb(cpuInfo, memInfo, conn);

                Console.WriteLine("Device info extracted and inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void InsertDeviceInfoToDb(string cpu, string memory, SqlConnection conn)
        {
            string query = "INSERT INTO DeviceInfoTable (CPUInfo, MemoryInfo) VALUES (@CPU, @Memory)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CPU", cpu);
                cmd.Parameters.AddWithValue("@Memory", memory);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }


    class DataEx
    {
        public static void Run()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LPW;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            SqlConnection conn = new SqlConnection(connectionString);

            string filePath = "C:\\Users\\BAPS\\Desktop\\dot NET LPW\\contacts.txt";
            ContactExtractor extractor = new ContactExtractor();
            extractor.ExtractContactsAndInsertToDb(filePath, conn);

            string filePath1 = "C:\\Users\\BAPS\\Desktop\\dot NET LPW\\sms.txt";
            MessageExtractor extractor1 = new MessageExtractor();
            extractor1.ExtractMessagesAndInsertToDb(filePath1, conn);

            string filePath2 = "C:\\Users\\BAPS\\Desktop\\dot NET LPW\\log.txt";
            CallLogExtractor logExtractor = new CallLogExtractor();
            logExtractor.ExtractCallLogsAndInsertToDb(filePath2, conn);

            string cpuPath = "C:\\Users\\BAPS\\Desktop\\dot NET LPW\\cpu.txt";
            string memPath = "C:\\Users\\BAPS\\Desktop\\dot NET LPW\\mem.txt";
            DeviceInfoExtractor infoExtractor = new DeviceInfoExtractor();
            infoExtractor.ExtractDeviceInfoAndInsertToDb(cpuPath, memPath, conn);

        }
    }

