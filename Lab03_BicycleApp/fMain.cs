using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_BicycleApp
{
    public partial class fMain : Form
    {
        private List<Bicycle> bicycles = new List<Bicycle>();

        private void UpdateBicyclesInfo()
        {
            tbBicyclesInfo.Clear();

            for (int i = 0; i < bicycles.Count; i++)
            {
                var bicycle = bicycles[i];
                string bicycleInfo = $"Велосипед #{i + 1}: " +
                             $"Марка: {bicycle.Brand}, Модель: {bicycle.Model}, Рік: {bicycle.Year}, " +
                             $"Тип: {bicycle.Type}, Вага: {bicycle.Weight} кг, " +
                             $"Матеріал рами: {bicycle.FrameMaterial}, Кількість передач: {bicycle.GearCount}, " +
                             $"Пробіг: {bicycle.Mileage} км, " +
                             $"Відстань: {bicycle.Distance} км, Час: {bicycle.Time} год, " +
                             $"Швидкість: {bicycle.Speed} км/год";

                tbBicyclesInfo.AppendText(bicycleInfo + Environment.NewLine);
            }
        }


        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBicycle_Click(object sender, EventArgs e)
        {
            Bicycle newBicycle = new Bicycle();
            fBicycle addBicycleForm = new fBicycle(newBicycle);

            if (addBicycleForm.ShowDialog() == DialogResult.OK)
            {
                bicycles.Add(newBicycle);

                UpdateBicyclesInfo();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void AddBicycleInfoToTextBox(Bicycle bicycle)
        {
            string bicycleInfo = $"Марка: {bicycle.Brand}, Модель: {bicycle.Model}, Рік: {bicycle.Year}, " +
                                 $"Тип: {bicycle.Type}, Вага: {bicycle.Weight} кг, Матеріал рами: {bicycle.FrameMaterial}, " +
                                 $"Кількість передач: {bicycle.GearCount}, Пробіг: {bicycle.Mileage} км";

            tbBicyclesInfo.AppendText(bicycleInfo + Environment.NewLine);
        }


    }
}
