using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DTO
{
    public class CarDTO
    {
        public Brands Brands { get; set; }

        public Models Models { get; set; }

        public Cars Cars { get; set; }

        public Images Images { get; set; }
    }
}
