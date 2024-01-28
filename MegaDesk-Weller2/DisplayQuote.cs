using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaDesk_Weller2.Desk;

namespace MegaDesk_Weller2
{
    public partial class DisplayQuote : Form
    {

        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial DeskMaterial { get; set; }
        public int RushDays { get; set; }
        public decimal QuoteTotal { get; set; }

        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            labCustomerName.Text = CustomerName;
            labDeskWidth.Text = Desk.Width.ToString();
            labDeskDepth.Text = Desk.Depth.ToString();
            labNumDrawers.Text = Desk.NumDrawers.ToString();
            labSurfaceMaterial.Text = Desk.Material.ToString();
            labRushOrder.Text = RushDays.ToString();
            labQuoteTotal.Text = $"Quote Total: {QuoteTotal:C}";

        }
    }
}
