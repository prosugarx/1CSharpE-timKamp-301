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
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()//: Form
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            category Category = new category();
            Category.categoryName =txtCategoryNamee.Text;
            Category.categoryStatus = true;
            _categoryService.TInsert(Category);
            MessageBox.Show("Ekleme başarılı");

        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtCategoryId.Text);
            var deletedValues=_categoryService.TGet(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Silme başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId =int.Parse(txtCategoryId.Text);
            var updateValue=_categoryService.TGet(updatedId);
            updateValue.categoryName = txtCategoryNamee.Text;
            updateValue.categoryStatus = true;
            _categoryService.TUpdate(updateValue);
            MessageBox.Show("Güncelleme başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var values = _categoryService.TGet(id);
            dataGridView1.DataSource = values; 
        }
    }
}
