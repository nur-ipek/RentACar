using MaterialSkin;
using MaterialSkin.Controls;
using RentACar.Entities;
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
    public partial class MainForm : Form
    {
        Users _user ;

        public MainForm()
        {
            InitializeComponent();
    
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //IsMdiContainer = true;
            menuStrip1.Items[1].Visible = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Owner = this;
            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Owner = this;
            register.Show();
        }
        public void LoginEvent(Users u)
        {
            lblWelcome.Visible = true;
            _user = u;
            lblWelcome.Text = $"hoşgeldin {_user.FirstName} {_user.LastName}";

            if(u.UserType==true)
            {
                menuStrip1.Items[1].Visible = true;
            }
        }

        private void araçEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Owner = this;
            addCar.Show();
        }

        private void profilimiGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProfil viewProfil = new ViewProfil();
            viewProfil.Owner = this;
            viewProfil.Show();
        }

        private void araçlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCars listCars = new ListCars();
            listCars.Owner = this;
            listCars.Show();
         
        }
    }
}
