using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class CitizenshipEL
    {
        int citizenshipid;
        int countryid;
        String citizenshiptype;
        String citizenshipaquiredby;
        String citizenshipdualitycountry;

        public int Citizenshipid { get => citizenshipid; set => citizenshipid = value; }
        public int Countryid { get => countryid; set => countryid = value; }
        public string Citizenshiptype { get => citizenshiptype; set => citizenshiptype = value; }
        public string Citizenshipaquiredby { get => citizenshipaquiredby; set => citizenshipaquiredby = value; }
        public string Citizenshipdualitycountry { get => citizenshipdualitycountry; set => citizenshipdualitycountry = value; }
    }
}
