using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class CSEligibilityEL
    {
        int cseligibilityid;
        int employeeid;
        String eligibilitydescription;
        String rating;
        String datein;
        String placeofexam;
        String licensenumber;
        String datelicense;

        public int Cseligibilityid { get => cseligibilityid; set => cseligibilityid = value; }
        public int Employeeid { get => employeeid; set => employeeid = value; }
        public string Eligibilitydescription { get => eligibilitydescription; set => eligibilitydescription = value; }
        public string Rating { get => rating; set => rating = value; }
        public string Datein { get => datein; set => datein = value; }
        public string Placeofexam { get => placeofexam; set => placeofexam = value; }
        public string Licensenumber { get => licensenumber; set => licensenumber = value; }
        public string Datelicense { get => datelicense; set => datelicense = value; }
    }
}
