namespace MegaDesk_Weller2
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtDeskDepth = new System.Windows.Forms.TextBox();
            this.txtDeskWidth = new System.Windows.Forms.TextBox();
            this.cmbSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.cmbRushOrder = new System.Windows.Forms.ComboBox();
            this.cmbNumDrawers = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.labQuoteTotal = new System.Windows.Forms.Label();
            this.btnCalcTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(172, 136);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(122, 26);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtDeskDepth
            // 
            this.txtDeskDepth.Location = new System.Drawing.Point(172, 220);
            this.txtDeskDepth.Name = "txtDeskDepth";
            this.txtDeskDepth.Size = new System.Drawing.Size(122, 26);
            this.txtDeskDepth.TabIndex = 2;
            this.txtDeskDepth.Text = "Desk Depth";
            this.txtDeskDepth.TextChanged += new System.EventHandler(this.txtDeskDepth_TextChanged);
            // 
            // txtDeskWidth
            // 
            this.txtDeskWidth.Location = new System.Drawing.Point(172, 178);
            this.txtDeskWidth.Name = "txtDeskWidth";
            this.txtDeskWidth.Size = new System.Drawing.Size(122, 26);
            this.txtDeskWidth.TabIndex = 3;
            this.txtDeskWidth.Text = "Desk Width";
            this.txtDeskWidth.TextChanged += new System.EventHandler(this.txtDeskWidth_TextChanged);
            // 
            // cmbSurfaceMaterial
            // 
            this.cmbSurfaceMaterial.FormattingEnabled = true;
            this.cmbSurfaceMaterial.Location = new System.Drawing.Point(425, 134);
            this.cmbSurfaceMaterial.Name = "cmbSurfaceMaterial";
            this.cmbSurfaceMaterial.Size = new System.Drawing.Size(179, 28);
            this.cmbSurfaceMaterial.TabIndex = 4;
            this.cmbSurfaceMaterial.Text = "Surface Material";
            // 
            // cmbRushOrder
            // 
            this.cmbRushOrder.FormattingEnabled = true;
            this.cmbRushOrder.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.cmbRushOrder.Location = new System.Drawing.Point(425, 178);
            this.cmbRushOrder.Name = "cmbRushOrder";
            this.cmbRushOrder.Size = new System.Drawing.Size(179, 28);
            this.cmbRushOrder.TabIndex = 5;
            this.cmbRushOrder.Text = "Rush Order?";
            // 
            // cmbNumDrawers
            // 
            this.cmbNumDrawers.FormattingEnabled = true;
            this.cmbNumDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbNumDrawers.Location = new System.Drawing.Point(425, 222);
            this.cmbNumDrawers.Name = "cmbNumDrawers";
            this.cmbNumDrawers.Size = new System.Drawing.Size(179, 28);
            this.cmbNumDrawers.TabIndex = 6;
            this.cmbNumDrawers.Text = "Number of Drawers";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 37);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.Location = new System.Drawing.Point(304, 352);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(109, 34);
            this.btnAddQuote.TabIndex = 8;
            this.btnAddQuote.Text = "Add Quote";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.btnAddQuote_Click);
            // 
            // labQuoteTotal
            // 
            this.labQuoteTotal.AutoSize = true;
            this.labQuoteTotal.Location = new System.Drawing.Point(585, 366);
            this.labQuoteTotal.Name = "labQuoteTotal";
            this.labQuoteTotal.Size = new System.Drawing.Size(0, 20);
            this.labQuoteTotal.TabIndex = 9;
            // 
            // btnCalcTotal
            // 
            this.btnCalcTotal.Location = new System.Drawing.Point(290, 312);
            this.btnCalcTotal.Name = "btnCalcTotal";
            this.btnCalcTotal.Size = new System.Drawing.Size(139, 34);
            this.btnCalcTotal.TabIndex = 10;
            this.btnCalcTotal.Text = "Calculate Total";
            this.btnCalcTotal.UseVisualStyleBackColor = true;
            this.btnCalcTotal.Click += new System.EventHandler(this.btnCalcTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Desk Width (24-96)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Desk Depth (12-48)";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcTotal);
            this.Controls.Add(this.labQuoteTotal);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbNumDrawers);
            this.Controls.Add(this.cmbRushOrder);
            this.Controls.Add(this.cmbSurfaceMaterial);
            this.Controls.Add(this.txtDeskWidth);
            this.Controls.Add(this.txtDeskDepth);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "AddQuote";
            this.Text = "AddQuoteMenu";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDeskDepth;
        private System.Windows.Forms.TextBox txtDeskWidth;
        private System.Windows.Forms.ComboBox cmbSurfaceMaterial;
        private System.Windows.Forms.ComboBox cmbRushOrder;
        private System.Windows.Forms.ComboBox cmbNumDrawers;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Label labQuoteTotal;
        private System.Windows.Forms.Button btnCalcTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}