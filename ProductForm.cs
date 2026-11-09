using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Polo_Week05_Work04
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

            Random random = new Random();

            //txtBoxBarcode.Text = random.Next(100000000, 999999999).ToString();

            lblBarCodeAvailable.Text = "Barcode is available.";

            cmbCategory.Items.Add("Food");
            cmbCategory.Items.Add("Beverages");
            cmbCategory.Items.Add("Personal Care");
            cmbCategory.Items.Add("Household");
            cmbCategory.Items.Add("Electronics");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxBarcode.Clear();
           // lblBarCodeAvailable.Text = "";

            txtBoxName.Clear();
            txtBoxDesc.Clear();
            cmbCategory.SelectedIndex = -1;

            rdbLocal.Checked = false;
            rdbAbroad.Checked = false;

            ckbActive.Checked = false;

            txtBoxCost.Clear();
            txtBoxPrice.Clear();
            txtBoxMarkup.Clear();
        }
        private void txtBoxBarcode_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtBoxBarcode.Text))
            {
                lblBarCodeAvailable.Text = "Barcode is available.";
            }
            else
            {
                lblBarCodeAvailable.Text = "";
            }
        }

        private void txtBoxMarkup_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBoxCost_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBoxCost.Text, out decimal cost) &&
                decimal.TryParse(txtBoxPrice.Text, out decimal price) &&
                cost > 0)
            {
                txtBoxMarkup.Text =
                    (((price - cost) / cost) * 100).ToString("0.00");
            }
            else
            {
                txtBoxMarkup.Clear();
            }
        }

        private void txtBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBoxCost.Text, out decimal cost) &&
               decimal.TryParse(txtBoxPrice.Text, out decimal price) &&
               cost > 0)
            {
                txtBoxMarkup.Text =
                    (((price - cost) / cost) * 100).ToString("0.00");
            }
            else
            {
                txtBoxMarkup.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to cancel?",
            "Confirm Cancel",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBoxBarcode.Text.Length != 13)
            {
                MessageBox.Show("Barcode must contain exactly 13 digits.",
                    "Invalid Barcode",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxBarcode.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBoxBarcode.Text))
            {
                MessageBox.Show("Please enter the barcode.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxBarcode.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBoxDesc.Text))
            {
                MessageBox.Show("Please enter the product description.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxDesc.Focus();
                return;
            }
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCategory.Focus();
                return;
            }
            if (!rdbLocal.Checked && !rdbAbroad.Checked)
            {
                MessageBox.Show("Please select the product origin.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            if (!decimal.TryParse(txtBoxCost.Text, out decimal cost) || cost <= 0)
            {
                MessageBox.Show("Please enter a valid cost greater than zero.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxCost.Focus();
                return;
            }
            if (!decimal.TryParse(txtBoxPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than zero.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxPrice.Focus();
                return;
            }
            if (price < cost)
            {
                MessageBox.Show("The selling price cannot be lower than the cost.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxPrice.Focus();
                return;
            }
            if (txtBoxBarcode.Text == "" ||
                txtBoxName.Text == "" ||
                txtBoxDesc.Text == "" ||
                cmbCategory.SelectedIndex == -1 ||
                (!rdbLocal.Checked && !rdbAbroad.Checked) ||
                txtBoxCost.Text == "" ||
                txtBoxPrice.Text == "")
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

            Product product = new Product();

            product.Barcode = txtBoxBarcode.Text;
            product.Name = txtBoxName.Text;
            product.Description = txtBoxDesc.Text;
            product.Category = cmbCategory.Text;
            product.Origin = rdbLocal.Checked ? "Local" : "Abroad";
            product.Status = ckbActive.Checked ? "Active" : "Inactive";
            product.Cost = cost;
            product.Price = price;
            product.Markup = ((price - cost) / cost) * 100;
         

            MessageBox.Show("Product saved successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void lblMarkup_Click(object sender, EventArgs e)
        {
          
        }
    }
}
