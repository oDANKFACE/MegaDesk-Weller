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
using static MegaDesk_Weller2.Desk;

namespace MegaDesk_Weller2
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            cmbSearchMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            //cmbSearchMaterial.DisplayMember = "ToString";
        }

        private void LoadQuotes()
        {
            try
            {
                string filePath = "quotes.txt";
                if (File.Exists(filePath))
                {
                    string[] quotes = File.ReadAllLines(filePath);
                    lstMatchingQuotes.Items.AddRange(quotes);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DesktopMaterial selectedMaterial = (DesktopMaterial)cmbSearchMaterial.SelectedItem;
            string filePath = "quotes.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    string[] allLines = File.ReadAllLines(filePath);
                    List<string> matchingQuotes = new List<string>();

                    foreach (string line in allLines)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length >= 6 && parts[4] == ((int)selectedMaterial).ToString())
                        {
                            matchingQuotes.Add(line);
                        }
                    }

                    lstMatchingQuotes.Items.Clear();
                    lstMatchingQuotes.Items.AddRange(matchingQuotes.ToArray());
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

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}
