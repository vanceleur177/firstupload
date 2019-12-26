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

        String houseblklotnumber2;
        String street2;
        String subdvillage2;
        String brgy2;
        String citymunicipality2;
        String province2;
        int zipcode2;

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


        public string Houseblklotnumber2 { get => houseblklotnumber2; set => houseblklotnumber2 = value; }
        public string Street2 { get => street2; set => street2 = value; }
        public string Subdvillage2 { get => subdvillage2; set => subdvillage2 = value; }
        public string Brgy2 { get => brgy2; set => brgy2 = value; }
        public string Citymunicipality2 { get => citymunicipality2; set => citymunicipality2 = value; }
        public string Province2 { get => province2; set => province2 = value; }
        public int Zipcode2 { get => zipcode2; set => zipcode2 = value; }
    }
}
