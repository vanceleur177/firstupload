using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.DL.manageEmployees
{
   public class AddressDL
    {
        public long InsertResidential(EL.manageEmployees.AddressEL address)
        {
            address.Typeofaddress = "Residential";
            return Helper.executeNonQueryLong("insert into address_tbl (employeeid, typeofaddress, houseblklotnumber, street, subdvillage, brgy, citymunicipality, province, zipcode) values ('" + address.Employeeid + "', '" + address.Typeofaddress + "', '" + address.Houseblklotnumber + "', '" + address.Street + "', '" + address.Subdvillage + "', '" + address.Brgy + "', '" + address.Citymunicipality + "', '" + address.Province + "', '" + address.Zipcode + "')");
        }
        public long InsertPermanent(EL.manageEmployees.AddressEL address)
        {
            address.Typeofaddress = "Permanent";
            return Helper.executeNonQueryLong("insert into address_tbl (employeeid, typeofaddress, houseblklotnumber, street, subdvillage, brgy, citymunicipality, province, zipcode) values ('" + address.Employeeid + "', '" + address.Typeofaddress + "', '" + address.Houseblklotnumber2 + "', '" + address.Street2 + "', '" + address.Subdvillage2 + "', '" + address.Brgy2 + "', '" + address.Citymunicipality2 + "', '" + address.Province2 + "', '" + address.Zipcode2 + "')");
        }
    }
}
