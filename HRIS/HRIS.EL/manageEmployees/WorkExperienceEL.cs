using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class WorkExperienceEL
    {
        int workexperienceid;
        int employeeid;
        String datefrom;
        String dateto;
        String workposition;
        String workorganization;
        float monthlysalary;
        String gradesalary;
        String statusofappointment;
        String govntserviceyn;

        public int Workexperienceid { get => workexperienceid; set => workexperienceid = value; }
        public int Employeeid { get => employeeid; set => employeeid = value; }
        public string Datefrom { get => datefrom; set => datefrom = value; }
        public string Dateto { get => dateto; set => dateto = value; }
        public string Workposition { get => workposition; set => workposition = value; }
        public string Workorganization { get => workorganization; set => workorganization = value; }
        public float Monthlysalary { get => monthlysalary; set => monthlysalary = value; }
        public string Gradesalary { get => gradesalary; set => gradesalary = value; }
        public string Statusofappointment { get => statusofappointment; set => statusofappointment = value; }
        public string Govntserviceyn { get => govntserviceyn; set => govntserviceyn = value; }
    }
}
