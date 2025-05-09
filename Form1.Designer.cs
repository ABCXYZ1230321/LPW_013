namespace ADB_Form
{
    partial class tabPage1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.Contacts = new System.Windows.Forms.TabPage();
            this.dataGridContacts = new System.Windows.Forms.DataGridView();
            this.SMS = new System.Windows.Forms.TabPage();
            this.dataGridSMS = new System.Windows.Forms.DataGridView();
            this.Logs = new System.Windows.Forms.TabPage();
            this.dataGridLogs = new System.Windows.Forms.DataGridView();
            this.Device = new System.Windows.Forms.TabPage();
            this.dataGridDevice = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnSavetoDB = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.Contacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).BeginInit();
            this.SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSMS)).BeginInit();
            this.Logs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLogs)).BeginInit();
            this.Device.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlMain.Controls.Add(this.Contacts);
            this.tabControlMain.Controls.Add(this.SMS);
            this.tabControlMain.Controls.Add(this.Logs);
            this.tabControlMain.Controls.Add(this.Device);
            this.tabControlMain.Location = new System.Drawing.Point(10, 80);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(1);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1412, 530);
            this.tabControlMain.TabIndex = 0;
            // 
            // Contacts
            // 
            this.Contacts.Controls.Add(this.dataGridContacts);
            this.Contacts.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contacts.Location = new System.Drawing.Point(4, 22);
            this.Contacts.Margin = new System.Windows.Forms.Padding(1);
            this.Contacts.Name = "Contacts";
            this.Contacts.Padding = new System.Windows.Forms.Padding(1);
            this.Contacts.Size = new System.Drawing.Size(1404, 504);
            this.Contacts.TabIndex = 0;
            this.Contacts.Text = "Contacts";
            this.Contacts.UseVisualStyleBackColor = true;
            // 
            // dataGridContacts
            // 
            this.dataGridContacts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridContacts.Location = new System.Drawing.Point(1, 1);
            this.dataGridContacts.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridContacts.Name = "dataGridContacts";
            this.dataGridContacts.RowHeadersWidth = 102;
            this.dataGridContacts.RowTemplate.Height = 40;
            this.dataGridContacts.Size = new System.Drawing.Size(1402, 502);
            this.dataGridContacts.TabIndex = 0;
            // 
            // SMS
            // 
            this.SMS.Controls.Add(this.dataGridSMS);
            this.SMS.Font = new System.Drawing.Font("Consolas", 12F);
            this.SMS.Location = new System.Drawing.Point(4, 22);
            this.SMS.Margin = new System.Windows.Forms.Padding(1);
            this.SMS.Name = "SMS";
            this.SMS.Padding = new System.Windows.Forms.Padding(1);
            this.SMS.Size = new System.Drawing.Size(1404, 504);
            this.SMS.TabIndex = 1;
            this.SMS.Text = "SMS Msgs";
            this.SMS.UseVisualStyleBackColor = true;
            // 
            // dataGridSMS
            // 
            this.dataGridSMS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridSMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSMS.Location = new System.Drawing.Point(1, 1);
            this.dataGridSMS.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridSMS.Name = "dataGridSMS";
            this.dataGridSMS.RowHeadersWidth = 102;
            this.dataGridSMS.RowTemplate.Height = 40;
            this.dataGridSMS.Size = new System.Drawing.Size(1402, 502);
            this.dataGridSMS.TabIndex = 1;
            // 
            // Logs
            // 
            this.Logs.Controls.Add(this.dataGridLogs);
            this.Logs.Font = new System.Drawing.Font("Consolas", 12F);
            this.Logs.Location = new System.Drawing.Point(4, 22);
            this.Logs.Margin = new System.Windows.Forms.Padding(1);
            this.Logs.Name = "Logs";
            this.Logs.Padding = new System.Windows.Forms.Padding(1);
            this.Logs.Size = new System.Drawing.Size(1404, 504);
            this.Logs.TabIndex = 2;
            this.Logs.Text = "Call Logs";
            this.Logs.UseVisualStyleBackColor = true;
            // 
            // dataGridLogs
            // 
            this.dataGridLogs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridLogs.Location = new System.Drawing.Point(1, 1);
            this.dataGridLogs.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridLogs.Name = "dataGridLogs";
            this.dataGridLogs.RowHeadersWidth = 102;
            this.dataGridLogs.RowTemplate.Height = 40;
            this.dataGridLogs.Size = new System.Drawing.Size(1402, 502);
            this.dataGridLogs.TabIndex = 0;
            // 
            // Device
            // 
            this.Device.Controls.Add(this.dataGridDevice);
            this.Device.Font = new System.Drawing.Font("Consolas", 12F);
            this.Device.Location = new System.Drawing.Point(4, 22);
            this.Device.Margin = new System.Windows.Forms.Padding(1);
            this.Device.Name = "Device";
            this.Device.Padding = new System.Windows.Forms.Padding(1);
            this.Device.Size = new System.Drawing.Size(1404, 504);
            this.Device.TabIndex = 3;
            this.Device.Text = "Device Info";
            this.Device.UseVisualStyleBackColor = true;
            // 
            // dataGridDevice
            // 
            this.dataGridDevice.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDevice.Location = new System.Drawing.Point(1, 1);
            this.dataGridDevice.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridDevice.Name = "dataGridDevice";
            this.dataGridDevice.RowHeadersWidth = 102;
            this.dataGridDevice.RowTemplate.Height = 40;
            this.dataGridDevice.Size = new System.Drawing.Size(1402, 502);
            this.dataGridDevice.TabIndex = 0;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadData.Font = new System.Drawing.Font("Consolas", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLoadData.Location = new System.Drawing.Point(143, 643);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(1);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(181, 42);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnSavetoDB
            // 
            this.btnSavetoDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavetoDB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSavetoDB.Font = new System.Drawing.Font("Consolas", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavetoDB.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSavetoDB.Location = new System.Drawing.Point(1116, 643);
            this.btnSavetoDB.Margin = new System.Windows.Forms.Padding(1);
            this.btnSavetoDB.Name = "btnSavetoDB";
            this.btnSavetoDB.Size = new System.Drawing.Size(181, 42);
            this.btnSavetoDB.TabIndex = 2;
            this.btnSavetoDB.Text = "Save to DB";
            this.btnSavetoDB.UseVisualStyleBackColor = false;
            this.btnSavetoDB.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewReport.Font = new System.Drawing.Font("Consolas", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.ForeColor = System.Drawing.SystemColors.Info;
            this.btnViewReport.Location = new System.Drawing.Point(637, 643);
            this.btnViewReport.Margin = new System.Windows.Forms.Padding(1);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(181, 42);
            this.btnViewReport.TabIndex = 3;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(586, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADB FORM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1432, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnSavetoDB);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "tabPage1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.tabPage1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.Contacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).EndInit();
            this.SMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSMS)).EndInit();
            this.Logs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLogs)).EndInit();
            this.Device.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage Contacts;
        private System.Windows.Forms.TabPage SMS;
        private System.Windows.Forms.TabPage Logs;
        private System.Windows.Forms.TabPage Device;
        private System.Windows.Forms.DataGridView dataGridSMS;
        private System.Windows.Forms.DataGridView dataGridContacts;
        private System.Windows.Forms.DataGridView dataGridLogs;
        private System.Windows.Forms.DataGridView dataGridDevice;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnSavetoDB;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Label label1;
    }
}

