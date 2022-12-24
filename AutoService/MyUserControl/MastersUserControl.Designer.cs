
namespace AutoService.MyUserControl
{
    partial class MastersUserControl
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
            this.tsbSearchMasters = new System.Windows.Forms.ToolStripButton();
            this.tsbEditMasters = new System.Windows.Forms.ToolStripButton();
            this.tsbInsertMasters = new System.Windows.Forms.ToolStripButton();
            this.tsMasters = new System.Windows.Forms.ToolStrip();
            this.tsbDeleteMasters = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateMasters = new System.Windows.Forms.ToolStripButton();
            this.pClients = new System.Windows.Forms.Panel();
            this.dgvMasters = new System.Windows.Forms.DataGridView();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMasterSeparatelyView = new System.Windows.Forms.BindingSource(this.components);
            this.cbSortModeMasters = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSortMasters = new System.Windows.Forms.Button();
            this.btnSearchMasters = new System.Windows.Forms.Button();
            this.tbSearchMasters = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSortMasters = new System.Windows.Forms.ComboBox();
            this.pFunction = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSearchMasters = new System.Windows.Forms.DateTimePicker();
            this.cbSearchMasters = new System.Windows.Forms.ComboBox();
            this.bsClientView = new System.Windows.Forms.BindingSource(this.components);
            this.tsMasters.SuspendLayout();
            this.pClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterSeparatelyView)).BeginInit();
            this.pFunction.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientView)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbSearchMasters
            // 
            this.tsbSearchMasters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbSearchMasters.Image = global::AutoService.Properties.Resources.Search;
            this.tsbSearchMasters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchMasters.Name = "tsbSearchMasters";
            this.tsbSearchMasters.Size = new System.Drawing.Size(159, 24);
            this.tsbSearchMasters.Text = "Поиск/сортировка";
            this.tsbSearchMasters.Click += new System.EventHandler(this.tsbSearchMasters_Click);
            // 
            // tsbEditMasters
            // 
            this.tsbEditMasters.Image = global::AutoService.Properties.Resources.Edit;
            this.tsbEditMasters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditMasters.Name = "tsbEditMasters";
            this.tsbEditMasters.Size = new System.Drawing.Size(131, 24);
            this.tsbEditMasters.Text = "Редактировать";
            this.tsbEditMasters.Click += new System.EventHandler(this.tsbEditMasters_Click);
            // 
            // tsbInsertMasters
            // 
            this.tsbInsertMasters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbInsertMasters.Image = global::AutoService.Properties.Resources.UserAdd;
            this.tsbInsertMasters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertMasters.Name = "tsbInsertMasters";
            this.tsbInsertMasters.Size = new System.Drawing.Size(96, 24);
            this.tsbInsertMasters.Text = "Добавить";
            this.tsbInsertMasters.Click += new System.EventHandler(this.tsbInsertMasters_Click);
            // 
            // tsMasters
            // 
            this.tsMasters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsMasters.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMasters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsertMasters,
            this.tsbEditMasters,
            this.tsbDeleteMasters,
            this.tsbSearchMasters,
            this.tsbUpdateMasters});
            this.tsMasters.Location = new System.Drawing.Point(0, 0);
            this.tsMasters.Name = "tsMasters";
            this.tsMasters.Size = new System.Drawing.Size(808, 27);
            this.tsMasters.TabIndex = 15;
            this.tsMasters.Text = "toolStrip1";
            // 
            // tsbDeleteMasters
            // 
            this.tsbDeleteMasters.Image = global::AutoService.Properties.Resources.Delete;
            this.tsbDeleteMasters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteMasters.Name = "tsbDeleteMasters";
            this.tsbDeleteMasters.Size = new System.Drawing.Size(85, 24);
            this.tsbDeleteMasters.Text = "Удалить";
            this.tsbDeleteMasters.Click += new System.EventHandler(this.tsbDeleteMasters_Click);
            // 
            // tsbUpdateMasters
            // 
            this.tsbUpdateMasters.Image = global::AutoService.Properties.Resources.Update;
            this.tsbUpdateMasters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateMasters.Name = "tsbUpdateMasters";
            this.tsbUpdateMasters.Size = new System.Drawing.Size(98, 24);
            this.tsbUpdateMasters.Text = "Обновить";
            this.tsbUpdateMasters.Click += new System.EventHandler(this.tsbUpdateMasters_Click);
            // 
            // pClients
            // 
            this.pClients.Controls.Add(this.dgvMasters);
            this.pClients.Controls.Add(this.tsMasters);
            this.pClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClients.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pClients.Location = new System.Drawing.Point(0, 221);
            this.pClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pClients.Name = "pClients";
            this.pClients.Size = new System.Drawing.Size(808, 399);
            this.pClients.TabIndex = 29;
            // 
            // dgvMasters
            // 
            this.dgvMasters.AllowUserToAddRows = false;
            this.dgvMasters.AllowUserToDeleteRows = false;
            this.dgvMasters.AutoGenerateColumns = false;
            this.dgvMasters.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMasters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dgvMasters.DataSource = this.bsMasterSeparatelyView;
            this.dgvMasters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMasters.Location = new System.Drawing.Point(0, 27);
            this.dgvMasters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMasters.Name = "dgvMasters";
            this.dgvMasters.ReadOnly = true;
            this.dgvMasters.RowHeadersVisible = false;
            this.dgvMasters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMasters.Size = new System.Drawing.Size(808, 372);
            this.dgvMasters.TabIndex = 14;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.surnameDataGridViewTextBoxColumn.Width = 79;
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
            this.birthdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.birthdayDataGridViewTextBoxColumn.Width = 122;
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
            // bsMasterSeparatelyView
            // 
            this.bsMasterSeparatelyView.DataSource = typeof(AutoService.Models.MasterSeparatelyView);
            this.bsMasterSeparatelyView.CurrentChanged += new System.EventHandler(this.bsMasterSeparatelyView_CurrentChanged);
            // 
            // cbSortModeMasters
            // 
            this.cbSortModeMasters.FormattingEnabled = true;
            this.cbSortModeMasters.Items.AddRange(new object[] {
            "По убыванию (z-a, 10-1)",
            "По возрастанию (a-z, 1-10)"});
            this.cbSortModeMasters.Location = new System.Drawing.Point(340, 106);
            this.cbSortModeMasters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSortModeMasters.Name = "cbSortModeMasters";
            this.cbSortModeMasters.Size = new System.Drawing.Size(259, 28);
            this.cbSortModeMasters.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Сортировать по:";
            // 
            // btnSortMasters
            // 
            this.btnSortMasters.BackColor = System.Drawing.Color.Green;
            this.btnSortMasters.FlatAppearance.BorderSize = 0;
            this.btnSortMasters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSortMasters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSortMasters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortMasters.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSortMasters.ForeColor = System.Drawing.Color.White;
            this.btnSortMasters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSortMasters.Location = new System.Drawing.Point(624, 95);
            this.btnSortMasters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortMasters.Name = "btnSortMasters";
            this.btnSortMasters.Size = new System.Drawing.Size(142, 39);
            this.btnSortMasters.TabIndex = 18;
            this.btnSortMasters.Text = "Применить";
            this.btnSortMasters.UseVisualStyleBackColor = false;
            this.btnSortMasters.Click += new System.EventHandler(this.btnSortMasters_Click);
            // 
            // btnSearchMasters
            // 
            this.btnSearchMasters.BackColor = System.Drawing.Color.Green;
            this.btnSearchMasters.FlatAppearance.BorderSize = 0;
            this.btnSearchMasters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSearchMasters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSearchMasters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMasters.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearchMasters.ForeColor = System.Drawing.Color.White;
            this.btnSearchMasters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchMasters.Location = new System.Drawing.Point(624, 29);
            this.btnSearchMasters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchMasters.Name = "btnSearchMasters";
            this.btnSearchMasters.Size = new System.Drawing.Size(142, 39);
            this.btnSearchMasters.TabIndex = 17;
            this.btnSearchMasters.Text = "Найти";
            this.btnSearchMasters.UseVisualStyleBackColor = false;
            this.btnSearchMasters.Click += new System.EventHandler(this.btnSearchMasters_Click);
            // 
            // tbSearchMasters
            // 
            this.tbSearchMasters.Location = new System.Drawing.Point(375, 41);
            this.tbSearchMasters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchMasters.Name = "tbSearchMasters";
            this.tbSearchMasters.Size = new System.Drawing.Size(224, 27);
            this.tbSearchMasters.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Поиск по:";
            // 
            // cbSortMasters
            // 
            this.cbSortMasters.FormattingEnabled = true;
            this.cbSortMasters.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Дата рождения",
            "Телефон"});
            this.cbSortMasters.Location = new System.Drawing.Point(17, 106);
            this.cbSortMasters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSortMasters.Name = "cbSortMasters";
            this.cbSortMasters.Size = new System.Drawing.Size(259, 28);
            this.cbSortMasters.TabIndex = 16;
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
            this.pFunction.Size = new System.Drawing.Size(808, 221);
            this.pFunction.TabIndex = 28;
            this.pFunction.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Поиск и сортировка";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpSearchMasters);
            this.panel1.Controls.Add(this.cbSearchMasters);
            this.panel1.Controls.Add(this.tbSearchMasters);
            this.panel1.Controls.Add(this.cbSortModeMasters);
            this.panel1.Controls.Add(this.cbSortMasters);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnSortMasters);
            this.panel1.Controls.Add(this.btnSearchMasters);
            this.panel1.Location = new System.Drawing.Point(16, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 166);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "По дате:";
            // 
            // dtpSearchMasters
            // 
            this.dtpSearchMasters.Location = new System.Drawing.Point(202, 41);
            this.dtpSearchMasters.Name = "dtpSearchMasters";
            this.dtpSearchMasters.Size = new System.Drawing.Size(154, 27);
            this.dtpSearchMasters.TabIndex = 23;
            // 
            // cbSearchMasters
            // 
            this.cbSearchMasters.FormattingEnabled = true;
            this.cbSearchMasters.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Дата рождения",
            "Телефон"});
            this.cbSearchMasters.Location = new System.Drawing.Point(17, 40);
            this.cbSearchMasters.Name = "cbSearchMasters";
            this.cbSearchMasters.Size = new System.Drawing.Size(167, 28);
            this.cbSearchMasters.TabIndex = 22;
            // 
            // bsClientView
            // 
            this.bsClientView.DataSource = typeof(AutoService.Models.ClientView);
            // 
            // MastersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pClients);
            this.Controls.Add(this.pFunction);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MastersUserControl";
            this.Size = new System.Drawing.Size(808, 620);
            this.Load += new System.EventHandler(this.MastersUserControl_Load);
            this.tsMasters.ResumeLayout(false);
            this.tsMasters.PerformLayout();
            this.pClients.ResumeLayout(false);
            this.pClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterSeparatelyView)).EndInit();
            this.pFunction.ResumeLayout(false);
            this.pFunction.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbSearchMasters;
        private System.Windows.Forms.ToolStripButton tsbEditMasters;
        private System.Windows.Forms.ToolStripButton tsbInsertMasters;
        private System.Windows.Forms.BindingSource bsClientView;
        private System.Windows.Forms.ToolStrip tsMasters;
        private System.Windows.Forms.ToolStripButton tsbDeleteMasters;
        private System.Windows.Forms.Panel pClients;
        private System.Windows.Forms.DataGridView dgvMasters;
        private System.Windows.Forms.ComboBox cbSortModeMasters;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSortMasters;
        private System.Windows.Forms.Button btnSearchMasters;
        private System.Windows.Forms.TextBox tbSearchMasters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSortMasters;
        private System.Windows.Forms.Panel pFunction;
        private System.Windows.Forms.BindingSource bsMasterSeparatelyView;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearchMasters;
        private System.Windows.Forms.ToolStripButton tsbUpdateMasters;
        private System.Windows.Forms.DateTimePicker dtpSearchMasters;
        private System.Windows.Forms.Label label3;
    }
}
