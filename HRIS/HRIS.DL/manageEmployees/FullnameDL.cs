using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace HRIS.DL.manageEmployees
{
   public class FullnameDL
    {
        public long Insert(EL.manageEmployees.FullnameEL fullname)
        {
            return Helper.executeNonQueryLong("insert into fullname_tbl (firstname, middlename, lastname, extname) values ('" + fullname.Firstname + "', '" + fullname.Middlename + "', '" + fullname.Lastname + "', '" + fullname.Extname + "')");
        }
    }
}
