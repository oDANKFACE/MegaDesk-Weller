namespace MegaDesk_Weller2
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
            this.cmbSearchMaterial = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstMatchingQuotes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbSearchMaterial
            // 
            this.cmbSearchMaterial.FormattingEnabled = true;
            this.cmbSearchMaterial.Location = new System.Drawing.Point(257, 71);
            this.cmbSearchMaterial.Name = "cmbSearchMaterial";
            this.cmbSearchMaterial.Size = new System.Drawing.Size(121, 28);
            this.cmbSearchMaterial.TabIndex = 0;
            this.cmbSearchMaterial.Text = "Search By Material";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(431, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // lstMatchingQuotes
            // 
            this.lstMatchingQuotes.FormattingEnabled = true;
            this.lstMatchingQuotes.ItemHeight = 20;
            this.lstMatchingQuotes.Location = new System.Drawing.Point(89, 178);
            this.lstMatchingQuotes.Name = "lstMatchingQuotes";
            this.lstMatchingQuotes.Size = new System.Drawing.Size(626, 204);
            this.lstMatchingQuotes.TabIndex = 9;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMatchingQuotes);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSearchMaterial);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotesMenu";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSearchMaterial;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstMatchingQuotes;
    }
}