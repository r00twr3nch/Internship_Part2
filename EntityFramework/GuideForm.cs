using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class GuideForm : Form
    {
        public GuideForm()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EFTraveldbEntities db = new EFTraveldbEntities();
            var values = db.Guides.ToList();
            dataGridView1.DataSource = values;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EFTraveldbEntities db = new EFTraveldbEntities(); 
            Guide guide = new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.Guides.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Guide added successfully!");

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            EFTraveldbEntities db = new EFTraveldbEntities();
            int id = Convert.ToInt32(txtId.Text);
            var guide = db.Guides.Find(id);
            if (guide != null)
            {
                db.Guides.Remove(guide);
                db.SaveChanges();
                MessageBox.Show("Guide removed successfully!");
            }
            else
            {
                MessageBox.Show("Guide not found!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EFTraveldbEntities db = new EFTraveldbEntities();   
            int id = Convert.ToInt32(txtId.Text);
            var guide = db.Guides.Find(id);
            if (guide != null)
            {
                guide.GuideName = txtName.Text;
                guide.GuideSurname = txtSurname.Text;
                db.SaveChanges();
                MessageBox.Show("Guide updated successfully!");
            }
            else
            {
                MessageBox.Show("Guide not found!");
            }

        }
    }
}
