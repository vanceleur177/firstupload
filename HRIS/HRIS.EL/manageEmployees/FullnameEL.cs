using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class FullnameEL
    {
        int fullnameid;
        String firstname;
        String middlename;
        String lastname;
        String extname;
        String maidenname;

        public int Fullnameid { get => fullnameid; set => fullnameid = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Middlename { get => middlename; set => middlename = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Extname { get => extname; set => extname = value; }
        public string Maidenname { get => maidenname; set => maidenname = value; }
    }
}
