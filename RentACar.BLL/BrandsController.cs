using RentACar.DAL;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    public class BrandsController
    {
        BrandsManagement brandsManagement;

        public BrandsController()
        {
            brandsManagement = new BrandsManagement();
        }
        public bool AddBrands(Brands brands)
        {
            

                if(string.IsNullOrWhiteSpace(brands.BrandName)|| string.IsNullOrEmpty(brands.BrandName))
               {
                    throw new EmptyException();
               }
                else
               {
                    
                    bool isAdded= brandsManagement.AddBrands(brands);
                    return isAdded;
               }       
          
        }
        public List<Brands> GetsBrands()
        {
            return brandsManagement.GetBrands();
        }
    }
}
