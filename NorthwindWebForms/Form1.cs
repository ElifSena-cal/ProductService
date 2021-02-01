using NorthwindBusiness.Abstract;
using NorthwindBusiness.Concrete;
using NorthwindBusiness.DependencyResolvers.Ninject;
using NorthwindDataAccess.Concrete;
using NorthwindDataAccess.Concrete.EntityFramework;
using NorthwindEntites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindWebForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            
        }
        private IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();


            

        }
        private ICategoryService _categoryService;
        private void LoadCategories()
        {
            kategoritxt.DataSource = _categoryService.GetAll();
            kategoritxt.DisplayMember = "CategoryName";
            kategoritxt.ValueMember = "CategoryId";

            ktgraddcb.DataSource = _categoryService.GetAll();
            ktgraddcb.DisplayMember = "CategoryName";
            ktgraddcb.ValueMember = "CategoryId";


            ktggnc.DataSource = _categoryService.GetAll();
            ktggnc.DisplayMember = "CategoryName";
            ktggnc.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dataGridView1.DataSource = _productService.GetAll();
        }

        private void kategoritxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(kategoritxt.SelectedValue));
            }
            catch
            {

               
            }
     
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
          
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(ktgraddcb.SelectedValue),
                    ProductName = ürüntxt.Text,
                    QuantityPerUnit = birimtxt.Text,
                    UnitPrice = Convert.ToDecimal(fiyattxt.Text),
                    UnitsInStock = Convert.ToInt16(stoktxt.Text)


                });

                MessageBox.Show("Ürün Eklendi");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                ProductName=urunad.Text,
                CategoryId=Convert.ToInt32(ktggnc.SelectedValue),
                QuantityPerUnit = birimgnc.Text,
                UnitPrice = Convert.ToDecimal(fiyatgnc.Text),
                UnitsInStock = Convert.ToInt16(stokgnc.Text)

            }) ;
            MessageBox.Show("Ürün Güncellendi");
            LoadProducts();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            urunad.Text = row.Cells[1].Value.ToString();
            ktggnc.SelectedValue = row.Cells[2].Value;
            fiyatgnc.Text = row.Cells[3].Value.ToString();
            birimgnc.Text = row.Cells[4].Value.ToString();
            stokgnc.Text = row.Cells[5].Value.ToString()
                ;

        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi!");
                    LoadProducts();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
             
            }
            
        }
    }
}
