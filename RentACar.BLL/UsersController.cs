using RentACar.DAL;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    public class UsersController
    {
        
        UsersManagement _usersManagement;
        
        public UsersController()
        {
            _usersManagement = new UsersManagement();
        }
        public bool AddUsers(Users user)
        {

            ValidateEmail(user.MailAdress);
            ValidatePassword(user.Password);
          

            bool isAdded = _usersManagement.AddUsers(user);
            return isAdded;
        }

        

       public bool ValidateEmail (string email)
        {
            if (email.Contains("@"))
            {
                if (email.Contains(".com"))
                {
                    return true;
                }
                else
                {
                    throw new EmailException();
                }
            }
            else
            {
                throw new EmailException();
            }
        }

        public bool ValidatePassword (string password)
        {
            if(password.Length >= 8 && password.Length <= 16)
            {
                return true;
            }
            else
            {
                throw new PasswordException();
            }
        }

        int sayac = 0;
        public Users CheckLogin(string mail, string password)
        {
            Users user = null;
            foreach (Users item in _usersManagement.GetUsers())
            {
               
                if (mail == item.MailAdress && password == item.Password)
                {
                    sayac++;
                    user = item;
                    break;
                }
            }

            if (sayac == 0)
            {
                throw new LoginException();
            }

            return user;
        }

       
    }
}
