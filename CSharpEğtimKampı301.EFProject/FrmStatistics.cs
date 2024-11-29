using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEğtimKampı301.EFProject
{
    public partial class FrmStatistics : Form
    {
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
           
            lblLocationCount.Text = db.Location.Count().ToString();

            lblSumCapacity.Text=db.Location.Sum(x=> x.Capacity).ToString();

            lblGuideCount.Text=db.Guide.Count().ToString();

            lblAvarageCapacity.Text = db.Location.Average(x => x.Capacity)?.ToString("0.00");

            lblAvargeLocationPrice.Text= db.Location.Average(x=> x.Price)?.ToString("0.00");

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId==lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text= db.Location.Where(x => x.City=="kapodokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvarage.Text=db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();

            var romeGuideId=db.Location.Where(X=>X.City=="roma").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text=db.Guide.Where(x=>x.GuideId==romeGuideId).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity=db.Location.Max(x=>x.Capacity);
            lblMaxCapacityLocation.Text=db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault(). ToString();

            var minCapacity = db.Location.Min(x => x.Capacity);
            lblMinCapacityLocation.Text = db.Location.Where(x => x.Capacity == minCapacity).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByNameKenanYıldız=db.Guide.Where(x=>x.GuideName=="kenan" && x.GuideSurname=="yıldız").Select(y=>y.GuideId).FirstOrDefault();
            lblKenanYıldızLocationCount.Text=db.Location.Where(x=>x.GuideId==guideIdByNameKenanYıldız).Count().ToString();

        }
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
