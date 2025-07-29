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
    public partial class LocationForm : Form
    {
        public LocationForm()
        {
            InitializeComponent();
        }
        EFTraveldbEntities db = new EFTraveldbEntities();
        private void LocationForm_Load(object sender, EventArgs e)
        {
            var values = db.Guides.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId,
            }).ToList();
            comboGuide.DisplayMember = "FullName";
            comboGuide.ValueMember = "GuideId";
            comboGuide.DataSource = values;


        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EFTraveldbEntities db = new EFTraveldbEntities();
            var values = db.Locations.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCity.Text == "" || txtCountry.Text == "" || txtCapacity.Text == "" || txtDayNight.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please fill all necessary fields.");
            }
            else
            {
                Location location = new Location();
                location.LocationCity = txtCity.Text;
                location.LocationCountry = txtCountry.Text;
                location.LocationCapacity = Convert.ToInt32(txtCapacity.Text);
                location.LocationPrice = Convert.ToDecimal(txtPrice.Text);
                location.DayNight = txtDayNight.Text;
                location.GuideId = (int)comboGuide.SelectedValue;

                db.Locations.Add(location);
                db.SaveChanges();
                MessageBox.Show("Location added successfully.");
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = int.Parse(txtId.Text);
                var deletedValue = db.Locations.Find(id);
                if (deletedValue != null)
                {
                    db.Locations.Remove(deletedValue);
                    db.SaveChanges();
                    MessageBox.Show("Location removed successfully.");
                }
                else
                {
                    MessageBox.Show("Location not found.");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.Locations.Find(id);
            if (updatedValue != null)
            {
                updatedValue.LocationCity = txtCity.Text;
                updatedValue.LocationCountry = txtCountry.Text;
                updatedValue.LocationCapacity = Convert.ToInt32(txtCapacity.Text);
                updatedValue.LocationPrice = Convert.ToDecimal(txtPrice.Text);
                updatedValue.DayNight = txtDayNight.Text;
                updatedValue.GuideId = (int)comboGuide.SelectedValue;
                db.SaveChanges();
                MessageBox.Show("Location updated successfully.");
            }
            else
            {
                MessageBox.Show("Location not found.");
            }
        }
    }   
}