using MaterialSkin.Controls;
using RentACar.BLL;
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
    public partial class Register : MaterialForm
    {
        UsersController _usersController;
        public Register()
        {
            InitializeComponent();
            _usersController = new UsersController();
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            try
            {
                users.FirstName = txtFirstName.Text;
                users.LastName = txtLastName.Text;
                users.MailAdress = txtMailAdress.Text;
                users.Password = txtPassword.Text;
                _usersController.AddUsers(users);
                MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
