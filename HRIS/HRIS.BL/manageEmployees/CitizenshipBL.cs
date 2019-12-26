using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.BL.manageEmployees
{
   public class CitizenshipBL
    {
        HRIS.DL.manageEmployees.CitizenshipDL citizenshipDL = new DL.manageEmployees.CitizenshipDL();
        public long Insert(EL.manageEmployees.CitizenshipEL citizenship)
        {
            return citizenshipDL.Insert(citizenship);
        }
    }
}
