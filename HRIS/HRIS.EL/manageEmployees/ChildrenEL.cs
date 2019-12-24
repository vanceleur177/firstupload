using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class ChildrenEL
    {
       int childrenid;
           int familybackgroundid;
           String childrenfullname;
           String birthdate;

        public int Childrenid { get => childrenid; set => childrenid = value; }
        public int Familybackgroundid { get => familybackgroundid; set => familybackgroundid = value; }
        public string Childrenfullname { get => childrenfullname; set => childrenfullname = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
    }
}
