
namespace AutoService
{
    partial class ModelAutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelAutoForm));
            this.modelAutoControl1 = new AutoService.MyUserControl.ModelAutoControl();
            this.SuspendLayout();
            // 
            // modelCarViewTableAdapter1
            // 
            // 
            // modelCarsTableAdapter1
            // 
            // 
            // modelAutoControl1
            // 
            this.modelAutoControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.modelAutoControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelAutoControl1.Location = new System.Drawing.Point(4, 1);
            this.modelAutoControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modelAutoControl1.Name = "modelAutoControl1";
            this.modelAutoControl1.Size = new System.Drawing.Size(571, 744);
            this.modelAutoControl1.TabIndex = 0;
            // 
            // ModelAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(576, 747);
            this.Controls.Add(this.modelAutoControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ModelAutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Марки авто";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelAutoForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion


        private AutoService.MyUserControl.ModelAutoControl modelAutoControl1;
    }
}