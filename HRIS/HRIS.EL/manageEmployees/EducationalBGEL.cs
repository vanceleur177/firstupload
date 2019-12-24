using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class EducationalBGEL
    {
        int educationalbackgroundid;
        int employeeid;
        String educationallevel;
        String nameofschool;
        String basiceduation;
        String datefrom;
        String dateto;
        int unitsearned;
        String dategraduated;
        String honorsrecieved;

        public int Educationalbackgroundid { get => educationalbackgroundid; set => educationalbackgroundid = value; }
        public int Employeeid { get => employeeid; set => employeeid = value; }
        public string Educationallevel { get => educationallevel; set => educationallevel = value; }
        public string Nameofschool { get => nameofschool; set => nameofschool = value; }
        public string Basiceduation { get => basiceduation; set => basiceduation = value; }
        public string Datefrom { get => datefrom; set => datefrom = value; }
        public string Dateto { get => dateto; set => dateto = value; }
        public int Unitsearned { get => unitsearned; set => unitsearned = value; }
        public string Dategraduated { get => dategraduated; set => dategraduated = value; }
        public string Honorsrecieved { get => honorsrecieved; set => honorsrecieved = value; }
    }
}
