
namespace AutoService
{
    partial class PerformForm
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
            this.dtpDateReady = new System.Windows.Forms.DateTimePicker();
            this.btnDateReady = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDateReady
            // 
            this.dtpDateReady.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateReady.Location = new System.Drawing.Point(12, 12);
            this.dtpDateReady.Name = "dtpDateReady";
            this.dtpDateReady.Size = new System.Drawing.Size(190, 27);
            this.dtpDateReady.TabIndex = 0;
            // 
            // btnDateReady
            // 
            this.btnDateReady.BackColor = System.Drawing.Color.Green;
            this.btnDateReady.FlatAppearance.BorderSize = 0;
            this.btnDateReady.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnDateReady.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnDateReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateReady.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnDateReady.ForeColor = System.Drawing.Color.White;
            this.btnDateReady.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDateReady.Location = new System.Drawing.Point(12, 45);
            this.btnDateReady.Name = "btnDateReady";
            this.btnDateReady.Size = new System.Drawing.Size(190, 29);
            this.btnDateReady.TabIndex = 10;
            this.btnDateReady.Text = "Выполнить";
            this.btnDateReady.UseVisualStyleBackColor = false;
            this.btnDateReady.Click += new System.EventHandler(this.btnDateReady_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Green;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(12, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(190, 29);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PerformForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(215, 121);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDateReady);
            this.Controls.Add(this.dtpDateReady);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerformForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerformForm";
            this.Load += new System.EventHandler(this.PerformForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateReady;
        private System.Windows.Forms.Button btnDateReady;
        private System.Windows.Forms.Button btnClose;
    }
}