using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.DL.manageEmployees
{
   public class CitizenshipDL
    {
        public long Insert(EL.manageEmployees.CitizenshipEL citizenship)
        {
            return Helper.executeNonQueryLong("insert into citizenship_tbl (citizenshiptype, citizenshipaquiredby, citizenshipdualitycountry) values ('" + citizenship.Citizenshiptype + "', '" + citizenship.Citizenshipdualitycountry + "', '" + citizenship.Citizenshipaquiredby + "')");
        }
    }
}
