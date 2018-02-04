namespace MegaDesk_3_ChrisZitting
{
    partial class DeskQuoteView
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
            this.btn_vdq_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_vdq_close
            // 
            this.btn_vdq_close.Location = new System.Drawing.Point(122, 516);
            this.btn_vdq_close.Name = "btn_vdq_close";
            this.btn_vdq_close.Size = new System.Drawing.Size(171, 23);
            this.btn_vdq_close.TabIndex = 0;
            this.btn_vdq_close.Text = "Close Quote";
            this.btn_vdq_close.UseVisualStyleBackColor = true;
            this.btn_vdq_close.Click += new System.EventHandler(this.btn_vdq_close_Click);
            // 
            // DeskQuoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 551);
            this.Controls.Add(this.btn_vdq_close);
            this.Name = "DeskQuoteView";
            this.Text = "View Desk Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_vdq_close;
    }
}