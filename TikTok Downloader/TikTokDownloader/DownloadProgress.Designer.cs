namespace TikTokDownloader
{
    partial class DownloadProgress
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbNo = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 73);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(532, 36);
            this.progressBar.TabIndex = 0;
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNo.Location = new System.Drawing.Point(19, 12);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(62, 32);
            this.lbNo.TabIndex = 1;
            this.lbNo.Text = "100";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(94, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(451, 26);
            this.txtId.TabIndex = 2;
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lbPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentage.ForeColor = System.Drawing.Color.Black;
            this.lbPercentage.Location = new System.Drawing.Point(255, 45);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(41, 25);
            this.lbPercentage.TabIndex = 3;
            this.lbPercentage.Text = "0%";
            // 
            // DownloadProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 114);
            this.Controls.Add(this.lbPercentage);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.progressBar);
            this.Name = "DownloadProgress";
            this.Text = "Download Progress";
            this.Load += new System.EventHandler(this.DownloadProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.Label lbNo;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Label lbPercentage;
    }
}