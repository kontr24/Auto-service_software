
namespace AutoService.MyUserControl
{
    partial class UsersUserControl
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
            this.bsClientView = new System.Windows.Forms.BindingSource(this.components);
            this.pClients = new System.Windows.Forms.Panel();
            this.pNewUsers = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.bsStatus = new System.Windows.Forms.BindingSource(this.components);
            this.btnInsertUser = new System.Windows.Forms.Button();
            this.dgvModelAuto = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsUsersView = new System.Windows.Forms.BindingSource(this.components);
            this.tsUsers = new System.Windows.Forms.ToolStrip();
            this.tsbInsertUsers = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteUsers = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchModelAuto = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateUsers = new System.Windows.Forms.ToolStripButton();
            this.bsModelCarView = new System.Windows.Forms.BindingSource(this.components);
            this.pFunction = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSearchUsers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSortModeUsers = new System.Windows.Forms.ComboBox();
            this.cbSortUsers = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSearchUsers = new System.Windows.Forms.TextBox();
            this.btnSortUsers = new System.Windows.Forms.Button();
            this.btnSearchUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientView)).BeginInit();
            this.pClients.SuspendLayout();
            this.pNewUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersView)).BeginInit();
            this.tsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelCarView)).BeginInit();
            this.pFunction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsClientView
            // 
            this.bsClientView.DataSource = typeof(AutoService.Models.ClientView);
            // 
            // pClients
            // 
            this.pClients.Controls.Add(this.pNewUsers);
            this.pClients.Controls.Add(this.dgvModelAuto);
            this.pClients.Controls.Add(this.tsUsers);
            this.pClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClients.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pClients.Location = new System.Drawing.Point(0, 196);
            this.pClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pClients.Name = "pClients";
            this.pClients.Size = new System.Drawing.Size(590, 391);
            this.pClients.TabIndex = 32;
            // 
            // pNewUsers
            // 
            this.pNewUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNewUsers.Controls.Add(this.label2);
            this.pNewUsers.Controls.Add(this.label3);
            this.pNewUsers.Controls.Add(this.tbLogin);
            this.pNewUsers.Controls.Add(this.tbPassword);
            this.pNewUsers.Controls.Add(this.label1);
            this.pNewUsers.Controls.Add(this.cbMode);
            this.pNewUsers.Controls.Add(this.btnInsertUser);
            this.pNewUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.pNewUsers.Location = new System.Drawing.Point(356, 27);
            this.pNewUsers.Name = "pNewUsers";
            this.pNewUsers.Size = new System.Drawing.Size(234, 364);
            this.pNewUsers.TabIndex = 17;
            this.pNewUsers.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Статус";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(23, 37);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(160, 27);
            this.tbLogin.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(23, 94);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(160, 27);
            this.tbPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Логин";
            // 
            // cbMode
            // 
            this.cbMode.DataSource = this.bsStatus;
            this.cbMode.DisplayMember = "Login";
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Location = new System.Drawing.Point(23, 151);
            this.cbMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(160, 28);
            this.cbMode.TabIndex = 3;
            this.cbMode.ValueMember = "Id";
            // 
            // bsStatus
            // 
            this.bsStatus.DataSource = typeof(AutoService.Models.Status);
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.BackColor = System.Drawing.Color.Green;
            this.btnInsertUser.FlatAppearance.BorderSize = 0;
            this.btnInsertUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnInsertUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnInsertUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertUser.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnInsertUser.ForeColor = System.Drawing.Color.White;
            this.btnInsertUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsertUser.Location = new System.Drawing.Point(23, 205);
            this.btnInsertUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(160, 39);
            this.btnInsertUser.TabIndex = 10;
            this.btnInsertUser.Text = "Добавить";
            this.btnInsertUser.UseVisualStyleBackColor = false;
            this.btnInsertUser.Click += new System.EventHandler(this.btnInsertUser_Click);
            // 
            // dgvModelAuto
            // 
            this.dgvModelAuto.AllowUserToAddRows = false;
            this.dgvModelAuto.AllowUserToDeleteRows = false;
            this.dgvModelAuto.AutoGenerateColumns = false;
            this.dgvModelAuto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvModelAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.usersDataGridViewTextBoxColumn});
            this.dgvModelAuto.DataSource = this.bsUsersView;
            this.dgvModelAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModelAuto.Location = new System.Drawing.Point(0, 27);
            this.dgvModelAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvModelAuto.Name = "dgvModelAuto";
            this.dgvModelAuto.ReadOnly = true;
            this.dgvModelAuto.RowHeadersVisible = false;
            this.dgvModelAuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelAuto.Size = new System.Drawing.Size(590, 364);
            this.dgvModelAuto.TabIndex = 14;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.loginDataGridViewTextBoxColumn.Width = 58;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // usersDataGridViewTextBoxColumn
            // 
            this.usersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usersDataGridViewTextBoxColumn.DataPropertyName = "Users";
            this.usersDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.usersDataGridViewTextBoxColumn.Name = "usersDataGridViewTextBoxColumn";
            this.usersDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.usersDataGridViewTextBoxColumn.Width = 58;
            // 
            // bsUsersView
            // 
            this.bsUsersView.DataSource = typeof(AutoService.Models.UserView);
            this.bsUsersView.CurrentChanged += new System.EventHandler(this.bsUsersView_CurrentChanged);
            // 
            // tsUsers
            // 
            this.tsUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsUsers.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsertUsers,
            this.tsbDeleteUsers,
            this.tsbSearchModelAuto,
            this.tsbUpdateUsers});
            this.tsUsers.Location = new System.Drawing.Point(0, 0);
            this.tsUsers.Name = "tsUsers";
            this.tsUsers.Size = new System.Drawing.Size(590, 27);
            this.tsUsers.TabIndex = 15;
            this.tsUsers.Text = "toolStrip1";
            // 
            // tsbInsertUsers
            // 
            this.tsbInsertUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbInsertUsers.Image = global::AutoService.Properties.Resources.UserAdd;
            this.tsbInsertUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertUsers.Name = "tsbInsertUsers";
            this.tsbInsertUsers.Size = new System.Drawing.Size(96, 24);
            this.tsbInsertUsers.Text = "Добавить";
            this.tsbInsertUsers.Click += new System.EventHandler(this.tsbInsertUsers_Click);
            // 
            // tsbDeleteUsers
            // 
            this.tsbDeleteUsers.Image = global::AutoService.Properties.Resources.Delete;
            this.tsbDeleteUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteUsers.Name = "tsbDeleteUsers";
            this.tsbDeleteUsers.Size = new System.Drawing.Size(85, 24);
            this.tsbDeleteUsers.Text = "Удалить";
            this.tsbDeleteUsers.Click += new System.EventHandler(this.tsbDeleteUsers_Click);
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
            // tsbUpdateUsers
            // 
            this.tsbUpdateUsers.Image = global::AutoService.Properties.Resources.Update;
            this.tsbUpdateUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateUsers.Name = "tsbUpdateUsers";
            this.tsbUpdateUsers.Size = new System.Drawing.Size(98, 24);
            this.tsbUpdateUsers.Text = "Обновить";
            this.tsbUpdateUsers.Click += new System.EventHandler(this.tsbUpdateUsers_Click);
            // 
            // bsModelCarView
            // 
            this.bsModelCarView.DataSource = typeof(AutoService.Models.ModelCarView);
            // 
            // pFunction
            // 
            this.pFunction.Controls.Add(this.label4);
            this.pFunction.Controls.Add(this.panel1);
            this.pFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFunction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pFunction.Location = new System.Drawing.Point(0, 0);
            this.pFunction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pFunction.Name = "pFunction";
            this.pFunction.Size = new System.Drawing.Size(590, 196);
            this.pFunction.TabIndex = 31;
            this.pFunction.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Поиск и сортировка";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbSearchUsers);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbSortModeUsers);
            this.panel1.Controls.Add(this.cbSortUsers);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbSearchUsers);
            this.panel1.Controls.Add(this.btnSortUsers);
            this.panel1.Controls.Add(this.btnSearchUsers);
            this.panel1.Location = new System.Drawing.Point(16, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 149);
            this.panel1.TabIndex = 21;
            // 
            // cbSearchUsers
            // 
            this.cbSearchUsers.FormattingEnabled = true;
            this.cbSearchUsers.Items.AddRange(new object[] {
            "Логин",
            "Статус"});
            this.cbSearchUsers.Location = new System.Drawing.Point(18, 42);
            this.cbSearchUsers.Name = "cbSearchUsers";
            this.cbSearchUsers.Size = new System.Drawing.Size(160, 28);
            this.cbSearchUsers.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Поиск по:";
            // 
            // cbSortModeUsers
            // 
            this.cbSortModeUsers.FormattingEnabled = true;
            this.cbSortModeUsers.Items.AddRange(new object[] {
            "По убыванию (z-a, 10-1)",
            "По возрастанию (a-z, 1-10)"});
            this.cbSortModeUsers.Location = new System.Drawing.Point(202, 98);
            this.cbSortModeUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSortModeUsers.Name = "cbSortModeUsers";
            this.cbSortModeUsers.Size = new System.Drawing.Size(160, 28);
            this.cbSortModeUsers.TabIndex = 20;
            // 
            // cbSortUsers
            // 
            this.cbSortUsers.FormattingEnabled = true;
            this.cbSortUsers.Items.AddRange(new object[] {
            "Логин",
            "Статус"});
            this.cbSortUsers.Location = new System.Drawing.Point(18, 98);
            this.cbSortUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSortUsers.Name = "cbSortUsers";
            this.cbSortUsers.Size = new System.Drawing.Size(160, 28);
            this.cbSortUsers.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Сортировать по:";
            // 
            // tbSearchUsers
            // 
            this.tbSearchUsers.Location = new System.Drawing.Point(202, 43);
            this.tbSearchUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchUsers.Name = "tbSearchUsers";
            this.tbSearchUsers.Size = new System.Drawing.Size(160, 27);
            this.tbSearchUsers.TabIndex = 15;
            // 
            // btnSortUsers
            // 
            this.btnSortUsers.BackColor = System.Drawing.Color.Green;
            this.btnSortUsers.FlatAppearance.BorderSize = 0;
            this.btnSortUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSortUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSortUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSortUsers.ForeColor = System.Drawing.Color.White;
            this.btnSortUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSortUsers.Location = new System.Drawing.Point(381, 87);
            this.btnSortUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortUsers.Name = "btnSortUsers";
            this.btnSortUsers.Size = new System.Drawing.Size(160, 39);
            this.btnSortUsers.TabIndex = 18;
            this.btnSortUsers.Text = "Применить";
            this.btnSortUsers.UseVisualStyleBackColor = false;
            this.btnSortUsers.Click += new System.EventHandler(this.btnSortUsers_Click);
            // 
            // btnSearchUsers
            // 
            this.btnSearchUsers.BackColor = System.Drawing.Color.Green;
            this.btnSearchUsers.FlatAppearance.BorderSize = 0;
            this.btnSearchUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnSearchUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnSearchUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearchUsers.ForeColor = System.Drawing.Color.White;
            this.btnSearchUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchUsers.Location = new System.Drawing.Point(381, 31);
            this.btnSearchUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchUsers.Name = "btnSearchUsers";
            this.btnSearchUsers.Size = new System.Drawing.Size(160, 39);
            this.btnSearchUsers.TabIndex = 17;
            this.btnSearchUsers.Text = "Найти";
            this.btnSearchUsers.UseVisualStyleBackColor = false;
            this.btnSearchUsers.Click += new System.EventHandler(this.btnSearchUsers_Click);
            // 
            // UsersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pClients);
            this.Controls.Add(this.pFunction);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UsersUserControl";
            this.Size = new System.Drawing.Size(590, 587);
            this.Load += new System.EventHandler(this.UsersUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsClientView)).EndInit();
            this.pClients.ResumeLayout(false);
            this.pClients.PerformLayout();
            this.pNewUsers.ResumeLayout(false);
            this.pNewUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersView)).EndInit();
            this.tsUsers.ResumeLayout(false);
            this.tsUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelCarView)).EndInit();
            this.pFunction.ResumeLayout(false);
            this.pFunction.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsClientView;
        private System.Windows.Forms.Panel pClients;
        private System.Windows.Forms.DataGridView dgvModelAuto;
        private System.Windows.Forms.BindingSource bsModelCarView;
        private System.Windows.Forms.ToolStrip tsUsers;
        private System.Windows.Forms.ToolStripButton tsbInsertUsers;
        private System.Windows.Forms.ToolStripButton tsbDeleteUsers;
        private System.Windows.Forms.ToolStripButton tsbSearchModelAuto;
        private System.Windows.Forms.Panel pFunction;
        private System.Windows.Forms.ComboBox cbSortModeUsers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSortUsers;
        private System.Windows.Forms.Button btnSearchUsers;
        private System.Windows.Forms.TextBox tbSearchUsers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSortUsers;
        private System.Windows.Forms.Panel pNewUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Button btnInsertUser;
        private System.Windows.Forms.BindingSource bsUsersView;
        private System.Windows.Forms.BindingSource bsStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSearchUsers;
        private System.Windows.Forms.ToolStripButton tsbUpdateUsers;
    }
}
