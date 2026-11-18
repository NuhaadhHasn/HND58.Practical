using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;

namespace ProductSales.Forms
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:5236/api/Product";
            HttpClient client = new HttpClient();
            MyProducts myProducts = new MyProducts();
            myProducts.Code = txtBoxCode.Text;
            myProducts.Name = txtBoxName.Text;
            myProducts.Price = Convert.ToDecimal(txtBoxPrice.Text);
            myProducts.Description = txtBoxDescription.Text;

            string info = (new JavaScriptSerializer()).Serialize(myProducts);

            var content = new StringContent(info, UnicodeEncoding.UTF8, "application/json");
            var response = client.PostAsync(url, content).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product Added");
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Fail to add product");
            }
        }

        private void LoadProducts()
        {
            string url = "http://localhost:5236/api/Product";
            HttpClient httpClient = new HttpClient();
            var resTask = httpClient.GetAsync(url);
            resTask.Wait();
            var results = resTask.Result;

            if (results.IsSuccessStatusCode)
            {
                var readTask = results.Content.ReadAsStringAsync();
                readTask.Wait();
                var products = readTask.Result;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = (new JavaScriptSerializer()).Deserialize<List<MyProducts>>(products);
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                txtBoxCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtBoxPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtBoxDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            } else if (e.ColumnIndex == 1)
            {
                string code = txtBoxCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                
                string url = "http://localhost:5236/api/Product?code="+code;
                HttpClient client = new HttpClient();
                DialogResult result = MessageBox.Show("are you sure, you want to delete?", "Confirm Delete!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var res = client.DeleteAsync(url).Result;
                    if (res.IsSuccessStatusCode)
                    {
                        LoadProducts();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:5236/api/Product/";
            HttpClient client = new HttpClient();
            MyProducts myProducts = new MyProducts();
            myProducts.Code = txtBoxCode.Text;
            myProducts.Name = txtBoxName.Text;
            myProducts.Price = Convert.ToDecimal(txtBoxPrice.Text);
            myProducts.Description = txtBoxDescription.Text;
            string info = (new JavaScriptSerializer()).Serialize(myProducts);
            var content = new StringContent(info, UnicodeEncoding.UTF8, "application/json");
            var response = client.PutAsync(url, content).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product Updated");
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Failed to update product");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string code = txtBoxCode.Text;
            string url = "http://localhost:5236/api/Product/"+code;
            HttpClient client = new HttpClient();
            var resTask = client.GetAsync(url);
            resTask.Wait();
            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsStringAsync();
                readTask.Wait();
                var product = readTask.Result;
                MyProducts myProducts = (new JavaScriptSerializer()).Deserialize<MyProducts>(product);
                txtBoxCode.Text = myProducts.Code;
                txtBoxName.Text = myProducts.Name;
                txtBoxDescription.Text = myProducts.Description;
                txtBoxPrice.Text = myProducts.Price.ToString();
            }
        }
    }

    public class MyProducts
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
    }
}