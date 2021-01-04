
namespace WindowsFormsApp2
{
    partial class MemoryForm
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
            this.memoryStat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memoryStat
            // 
            this.memoryStat.AutoSize = true;
            this.memoryStat.Location = new System.Drawing.Point(13, 13);
            this.memoryStat.Margin = new System.Windows.Forms.Padding(4);
            this.memoryStat.Name = "memoryStat";
            this.memoryStat.Size = new System.Drawing.Size(51, 20);
            this.memoryStat.TabIndex = 0;
            this.memoryStat.Text = "label1";
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(397, 99);
            this.Controls.Add(this.memoryStat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemoryForm";
            this.Text = "Memory Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memoryStat;
    }
}