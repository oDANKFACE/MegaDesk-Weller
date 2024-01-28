using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Weller2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Show();
            this.Hide();
        }

        private void btnViewAllQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Show();
            this.Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
