using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animal_Crossing_New_Horizon.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int utilisateursID { get; set; }
        public int villageoisID { get; set; }
        public int meshabitantsID { get; set; }
        public int wishlistID { get; set; }

        public virtual utilisateurs Utilisateurs { get; set; }
        public virtual villageois villageois { get; set; }
        public virtual wishlist wishlist { get; set; }
    }
}