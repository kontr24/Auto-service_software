
namespace AutoService
{
    partial class SettingsModelAutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsModelAutoForm));
            this.tbModelAuto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertClientOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbModelAuto
            // 
            this.tbModelAuto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModelAuto.Location = new System.Drawing.Point(22, 32);
            this.tbModelAuto.Name = "tbModelAuto";
            this.tbModelAuto.Size = new System.Drawing.Size(246, 27);
            this.tbModelAuto.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Марка";
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
            this.btnInsertClientOK.Location = new System.Drawing.Point(178, 84);
            this.btnInsertClientOK.Name = "btnInsertClientOK";
            this.btnInsertClientOK.Size = new System.Drawing.Size(90, 34);
            this.btnInsertClientOK.TabIndex = 21;
            this.btnInsertClientOK.Text = "OK";
            this.btnInsertClientOK.UseVisualStyleBackColor = false;
            this.btnInsertClientOK.Click += new System.EventHandler(this.btnInsertClientOK_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbModelAuto);
            this.panel1.Controls.Add(this.btnInsertClientOK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 137);
            this.panel1.TabIndex = 22;
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
            this.button1.Location = new System.Drawing.Point(65, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsModelAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(318, 176);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsModelAutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать/Добавить";
            this.Load += new System.EventHandler(this.SettingsModelAutoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbModelAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertClientOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}