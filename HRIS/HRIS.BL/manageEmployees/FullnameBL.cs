using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.BL.manageEmployees
{
   public class FullnameBL
    {
        HRIS.DL.manageEmployees.FullnameDL FullnameDL = new DL.manageEmployees.FullnameDL();
        public long Insert(EL.manageEmployees.FullnameEL fullname)
        {
            return FullnameDL.Insert(fullname);
        }
    }
}
