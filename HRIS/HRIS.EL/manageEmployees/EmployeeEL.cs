using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class EmployeeEL
    {
        int employeeid;
        int fullnameid;
        int insuranceid;
        int citizinshipid;
        String dateofbirth;
        String placeofbirth;
        String sex;
        String civilstatus;
        String heigthm;
        String weightkg;
        String bloodtype;
        String telnumber;
        String mobnumber;
        String emailaddress;
        String imageface;
           String imagesignature;

        public int Employeeid { get => employeeid; set => employeeid = value; }
        public int Fullnameid { get => fullnameid; set => fullnameid = value; }
        public int Insuranceid { get => insuranceid; set => insuranceid = value; }
        public int Citizinshipid { get => citizinshipid; set => citizinshipid = value; }
        public string Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        public string Placeofbirth { get => placeofbirth; set => placeofbirth = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Civilstatus { get => civilstatus; set => civilstatus = value; }
        public string Heigthm { get => heigthm; set => heigthm = value; }
        public string Weightkg { get => weightkg; set => weightkg = value; }
        public string Bloodtype { get => bloodtype; set => bloodtype = value; }
        public string Telnumber { get => telnumber; set => telnumber = value; }
        public string Mobnumber { get => mobnumber; set => mobnumber = value; }
        public string Emailaddress { get => emailaddress; set => emailaddress = value; }
        public string Imageface { get => imageface; set => imageface = value; }
        public string Imagesignature { get => imagesignature; set => imagesignature = value; }
    }
}
