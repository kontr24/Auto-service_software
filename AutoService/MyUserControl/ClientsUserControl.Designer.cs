
namespace AutoService.MyUserControl
{
    partial class ClientsUserControl
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
            this.pFunction = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSearchClients = new System.Windows.Forms.DateTimePicker();
            this.cbSearchClients = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSortModeClients = new System.Windows.Forms.ComboBox();
            this.cbSortClients = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSearchClient = new System.Windows.Forms.TextBox();
            this.btnSortClients = new System.Windows.Forms.Button();
            this.btnSearchClients = new System.Windows.Forms.Button();
            this.pClients = new System.Windows.Forms.Panel();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelAutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoRegisterSignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsClientView = new System.Windows.Forms.BindingSource(this.components);
            this.tsClients = new System.Windows.Forms.ToolStrip();
            this.tsbInsertClient = new System.Windows.Forms.ToolStripButton();
            this.tsbEditClient = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteClient = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchClient = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateClients = new System.Windows.Forms.ToolStripButton();
            this.pFunction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientView)).BeginInit();
            this.tsClients.SuspendLayout();
            this.SuspendLayout();
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
            this.pFunction.Size = new System.Drawing.Size(808, 226);
            this.pFunction.TabIndex = 25;
            this.pFunction.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Поиск и сортировка";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpSearchClients);
            this.panel1.Controls.Add(this.cbSearchClients);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbSortModeClients);
            this.panel1.Controls.Add(this.cbSortClients);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbSearchClient);
            this.panel1.Controls.Add(this.btnSortClients);
            this.panel1.Controls.Add(this.btnSearchClients);
            this.panel1.Location = new System.Drawing.Point(22, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 185);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "По дате:";
            // 
            // dtpSearchClients
            // 
            this.dtpSearchClients.Location = new System.Drawing.Point(208, 37);
            this.dtpSearchClients.Name = "dtpSearchClients";
            this.dtpSearchClients.Size = new System.Drawing.Size(143, 27);
            this.dtpSearchClients.TabIndex = 22;
            // 
            // cbSearchClients
            // 
            this.cbSearchClients.FormattingEnabled = true;
            this.cbSearchClients.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Дата рождения",
            "Телефон",
            "Авто",
            "ГРЗ"});
            this.cbSearchClients.Location = new System.Drawing.Point(20, 36);
            this.cbSearchClients.Name = "cbSearchClients";
            this.cbSearchClients.Size = new System.Drawing.Size(169, 28);
            this.cbSearchClients.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Поиск по:";
            // 
            // cbSortModeClients
            // 
            this.cbSortModeClients.FormattingEnabled = true;
            this.cbSortModeClients.Items.AddRange(new object[] {
            "По убыванию (z-a, 10-1)",
            "По возрастанию (a-z, 1-10)"});
            this.cbSortModeClients.Location = new System.Drawing.Point(320, 114);
            this.cbSortModeClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSortModeClients.Name = "cbSortModeClients";
            this.cbSortModeClients.Size = new System.Drawing.Size(270, 28);
            this.cbSortModeClients.TabIndex = 20;
            // 
            // cbSortClients
            // 
            this.cbSortClients.FormattingEnabled = true;
            this.cbSortClients.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Дата рождения",
            "Телефон",
            "Авто",
            "ГРЗ"});
            this.cbSortClients.Location = new System.Drawing.Point(20, 114);
            this.cbSortClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSortClients.Name = "cbSortClients";
            this.cbSortClients.Size = new System.Drawing.Size(270, 28);
            this.cbSortClients.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Сортировать по:";
            // 
            // tbSearchClient
            // 
            this.tbSearchClient.Location = new System.Drawing.Point(366, 36);
            this.tbSearchClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchClient.Name = "tbSearchClient";
            this.tbSearchClient.Size = new System.Drawing.Size(224, 27);
            this.tbSearchClient.TabIndex = 15;
            // 
            // btnSortClients
            // 
            this.btnSortClients.BackColor = System.Drawing.Color.Green;
            this.btnSortClients.FlatAppearance.BorderSize = 0;
            this.btnSortClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSortClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSortClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortClients.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSortClients.ForeColor = System.Drawing.Color.White;
            this.btnSortClients.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSortClients.Location = new System.Drawing.Point(613, 103);
            this.btnSortClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortClients.Name = "btnSortClients";
            this.btnSortClients.Size = new System.Drawing.Size(142, 39);
            this.btnSortClients.TabIndex = 18;
            this.btnSortClients.Text = "Применить";
            this.btnSortClients.UseVisualStyleBackColor = false;
            this.btnSortClients.Click += new System.EventHandler(this.btnSortClients_Click);
            // 
            // btnSearchClients
            // 
            this.btnSearchClients.BackColor = System.Drawing.Color.Green;
            this.btnSearchClients.FlatAppearance.BorderSize = 0;
            this.btnSearchClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSearchClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSearchClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClients.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearchClients.ForeColor = System.Drawing.Color.White;
            this.btnSearchClients.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchClients.Location = new System.Drawing.Point(613, 25);
            this.btnSearchClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchClients.Name = "btnSearchClients";
            this.btnSearchClients.Size = new System.Drawing.Size(142, 39);
            this.btnSearchClients.TabIndex = 17;
            this.btnSearchClients.Text = "Найти";
            this.btnSearchClients.UseVisualStyleBackColor = false;
            this.btnSearchClients.Click += new System.EventHandler(this.btnSearchClients_Click);
            // 
            // pClients
            // 
            this.pClients.Controls.Add(this.dgvClients);
            this.pClients.Controls.Add(this.tsClients);
            this.pClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClients.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pClients.Location = new System.Drawing.Point(0, 226);
            this.pClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pClients.Name = "pClients";
            this.pClients.Size = new System.Drawing.Size(808, 394);
            this.pClients.TabIndex = 26;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AutoGenerateColumns = false;
            this.dgvClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.modelAutoDataGridViewTextBoxColumn,
            this.autoRegisterSignDataGridViewTextBoxColumn});
            this.dgvClients.DataSource = this.bsClientView;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.Location = new System.Drawing.Point(0, 27);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(808, 367);
            this.dgvClients.TabIndex = 14;
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            this.surNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.surNameDataGridViewTextBoxColumn.Width = 79;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 45;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            this.patronymicDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.patronymicDataGridViewTextBoxColumn.Width = 78;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.phoneDataGridViewTextBoxColumn.Width = 75;
            // 
            // modelAutoDataGridViewTextBoxColumn
            // 
            this.modelAutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modelAutoDataGridViewTextBoxColumn.DataPropertyName = "ModelAuto";
            this.modelAutoDataGridViewTextBoxColumn.HeaderText = "Авто";
            this.modelAutoDataGridViewTextBoxColumn.Name = "modelAutoDataGridViewTextBoxColumn";
            this.modelAutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelAutoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.modelAutoDataGridViewTextBoxColumn.Width = 48;
            // 
            // autoRegisterSignDataGridViewTextBoxColumn
            // 
            this.autoRegisterSignDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.autoRegisterSignDataGridViewTextBoxColumn.DataPropertyName = "AutoRegisterSign";
            this.autoRegisterSignDataGridViewTextBoxColumn.HeaderText = "Регистрационный знак";
            this.autoRegisterSignDataGridViewTextBoxColumn.Name = "autoRegisterSignDataGridViewTextBoxColumn";
            this.autoRegisterSignDataGridViewTextBoxColumn.ReadOnly = true;
            this.autoRegisterSignDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.autoRegisterSignDataGridViewTextBoxColumn.Width = 158;
            // 
            // bsClientView
            // 
            this.bsClientView.DataSource = typeof(AutoService.Models.ClientView);
            this.bsClientView.CurrentChanged += new System.EventHandler(this.bsClientView_CurrentChanged);
            // 
            // tsClients
            // 
            this.tsClients.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsClients.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsertClient,
            this.tsbEditClient,
            this.tsbDeleteClient,
            this.tsbSearchClient,
            this.tsbUpdateClients});
            this.tsClients.Location = new System.Drawing.Point(0, 0);
            this.tsClients.Name = "tsClients";
            this.tsClients.Size = new System.Drawing.Size(808, 27);
            this.tsClients.TabIndex = 15;
            this.tsClients.Text = "toolStrip1";
            // 
            // tsbInsertClient
            // 
            this.tsbInsertClient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbInsertClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbInsertClient.Image = global::AutoService.Properties.Resources.UserAdd;
            this.tsbInsertClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertClient.Name = "tsbInsertClient";
            this.tsbInsertClient.Size = new System.Drawing.Size(96, 24);
            this.tsbInsertClient.Text = "Добавить";
            this.tsbInsertClient.Click += new System.EventHandler(this.tsbInsertClient_Click);
            // 
            // tsbEditClient
            // 
            this.tsbEditClient.Image = global::AutoService.Properties.Resources.Edit;
            this.tsbEditClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditClient.Name = "tsbEditClient";
            this.tsbEditClient.Size = new System.Drawing.Size(131, 24);
            this.tsbEditClient.Text = "Редактировать";
            this.tsbEditClient.Click += new System.EventHandler(this.tsbEditClient_Click);
            // 
            // tsbDeleteClient
            // 
            this.tsbDeleteClient.Image = global::AutoService.Properties.Resources.Delete;
            this.tsbDeleteClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteClient.Name = "tsbDeleteClient";
            this.tsbDeleteClient.Size = new System.Drawing.Size(85, 24);
            this.tsbDeleteClient.Text = "Удалить";
            this.tsbDeleteClient.Click += new System.EventHandler(this.tsbDeleteClient_Click);
            // 
            // tsbSearchClient
            // 
            this.tsbSearchClient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbSearchClient.Image = global::AutoService.Properties.Resources.Search;
            this.tsbSearchClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchClient.Name = "tsbSearchClient";
            this.tsbSearchClient.Size = new System.Drawing.Size(159, 24);
            this.tsbSearchClient.Text = "Поиск/сортировка";
            this.tsbSearchClient.Click += new System.EventHandler(this.tsbSearchClient_Click);
            // 
            // tsbUpdateClients
            // 
            this.tsbUpdateClients.Image = global::AutoService.Properties.Resources.Update;
            this.tsbUpdateClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateClients.Name = "tsbUpdateClients";
            this.tsbUpdateClients.Size = new System.Drawing.Size(98, 24);
            this.tsbUpdateClients.Text = "Обновить";
            this.tsbUpdateClients.Click += new System.EventHandler(this.tsbUpdateClients_Click);
            // 
            // ClientsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pClients);
            this.Controls.Add(this.pFunction);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientsUserControl";
            this.Size = new System.Drawing.Size(808, 620);
            this.Load += new System.EventHandler(this.ClientsUserControl_Load);
            this.pFunction.ResumeLayout(false);
            this.pFunction.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pClients.ResumeLayout(false);
            this.pClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientView)).EndInit();
            this.tsClients.ResumeLayout(false);
            this.tsClients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pFunction;
        private System.Windows.Forms.ComboBox cbSortModeClients;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSortClients;
        private System.Windows.Forms.Button btnSearchClients;
        private System.Windows.Forms.TextBox tbSearchClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSortClients;
        private System.Windows.Forms.Panel pClients;
        private System.Windows.Forms.BindingSource bsClientView;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.ToolStrip tsClients;
        private System.Windows.Forms.ToolStripButton tsbSearchClient;
        private System.Windows.Forms.ToolStripButton tsbInsertClient;
        private System.Windows.Forms.ToolStripButton tsbEditClient;
        private System.Windows.Forms.ToolStripButton tsbDeleteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelAutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoRegisterSignDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSearchClients;
        private System.Windows.Forms.ToolStripButton tsbUpdateClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSearchClients;
    }
}
