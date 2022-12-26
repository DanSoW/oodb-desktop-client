namespace oodb_desktop_client
{
    partial class Window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridAdmin = new System.Windows.Forms.DataGridView();
            this.AdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridMonitor = new System.Windows.Forms.DataGridView();
            this.MonitorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorHostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorAdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridHost = new System.Windows.Forms.DataGridView();
            this.HostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostIPv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridHostService = new System.Windows.Forms.DataGridView();
            this.HostServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostService_HostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostService_ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTimeUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_DataSourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DataSourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSourceUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._btnAdminLoad = new System.Windows.Forms.Button();
            this._btnAdminAddRow = new System.Windows.Forms.Button();
            this._btnAdminClear = new System.Windows.Forms.Button();
            this._btnAdminDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._btnGenerateAdmin = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHost)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHostService)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAdmin
            // 
            this.dataGridAdmin.AllowUserToAddRows = false;
            this.dataGridAdmin.AllowUserToDeleteRows = false;
            this.dataGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminId,
            this.AdminEmail});
            this.dataGridAdmin.Location = new System.Drawing.Point(0, 3);
            this.dataGridAdmin.Name = "dataGridAdmin";
            this.dataGridAdmin.ReadOnly = true;
            this.dataGridAdmin.RowHeadersWidth = 51;
            this.dataGridAdmin.RowTemplate.Height = 24;
            this.dataGridAdmin.Size = new System.Drawing.Size(1031, 353);
            this.dataGridAdmin.TabIndex = 0;
            // 
            // AdminId
            // 
            this.AdminId.HeaderText = "Id";
            this.AdminId.MinimumWidth = 6;
            this.AdminId.Name = "AdminId";
            this.AdminId.ReadOnly = true;
            this.AdminId.Width = 125;
            // 
            // AdminEmail
            // 
            this.AdminEmail.HeaderText = "Email";
            this.AdminEmail.MinimumWidth = 6;
            this.AdminEmail.Name = "AdminEmail";
            this.AdminEmail.ReadOnly = true;
            this.AdminEmail.Width = 125;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 794);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this._btnGenerateAdmin);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this._btnAdminDelete);
            this.tabPage1.Controls.Add(this._btnAdminClear);
            this.tabPage1.Controls.Add(this._btnAdminAddRow);
            this.tabPage1.Controls.Add(this._btnAdminLoad);
            this.tabPage1.Controls.Add(this.dataGridAdmin);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1037, 765);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Админы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridMonitor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1037, 765);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мониторинг";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridMonitor
            // 
            this.dataGridMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonitorId,
            this.MonitorName,
            this.MonitorUrl,
            this.MonitorHostId,
            this.MonitorAdminId});
            this.dataGridMonitor.Location = new System.Drawing.Point(3, 3);
            this.dataGridMonitor.Name = "dataGridMonitor";
            this.dataGridMonitor.RowHeadersWidth = 51;
            this.dataGridMonitor.RowTemplate.Height = 24;
            this.dataGridMonitor.Size = new System.Drawing.Size(1028, 354);
            this.dataGridMonitor.TabIndex = 0;
            // 
            // MonitorId
            // 
            this.MonitorId.HeaderText = "Id";
            this.MonitorId.MinimumWidth = 6;
            this.MonitorId.Name = "MonitorId";
            this.MonitorId.ReadOnly = true;
            this.MonitorId.Width = 125;
            // 
            // MonitorName
            // 
            this.MonitorName.HeaderText = "Название";
            this.MonitorName.MinimumWidth = 6;
            this.MonitorName.Name = "MonitorName";
            this.MonitorName.Width = 125;
            // 
            // MonitorUrl
            // 
            this.MonitorUrl.HeaderText = "URL";
            this.MonitorUrl.MinimumWidth = 6;
            this.MonitorUrl.Name = "MonitorUrl";
            this.MonitorUrl.Width = 125;
            // 
            // MonitorHostId
            // 
            this.MonitorHostId.HeaderText = "Host ID";
            this.MonitorHostId.MinimumWidth = 6;
            this.MonitorHostId.Name = "MonitorHostId";
            this.MonitorHostId.Width = 125;
            // 
            // MonitorAdminId
            // 
            this.MonitorAdminId.HeaderText = "Admin ID";
            this.MonitorAdminId.MinimumWidth = 6;
            this.MonitorAdminId.Name = "MonitorAdminId";
            this.MonitorAdminId.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridHost);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1037, 765);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Хосты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridHost
            // 
            this.dataGridHost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HostId,
            this.HostName,
            this.HostUrl,
            this.HostIPv4,
            this.HostSystem});
            this.dataGridHost.Location = new System.Drawing.Point(4, 4);
            this.dataGridHost.Name = "dataGridHost";
            this.dataGridHost.RowHeadersWidth = 51;
            this.dataGridHost.RowTemplate.Height = 24;
            this.dataGridHost.Size = new System.Drawing.Size(1030, 350);
            this.dataGridHost.TabIndex = 0;
            // 
            // HostId
            // 
            this.HostId.HeaderText = "Id";
            this.HostId.MinimumWidth = 6;
            this.HostId.Name = "HostId";
            this.HostId.ReadOnly = true;
            this.HostId.Width = 125;
            // 
            // HostName
            // 
            this.HostName.HeaderText = "Название";
            this.HostName.MinimumWidth = 6;
            this.HostName.Name = "HostName";
            this.HostName.Width = 125;
            // 
            // HostUrl
            // 
            this.HostUrl.HeaderText = "URL";
            this.HostUrl.MinimumWidth = 6;
            this.HostUrl.Name = "HostUrl";
            this.HostUrl.Width = 125;
            // 
            // HostIPv4
            // 
            this.HostIPv4.HeaderText = "IPv4";
            this.HostIPv4.MinimumWidth = 6;
            this.HostIPv4.Name = "HostIPv4";
            this.HostIPv4.Width = 125;
            // 
            // HostSystem
            // 
            this.HostSystem.HeaderText = "Система";
            this.HostSystem.MinimumWidth = 6;
            this.HostSystem.Name = "HostSystem";
            this.HostSystem.Width = 125;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridHostService);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1037, 765);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Хосты и сервисы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridHostService
            // 
            this.dataGridHostService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHostService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HostServiceId,
            this.HostService_HostId,
            this.HostService_ServiceId});
            this.dataGridHostService.Location = new System.Drawing.Point(4, 4);
            this.dataGridHostService.Name = "dataGridHostService";
            this.dataGridHostService.RowHeadersWidth = 51;
            this.dataGridHostService.RowTemplate.Height = 24;
            this.dataGridHostService.Size = new System.Drawing.Size(1030, 350);
            this.dataGridHostService.TabIndex = 0;
            // 
            // HostServiceId
            // 
            this.HostServiceId.HeaderText = "Id";
            this.HostServiceId.MinimumWidth = 6;
            this.HostServiceId.Name = "HostServiceId";
            this.HostServiceId.ReadOnly = true;
            this.HostServiceId.Width = 125;
            // 
            // HostService_HostId
            // 
            this.HostService_HostId.HeaderText = "Host ID";
            this.HostService_HostId.MinimumWidth = 6;
            this.HostService_HostId.Name = "HostService_HostId";
            this.HostService_HostId.Width = 125;
            // 
            // HostService_ServiceId
            // 
            this.HostService_ServiceId.HeaderText = "Service ID";
            this.HostService_ServiceId.MinimumWidth = 6;
            this.HostService_ServiceId.Name = "HostService_ServiceId";
            this.HostService_ServiceId.Width = 125;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1037, 765);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Сервисы";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView2);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1037, 765);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ресурсы";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1037, 765);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Тестирование";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceId,
            this.ServiceName,
            this.ServicePort,
            this.ServiceTimeUpdate,
            this.Service_DataSourceId});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // ServiceId
            // 
            this.ServiceId.HeaderText = "Id";
            this.ServiceId.MinimumWidth = 6;
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.ReadOnly = true;
            this.ServiceId.Width = 125;
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "Название";
            this.ServiceName.MinimumWidth = 6;
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Width = 125;
            // 
            // ServicePort
            // 
            this.ServicePort.HeaderText = "Порт";
            this.ServicePort.MinimumWidth = 6;
            this.ServicePort.Name = "ServicePort";
            this.ServicePort.Width = 125;
            // 
            // ServiceTimeUpdate
            // 
            this.ServiceTimeUpdate.HeaderText = "Время обновления";
            this.ServiceTimeUpdate.MinimumWidth = 6;
            this.ServiceTimeUpdate.Name = "ServiceTimeUpdate";
            this.ServiceTimeUpdate.Width = 125;
            // 
            // Service_DataSourceId
            // 
            this.Service_DataSourceId.HeaderText = "Data Source Id";
            this.Service_DataSourceId.MinimumWidth = 6;
            this.Service_DataSourceId.Name = "Service_DataSourceId";
            this.Service_DataSourceId.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataSourceId,
            this.DataSourceName,
            this.DataSourceUrl});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1031, 350);
            this.dataGridView2.TabIndex = 0;
            // 
            // DataSourceId
            // 
            this.DataSourceId.HeaderText = "Id";
            this.DataSourceId.MinimumWidth = 6;
            this.DataSourceId.Name = "DataSourceId";
            this.DataSourceId.ReadOnly = true;
            this.DataSourceId.Width = 125;
            // 
            // DataSourceName
            // 
            this.DataSourceName.HeaderText = "Название";
            this.DataSourceName.MinimumWidth = 6;
            this.DataSourceName.Name = "DataSourceName";
            this.DataSourceName.Width = 125;
            // 
            // DataSourceUrl
            // 
            this.DataSourceUrl.HeaderText = "URL";
            this.DataSourceUrl.MinimumWidth = 6;
            this.DataSourceUrl.Name = "DataSourceUrl";
            this.DataSourceUrl.Width = 125;
            // 
            // _btnAdminLoad
            // 
            this._btnAdminLoad.Location = new System.Drawing.Point(873, 408);
            this._btnAdminLoad.Name = "_btnAdminLoad";
            this._btnAdminLoad.Size = new System.Drawing.Size(158, 40);
            this._btnAdminLoad.TabIndex = 1;
            this._btnAdminLoad.Text = "Загрузить данные";
            this._btnAdminLoad.UseVisualStyleBackColor = true;
            this._btnAdminLoad.Click += new System.EventHandler(this._btnLoadData_Click);
            // 
            // _btnAdminAddRow
            // 
            this._btnAdminAddRow.Location = new System.Drawing.Point(6, 362);
            this._btnAdminAddRow.Name = "_btnAdminAddRow";
            this._btnAdminAddRow.Size = new System.Drawing.Size(158, 40);
            this._btnAdminAddRow.TabIndex = 2;
            this._btnAdminAddRow.Text = "Добавить запись";
            this._btnAdminAddRow.UseVisualStyleBackColor = true;
            this._btnAdminAddRow.Click += new System.EventHandler(this._btnAddRow_Click);
            // 
            // _btnAdminClear
            // 
            this._btnAdminClear.Location = new System.Drawing.Point(873, 362);
            this._btnAdminClear.Name = "_btnAdminClear";
            this._btnAdminClear.Size = new System.Drawing.Size(158, 40);
            this._btnAdminClear.TabIndex = 3;
            this._btnAdminClear.Text = "Очистить таблицу";
            this._btnAdminClear.UseVisualStyleBackColor = true;
            this._btnAdminClear.Click += new System.EventHandler(this._btnAdminClear_Click);
            // 
            // _btnAdminDelete
            // 
            this._btnAdminDelete.Location = new System.Drawing.Point(6, 452);
            this._btnAdminDelete.Name = "_btnAdminDelete";
            this._btnAdminDelete.Size = new System.Drawing.Size(158, 40);
            this._btnAdminDelete.TabIndex = 4;
            this._btnAdminDelete.Text = "Удалить запись";
            this._btnAdminDelete.UseVisualStyleBackColor = true;
            this._btnAdminDelete.Click += new System.EventHandler(this._btnAdminDelete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _btnGenerateAdmin
            // 
            this._btnGenerateAdmin.Location = new System.Drawing.Point(873, 528);
            this._btnGenerateAdmin.Name = "_btnGenerateAdmin";
            this._btnGenerateAdmin.Size = new System.Drawing.Size(158, 40);
            this._btnGenerateAdmin.TabIndex = 6;
            this._btnGenerateAdmin.Text = "Сгенерировать";
            this._btnGenerateAdmin.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1000",
            "2000",
            "10000"});
            this.comboBox1.Location = new System.Drawing.Point(873, 498);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(873, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество:";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 818);
            this.Controls.Add(this.tabControl1);
            this.Name = "Window";
            this.Text = "Window";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHost)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHostService)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAdmin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorHostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorAdminId;
        private System.Windows.Forms.DataGridView dataGridHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostIPv4;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostSystem;
        private System.Windows.Forms.DataGridView dataGridHostService;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostService_HostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostService_ServiceId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTimeUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_DataSourceId;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSourceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSourceUrl;
        private System.Windows.Forms.Button _btnAdminLoad;
        private System.Windows.Forms.Button _btnAdminAddRow;
        private System.Windows.Forms.Button _btnAdminClear;
        private System.Windows.Forms.Button _btnAdminDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button _btnGenerateAdmin;
    }
}

