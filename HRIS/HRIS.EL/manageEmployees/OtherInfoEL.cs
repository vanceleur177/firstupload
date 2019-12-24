using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class OtherInfoEL
    {
        int otherinfoid;
        int employeeid;
        String specialskillshobbies;
        String nonacademicdistinctions;
        String membership;

        public int Otherinfoid { get => otherinfoid; set => otherinfoid = value; }
        public int Employeeid { get => employeeid; set => employeeid = value; }
        public string Specialskillshobbies { get => specialskillshobbies; set => specialskillshobbies = value; }
        public string Nonacademicdistinctions { get => nonacademicdistinctions; set => nonacademicdistinctions = value; }
        public string Membership { get => membership; set => membership = value; }
    }
}
