using RentACar.DAL;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    public class ModelsController
    {
        ModelsManagement modelsManagement;

        public ModelsController()
        {
            modelsManagement = new ModelsManagement();
        }
        public List<Models> GetModels(Brands brands)
        {
            return modelsManagement.GetModels(brands);
        }
        public bool AddModels(Models model)
        {
            if(string.IsNullOrEmpty(model.ModelName) || string.IsNullOrWhiteSpace(model.ModelName))
            {
                throw new EmptyException();
            }
            else
            {
                return modelsManagement.AddModels(model);
            }
          
        }
    }
}
