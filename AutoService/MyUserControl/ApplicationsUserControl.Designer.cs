
namespace AutoService.MyUserControl
{
    partial class ApplicationsUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationsUserControl));
            this.bsApplicationsViewTest = new System.Windows.Forms.BindingSource(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.report1 = new FastReport.Report();
            this.report = new FastReport.Report();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFilters = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSearchApplications = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSearchApplications = new System.Windows.Forms.ComboBox();
            this.cbSortApplications = new System.Windows.Forms.ComboBox();
            this.tbSearchApplications = new System.Windows.Forms.TextBox();
            this.cbSortModeApplications = new System.Windows.Forms.ComboBox();
            this.btnSearchApplications = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSortApplications = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tcApplications = new System.Windows.Forms.TabControl();
            this.tbApplications = new System.Windows.Forms.TabPage();
            this.dgvApplication = new System.Windows.Forms.DataGridView();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReadyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsApplications = new System.Windows.Forms.ToolStrip();
            this.tsbInsertApplications = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateApplications = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteApplications = new System.Windows.Forms.ToolStripButton();
            this.tsbPerformApplications = new System.Windows.Forms.ToolStripButton();
            this.tsbFunction = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbReport = new System.Windows.Forms.ToolStripButton();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bsApplicationsViewTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report)).BeginInit();
            this.pFilters.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tcApplications.SuspendLayout();
            this.tbApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).BeginInit();
            this.tsApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsApplicationsViewTest
            // 
            this.bsApplicationsViewTest.DataSource = typeof(AutoService.Models.ApplicationView);
            this.bsApplicationsViewTest.CurrentChanged += new System.EventHandler(this.bsApplicationsViewTest_CurrentChanged);
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            this.report1.RegisterData(this.bsApplicationsViewTest, "bsApplicationsViewTest");
            // 
            // report
            // 
            this.report.NeedRefresh = false;
            this.report.ReportResourceString = resources.GetString("report.ReportResourceString");
            this.report.Tag = null;
            this.report.RegisterData(this.bsApplicationsViewTest, "bsApplicationsViewTest");
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Done";
            this.dataGridViewTextBoxColumn9.HeaderText = "Состояние";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ServiceName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Услуга";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateReady";
            this.dataGridViewTextBoxColumn6.HeaderText = "Выполнено";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 96;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateVisit";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата визита";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Master";
            this.dataGridViewTextBoxColumn4.HeaderText = "Мастер";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Car";
            this.dataGridViewTextBoxColumn2.HeaderText = "Авто";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn1.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pFilters
            // 
            this.pFilters.Controls.Add(this.label1);
            this.pFilters.Controls.Add(this.panel3);
            this.pFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFilters.Location = new System.Drawing.Point(0, 0);
            this.pFilters.Name = "pFilters";
            this.pFilters.Size = new System.Drawing.Size(1459, 109);
            this.pFilters.TabIndex = 11;
            this.pFilters.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Поиск и сортировка";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtpSearchApplications);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbSearchApplications);
            this.panel3.Controls.Add(this.cbSortApplications);
            this.panel3.Controls.Add(this.tbSearchApplications);
            this.panel3.Controls.Add(this.cbSortModeApplications);
            this.panel3.Controls.Add(this.btnSearchApplications);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnSortApplications);
            this.panel3.Location = new System.Drawing.Point(19, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1418, 67);
            this.panel3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "По дате:";
            // 
            // dtpSearchApplications
            // 
            this.dtpSearchApplications.Location = new System.Drawing.Point(204, 26);
            this.dtpSearchApplications.Name = "dtpSearchApplications";
            this.dtpSearchApplications.Size = new System.Drawing.Size(157, 27);
            this.dtpSearchApplications.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Поиск по:";
            // 
            // cbSearchApplications
            // 
            this.cbSearchApplications.FormattingEnabled = true;
            this.cbSearchApplications.Items.AddRange(new object[] {
            "Клиент",
            "Авто",
            "Дата рождения",
            "Мастер",
            "Дата визита",
            "Дата выполнения",
            "Услуга",
            "Цена",
            "Состояние"});
            this.cbSearchApplications.Location = new System.Drawing.Point(17, 25);
            this.cbSearchApplications.Name = "cbSearchApplications";
            this.cbSearchApplications.Size = new System.Drawing.Size(163, 28);
            this.cbSearchApplications.TabIndex = 1;
            // 
            // cbSortApplications
            // 
            this.cbSortApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSortApplications.FormattingEnabled = true;
            this.cbSortApplications.Items.AddRange(new object[] {
            "Цена",
            "Клиент",
            "Авто",
            "Дата рождения",
            "Мастер",
            "Дата визита",
            "Дата выполнения",
            "Услуга",
            "Состояние"});
            this.cbSortApplications.Location = new System.Drawing.Point(911, 26);
            this.cbSortApplications.Name = "cbSortApplications";
            this.cbSortApplications.Size = new System.Drawing.Size(163, 28);
            this.cbSortApplications.TabIndex = 9;
            // 
            // tbSearchApplications
            // 
            this.tbSearchApplications.Location = new System.Drawing.Point(376, 26);
            this.tbSearchApplications.Name = "tbSearchApplications";
            this.tbSearchApplications.Size = new System.Drawing.Size(224, 27);
            this.tbSearchApplications.TabIndex = 1;
            // 
            // cbSortModeApplications
            // 
            this.cbSortModeApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSortModeApplications.FormattingEnabled = true;
            this.cbSortModeApplications.Items.AddRange(new object[] {
            "По убыванию (z-a, 10-1)",
            "По возрастанию (a-z, 1-10)"});
            this.cbSortModeApplications.Location = new System.Drawing.Point(1094, 26);
            this.cbSortModeApplications.Name = "cbSortModeApplications";
            this.cbSortModeApplications.Size = new System.Drawing.Size(163, 28);
            this.cbSortModeApplications.TabIndex = 13;
            // 
            // btnSearchApplications
            // 
            this.btnSearchApplications.BackColor = System.Drawing.Color.Green;
            this.btnSearchApplications.FlatAppearance.BorderSize = 0;
            this.btnSearchApplications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSearchApplications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSearchApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchApplications.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearchApplications.ForeColor = System.Drawing.Color.White;
            this.btnSearchApplications.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchApplications.Location = new System.Drawing.Point(618, 19);
            this.btnSearchApplications.Name = "btnSearchApplications";
            this.btnSearchApplications.Size = new System.Drawing.Size(134, 34);
            this.btnSearchApplications.TabIndex = 10;
            this.btnSearchApplications.Text = "Найти";
            this.btnSearchApplications.UseVisualStyleBackColor = false;
            this.btnSearchApplications.Click += new System.EventHandler(this.btnSearchApplications_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(907, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Сортировать по:";
            // 
            // btnSortApplications
            // 
            this.btnSortApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortApplications.BackColor = System.Drawing.Color.Green;
            this.btnSortApplications.FlatAppearance.BorderSize = 0;
            this.btnSortApplications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSortApplications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSortApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortApplications.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSortApplications.ForeColor = System.Drawing.Color.White;
            this.btnSortApplications.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSortApplications.Location = new System.Drawing.Point(1275, 20);
            this.btnSortApplications.Name = "btnSortApplications";
            this.btnSortApplications.Size = new System.Drawing.Size(134, 34);
            this.btnSortApplications.TabIndex = 11;
            this.btnSortApplications.Text = "Применить";
            this.btnSortApplications.UseVisualStyleBackColor = false;
            this.btnSortApplications.Click += new System.EventHandler(this.btnSortApplications_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tcApplications);
            this.panel4.Controls.Add(this.tsApplications);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1459, 620);
            this.panel4.TabIndex = 13;
            // 
            // tcApplications
            // 
            this.tcApplications.Controls.Add(this.tbApplications);
            this.tcApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcApplications.Location = new System.Drawing.Point(0, 27);
            this.tcApplications.Name = "tcApplications";
            this.tcApplications.SelectedIndex = 0;
            this.tcApplications.Size = new System.Drawing.Size(1459, 593);
            this.tcApplications.TabIndex = 14;
            // 
            // tbApplications
            // 
            this.tbApplications.Controls.Add(this.dgvApplication);
            this.tbApplications.Location = new System.Drawing.Point(4, 29);
            this.tbApplications.Name = "tbApplications";
            this.tbApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tbApplications.Size = new System.Drawing.Size(1451, 560);
            this.tbApplications.TabIndex = 0;
            this.tbApplications.Text = "Все заявки";
            this.tbApplications.UseVisualStyleBackColor = true;
            // 
            // dgvApplication
            // 
            this.dgvApplication.AllowUserToAddRows = false;
            this.dgvApplication.AllowUserToDeleteRows = false;
            this.dgvApplication.AutoGenerateColumns = false;
            this.dgvApplication.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientDataGridViewTextBoxColumn,
            this.carDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.masterDataGridViewTextBoxColumn,
            this.dateVisitDataGridViewTextBoxColumn,
            this.dateReadyDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.doneDataGridViewTextBoxColumn});
            this.dgvApplication.DataSource = this.bsApplicationsViewTest;
            this.dgvApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApplication.Location = new System.Drawing.Point(3, 3);
            this.dgvApplication.Name = "dgvApplication";
            this.dgvApplication.ReadOnly = true;
            this.dgvApplication.RowHeadersVisible = false;
            this.dgvApplication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplication.Size = new System.Drawing.Size(1445, 554);
            this.dgvApplication.TabIndex = 0;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clientDataGridViewTextBoxColumn.Width = 64;
            // 
            // carDataGridViewTextBoxColumn
            // 
            this.carDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.carDataGridViewTextBoxColumn.DataPropertyName = "Car";
            this.carDataGridViewTextBoxColumn.HeaderText = "Авто";
            this.carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            this.carDataGridViewTextBoxColumn.ReadOnly = true;
            this.carDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.carDataGridViewTextBoxColumn.Width = 48;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // masterDataGridViewTextBoxColumn
            // 
            this.masterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.masterDataGridViewTextBoxColumn.DataPropertyName = "Master";
            this.masterDataGridViewTextBoxColumn.HeaderText = "Мастер";
            this.masterDataGridViewTextBoxColumn.Name = "masterDataGridViewTextBoxColumn";
            this.masterDataGridViewTextBoxColumn.ReadOnly = true;
            this.masterDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.masterDataGridViewTextBoxColumn.Width = 66;
            // 
            // dateVisitDataGridViewTextBoxColumn
            // 
            this.dateVisitDataGridViewTextBoxColumn.DataPropertyName = "DateVisit";
            this.dateVisitDataGridViewTextBoxColumn.HeaderText = "Дата визита";
            this.dateVisitDataGridViewTextBoxColumn.Name = "dateVisitDataGridViewTextBoxColumn";
            this.dateVisitDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateVisitDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateReadyDataGridViewTextBoxColumn
            // 
            this.dateReadyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateReadyDataGridViewTextBoxColumn.DataPropertyName = "DateReady";
            this.dateReadyDataGridViewTextBoxColumn.HeaderText = "Дата выполнения";
            this.dateReadyDataGridViewTextBoxColumn.Name = "dateReadyDataGridViewTextBoxColumn";
            this.dateReadyDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateReadyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateReadyDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.serviceNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.priceDataGridViewTextBoxColumn.Width = 51;
            // 
            // doneDataGridViewTextBoxColumn
            // 
            this.doneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.doneDataGridViewTextBoxColumn.DataPropertyName = "Done";
            this.doneDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.doneDataGridViewTextBoxColumn.Name = "doneDataGridViewTextBoxColumn";
            this.doneDataGridViewTextBoxColumn.ReadOnly = true;
            this.doneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.doneDataGridViewTextBoxColumn.Width = 89;
            // 
            // tsApplications
            // 
            this.tsApplications.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsApplications.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsertApplications,
            this.tsbUpdateApplications,
            this.tsbDeleteApplications,
            this.tsbPerformApplications,
            this.tsbFunction,
            this.tsbUpdate,
            this.tsbReport});
            this.tsApplications.Location = new System.Drawing.Point(0, 0);
            this.tsApplications.Name = "tsApplications";
            this.tsApplications.Size = new System.Drawing.Size(1459, 27);
            this.tsApplications.TabIndex = 13;
            this.tsApplications.Text = "toolStrip1";
            // 
            // tsbInsertApplications
            // 
            this.tsbInsertApplications.Image = global::AutoService.Properties.Resources.UserAdd;
            this.tsbInsertApplications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertApplications.Name = "tsbInsertApplications";
            this.tsbInsertApplications.Size = new System.Drawing.Size(96, 24);
            this.tsbInsertApplications.Text = "Добавить";
            this.tsbInsertApplications.Click += new System.EventHandler(this.tsbInsertApplications_Click);
            // 
            // tsbUpdateApplications
            // 
            this.tsbUpdateApplications.Image = global::AutoService.Properties.Resources.Edit;
            this.tsbUpdateApplications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateApplications.Name = "tsbUpdateApplications";
            this.tsbUpdateApplications.Size = new System.Drawing.Size(131, 24);
            this.tsbUpdateApplications.Text = "Редактировать";
            this.tsbUpdateApplications.Click += new System.EventHandler(this.tsbUpdateApplications_Click);
            // 
            // tsbDeleteApplications
            // 
            this.tsbDeleteApplications.Image = global::AutoService.Properties.Resources.Delete;
            this.tsbDeleteApplications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteApplications.Name = "tsbDeleteApplications";
            this.tsbDeleteApplications.Size = new System.Drawing.Size(85, 24);
            this.tsbDeleteApplications.Text = "Удалить";
            this.tsbDeleteApplications.Click += new System.EventHandler(this.tsbDeleteApplications_Click);
            // 
            // tsbPerformApplications
            // 
            this.tsbPerformApplications.Image = global::AutoService.Properties.Resources.Work;
            this.tsbPerformApplications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPerformApplications.Name = "tsbPerformApplications";
            this.tsbPerformApplications.Size = new System.Drawing.Size(107, 24);
            this.tsbPerformApplications.Text = "Выполнить";
            this.tsbPerformApplications.Click += new System.EventHandler(this.tsbPerformApplications_Click);
            // 
            // tsbFunction
            // 
            this.tsbFunction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbFunction.Image = global::AutoService.Properties.Resources.Search;
            this.tsbFunction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFunction.Name = "tsbFunction";
            this.tsbFunction.Size = new System.Drawing.Size(159, 24);
            this.tsbFunction.Text = "Поиск/сортировка";
            this.tsbFunction.Click += new System.EventHandler(this.tsbFunction_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbUpdate.Image = global::AutoService.Properties.Resources.Update1;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(98, 24);
            this.tsbUpdate.Text = "Обновить";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbReport
            // 
            this.tsbReport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbReport.Image = global::AutoService.Properties.Resources.Report;
            this.tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReport.Name = "tsbReport";
            this.tsbReport.Size = new System.Drawing.Size(68, 24);
            this.tsbReport.Text = "Отчёт";
            this.tsbReport.Click += new System.EventHandler(this.tsbReport_Click);
            // 
            // ApplicationsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pFilters);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ApplicationsUserControl";
            this.Size = new System.Drawing.Size(1459, 729);
            this.Load += new System.EventHandler(this.ApplicationsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsApplicationsViewTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report)).EndInit();
            this.pFilters.ResumeLayout(false);
            this.pFilters.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tcApplications.ResumeLayout(false);
            this.tbApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).EndInit();
            this.tsApplications.ResumeLayout(false);
            this.tsApplications.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsApplicationsViewTest;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private FastReport.Report report1;
        private FastReport.Report report;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel pFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSearchApplications;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSearchApplications;
        private System.Windows.Forms.ComboBox cbSortApplications;
        private System.Windows.Forms.TextBox tbSearchApplications;
        private System.Windows.Forms.ComboBox cbSortModeApplications;
        private System.Windows.Forms.Button btnSearchApplications;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSortApplications;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tcApplications;
        private System.Windows.Forms.TabPage tbApplications;
        private System.Windows.Forms.DataGridView dgvApplication;
        private System.Windows.Forms.ToolStrip tsApplications;
        private System.Windows.Forms.ToolStripButton tsbInsertApplications;
        private System.Windows.Forms.ToolStripButton tsbUpdateApplications;
        private System.Windows.Forms.ToolStripButton tsbDeleteApplications;
        private System.Windows.Forms.ToolStripButton tsbPerformApplications;
        private System.Windows.Forms.ToolStripButton tsbFunction;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbReport;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReadyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doneDataGridViewTextBoxColumn;
    }
}
