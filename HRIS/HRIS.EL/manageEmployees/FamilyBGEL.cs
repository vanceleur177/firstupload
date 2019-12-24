using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class FamilyBGEL
    {
        int familybackgroundid;
        int employeeid;
        String fulnameid;
        String ocupation;
        String employerbusinessname;
        String businessaddress;
        String telephonenumber;

        public int Familybackgroundid { get => familybackgroundid; set => familybackgroundid = value; }
        public int Employeeid { get => employeeid; set => employeeid = value; }
        public string Fulnameid { get => fulnameid; set => fulnameid = value; }
        public string Ocupation { get => ocupation; set => ocupation = value; }
        public string Employerbusinessname { get => employerbusinessname; set => employerbusinessname = value; }
        public string Businessaddress { get => businessaddress; set => businessaddress = value; }
        public string Telephonenumber { get => telephonenumber; set => telephonenumber = value; }
    }
}
