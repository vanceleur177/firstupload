using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.DL.manageEmployees
{
   public class EmployeeDL
    {
        public long Insert(EL.manageEmployees.EmployeeEL employee)
        {
            return Helper.executeNonQueryLong("insert into employee_tbl (fullnameid, citizenshipid, insuranceid, dateofbirth, placeofbirth, sex, civilstatus, heigthm, weightkg, bloodtype, telnumber, mobnumber, emailaddress) values ('" + employee.Fullnameid + "', '" + employee.Citizinshipid + "', '" + employee.Insuranceid + "', '" + employee.Dateofbirth + "',  '" + employee.Placeofbirth + "',  '" + employee.Sex + "',  '" + employee.Civilstatus + "',  '" + employee.Heigthm + "',  '" + employee.Weightkg + "',  '" + employee.Bloodtype + "',  '" + employee.Telnumber + "',  '" + employee.Mobnumber + "',  '" + employee.Emailaddress + "')");
        }
    }
}
