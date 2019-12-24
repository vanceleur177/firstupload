using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class CountryEL
    {
        int countryid;
        String countrycode;
        String countrydescription;
        String countrycitizen;

        public int Countryid { get => countryid; set => countryid = value; }
        public string Countrycode { get => countrycode; set => countrycode = value; }
        public string Countrydescription { get => countrydescription; set => countrydescription = value; }
        public string Countrycitizen { get => countrycitizen; set => countrycitizen = value; }
    }
}
