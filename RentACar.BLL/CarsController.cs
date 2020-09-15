using RentACar.DAL;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    public class CarsController
    {
        CarsManagement carsManagement;
        public CarsController()
        {
            carsManagement = new CarsManagement();
        }
        public bool AddCar(Cars car)
        {
           return carsManagement.AddCar(car);
            
        }

        public DataTable GetCar()
        {
            DataTable dataTable = carsManagement.GetCar();
            return dataTable;
        }
    }
}
