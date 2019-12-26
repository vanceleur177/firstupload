using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.BL.manageEmployees
{
   public class InsuranceBL
    {
        HRIS.DL.manageEmployees.InsuranceDL InsuranceDL = new DL.manageEmployees.InsuranceDL();
        public long Insert(EL.manageEmployees.InsuranceEL insurance)
        {
            return InsuranceDL.Insert(insurance);
        }
    }
}
