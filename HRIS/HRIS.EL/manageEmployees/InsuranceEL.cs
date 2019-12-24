using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class EnsuranceEL
    {
        int insuranceid;
        String insurancedescription;
           String insurancecontrolnumber;

        public int Insuranceid { get => insuranceid; set => insuranceid = value; }
        public string Insurancedescription { get => insurancedescription; set => insurancedescription = value; }
        public string Insurancecontrolnumber { get => insurancecontrolnumber; set => insurancecontrolnumber = value; }
    }
}
