using System;
using System.Linq;
using System.Windows.Forms;

namespace Testing_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (var context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }

        private void LoadProducts(int categoryId)
        {
            using (var context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.CategoryID == categoryId).ToList();
            }
        }

        private void LoadProducts(string word)
        {
            using (var context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.StartsWith(word) || p.ProductName.Contains(word)).ToList();
            }
        }

        private void LoadCategories()
        {
            using (var context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryID";
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProducts(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception exception)
            {
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(tbxSearch.Text);
        }
    }
}