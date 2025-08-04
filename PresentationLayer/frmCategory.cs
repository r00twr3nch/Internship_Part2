using System;
using System.Windows.Forms;
using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Abstract; // ICategoryDal için gerekli using

namespace PresentationLayer
{
    public partial class frmCategory : Form
    {
        private readonly ICategoryService _categoryService;
        public frmCategory()
        {
            _categoryService = new CategoryManager(new EFCategoryDal()); // EFCategoryDal'ın ICategoryDal'ı implemente ettiğinden emin olun
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.GetAll();
            dataGridView1.DataSource = categoryValues;

        }
    }
}
