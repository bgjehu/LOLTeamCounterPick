using LOLTeamCounterPick.Classes;
namespace LOLTeamCounterPick.Components
{
    partial class ProgressFRM
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
            this.PB = new System.Windows.Forms.ProgressBar();
            this.LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB.Location = new System.Drawing.Point(0, 0);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(284, 34);
            this.PB.Step = 1;
            this.PB.TabIndex = 0;
            // 
            // LBL
            // 
            this.LBL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL.Location = new System.Drawing.Point(0, 34);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(284, 15);
            this.LBL.TabIndex = 1;
            this.LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 49);
            this.Controls.Add(this.LBL);
            this.Controls.Add(this.PB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBarFRM";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.Label LBL;
    }
}