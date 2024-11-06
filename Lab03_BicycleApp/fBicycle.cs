using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_BicycleApp
{
    public partial class fBicycle : Form
    {
        public Bicycle TheBicycle { get; set; }

        public fBicycle(Bicycle bicycle)
        {
            InitializeComponent();
            this.TheBicycle = bicycle;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheBicycle.Brand = tbBrand.Text;
            TheBicycle.Model = tbModel.Text;
            TheBicycle.Year = int.Parse(tbYear.Text);
            TheBicycle.Type = tbType.Text;
            TheBicycle.Weight = double.Parse(tbWeight.Text);
            TheBicycle.FrameMaterial = tbFrameMaterial.Text;
            TheBicycle.GearCount = int.Parse(tbGearCount.Text);
            TheBicycle.Mileage = double.Parse(tbMileage.Text);

            try
            {
                TheBicycle.Distance = double.Parse(tbDistance.Text);
                TheBicycle.Time = double.Parse(tbTime.Text);
                TheBicycle.Speed = TheBicycle.CalculateSpeed(TheBicycle.Distance, TheBicycle.Time);
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення для відстані та часу.");
                return; 
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return; 
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
