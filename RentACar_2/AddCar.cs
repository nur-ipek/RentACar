using MaterialSkin.Controls;
using RentACar.BLL;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RentACar_2
{
    public partial class AddCar : MaterialForm
    {
        BrandsController brandsController;
        ModelsController modelsController;
        public AddCar()
        {
            InitializeComponent();
            brandsController = new BrandsController();
            modelsController = new ModelsController();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            btnAddModel.Enabled = false;
            btnAddModel.BackColor = Color.Red;
        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            try
            {
                Brands brands = new Brands
                {
                    BrandName = txtBrandName.Text
                };
                brandsController.AddBrands(brands);
                txtBrandName.Text = string.Empty;
                MessageBox.Show("Marka eklenmiştir !");
            }
            catch (Exception exception)
            {
               MessageBox.Show(exception.Message);

            }
        }
        private void cmbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrands.SelectedIndex==-1)
            {

            }
            else
            {
                Brands brands = new Brands();
                brands.BrandID = cmbBrands.SelectedIndex + 1;
                cmbModels.DataSource= modelsController.GetModels(brands);
                cmbModels.DisplayMember = "ModelName";
                cmbModels.ValueMember = "ModelID";
            }

            if (cmbBrands.SelectedItem == null)
            {
                btnAddModel.Enabled = false;
            }
            else
            {
                btnAddModel.Enabled = true;
            }
        }

        private void cmbBrands_MouseClick(object sender, MouseEventArgs e)
        {
            cmbBrands.DataSource = brandsController.GetsBrands();
            cmbBrands.DisplayMember = "BrandName";
            cmbBrands.ValueMember = "BrandID";
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            try
            {
                Models model = new Models()
                {
                    ModelName = txtModelName.Text,
                    BrandID = cmbBrands.SelectedIndex + 1
                };
                ModelsController modelsController = new ModelsController();
                modelsController.AddModels(model);
                txtModelName.Text = string.Empty;
                MessageBox.Show("Model Eklenmiştir !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Cars car = new Cars()
            {
                SasiNo = txtSasiNo.Text,
                Km = Convert.ToInt32 (txtKm.Text),
                ModelYear = dateTimePicker.Value,
                ModelID =((int)cmbModels.SelectedValue),
                Price = Convert.ToDecimal(txtPrice.Text)

            };
            CarsController carsController = new CarsController();
            bool result = carsController.AddCar(car);
           
            //dateTimePicker.Value = default;
            txtPrice.Text = string.Empty;
            if(result)
            {
                foreach (string item in ImagePathList)
                {
                    Images ımage = new Images()
                    {
                       ImageUrl = item,
                    }; 
                    ImagesController ımagesController = new ImagesController();
                    ımagesController.AddImage(ımage);
                }
            }
            MessageBox.Show("Araba eklenmiştir !");
            flowLayoutPanel1.Controls.Clear();
            cmbBrands.SelectedIndex = -1;
            cmbModels.SelectedIndex = -1;
            txtSasiNo.Text = string.Empty;
            txtKm.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
            
        }

        List<string> ImagePathList;
         private void btnAddPicture_Click(object sender, EventArgs e)
        {

            ImagePathList = new List<string>();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int count = 0;
                foreach (String file in ofd.FileNames)
                {
                    if (count < 5)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.ImageLocation = file;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        flowLayoutPanel1.Controls.Add(pictureBox);
                        ImagePathList.Add(file);
                    }
                    else
                    {
                        flowLayoutPanel1.Controls.Clear();
                        MessageBox.Show("5 ten fazla eklenmez");
                    }
                    count++;
                }
               
            }
        }
    }
}
