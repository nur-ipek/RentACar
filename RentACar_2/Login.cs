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
    public partial class Login : MaterialForm
    {
        UsersController _userController ;
        public Login()
        {
            InitializeComponent();
            _userController = new UsersController();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    Users user = new Users()
            //    {
            //        MailAdress = txtMailAdress.Text,
            //        Password = txtPassword.Text,
            //        UserType = false
            //    };
            //    UsersController usersController = new UsersController();
            //    usersController.CheckLogin(user.MailAdress, user.Password, user.UserType);


            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message);
            //}
            try
            {
                Users loginUser = _userController.CheckLogin(txtMailAdress.Text, txtPassword.Text);
                if (loginUser!=null)
                {
                    ((MainForm)Owner).LoginEvent(loginUser);
                    //MessageBox.Show(loginUser.UserID.ToString());
                    
                    this.Close();
                }
               


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           

        }
    }
}
