using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities
{
    public class Cars
    {
        public int CarID { get; set; }

        public string SasiNo { get; set; }

        public int Km { get; set; }

        public DateTime ModelYear { get; set; }

        public int ModelID { get; set; }

        public decimal Price { get; set; }

    }
}
