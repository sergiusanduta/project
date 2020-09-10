using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingWebForm
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string make = txtMake.Text;
            string model = txtModel.Text;
            int year = Convert.ToInt32(txtYear.Text);
            int price = Convert.ToInt32(txtPrice.Text);

            Car car = new Car(make, model, year, price);

            DataBase data = new DataBase();
            data.SaveCar(car);

            MessageBox.Show("Success!");


        }
    }
}
