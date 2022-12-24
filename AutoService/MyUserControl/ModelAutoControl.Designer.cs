
namespace AutoService.MyUserControl
{
    partial class ModelAutoControl
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
            this.tsbSearchModelAuto = new System.Windows.Forms.ToolStripButton();
            this.tsbEditModelAuto = new System.Windows.Forms.ToolStripButton();
            this.tsbInsertModelAuto = new System.Windows.Forms.ToolStripButton();
            this.bsClientView = new System.Windows.Forms.BindingSource(this.components);
            this.tsModelAuto = new System.Windows.Forms.ToolStrip();
            this.tsbDeleteModelAuto = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateModelAuto = new System.Windows.Forms.ToolStripButton();
            this.pClients = new System.Windows.Forms.Panel();
            this.dgvModelAuto = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsModelCarView = new System.Windows.Forms.BindingSource(this.components);
            this.cbSortModeModelAuto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSortModelAuto = new System.Windows.Forms.Button();
            this.btnSearchModelAuto = new System.Windows.Forms.Button();
            this.tbSearchModelAuto = new System.Windows.Forms.TextBox();
            this.cbSortModelAuto = new System.Windows.Forms.ComboBox();
            this.pFunction = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientView)).BeginInit();
            this.tsModelAuto.SuspendLayout();
            this.pClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelCarView)).BeginInit();
            this.pFunction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbSearchModelAuto
            // 
            this.tsbSearchModelAuto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbSearchModelAuto.Image = global::AutoService.Properties.Resources.Search;
            this.tsbSearchModelAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchModelAuto.Name = "tsbSearchModelAuto";
            this.tsbSearchModelAuto.Size = new System.Drawing.Size(159, 24);
            this.tsbSearchModelAuto.Text = "Поиск/сортировка";
            this.tsbSearchModelAuto.Click += new System.EventHandler(this.tsbSearchModelAuto_Click);
            // 
            // tsbEditModelAuto
            // 
            this.tsbEditModelAuto.Image = global::AutoService.Properties.Resources.Edit;
            this.tsbEditModelAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditModelAuto.Name = "tsbEditModelAuto";
            this.tsbEditModelAuto.Size = new System.Drawing.Size(131, 24);
            this.tsbEditModelAuto.Text = "Редактировать";
            this.tsbEditModelAuto.Click += new System.EventHandler(this.tsbEditModelAuto_Click);
            // 
            // tsbInsertModelAuto
            // 
            this.tsbInsertModelAuto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbInsertModelAuto.Image = global::AutoService.Properties.Resources.UserAdd;
            this.tsbInsertModelAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertModelAuto.Name = "tsbInsertModelAuto";
            this.tsbInsertModelAuto.Size = new System.Drawing.Size(96, 24);
            this.tsbInsertModelAuto.Text = "Добавить";
            this.tsbInsertModelAuto.Click += new System.EventHandler(this.tsbInsertModelAuto_Click);
            // 
            // bsClientView
            // 
            this.bsClientView.DataSource = typeof(AutoService.Models.ClientView);
            // 
            // tsModelAuto
            // 
            this.tsModelAuto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsModelAuto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsModelAuto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsertModelAuto,
            this.tsbEditModelAuto,
            this.tsbDeleteModelAuto,
            this.tsbSearchModelAuto,
            this.tsbUpdateModelAuto});
            this.tsModelAuto.Location = new System.Drawing.Point(0, 0);
            this.tsModelAuto.Name = "tsModelAuto";
            this.tsModelAuto.Size = new System.Drawing.Size(577, 27);
            this.tsModelAuto.TabIndex = 15;
            this.tsModelAuto.Text = "toolStrip1";
            // 
            // tsbDeleteModelAuto
            // 
            this.tsbDeleteModelAuto.Image = global::AutoService.Properties.Resources.Delete;
            this.tsbDeleteModelAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteModelAuto.Name = "tsbDeleteModelAuto";
            this.tsbDeleteModelAuto.Size = new System.Drawing.Size(85, 24);
            this.tsbDeleteModelAuto.Text = "Удалить";
            this.tsbDeleteModelAuto.Click += new System.EventHandler(this.tsbDeleteModelAuto_Click);
            // 
            // tsbUpdateModelAuto
            // 
            this.tsbUpdateModelAuto.Image = global::AutoService.Properties.Resources.Update;
            this.tsbUpdateModelAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateModelAuto.Name = "tsbUpdateModelAuto";
            this.tsbUpdateModelAuto.Size = new System.Drawing.Size(98, 24);
            this.tsbUpdateModelAuto.Text = "Обновить";
            this.tsbUpdateModelAuto.Click += new System.EventHandler(this.tsbUpdateModelAuto_Click);
            // 
            // pClients
            // 
            this.pClients.Controls.Add(this.dgvModelAuto);
            this.pClients.Controls.Add(this.tsModelAuto);
            this.pClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClients.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pClients.Location = new System.Drawing.Point(0, 174);
            this.pClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pClients.Name = "pClients";
            this.pClients.Size = new System.Drawing.Size(577, 570);
            this.pClients.TabIndex = 29;
            // 
            // dgvModelAuto
            // 
            this.dgvModelAuto.AllowUserToAddRows = false;
            this.dgvModelAuto.AllowUserToDeleteRows = false;
            this.dgvModelAuto.AutoGenerateColumns = false;
            this.dgvModelAuto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvModelAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dgvModelAuto.DataSource = this.bsModelCarView;
            this.dgvModelAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModelAuto.Location = new System.Drawing.Point(0, 27);
            this.dgvModelAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvModelAuto.Name = "dgvModelAuto";
            this.dgvModelAuto.ReadOnly = true;
            this.dgvModelAuto.RowHeadersVisible = false;
            this.dgvModelAuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelAuto.Size = new System.Drawing.Size(577, 543);
            this.dgvModelAuto.TabIndex = 14;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Марка авто";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // bsModelCarView
            // 
            this.bsModelCarView.DataSource = typeof(AutoService.Models.ModelCarView);
            this.bsModelCarView.CurrentChanged += new System.EventHandler(this.bsModelCarView_CurrentChanged);
            // 
            // cbSortModeModelAuto
            // 
            this.cbSortModeModelAuto.FormattingEnabled = true;
            this.cbSortModeModelAuto.Items.AddRange(new object[] {
            "По убыванию (z-a, 10-1)",
            "По возрастанию (a-z, 1-10)"});
            this.cbSortModeModelAuto.Location = new System.Drawing.Point(166, 81);
            this.cbSortModeModelAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSortModeModelAuto.Name = "cbSortModeModelAuto";
            this.cbSortModeModelAuto.Size = new System.Drawing.Size(131, 28);
            this.cbSortModeModelAuto.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 56);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Сортировать по:";
            // 
            // btnSortModelAuto
            // 
            this.btnSortModelAuto.BackColor = System.Drawing.Color.Green;
            this.btnSortModelAuto.FlatAppearance.BorderSize = 0;
            this.btnSortModelAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSortModelAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSortModelAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortModelAuto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSortModelAuto.ForeColor = System.Drawing.Color.White;
            this.btnSortModelAuto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSortModelAuto.Location = new System.Drawing.Point(334, 70);
            this.btnSortModelAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortModelAuto.Name = "btnSortModelAuto";
            this.btnSortModelAuto.Size = new System.Drawing.Size(142, 39);
            this.btnSortModelAuto.TabIndex = 18;
            this.btnSortModelAuto.Text = "Применить";
            this.btnSortModelAuto.UseVisualStyleBackColor = false;
            this.btnSortModelAuto.Click += new System.EventHandler(this.btnSortModelAuto_Click);
            // 
            // btnSearchModelAuto
            // 
            this.btnSearchModelAuto.BackColor = System.Drawing.Color.Green;
            this.btnSearchModelAuto.FlatAppearance.BorderSize = 0;
            this.btnSearchModelAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSearchModelAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSearchModelAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchModelAuto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearchModelAuto.ForeColor = System.Drawing.Color.White;
            this.btnSearchModelAuto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchModelAuto.Location = new System.Drawing.Point(334, 12);
            this.btnSearchModelAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchModelAuto.Name = "btnSearchModelAuto";
            this.btnSearchModelAuto.Size = new System.Drawing.Size(142, 39);
            this.btnSearchModelAuto.TabIndex = 17;
            this.btnSearchModelAuto.Text = "Найти";
            this.btnSearchModelAuto.UseVisualStyleBackColor = false;
            this.btnSearchModelAuto.Click += new System.EventHandler(this.btnSearchModelAuto_Click);
            // 
            // tbSearchModelAuto
            // 
            this.tbSearchModelAuto.Location = new System.Drawing.Point(24, 24);
            this.tbSearchModelAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchModelAuto.Name = "tbSearchModelAuto";
            this.tbSearchModelAuto.Size = new System.Drawing.Size(273, 27);
            this.tbSearchModelAuto.TabIndex = 15;
            // 
            // cbSortModelAuto
            // 
            this.cbSortModelAuto.FormattingEnabled = true;
            this.cbSortModelAuto.Items.AddRange(new object[] {
            "Марка авто"});
            this.cbSortModelAuto.Location = new System.Drawing.Point(24, 81);
            this.cbSortModelAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSortModelAuto.Name = "cbSortModelAuto";
            this.cbSortModelAuto.Size = new System.Drawing.Size(131, 28);
            this.cbSortModelAuto.TabIndex = 16;
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
            this.pFunction.Size = new System.Drawing.Size(577, 174);
            this.pFunction.TabIndex = 28;
            this.pFunction.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Поиск и сортировка";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbSortModelAuto);
            this.panel1.Controls.Add(this.cbSortModeModelAuto);
            this.panel1.Controls.Add(this.tbSearchModelAuto);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSearchModelAuto);
            this.panel1.Controls.Add(this.btnSortModelAuto);
            this.panel1.Location = new System.Drawing.Point(28, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 121);
            this.panel1.TabIndex = 21;
            // 
            // ModelAutoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pClients);
            this.Controls.Add(this.pFunction);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModelAutoControl";
            this.Size = new System.Drawing.Size(577, 744);
            this.Load += new System.EventHandler(this.ModelAutoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsClientView)).EndInit();
            this.tsModelAuto.ResumeLayout(false);
            this.tsModelAuto.PerformLayout();
            this.pClients.ResumeLayout(false);
            this.pClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelCarView)).EndInit();
            this.pFunction.ResumeLayout(false);
            this.pFunction.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbSearchModelAuto;
        private System.Windows.Forms.ToolStripButton tsbEditModelAuto;
        private System.Windows.Forms.ToolStripButton tsbInsertModelAuto;
        private System.Windows.Forms.BindingSource bsClientView;
        private System.Windows.Forms.ToolStrip tsModelAuto;
        private System.Windows.Forms.ToolStripButton tsbDeleteModelAuto;
        private System.Windows.Forms.Panel pClients;
        private System.Windows.Forms.DataGridView dgvModelAuto;
        private System.Windows.Forms.ComboBox cbSortModeModelAuto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSortModelAuto;
        private System.Windows.Forms.Button btnSearchModelAuto;
        private System.Windows.Forms.TextBox tbSearchModelAuto;
        private System.Windows.Forms.ComboBox cbSortModelAuto;
        private System.Windows.Forms.Panel pFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsModelCarView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbUpdateModelAuto;
    }
}
