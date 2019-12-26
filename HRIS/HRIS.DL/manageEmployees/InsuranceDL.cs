using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.DL.manageEmployees
{
   public class InsuranceDL
    {
        public long Insert(EL.manageEmployees.InsuranceEL insurance)
        {
            return Helper.executeNonQueryLong("insert into insurance_tbl (insurancegsis, insurancepagibig, insurancephilhealth, insurancesss, insurancetin, insuranceagencyid) values ('" + insurance.Insurancegsis + "', '" + insurance.Insurancepagibig + "', '" + insurance.Insurancephilhealth + "', '" + insurance.Insurancesss + "',  '" + insurance.Insurancetin + "',  '" + insurance.Insuranceagencyid + "')");
        }

    }
}
