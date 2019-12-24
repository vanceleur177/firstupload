using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.EL.manageEmployees
{
   public class VoluntaryWorkEL
    {
        int voluntaryworkid;
        int employeeid;
        String voluntaryworknameandaddress;
        String datesfrom;
        String datesto;
        int numberofhours;
        String position;

        public int Voluntaryworkid { get => voluntaryworkid; set => voluntaryworkid = value; }
        public int Employeeid { get => employeeid; set => employeeid = value; }
        public string Voluntaryworknameandaddress { get => voluntaryworknameandaddress; set => voluntaryworknameandaddress = value; }
        public string Datesfrom { get => datesfrom; set => datesfrom = value; }
        public string Datesto { get => datesto; set => datesto = value; }
        public int Numberofhours { get => numberofhours; set => numberofhours = value; }
        public string Position { get => position; set => position = value; }
    }
}
