using RentACar.DAL;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    public class ImagesController
    {
        public bool AddImage(Images ımages)
        {
            ImagesManagement ımagesManagement = new ImagesManagement();
            return ımagesManagement.AddImages(ımages);
        }
    }
}
