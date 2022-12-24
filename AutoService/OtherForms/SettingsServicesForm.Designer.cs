
namespace AutoService
{
    partial class SettingsServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsServicesForm));
            this.tbNameService = new System.Windows.Forms.TextBox();
            this.tbDetailsService = new System.Windows.Forms.TextBox();
            this.btnInsertClientOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPriceServices = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNameService
            // 
            this.tbNameService.Location = new System.Drawing.Point(25, 35);
            this.tbNameService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNameService.Multiline = true;
            this.tbNameService.Name = "tbNameService";
            this.tbNameService.Size = new System.Drawing.Size(409, 32);
            this.tbNameService.TabIndex = 7;
            // 
            // tbDetailsService
            // 
            this.tbDetailsService.Location = new System.Drawing.Point(25, 97);
            this.tbDetailsService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDetailsService.Multiline = true;
            this.tbDetailsService.Name = "tbDetailsService";
            this.tbDetailsService.Size = new System.Drawing.Size(409, 224);
            this.tbDetailsService.TabIndex = 8;
            // 
            // btnInsertClientOK
            // 
            this.btnInsertClientOK.BackColor = System.Drawing.Color.Green;
            this.btnInsertClientOK.FlatAppearance.BorderSize = 0;
            this.btnInsertClientOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnInsertClientOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnInsertClientOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertClientOK.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnInsertClientOK.ForeColor = System.Drawing.Color.White;
            this.btnInsertClientOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsertClientOK.Location = new System.Drawing.Point(338, 409);
            this.btnInsertClientOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertClientOK.Name = "btnInsertClientOK";
            this.btnInsertClientOK.Size = new System.Drawing.Size(96, 38);
            this.btnInsertClientOK.TabIndex = 15;
            this.btnInsertClientOK.Text = "OK";
            this.btnInsertClientOK.UseVisualStyleBackColor = false;
            this.btnInsertClientOK.Click += new System.EventHandler(this.btnInsertClientOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Наименование услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(401, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "р.";
            // 
            // tbPriceServices
            // 
            this.tbPriceServices.Location = new System.Drawing.Point(25, 360);
            this.tbPriceServices.Name = "tbPriceServices";
            this.tbPriceServices.Size = new System.Drawing.Size(370, 27);
            this.tbPriceServices.TabIndex = 20;
            this.tbPriceServices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPriceServices_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPriceServices);
            this.panel1.Controls.Add(this.tbNameService);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbDetailsService);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnInsertClientOK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 475);
            this.panel1.TabIndex = 21;
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
            this.button1.Location = new System.Drawing.Point(212, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Услуга";
            // 
            // SettingsServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(487, 525);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SettingsServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать/Добавить";
            this.Load += new System.EventHandler(this.SettingsServicesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNameService;
        private System.Windows.Forms.TextBox tbDetailsService;
        private System.Windows.Forms.Button btnInsertClientOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPriceServices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}