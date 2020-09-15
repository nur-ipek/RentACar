using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
   class EmailException : Exception
    {
        public override string Message
        {
            get
            {
                return "Lütfen geçerli bir e-mail adresi giriniz.";
            }
        }
    }

    class PasswordException : Exception
    {
        public override string Message
        {
            get
            {
                return "Şifreniz 8 ile 16 karakter arasında olmalıdır.";
            }
        }
    }

    class LoginException : Exception
    {
        public override string Message
        {
            get
            {
                return "Kullanıcı adı ya da şifre hatalı !";
            }
        }
    }

    class EmptyException : Exception
    {
        public override string Message
        {
            get
            {
                return "Bu alan boş geçilemez !";
            }
        }
    }
}
