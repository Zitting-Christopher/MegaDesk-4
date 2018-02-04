namespace MegaDesk_3_ChrisZitting
{
    partial class SearchQuotes
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
            this.btn_sq_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sq_back
            // 
            this.btn_sq_back.Location = new System.Drawing.Point(13, 13);
            this.btn_sq_back.Name = "btn_sq_back";
            this.btn_sq_back.Size = new System.Drawing.Size(181, 36);
            this.btn_sq_back.TabIndex = 2;
            this.btn_sq_back.Text = "Back to Main Menu";
            this.btn_sq_back.UseVisualStyleBackColor = true;
            this.btn_sq_back.Click += new System.EventHandler(this.btn_aq_back_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 351);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sq_back);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sq_back;
    }
}