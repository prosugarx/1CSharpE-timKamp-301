using CSharpEgtimKampı301.BussinesLayer.Abstract;
using CSharpEgtimKampı301.BussinesLayer.Concrate;
using CSharpEğtimKampı301.DataAccessLayer.EntityFramework;
using CSharpEğtimKampı301.EntityLayer.concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgtimKampi301.Presentation
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        //ProductManager productManager = new ProductManager(new EfProductDal());
        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.ProductStock = int.Parse(txtProductStock.Text);
           // productManager.TInsert(Product);
            MessageBox.Show("Ekleme başarılı");
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }
    }
}
