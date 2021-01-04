
namespace WindowsFormsApp2
{
    partial class processForm
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
            this.appCount = new System.Windows.Forms.Label();
            this.appMemory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appCount
            // 
            this.appCount.AutoSize = true;
            this.appCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appCount.Location = new System.Drawing.Point(30, 28);
            this.appCount.Name = "appCount";
            this.appCount.Size = new System.Drawing.Size(51, 20);
            this.appCount.TabIndex = 0;
            this.appCount.Text = "label1";
            // 
            // appMemory
            // 
            this.appMemory.AutoSize = true;
            this.appMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appMemory.Location = new System.Drawing.Point(30, 77);
            this.appMemory.Name = "appMemory";
            this.appMemory.Size = new System.Drawing.Size(51, 20);
            this.appMemory.TabIndex = 1;
            this.appMemory.Text = "label1";
            // 
            // processForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appMemory);
            this.Controls.Add(this.appCount);
            this.Name = "processForm";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appCount;
        private System.Windows.Forms.Label appMemory;
    }
}