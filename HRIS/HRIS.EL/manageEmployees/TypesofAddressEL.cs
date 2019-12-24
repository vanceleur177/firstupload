using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class TypesofAddressEL
    {
        int typesofaddressid;
        int employeeid;
        String description;

        public int Typesofaddressid { get => typesofaddressid; set => typesofaddressid = value; }
        public int Employeeid { get => employeeid; set => employeeid = value; }
        public string Description { get => description; set => description = value; }
    }
}
