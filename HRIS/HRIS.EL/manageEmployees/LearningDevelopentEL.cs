using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class LearningDevelopentEL
    {
        int learningdevelopmentid;
        int employeeid;
        String learningdevelopmentdescription;
        String datefrom;
        String dateto;
        int numberofhours;
        String typeoflearningdevelopment;
        String conductedsponsoredby;

        public int Learningdevelopmentid { get => learningdevelopmentid; set => learningdevelopmentid = value; }
        public int Employeeid { get => employeeid; set => employeeid = value; }
        public string Learningdevelopmentdescription { get => learningdevelopmentdescription; set => learningdevelopmentdescription = value; }
        public string Datefrom { get => datefrom; set => datefrom = value; }
        public string Dateto { get => dateto; set => dateto = value; }
        public int Numberofhours { get => numberofhours; set => numberofhours = value; }
        public string Typeoflearningdevelopment { get => typeoflearningdevelopment; set => typeoflearningdevelopment = value; }
        public string Conductedsponsoredby { get => conductedsponsoredby; set => conductedsponsoredby = value; }
    }
}
