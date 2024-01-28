using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MegaDesk_Weller2
{
    public partial class ViewAllQuotes : Form
    {


        public ViewAllQuotes()
        {
            InitializeComponent();
            LoadQuotes();
        }

        private void LoadQuotes()
        {
            try
            {
                string filePath = "quotes.txt";
                if (File.Exists(filePath))
                {
                    string[] quotes = File.ReadAllLines(filePath);
                    lstQuotes.Items.AddRange(quotes);
                }
                else
                {
                    MessageBox.Show("No quotes found. Please add quotes first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Close();
        }

        private void lstQuotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}
