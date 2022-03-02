using Business;
using Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductAppWinforms
{
    public partial class ProductForm : Form
    {
        private ProductBusiness productBusiness = new ProductBusiness();
        private int editId = 0;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = productBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearTextBoxes()
        {
            txtName.Text = "";
            txtPrice.Text = "0";
            txtStock.Text = "0";
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);
            int stock = 0;
            int.TryParse(txtStock.Text, out stock);

            Product product = new Product();
            product.Name = name;
            product.Price = price;
            product.Stock = stock;

            productBusiness.Add(product);
            UpdateGrid();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextboxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private void ToggleSaveUpdate()
        {
            if (btnUpdate.Visible)
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
        }

        private void UpdateTextboxes(int id)
        {
            Product update = productBusiness.Get(id);
            txtName.Text = update.Name;
            txtPrice.Text = update.Price.ToString();
            txtStock.Text = update.Stock.ToString();
        }

        private void DisableSelect()
        {
            dataGridView1.Enabled = false;
        }

        private void ResetSelect()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product editedProduct = GetEditedProduct();
            productBusiness.Update(editedProduct);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();
        }

        private Product GetEditedProduct()
        {
            Product product = new Product();
            product.Id = editId;
            
            var name = txtName.Text;
            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);
            int stock = 0;
            int.TryParse(txtStock.Text, out stock);
            product.Name = name;
            product.Price = price;
            product.Stock = stock;

            return product;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                productBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }
    }
}
