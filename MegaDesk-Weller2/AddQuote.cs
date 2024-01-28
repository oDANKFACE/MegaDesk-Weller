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
using System.IO;

namespace MegaDesk_Weller2
{
    public partial class AddQuote : Form
    {


        public AddQuote()
        {
            InitializeComponent();
            cmbSurfaceMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            cmbSurfaceMaterial.DisplayMember = "ToString";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Close();
        }

        private void txtDeskWidth_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtDeskWidth.Text, out int width))
            {
                if (width < Desk.MinWidth || width > Desk.MaxWidth)
                {
                    txtDeskWidth.ForeColor = Color.Red;
                }
                else
                {
                    txtDeskWidth.ForeColor = SystemColors.WindowText;
                }
            }
            else
            {
                txtDeskWidth.ForeColor = Color.Red;
            }
        }

        private void txtDeskDepth_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtDeskDepth.Text, out int depth))
            {
                if (depth < Desk.MinDepth || depth > Desk.MaxDepth)
                {
                    txtDeskDepth.ForeColor = Color.Red;
                }
                else
                {
                    txtDeskDepth.ForeColor = SystemColors.WindowText;
                }
            }
            else
            {
                txtDeskDepth.ForeColor = Color.Red;
            }
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            int width;
            int depth;

            if (int.TryParse(txtDeskWidth.Text, out width) && int.TryParse(txtDeskDepth.Text, out depth))
            {
                if (!ValidateInput(width, depth))
                {
                    return;
                }

                int numDrawers = Convert.ToInt32(cmbNumDrawers.SelectedItem);
                DesktopMaterial material = (DesktopMaterial)cmbSurfaceMaterial.SelectedItem;
                int rushDays = Convert.ToInt32(cmbRushOrder.SelectedItem);

                Desk desk = new Desk
                {
                    Width = width,
                    Depth = depth,
                    NumDrawers = numDrawers,
                    Material = material
                };

                DeskQuote deskQuote = new DeskQuote(customerName, desk, rushDays);
                decimal quoteTotal = deskQuote.CalculateQuote();
                string quoteData = $"{customerName},{width},{depth},{numDrawers},{(int)material},{rushDays},{quoteTotal}"; // Store material as an integer
                string filePath = Path.Combine(Environment.CurrentDirectory, "quotes.txt");

                try
                {
                    if (!File.Exists(filePath))
                    {
                        File.WriteAllText(filePath, "Customer Name,Width,Depth,Num Drawers,Material,Rush Days,Quote Total" + Environment.NewLine);
                    }

                    File.AppendAllText(filePath, quoteData + Environment.NewLine);
                    labQuoteTotal.Text = $"Quote Total: {quoteTotal:C}";
                    MessageBox.Show("Quote added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for width and depth.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtCustomerName.Clear();
            txtDeskWidth.Clear();
            txtDeskDepth.Clear();
            cmbNumDrawers.SelectedIndex = 0;
            cmbSurfaceMaterial.SelectedIndex = 0;
            cmbRushOrder.SelectedIndex = 0;
        }


        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            int width;
            int depth;

            if (int.TryParse(txtDeskWidth.Text, out width) && int.TryParse(txtDeskDepth.Text, out depth))
            {
                if (!ValidateInput(width, depth))
                {
                    return;
                }

                int numDrawers = Convert.ToInt32(cmbNumDrawers.SelectedItem);
                DesktopMaterial material = (DesktopMaterial)cmbSurfaceMaterial.SelectedItem;
                int rushDays = Convert.ToInt32(cmbRushOrder.SelectedItem);

                Desk desk = new Desk
                {
                    Width = width,
                    Depth = depth,
                    NumDrawers = numDrawers,
                    Material = material
                };

                DeskQuote deskQuote = new DeskQuote(customerName, desk, rushDays);
                decimal quoteTotal = deskQuote.CalculateQuote();

                DisplayQuote displayQuoteForm = new DisplayQuote();

                displayQuoteForm.CustomerName = customerName;
                displayQuoteForm.Desk = desk;
                displayQuoteForm.RushDays = rushDays;
                displayQuoteForm.QuoteTotal = quoteTotal;

                displayQuoteForm.ShowDialog();

                labQuoteTotal.Text = $"Quote Total: {quoteTotal:C}";
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for width and depth.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput(int width, int depth)
        {
            if (width < Desk.MinWidth || width > Desk.MaxWidth)
            {
                MessageBox.Show("Please enter a valid width between " + Desk.MinWidth + " and " + Desk.MaxWidth, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (depth < Desk.MinDepth || depth > Desk.MaxDepth)
            {
                MessageBox.Show("Please enter a valid depth between " + Desk.MinDepth + " and " + Desk.MaxDepth, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
