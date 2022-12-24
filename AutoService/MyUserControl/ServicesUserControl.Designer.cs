
namespace AutoService.MyUserControl
{
    partial class ServicesUserControl
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
            this.tsbSearchServices = new System.Windows.Forms.ToolStripButton();
            this.tsbEditServices = new System.Windows.Forms.ToolStripButton();
            this.tsbInsertServices = new System.Windows.Forms.ToolStripButton();
            this.tsServices = new System.Windows.Forms.ToolStrip();
            this.tsbDeleteServices = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateServices = new System.Windows.Forms.ToolStripButton();
            this.pClients = new System.Windows.Forms.Panel();
            this.pDetails = new System.Windows.Forms.Panel();
            this.lDetails = new System.Windows.Forms.Label();
            this.tbDetails = new System.Windows.Forms.TextBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsServicesView = new System.Windows.Forms.BindingSource(this.components);
            this.cbSortModeServices = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSortServices = new System.Windows.Forms.Button();
            this.btnSearchServices = new System.Windows.Forms.Button();
            this.tbSearchServices = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSortServices = new System.Windows.Forms.ComboBox();
            this.pFunction = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSearchService = new System.Windows.Forms.ComboBox();
            this.tsServices.SuspendLayout();
            this.pClients.SuspendLayout();
            this.pDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServicesView)).BeginInit();
            this.pFunction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbSearchServices
            // 
            this.tsbSearchServices.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbSearchServices.Image = global::AutoService.Properties.Resources.Search;
            this.tsbSearchServices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchServices.Name = "tsbSearchServices";
            this.tsbSearchServices.Size = new System.Drawing.Size(159, 24);
            this.tsbSearchServices.Text = "Поиск/сортировка";
            this.tsbSearchServices.Click += new System.EventHandler(this.tsbSearchServices_Click);
            // 
            // tsbEditServices
            // 
            this.tsbEditServices.Image = global::AutoService.Properties.Resources.Edit;
            this.tsbEditServices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditServices.Name = "tsbEditServices";
            this.tsbEditServices.Size = new System.Drawing.Size(131, 24);
            this.tsbEditServices.Text = "Редактировать";
            this.tsbEditServices.Click += new System.EventHandler(this.tsbEditServices_Click);
            // 
            // tsbInsertServices
            // 
            this.tsbInsertServices.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbInsertServices.Image = global::AutoService.Properties.Resources.UserAdd;
            this.tsbInsertServices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertServices.Name = "tsbInsertServices";
            this.tsbInsertServices.Size = new System.Drawing.Size(96, 24);
            this.tsbInsertServices.Text = "Добавить";
            this.tsbInsertServices.Click += new System.EventHandler(this.tsbInsertServices_Click);
            // 
            // tsServices
            // 
            this.tsServices.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsServices.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsertServices,
            this.tsbEditServices,
            this.tsbDeleteServices,
            this.tsbSearchServices,
            this.tsbUpdateServices});
            this.tsServices.Location = new System.Drawing.Point(0, 0);
            this.tsServices.Name = "tsServices";
            this.tsServices.Size = new System.Drawing.Size(793, 27);
            this.tsServices.TabIndex = 15;
            this.tsServices.Text = "toolStrip1";
            // 
            // tsbDeleteServices
            // 
            this.tsbDeleteServices.Image = global::AutoService.Properties.Resources.Delete;
            this.tsbDeleteServices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteServices.Name = "tsbDeleteServices";
            this.tsbDeleteServices.Size = new System.Drawing.Size(85, 24);
            this.tsbDeleteServices.Text = "Удалить";
            this.tsbDeleteServices.Click += new System.EventHandler(this.tsbDeleteServices_Click);
            // 
            // tsbUpdateServices
            // 
            this.tsbUpdateServices.Image = global::AutoService.Properties.Resources.Update;
            this.tsbUpdateServices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateServices.Name = "tsbUpdateServices";
            this.tsbUpdateServices.Size = new System.Drawing.Size(98, 24);
            this.tsbUpdateServices.Text = "Обновить";
            this.tsbUpdateServices.Click += new System.EventHandler(this.tsbUpdateServices_Click);
            // 
            // pClients
            // 
            this.pClients.Controls.Add(this.pDetails);
            this.pClients.Controls.Add(this.dgvServices);
            this.pClients.Controls.Add(this.tsServices);
            this.pClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClients.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pClients.Location = new System.Drawing.Point(0, 187);
            this.pClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pClients.Name = "pClients";
            this.pClients.Size = new System.Drawing.Size(793, 467);
            this.pClients.TabIndex = 29;
            // 
            // pDetails
            // 
            this.pDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDetails.Controls.Add(this.lDetails);
            this.pDetails.Controls.Add(this.tbDetails);
            this.pDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDetails.Location = new System.Drawing.Point(423, 27);
            this.pDetails.Name = "pDetails";
            this.pDetails.Size = new System.Drawing.Size(370, 440);
            this.pDetails.TabIndex = 16;
            // 
            // lDetails
            // 
            this.lDetails.AutoSize = true;
            this.lDetails.Location = new System.Drawing.Point(11, 16);
            this.lDetails.Name = "lDetails";
            this.lDetails.Size = new System.Drawing.Size(104, 20);
            this.lDetails.TabIndex = 1;
            this.lDetails.Text = "Подробности";
            // 
            // tbDetails
            // 
            this.tbDetails.Enabled = false;
            this.tbDetails.Location = new System.Drawing.Point(15, 39);
            this.tbDetails.Multiline = true;
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Size = new System.Drawing.Size(336, 383);
            this.tbDetails.TabIndex = 0;
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AutoGenerateColumns = false;
            this.dgvServices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn});
            this.dgvServices.DataSource = this.bsServicesView;
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(0, 27);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(793, 440);
            this.dgvServices.TabIndex = 14;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 60;
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
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.detailsDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsServicesView
            // 
            this.bsServicesView.DataSource = typeof(AutoService.Models.ServicesView);
            this.bsServicesView.CurrentChanged += new System.EventHandler(this.bsServicesView_CurrentChanged);
            // 
            // cbSortModeServices
            // 
            this.cbSortModeServices.FormattingEnabled = true;
            this.cbSortModeServices.Items.AddRange(new object[] {
            "По убыванию (z-a, 10-1)",
            "По возрастанию (a-z, 1-10)"});
            this.cbSortModeServices.Location = new System.Drawing.Point(285, 100);
            this.cbSortModeServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSortModeServices.Name = "cbSortModeServices";
            this.cbSortModeServices.Size = new System.Drawing.Size(224, 28);
            this.cbSortModeServices.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Сортировать по:";
            // 
            // btnSortServices
            // 
            this.btnSortServices.BackColor = System.Drawing.Color.Green;
            this.btnSortServices.FlatAppearance.BorderSize = 0;
            this.btnSortServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSortServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSortServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortServices.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSortServices.ForeColor = System.Drawing.Color.White;
            this.btnSortServices.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSortServices.Location = new System.Drawing.Point(535, 89);
            this.btnSortServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortServices.Name = "btnSortServices";
            this.btnSortServices.Size = new System.Drawing.Size(142, 39);
            this.btnSortServices.TabIndex = 18;
            this.btnSortServices.Text = "Применить";
            this.btnSortServices.UseVisualStyleBackColor = false;
            this.btnSortServices.Click += new System.EventHandler(this.btnSortServices_Click);
            // 
            // btnSearchServices
            // 
            this.btnSearchServices.BackColor = System.Drawing.Color.Green;
            this.btnSearchServices.FlatAppearance.BorderSize = 0;
            this.btnSearchServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSearchServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSearchServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchServices.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearchServices.ForeColor = System.Drawing.Color.White;
            this.btnSearchServices.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchServices.Location = new System.Drawing.Point(535, 28);
            this.btnSearchServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchServices.Name = "btnSearchServices";
            this.btnSearchServices.Size = new System.Drawing.Size(142, 39);
            this.btnSearchServices.TabIndex = 17;
            this.btnSearchServices.Text = "Найти";
            this.btnSearchServices.UseVisualStyleBackColor = false;
            this.btnSearchServices.Click += new System.EventHandler(this.btnSearchServices_Click);
            // 
            // tbSearchServices
            // 
            this.tbSearchServices.Location = new System.Drawing.Point(285, 34);
            this.tbSearchServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchServices.Name = "tbSearchServices";
            this.tbSearchServices.Size = new System.Drawing.Size(224, 27);
            this.tbSearchServices.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Поиск по:";
            // 
            // cbSortServices
            // 
            this.cbSortServices.FormattingEnabled = true;
            this.cbSortServices.Items.AddRange(new object[] {
            "Услуга",
            "Цена"});
            this.cbSortServices.Location = new System.Drawing.Point(33, 100);
            this.cbSortServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSortServices.Name = "cbSortServices";
            this.cbSortServices.Size = new System.Drawing.Size(224, 28);
            this.cbSortServices.TabIndex = 16;
            // 
            // pFunction
            // 
            this.pFunction.Controls.Add(this.label1);
            this.pFunction.Controls.Add(this.panel1);
            this.pFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFunction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pFunction.Location = new System.Drawing.Point(0, 0);
            this.pFunction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pFunction.Name = "pFunction";
            this.pFunction.Size = new System.Drawing.Size(793, 187);
            this.pFunction.TabIndex = 28;
            this.pFunction.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Поиск и сортировка";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbSearchService);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbSortModeServices);
            this.panel1.Controls.Add(this.cbSortServices);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbSearchServices);
            this.panel1.Controls.Add(this.btnSortServices);
            this.panel1.Controls.Add(this.btnSearchServices);
            this.panel1.Location = new System.Drawing.Point(23, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 146);
            this.panel1.TabIndex = 21;
            // 
            // cbSearchService
            // 
            this.cbSearchService.FormattingEnabled = true;
            this.cbSearchService.Items.AddRange(new object[] {
            "Услуга",
            "Цена"});
            this.cbSearchService.Location = new System.Drawing.Point(33, 33);
            this.cbSearchService.Name = "cbSearchService";
            this.cbSearchService.Size = new System.Drawing.Size(224, 28);
            this.cbSearchService.TabIndex = 22;
            // 
            // ServicesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pClients);
            this.Controls.Add(this.pFunction);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServicesUserControl";
            this.Size = new System.Drawing.Size(793, 654);
            this.Load += new System.EventHandler(this.ServicesUserControl_Load);
            this.tsServices.ResumeLayout(false);
            this.tsServices.PerformLayout();
            this.pClients.ResumeLayout(false);
            this.pClients.PerformLayout();
            this.pDetails.ResumeLayout(false);
            this.pDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServicesView)).EndInit();
            this.pFunction.ResumeLayout(false);
            this.pFunction.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbSearchServices;
        private System.Windows.Forms.ToolStripButton tsbEditServices;
        private System.Windows.Forms.ToolStripButton tsbInsertServices;
        private System.Windows.Forms.ToolStrip tsServices;
        private System.Windows.Forms.ToolStripButton tsbDeleteServices;
        private System.Windows.Forms.Panel pClients;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.ComboBox cbSortModeServices;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSortServices;
        private System.Windows.Forms.Button btnSearchServices;
        private System.Windows.Forms.TextBox tbSearchServices;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSortServices;
        private System.Windows.Forms.Panel pFunction;
        private System.Windows.Forms.BindingSource bsServicesView;
        private System.Windows.Forms.Panel pDetails;
        private System.Windows.Forms.Label lDetails;
        private System.Windows.Forms.TextBox tbDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSearchService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbUpdateServices;
    }
}
