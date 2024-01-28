namespace MegaDesk_Weller2
{
    partial class ViewAllQuotes
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lstQuotes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 37);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstQuotes
            // 
            this.lstQuotes.FormattingEnabled = true;
            this.lstQuotes.ItemHeight = 20;
            this.lstQuotes.Location = new System.Drawing.Point(36, 162);
            this.lstQuotes.Name = "lstQuotes";
            this.lstQuotes.Size = new System.Drawing.Size(707, 244);
            this.lstQuotes.TabIndex = 9;
            this.lstQuotes.SelectedIndexChanged += new System.EventHandler(this.lstQuotes_SelectedIndexChanged);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstQuotes);
            this.Controls.Add(this.btnBack);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotesMenu";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstQuotes;
    }
}