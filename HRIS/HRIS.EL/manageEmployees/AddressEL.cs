using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class AddressEL
    {
        int addressid;
           int countryid;
           int typeofaddressid;
           String houseblklotnumber;
           String street;
           String subdvillage;
           String brgy;
           String citymunicipality;
           String province;
           int zipcode;

        public int Addressid { get => addressid; set => addressid = value; }
        public int Countryid { get => countryid; set => countryid = value; }
        public int Typeofaddressid { get => typeofaddressid; set => typeofaddressid = value; }
        public string Houseblklotnumber { get => houseblklotnumber; set => houseblklotnumber = value; }
        public string Street { get => street; set => street = value; }
        public string Subdvillage { get => subdvillage; set => subdvillage = value; }
        public string Brgy { get => brgy; set => brgy = value; }
        public string Citymunicipality { get => citymunicipality; set => citymunicipality = value; }
        public string Province { get => province; set => province = value; }
        public int Zipcode { get => zipcode; set => zipcode = value; }
    }
}
