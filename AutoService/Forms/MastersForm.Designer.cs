
namespace AutoService
{
    partial class MastersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MastersForm));
            this.mastersUserControl1 = new AutoService.MyUserControl.MastersUserControl();
            this.SuspendLayout();
            // 
            // mastersUserControl1
            // 
            this.mastersUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.mastersUserControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mastersUserControl1.Location = new System.Drawing.Point(3, 3);
            this.mastersUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mastersUserControl1.Name = "mastersUserControl1";
            this.mastersUserControl1.Size = new System.Drawing.Size(808, 620);
            this.mastersUserControl1.TabIndex = 0;
            // 
            // MastersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(815, 626);
            this.Controls.Add(this.mastersUserControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MastersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мастера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MastersForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private AutoService.MyUserControl.MastersUserControl mastersUserControl1;
    }
}