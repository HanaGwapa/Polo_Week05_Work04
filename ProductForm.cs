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
            Random random = new Random();

            txtBoxBarcode.Text = random.Next(100000000, 999999999).ToString();

            //lblBarCodeAvailable.Text = "Barcode is available.";
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
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            if (!decimal.TryParse(txtBoxCost.Text, out decimal cost) ||
                !decimal.TryParse(txtBoxPrice.Text, out decimal price) ||
                cost <= 0 || price <= 0)
            {
                MessageBox.Show("Please enter valid Cost and Price values.");
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
