using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Web;
using System.Xml.Schema;

namespace Animal_Crossing_New_Horizon.Models
{
    public class meshabitants
    {
        public int IDhab { get; set; }
        public String nomhab { get; set; }
        public String personnalite { get; set }
        public String espece { get; set }
        public String sexe { get; set }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}