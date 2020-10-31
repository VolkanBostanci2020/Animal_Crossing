using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animal_Crossing_New_Horizon.Models
{
    public class utilisateurs
    {
        public int ID { get; set; }
        public String pseudo { get; set; }
        public String mdp { get; set; }
        public String email { get; set}
        public String nomile { get; set }
        public String fruitile { get; set }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}