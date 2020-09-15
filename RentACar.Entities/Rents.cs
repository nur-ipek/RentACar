using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities
{
    public class Rents
    {
        public int RentID { get; set; }

        public int CarID { get; set; }

        public int UserID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

    }
}
