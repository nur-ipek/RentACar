using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities
{
    public class Users
    {
        public int UserID { get; set; }

        public string MailAdress { get; set; }

        public string Password { get; set; }

        public string TcNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string City { get; set; }

        public string CopyOfIdentityCard { get; set; }

        public bool UserType { get; set; }
    }
}
