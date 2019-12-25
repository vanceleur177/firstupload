using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class InsuranceEL
    {
        int insuranceid;
        String insurancedescription;
           String insurancecontrolnumber;



        public int Insuranceid { get => insuranceid; set => insuranceid = value; }
        public string Insurancedescription { get => insurancedescription; set => insurancedescription = value; }
        public string Insurancecontrolnumber { get => insurancecontrolnumber; set => insurancecontrolnumber = value; }
        public string Insurancegsis { get => insurancegsis; set => insurancegsis = value; }
        public string Insurancepagibig { get => insurancepagibig; set => insurancepagibig = value; }
        public string Insurancephilhealth { get => insurancephilhealth; set => insurancephilhealth = value; }
        public string Insurancesss { get => insurancesss; set => insurancesss = value; }
        public string Insurancetin { get => insurancetin; set => insurancetin = value; }
        public string Insuranceagencyid { get => insuranceagencyid; set => insuranceagencyid = value; }

        String insurancegsis;
        String insurancepagibig;
        String insurancephilhealth;
        String insurancesss;
        String insurancetin;
        String insuranceagencyid;

    }
}
