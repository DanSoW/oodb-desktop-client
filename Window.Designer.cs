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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._lpbAdmin = new System.Windows.Forms.Label();
            this._pBarAdmin = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this._cmbCountAdmin = new System.Windows.Forms.ComboBox();
            this._btnGenerateAdmin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._btnAdminDelete = new System.Windows.Forms.Button();
            this._btnAdminClear = new System.Windows.Forms.Button();
            this._btnAdminAddRow = new System.Windows.Forms.Button();
            this._btnAdminLoad = new System.Windows.Forms.Button();
            this.dataGridAdmin = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridMonitor = new System.Windows.Forms.DataGridView();
            this.MonitorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorHostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorAdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this._lpbHost = new System.Windows.Forms.Label();
            this._pbHostLoad = new System.Windows.Forms.ProgressBar();
            this._lbCountHost = new System.Windows.Forms.Label();
            this._cmbCountHost = new System.Windows.Forms.ComboBox();
            this._btnGenHost = new System.Windows.Forms.Button();
            this._btnEditHost = new System.Windows.Forms.Button();
            this._btnDeleteHost = new System.Windows.Forms.Button();
            this._btnClearHost = new System.Windows.Forms.Button();
            this._btdAddHost = new System.Windows.Forms.Button();
            this._btnLoadHost = new System.Windows.Forms.Button();
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
            this.dataGridService = new System.Windows.Forms.DataGridView();
            this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTimeUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_DataSourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this._lpbDataSource = new System.Windows.Forms.Label();
            this._pBarDataSource = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this._cmbCountDataSource = new System.Windows.Forms.ComboBox();
            this._btnGenDataSource = new System.Windows.Forms.Button();
            this._btdEditDataSource = new System.Windows.Forms.Button();
            this._btnDeleteDataSource = new System.Windows.Forms.Button();
            this._btnClearDataSource = new System.Windows.Forms.Button();
            this._btdAddDataSource = new System.Windows.Forms.Button();
            this._btnLoadDataSource = new System.Windows.Forms.Button();
            this.dataGridDataSource = new System.Windows.Forms.DataGridView();
            this.DataSourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSourceUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminEmail1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHost)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHostService)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 794);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._lpbAdmin);
            this.tabPage1.Controls.Add(this._pBarAdmin);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this._cmbCountAdmin);
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
            // _lpbAdmin
            // 
            this._lpbAdmin.AutoSize = true;
            this._lpbAdmin.Location = new System.Drawing.Point(218, 675);
            this._lpbAdmin.Name = "_lpbAdmin";
            this._lpbAdmin.Size = new System.Drawing.Size(0, 16);
            this._lpbAdmin.TabIndex = 10;
            // 
            // _pBarAdmin
            // 
            this._pBarAdmin.Location = new System.Drawing.Point(7, 627);
            this._pBarAdmin.Maximum = 999999;
            this._pBarAdmin.Name = "_pBarAdmin";
            this._pBarAdmin.Size = new System.Drawing.Size(523, 45);
            this._pBarAdmin.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 8;
            // 
            // _cmbCountAdmin
            // 
            this._cmbCountAdmin.FormattingEnabled = true;
            this._cmbCountAdmin.Items.AddRange(new object[] {
            "1000",
            "2000",
            "10000"});
            this._cmbCountAdmin.Location = new System.Drawing.Point(6, 537);
            this._cmbCountAdmin.Name = "_cmbCountAdmin";
            this._cmbCountAdmin.Size = new System.Drawing.Size(158, 24);
            this._cmbCountAdmin.TabIndex = 7;
            // 
            // _btnGenerateAdmin
            // 
            this._btnGenerateAdmin.Location = new System.Drawing.Point(6, 567);
            this._btnGenerateAdmin.Name = "_btnGenerateAdmin";
            this._btnGenerateAdmin.Size = new System.Drawing.Size(158, 40);
            this._btnGenerateAdmin.TabIndex = 6;
            this._btnGenerateAdmin.Text = "Сгенерировать";
            this._btnGenerateAdmin.UseVisualStyleBackColor = true;
            this._btnGenerateAdmin.Click += new System.EventHandler(this._btnGenerateAdmin_Click);
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
            // dataGridAdmin
            // 
            this.dataGridAdmin.AllowUserToAddRows = false;
            this.dataGridAdmin.AllowUserToDeleteRows = false;
            this.dataGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminId1,
            this.AdminEmail1});
            this.dataGridAdmin.Location = new System.Drawing.Point(0, 3);
            this.dataGridAdmin.Name = "dataGridAdmin";
            this.dataGridAdmin.ReadOnly = true;
            this.dataGridAdmin.RowHeadersWidth = 51;
            this.dataGridAdmin.RowTemplate.Height = 24;
            this.dataGridAdmin.Size = new System.Drawing.Size(1031, 353);
            this.dataGridAdmin.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button6);
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
            this.dataGridMonitor.AllowUserToAddRows = false;
            this.dataGridMonitor.AllowUserToDeleteRows = false;
            this.dataGridMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonitorId,
            this.MonitorName,
            this.MonitorUrl,
            this.MonitorHostId,
            this.MonitorAdminId});
            this.dataGridMonitor.Location = new System.Drawing.Point(3, 3);
            this.dataGridMonitor.Name = "dataGridMonitor";
            this.dataGridMonitor.ReadOnly = true;
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
            this.MonitorName.ReadOnly = true;
            this.MonitorName.Width = 125;
            // 
            // MonitorUrl
            // 
            this.MonitorUrl.HeaderText = "URL";
            this.MonitorUrl.MinimumWidth = 6;
            this.MonitorUrl.Name = "MonitorUrl";
            this.MonitorUrl.ReadOnly = true;
            this.MonitorUrl.Width = 125;
            // 
            // MonitorHostId
            // 
            this.MonitorHostId.HeaderText = "Host ID";
            this.MonitorHostId.MinimumWidth = 6;
            this.MonitorHostId.Name = "MonitorHostId";
            this.MonitorHostId.ReadOnly = true;
            this.MonitorHostId.Width = 125;
            // 
            // MonitorAdminId
            // 
            this.MonitorAdminId.HeaderText = "Admin ID";
            this.MonitorAdminId.MinimumWidth = 6;
            this.MonitorAdminId.Name = "MonitorAdminId";
            this.MonitorAdminId.ReadOnly = true;
            this.MonitorAdminId.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this._lpbHost);
            this.tabPage3.Controls.Add(this._pbHostLoad);
            this.tabPage3.Controls.Add(this._lbCountHost);
            this.tabPage3.Controls.Add(this._cmbCountHost);
            this.tabPage3.Controls.Add(this._btnGenHost);
            this.tabPage3.Controls.Add(this._btnEditHost);
            this.tabPage3.Controls.Add(this._btnDeleteHost);
            this.tabPage3.Controls.Add(this._btnClearHost);
            this.tabPage3.Controls.Add(this._btdAddHost);
            this.tabPage3.Controls.Add(this._btnLoadHost);
            this.tabPage3.Controls.Add(this.dataGridHost);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1037, 765);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Хосты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // _lpbHost
            // 
            this._lpbHost.AutoSize = true;
            this._lpbHost.Location = new System.Drawing.Point(216, 673);
            this._lpbHost.Name = "_lpbHost";
            this._lpbHost.Size = new System.Drawing.Size(0, 16);
            this._lpbHost.TabIndex = 20;
            // 
            // _pbHostLoad
            // 
            this._pbHostLoad.Location = new System.Drawing.Point(5, 625);
            this._pbHostLoad.Maximum = 999999;
            this._pbHostLoad.Name = "_pbHostLoad";
            this._pbHostLoad.Size = new System.Drawing.Size(523, 45);
            this._pbHostLoad.TabIndex = 19;
            // 
            // _lbCountHost
            // 
            this._lbCountHost.AutoSize = true;
            this._lbCountHost.Location = new System.Drawing.Point(4, 512);
            this._lbCountHost.Name = "_lbCountHost";
            this._lbCountHost.Size = new System.Drawing.Size(88, 16);
            this._lbCountHost.TabIndex = 18;
            this._lbCountHost.Text = "Количество:";
            // 
            // _cmbCountHost
            // 
            this._cmbCountHost.FormattingEnabled = true;
            this._cmbCountHost.Items.AddRange(new object[] {
            "1000",
            "2000",
            "10000"});
            this._cmbCountHost.Location = new System.Drawing.Point(4, 535);
            this._cmbCountHost.Name = "_cmbCountHost";
            this._cmbCountHost.Size = new System.Drawing.Size(158, 24);
            this._cmbCountHost.TabIndex = 17;
            // 
            // _btnGenHost
            // 
            this._btnGenHost.Location = new System.Drawing.Point(4, 565);
            this._btnGenHost.Name = "_btnGenHost";
            this._btnGenHost.Size = new System.Drawing.Size(158, 40);
            this._btnGenHost.TabIndex = 16;
            this._btnGenHost.Text = "Сгенерировать";
            this._btnGenHost.UseVisualStyleBackColor = true;
            this._btnGenHost.Click += new System.EventHandler(this._btnGenHost_Click);
            // 
            // _btnEditHost
            // 
            this._btnEditHost.Location = new System.Drawing.Point(4, 405);
            this._btnEditHost.Name = "_btnEditHost";
            this._btnEditHost.Size = new System.Drawing.Size(158, 40);
            this._btnEditHost.TabIndex = 15;
            this._btnEditHost.Text = "Изменить";
            this._btnEditHost.UseVisualStyleBackColor = true;
            this._btnEditHost.Click += new System.EventHandler(this._btnEditHost_Click);
            // 
            // _btnDeleteHost
            // 
            this._btnDeleteHost.Location = new System.Drawing.Point(4, 450);
            this._btnDeleteHost.Name = "_btnDeleteHost";
            this._btnDeleteHost.Size = new System.Drawing.Size(158, 40);
            this._btnDeleteHost.TabIndex = 14;
            this._btnDeleteHost.Text = "Удалить запись";
            this._btnDeleteHost.UseVisualStyleBackColor = true;
            this._btnDeleteHost.Click += new System.EventHandler(this._btnDeleteHost_Click);
            // 
            // _btnClearHost
            // 
            this._btnClearHost.Location = new System.Drawing.Point(871, 360);
            this._btnClearHost.Name = "_btnClearHost";
            this._btnClearHost.Size = new System.Drawing.Size(158, 40);
            this._btnClearHost.TabIndex = 13;
            this._btnClearHost.Text = "Очистить таблицу";
            this._btnClearHost.UseVisualStyleBackColor = true;
            this._btnClearHost.Click += new System.EventHandler(this._btnClearHost_Click);
            // 
            // _btdAddHost
            // 
            this._btdAddHost.Location = new System.Drawing.Point(4, 360);
            this._btdAddHost.Name = "_btdAddHost";
            this._btdAddHost.Size = new System.Drawing.Size(158, 40);
            this._btdAddHost.TabIndex = 12;
            this._btdAddHost.Text = "Добавить запись";
            this._btdAddHost.UseVisualStyleBackColor = true;
            this._btdAddHost.Click += new System.EventHandler(this._btdAddHost_Click);
            // 
            // _btnLoadHost
            // 
            this._btnLoadHost.Location = new System.Drawing.Point(871, 406);
            this._btnLoadHost.Name = "_btnLoadHost";
            this._btnLoadHost.Size = new System.Drawing.Size(158, 40);
            this._btnLoadHost.TabIndex = 11;
            this._btnLoadHost.Text = "Загрузить данные";
            this._btnLoadHost.UseVisualStyleBackColor = true;
            this._btnLoadHost.Click += new System.EventHandler(this._btnLoadHost_Click);
            // 
            // dataGridHost
            // 
            this.dataGridHost.AllowUserToAddRows = false;
            this.dataGridHost.AllowUserToDeleteRows = false;
            this.dataGridHost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HostId,
            this.HostName,
            this.HostUrl,
            this.HostIPv4,
            this.HostSystem});
            this.dataGridHost.Location = new System.Drawing.Point(4, 4);
            this.dataGridHost.Name = "dataGridHost";
            this.dataGridHost.ReadOnly = true;
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
            this.HostName.ReadOnly = true;
            this.HostName.Width = 125;
            // 
            // HostUrl
            // 
            this.HostUrl.HeaderText = "URL";
            this.HostUrl.MinimumWidth = 6;
            this.HostUrl.Name = "HostUrl";
            this.HostUrl.ReadOnly = true;
            this.HostUrl.Width = 125;
            // 
            // HostIPv4
            // 
            this.HostIPv4.HeaderText = "IPv4";
            this.HostIPv4.MinimumWidth = 6;
            this.HostIPv4.Name = "HostIPv4";
            this.HostIPv4.ReadOnly = true;
            this.HostIPv4.Width = 125;
            // 
            // HostSystem
            // 
            this.HostSystem.HeaderText = "Система";
            this.HostSystem.MinimumWidth = 6;
            this.HostSystem.Name = "HostSystem";
            this.HostSystem.ReadOnly = true;
            this.HostSystem.Width = 125;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button7);
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
            this.dataGridHostService.AllowUserToAddRows = false;
            this.dataGridHostService.AllowUserToDeleteRows = false;
            this.dataGridHostService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHostService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HostServiceId,
            this.HostService_HostId,
            this.HostService_ServiceId});
            this.dataGridHostService.Location = new System.Drawing.Point(4, 4);
            this.dataGridHostService.Name = "dataGridHostService";
            this.dataGridHostService.ReadOnly = true;
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
            this.HostService_HostId.ReadOnly = true;
            this.HostService_HostId.Width = 125;
            // 
            // HostService_ServiceId
            // 
            this.HostService_ServiceId.HeaderText = "Service ID";
            this.HostService_ServiceId.MinimumWidth = 6;
            this.HostService_ServiceId.Name = "HostService_ServiceId";
            this.HostService_ServiceId.ReadOnly = true;
            this.HostService_ServiceId.Width = 125;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button8);
            this.tabPage5.Controls.Add(this.button9);
            this.tabPage5.Controls.Add(this.button10);
            this.tabPage5.Controls.Add(this.dataGridService);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1037, 765);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Сервисы";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridService
            // 
            this.dataGridService.AllowUserToAddRows = false;
            this.dataGridService.AllowUserToDeleteRows = false;
            this.dataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceId,
            this.ServiceName,
            this.ServicePort,
            this.ServiceTimeUpdate,
            this.Service_DataSourceId});
            this.dataGridService.Location = new System.Drawing.Point(4, 4);
            this.dataGridService.Name = "dataGridService";
            this.dataGridService.ReadOnly = true;
            this.dataGridService.RowHeadersWidth = 51;
            this.dataGridService.RowTemplate.Height = 24;
            this.dataGridService.Size = new System.Drawing.Size(1030, 350);
            this.dataGridService.TabIndex = 0;
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
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 125;
            // 
            // ServicePort
            // 
            this.ServicePort.HeaderText = "Порт";
            this.ServicePort.MinimumWidth = 6;
            this.ServicePort.Name = "ServicePort";
            this.ServicePort.ReadOnly = true;
            this.ServicePort.Width = 125;
            // 
            // ServiceTimeUpdate
            // 
            this.ServiceTimeUpdate.HeaderText = "Время обновления";
            this.ServiceTimeUpdate.MinimumWidth = 6;
            this.ServiceTimeUpdate.Name = "ServiceTimeUpdate";
            this.ServiceTimeUpdate.ReadOnly = true;
            this.ServiceTimeUpdate.Width = 125;
            // 
            // Service_DataSourceId
            // 
            this.Service_DataSourceId.HeaderText = "Data Source Id";
            this.Service_DataSourceId.MinimumWidth = 6;
            this.Service_DataSourceId.Name = "Service_DataSourceId";
            this.Service_DataSourceId.ReadOnly = true;
            this.Service_DataSourceId.Width = 125;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this._lpbDataSource);
            this.tabPage6.Controls.Add(this._pBarDataSource);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this._cmbCountDataSource);
            this.tabPage6.Controls.Add(this._btnGenDataSource);
            this.tabPage6.Controls.Add(this._btdEditDataSource);
            this.tabPage6.Controls.Add(this._btnDeleteDataSource);
            this.tabPage6.Controls.Add(this._btnClearDataSource);
            this.tabPage6.Controls.Add(this._btdAddDataSource);
            this.tabPage6.Controls.Add(this._btnLoadDataSource);
            this.tabPage6.Controls.Add(this.dataGridDataSource);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1037, 765);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ресурсы";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // _lpbDataSource
            // 
            this._lpbDataSource.AutoSize = true;
            this._lpbDataSource.Location = new System.Drawing.Point(215, 672);
            this._lpbDataSource.Name = "_lpbDataSource";
            this._lpbDataSource.Size = new System.Drawing.Size(0, 16);
            this._lpbDataSource.TabIndex = 30;
            // 
            // _pBarDataSource
            // 
            this._pBarDataSource.Location = new System.Drawing.Point(4, 624);
            this._pBarDataSource.Maximum = 999999;
            this._pBarDataSource.Name = "_pBarDataSource";
            this._pBarDataSource.Size = new System.Drawing.Size(523, 45);
            this._pBarDataSource.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Количество:";
            // 
            // _cmbCountDataSource
            // 
            this._cmbCountDataSource.FormattingEnabled = true;
            this._cmbCountDataSource.Items.AddRange(new object[] {
            "1000",
            "2000",
            "10000"});
            this._cmbCountDataSource.Location = new System.Drawing.Point(3, 534);
            this._cmbCountDataSource.Name = "_cmbCountDataSource";
            this._cmbCountDataSource.Size = new System.Drawing.Size(158, 24);
            this._cmbCountDataSource.TabIndex = 27;
            // 
            // _btnGenDataSource
            // 
            this._btnGenDataSource.Location = new System.Drawing.Point(3, 564);
            this._btnGenDataSource.Name = "_btnGenDataSource";
            this._btnGenDataSource.Size = new System.Drawing.Size(158, 40);
            this._btnGenDataSource.TabIndex = 26;
            this._btnGenDataSource.Text = "Сгенерировать";
            this._btnGenDataSource.UseVisualStyleBackColor = true;
            this._btnGenDataSource.Click += new System.EventHandler(this._btnGenDataSource_Click);
            // 
            // _btdEditDataSource
            // 
            this._btdEditDataSource.Location = new System.Drawing.Point(3, 404);
            this._btdEditDataSource.Name = "_btdEditDataSource";
            this._btdEditDataSource.Size = new System.Drawing.Size(158, 40);
            this._btdEditDataSource.TabIndex = 25;
            this._btdEditDataSource.Text = "Изменить";
            this._btdEditDataSource.UseVisualStyleBackColor = true;
            this._btdEditDataSource.Click += new System.EventHandler(this._btdEditDataSource_Click);
            // 
            // _btnDeleteDataSource
            // 
            this._btnDeleteDataSource.Location = new System.Drawing.Point(3, 449);
            this._btnDeleteDataSource.Name = "_btnDeleteDataSource";
            this._btnDeleteDataSource.Size = new System.Drawing.Size(158, 40);
            this._btnDeleteDataSource.TabIndex = 24;
            this._btnDeleteDataSource.Text = "Удалить запись";
            this._btnDeleteDataSource.UseVisualStyleBackColor = true;
            this._btnDeleteDataSource.Click += new System.EventHandler(this._btnDeleteDataSource_Click);
            // 
            // _btnClearDataSource
            // 
            this._btnClearDataSource.Location = new System.Drawing.Point(870, 359);
            this._btnClearDataSource.Name = "_btnClearDataSource";
            this._btnClearDataSource.Size = new System.Drawing.Size(158, 40);
            this._btnClearDataSource.TabIndex = 23;
            this._btnClearDataSource.Text = "Очистить таблицу";
            this._btnClearDataSource.UseVisualStyleBackColor = true;
            this._btnClearDataSource.Click += new System.EventHandler(this._btnClearDataSource_Click);
            // 
            // _btdAddDataSource
            // 
            this._btdAddDataSource.Location = new System.Drawing.Point(3, 359);
            this._btdAddDataSource.Name = "_btdAddDataSource";
            this._btdAddDataSource.Size = new System.Drawing.Size(158, 40);
            this._btdAddDataSource.TabIndex = 22;
            this._btdAddDataSource.Text = "Добавить запись";
            this._btdAddDataSource.UseVisualStyleBackColor = true;
            this._btdAddDataSource.Click += new System.EventHandler(this._btdAddDataSource_Click);
            // 
            // _btnLoadDataSource
            // 
            this._btnLoadDataSource.Location = new System.Drawing.Point(870, 405);
            this._btnLoadDataSource.Name = "_btnLoadDataSource";
            this._btnLoadDataSource.Size = new System.Drawing.Size(158, 40);
            this._btnLoadDataSource.TabIndex = 21;
            this._btnLoadDataSource.Text = "Загрузить данные";
            this._btnLoadDataSource.UseVisualStyleBackColor = true;
            this._btnLoadDataSource.Click += new System.EventHandler(this._btnLoadDataSource_Click);
            // 
            // dataGridDataSource
            // 
            this.dataGridDataSource.AllowUserToAddRows = false;
            this.dataGridDataSource.AllowUserToDeleteRows = false;
            this.dataGridDataSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDataSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataSourceId,
            this.DataSourceName,
            this.DataSourceUrl,
            this.AdminId,
            this.AdminEmail});
            this.dataGridDataSource.Location = new System.Drawing.Point(3, 3);
            this.dataGridDataSource.Name = "dataGridDataSource";
            this.dataGridDataSource.ReadOnly = true;
            this.dataGridDataSource.RowHeadersWidth = 51;
            this.dataGridDataSource.RowTemplate.Height = 24;
            this.dataGridDataSource.Size = new System.Drawing.Size(1031, 350);
            this.dataGridDataSource.TabIndex = 0;
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
            this.DataSourceName.ReadOnly = true;
            this.DataSourceName.Width = 125;
            // 
            // DataSourceUrl
            // 
            this.DataSourceUrl.HeaderText = "URL";
            this.DataSourceUrl.MinimumWidth = 6;
            this.DataSourceUrl.Name = "DataSourceUrl";
            this.DataSourceUrl.ReadOnly = true;
            this.DataSourceUrl.Width = 125;
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
            // AdminId1
            // 
            this.AdminId1.HeaderText = "Id";
            this.AdminId1.MinimumWidth = 6;
            this.AdminId1.Name = "AdminId1";
            this.AdminId1.ReadOnly = true;
            this.AdminId1.Width = 125;
            // 
            // AdminEmail1
            // 
            this.AdminEmail1.HeaderText = "Email";
            this.AdminEmail1.MinimumWidth = 6;
            this.AdminEmail1.Name = "AdminEmail1";
            this.AdminEmail1.ReadOnly = true;
            this.AdminEmail1.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "Удалить запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(873, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "Очистить таблицу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(873, 409);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 40);
            this.button6.TabIndex = 9;
            this.button6.Text = "Загрузить данные";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Удалить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(871, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 40);
            this.button5.TabIndex = 14;
            this.button5.Text = "Очистить таблицу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(871, 406);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 40);
            this.button7.TabIndex = 13;
            this.button7.Text = "Загрузить данные";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(4, 360);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 40);
            this.button8.TabIndex = 18;
            this.button8.Text = "Удалить запись";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(871, 360);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(158, 40);
            this.button9.TabIndex = 17;
            this.button9.Text = "Очистить таблицу";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(871, 406);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(158, 40);
            this.button10.TabIndex = 16;
            this.button10.Text = "Загрузить данные";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 818);
            this.Controls.Add(this.tabControl1);
            this.Name = "Window";
            this.Text = "Window";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHost)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHostService)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDataSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridMonitor;
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
        private System.Windows.Forms.DataGridView dataGridService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTimeUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_DataSourceId;
        private System.Windows.Forms.DataGridView dataGridDataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSourceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSourceUrl;
        private System.Windows.Forms.Label _lpbHost;
        private System.Windows.Forms.ProgressBar _pbHostLoad;
        private System.Windows.Forms.Label _lbCountHost;
        private System.Windows.Forms.ComboBox _cmbCountHost;
        private System.Windows.Forms.Button _btnGenHost;
        private System.Windows.Forms.Button _btnEditHost;
        private System.Windows.Forms.Button _btnDeleteHost;
        private System.Windows.Forms.Button _btnClearHost;
        private System.Windows.Forms.Button _btdAddHost;
        private System.Windows.Forms.Button _btnLoadHost;
        private System.Windows.Forms.Label _lpbDataSource;
        private System.Windows.Forms.ProgressBar _pBarDataSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cmbCountDataSource;
        private System.Windows.Forms.Button _btnGenDataSource;
        private System.Windows.Forms.Button _btdEditDataSource;
        private System.Windows.Forms.Button _btnDeleteDataSource;
        private System.Windows.Forms.Button _btnClearDataSource;
        private System.Windows.Forms.Button _btdAddDataSource;
        private System.Windows.Forms.Button _btnLoadDataSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label _lpbAdmin;
        private System.Windows.Forms.ProgressBar _pBarAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cmbCountAdmin;
        private System.Windows.Forms.Button _btnGenerateAdmin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button _btnAdminDelete;
        private System.Windows.Forms.Button _btnAdminClear;
        private System.Windows.Forms.Button _btnAdminAddRow;
        private System.Windows.Forms.Button _btnAdminLoad;
        private System.Windows.Forms.DataGridView dataGridAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminEmail1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

