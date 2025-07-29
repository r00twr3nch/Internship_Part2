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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }
        EFTraveldbEntities  db = new EFTraveldbEntities();

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı
            lblLocationCount.Text = db.Locations.Count().ToString();
            lblCapacity.Text = db.Locations.Sum(x => x.LocationCapacity).ToString();
            lblGuide.Text = db.Guides.Count().ToString();
            lblAvgCapacity.Text = db.Locations.Average(x => x.LocationCapacity).ToString();
            lblAvgPrice.Text = db.Locations.Average(x => x.LocationPrice).ToString();
            lblLastCountry.Text = db.Locations.OrderByDescending(x => x.LocationId).Select(y => y.LocationCountry).FirstOrDefault();
            lblMostExpensive.Text = db.Locations.OrderByDescending(x => x.LocationPrice).Select(y => y.LocationCity).FirstOrDefault();
            lblMostCapacity.Text = db.Locations.OrderByDescending(x => x.LocationCapacity).Select(y => y.LocationCity).FirstOrDefault();
            var guideIdByName = db.Guides.Where(x => x.GuideName == "Micheal" && x.GuideSurname == "Corleone").Select(y => y.GuideId).FirstOrDefault();
            lblMichelCorleoneTours.Text = db.Locations.ToString() == null ? "0" : db.Locations.Count(x => x.GuideId == guideIdByName).ToString();





            #endregion
        }
    }
}
