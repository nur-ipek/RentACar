using MaterialSkin.Controls;
using RentACar.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar_2
{
    public partial class ListCars : MaterialForm
    {
        public ListCars()
        {
            InitializeComponent();
        }

        private void ListCars_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn brand = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn model = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
            DataGridViewImageColumn image = new DataGridViewImageColumn();

            dataGridView1.Columns.Add(brand);
            dataGridView1.Columns.Add(model);
            dataGridView1.Columns.Add(price);
            dataGridView1.Columns.Add(image);

            brand.HeaderText = "Marka";
            model.HeaderText = "Model";
            price.HeaderText = "Günlük Fiyat";
            image.HeaderText = "Resim";

            CarsController carsController = new CarsController();
            DataTable dt= carsController.GetCar();
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
