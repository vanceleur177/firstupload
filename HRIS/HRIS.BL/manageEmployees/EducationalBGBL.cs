using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.BL.manageEmployees
{
   public class EducationalBGBL
    {
        HRIS.DL.manageEmployees.EducationalBGDL educationalBGDL = new DL.manageEmployees.EducationalBGDL();
        public long Insertelem(EL.manageEmployees.EducationalBGEL educational)
        {
            return educationalBGDL.Insertelem(educational);
        }
        public long Insertsec(EL.manageEmployees.EducationalBGEL educational)
        {
            return educationalBGDL.Insertsec(educational);
        }
        public long Insertvoc(EL.manageEmployees.EducationalBGEL educational)
        {
            return educationalBGDL.Insertvoc(educational);
        }
        public long Insertcoll(EL.manageEmployees.EducationalBGEL educational)
        {
            return educationalBGDL.Insertcoll(educational);
        }
        public long Insertgrad(EL.manageEmployees.EducationalBGEL educational)
        {
            return educationalBGDL.Insertgrad(educational);
        }
    }
}
