using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animal_Crossing_New_Horizon.Models
{
    public class villageois
    {
        public int ID { get; set; }
        public String nomhab { get; set; }
        public String personnalite { get; set }
        public String espece { get; set }
        public String sexe { get; set }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}