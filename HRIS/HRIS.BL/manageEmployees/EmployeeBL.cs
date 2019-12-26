using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.BL.manageEmployees
{
   public class EmployeeBL
    {
        HRIS.DL.manageEmployees.EmployeeDL employeeDL = new DL.manageEmployees.EmployeeDL();
        public long Insert(EL.manageEmployees.EmployeeEL employee)
        {
            return employeeDL.Insert(employee);
        }
    }
}
