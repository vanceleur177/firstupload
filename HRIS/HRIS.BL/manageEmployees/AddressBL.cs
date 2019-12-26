using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.BL.manageEmployees
{
   public class AddressBL
    {
        HRIS.DL.manageEmployees.AddressDL addressDL = new DL.manageEmployees.AddressDL();
        public long InsertResidential(EL.manageEmployees.AddressEL addres)
        {
            return addressDL.InsertResidential(addres);
        }

       
        public long InsertPermanent(EL.manageEmployees.AddressEL addres)
        {
            return addressDL.InsertPermanent(addres);
        }
    }
}
