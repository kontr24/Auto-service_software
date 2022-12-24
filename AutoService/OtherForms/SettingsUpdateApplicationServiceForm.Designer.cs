
namespace AutoService
{
    partial class SettingsUpdateApplicationServiceForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUpdateApplicationServiceForm));
            this.btnUpdeteServiceOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbServices = new System.Windows.Forms.ComboBox();
            this.bsServiceView = new System.Windows.Forms.BindingSource(this.components);
            this.bsMastersView = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbClientSurName = new System.Windows.Forms.ComboBox();
            this.bsClientsJoinView = new System.Windows.Forms.BindingSource(this.components);
            this.bsApplicationsView = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cbMasters = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataVisit = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMastersView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientsJoinView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsApplicationsView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdeteServiceOK
            // 
            this.btnUpdeteServiceOK.BackColor = System.Drawing.Color.Green;
            this.btnUpdeteServiceOK.FlatAppearance.BorderSize = 0;
            this.btnUpdeteServiceOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnUpdeteServiceOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnUpdeteServiceOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdeteServiceOK.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnUpdeteServiceOK.ForeColor = System.Drawing.Color.White;
            this.btnUpdeteServiceOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdeteServiceOK.Location = new System.Drawing.Point(313, 214);
            this.btnUpdeteServiceOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdeteServiceOK.Name = "btnUpdeteServiceOK";
            this.btnUpdeteServiceOK.Size = new System.Drawing.Size(93, 36);
            this.btnUpdeteServiceOK.TabIndex = 15;
            this.btnUpdeteServiceOK.Text = "OK";
            this.btnUpdeteServiceOK.UseVisualStyleBackColor = false;
            this.btnUpdeteServiceOK.Click += new System.EventHandler(this.btnUpdeteServiceOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Услуги";
            // 
            // cbServices
            // 
            this.cbServices.DataSource = this.bsServiceView;
            this.cbServices.DisplayMember = "Name";
            this.cbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServices.FormattingEnabled = true;
            this.cbServices.Location = new System.Drawing.Point(35, 95);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(371, 28);
            this.cbServices.TabIndex = 20;
            this.cbServices.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "ФИО";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbClientSurName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 86);
            this.panel1.TabIndex = 31;
            // 
            // cbClientSurName
            // 
            this.cbClientSurName.DataSource = this.bsClientsJoinView;
            this.cbClientSurName.DisplayMember = "Client";
            this.cbClientSurName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientSurName.FormattingEnabled = true;
            this.cbClientSurName.Location = new System.Drawing.Point(36, 33);
            this.cbClientSurName.Name = "cbClientSurName";
            this.cbClientSurName.Size = new System.Drawing.Size(370, 28);
            this.cbClientSurName.TabIndex = 31;
            this.cbClientSurName.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Клиент";
            // 
            // cbMasters
            // 
            this.cbMasters.DataSource = this.bsMastersView;
            this.cbMasters.DisplayMember = "Master";
            this.cbMasters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMasters.FormattingEnabled = true;
            this.cbMasters.Location = new System.Drawing.Point(35, 156);
            this.cbMasters.Name = "cbMasters";
            this.cbMasters.Size = new System.Drawing.Size(371, 28);
            this.cbMasters.TabIndex = 33;
            this.cbMasters.ValueMember = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Мастера";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpDataVisit);
            this.panel2.Controls.Add(this.cbServices);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnUpdeteServiceOK);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbMasters);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 266);
            this.panel2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Дата визита";
            // 
            // dtpDataVisit
            // 
            this.dtpDataVisit.Location = new System.Drawing.Point(36, 39);
            this.dtpDataVisit.Name = "dtpDataVisit";
            this.dtpDataVisit.Size = new System.Drawing.Size(370, 27);
            this.dtpDataVisit.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(198, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 36;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsUpdateApplicationServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(469, 399);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SettingsUpdateApplicationServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать заявку";
            this.Load += new System.EventHandler(this.SettingsUpdateApplicationServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMastersView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientsJoinView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsApplicationsView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdeteServiceOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbServices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMasters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbClientSurName;
        private System.Windows.Forms.BindingSource bsApplicationsView;
        private System.Windows.Forms.BindingSource bsMastersView;
        private System.Windows.Forms.BindingSource bsServiceView;
        private System.Windows.Forms.BindingSource bsClientsJoinView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataVisit;
        private System.Windows.Forms.Button button1;
    }
}