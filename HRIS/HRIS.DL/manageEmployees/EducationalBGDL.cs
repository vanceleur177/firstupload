using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.DL.manageEmployees
{
   public class EducationalBGDL
    {
        public long Insertelem(EL.manageEmployees.EducationalBGEL educational)
        {
            educational.Educationallevel = "Elementary";
            return Helper.executeNonQueryLong("insert into educationalbackground_tbl (employeeid, educationallevel, nameofschool, basiceduation, datefrom, dateto, unitsearned, dategraduated, honorsrecieved) values ('" + educational.Employeeid + "', '" + educational.Educationallevel + "', '" + educational.Elementaryschoolname + "', '" + educational.Elementarydegcourse + "',  '" + educational.ElementaryFrom + "',  '" + educational.ElementaryTo + "',  '" + educational.Elementaryunitearned + "',  '" + educational.ElementaryYeargraduated + "',  '" + educational.ElementaryHonorrecieved + "')");
        }
        public long Insertsec(EL.manageEmployees.EducationalBGEL educational)
        {
            educational.Educationallevel = "Secondary";
            return Helper.executeNonQueryLong("insert into educationalbackground_tbl (employeeid, educationallevel, nameofschool, basiceduation, datefrom, dateto, unitsearned, dategraduated, honorsrecieved) values ('" + educational.Employeeid + "', '" + educational.Educationallevel + "', '" + educational.Secondaryschoolname + "', '" + educational.Secondarydegcourse + "',  '" + educational.SecondaryFrom + "',  '" + educational.SecondaryTo + "',  '" + educational.Secondaryunitearned + "',  '" + educational.SecondaryYeargraduated + "',  '" + educational.SecondaryHonorrecieved + "')");
        }
        public long Insertvoc(EL.manageEmployees.EducationalBGEL educational)
        {
            educational.Educationallevel = "Vocational/Trade Course";
            return Helper.executeNonQueryLong("insert into educationalbackground_tbl (employeeid, educationallevel, nameofschool, basiceduation, datefrom, dateto, unitsearned, dategraduated, honorsrecieved) values ('" + educational.Employeeid + "', '" + educational.Educationallevel + "', '" + educational.Vocationalschoolname + "', '" + educational.Vocationaldegcource + "',  '" + educational.VocationalFrom + "',  '" + educational.VocationalTo + "',  '" + educational.Vocationalunitearned + "',  '" + educational.VocationalYeargraduated + "',  '" + educational.VocationalHonorrecieved + "')");
        }
        public long Insertcoll(EL.manageEmployees.EducationalBGEL educational)
        {
            educational.Educationallevel = "College";
            return Helper.executeNonQueryLong("insert into educationalbackground_tbl (employeeid, educationallevel, nameofschool, basiceduation, datefrom, dateto, unitsearned, dategraduated, honorsrecieved) values ('" + educational.Employeeid + "', '" + educational.Educationallevel + "', '" + educational.Collegeschoolname + "', '" + educational.Collegdegcourse + "',  '" + educational.CollegeFrom + "',  '" + educational.CollegeTo + "',  '" + educational.Collegeunitearned + "',  '" + educational.CollegeYeargraduated + "',  '" + educational.CollegeHonorrecieved + "')");
        }
        public long Insertgrad(EL.manageEmployees.EducationalBGEL educational)
        {
            educational.Educationallevel = "Graduate Studies";
            return Helper.executeNonQueryLong("insert into educationalbackground_tbl (employeeid, educationallevel, nameofschool, basiceduation, datefrom, dateto, unitsearned, dategraduated, honorsrecieved) values ('" + educational.Employeeid + "', '" + educational.Educationallevel + "', '" + educational.Graduateschoolname + "', '" + educational.Graduatedegcourse + "',  '" + educational.GraduateFrom + "',  '" + educational.GraduateTo + "',  '" + educational.Graduateunitearned + "',  '" + educational.GraduateschoolGraduated + "',  '" + educational.GraduateHonorrecieved + "')");
        }
    }
}
