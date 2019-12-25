using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.PL.manageEmployees
{
    public partial class frmADDEMPLOYEEEDUCBG : Form
    {
        HRIS.EL.manageEmployees.EducationalBGEL EducationalBGEL = new EL.manageEmployees.EducationalBGEL();
        public frmADDEMPLOYEEEDUCBG()
        {
            InitializeComponent();
        }


        private void getDataFromForm()
        {
            EducationalBGEL.Elementarylevel = "Elementary";
            EducationalBGEL.SecondaryLevel = "Secondary";
            EducationalBGEL.VocationalLevel = "Vocational/Trade Course";
            EducationalBGEL.CollegeLevel = "College";
            EducationalBGEL.GraduateLevel = "Graduate";


            if (txtElementaryName.Text.Equals(""))
            { EducationalBGEL.Elementaryschoolname = "N/A"; }
            else EducationalBGEL.Elementaryschoolname = txtElementaryName.Text;
            if (txtElementaryDegCource.Text.Equals(""))
            { EducationalBGEL.Elementarydegcourse = "N/A"; }
            else EducationalBGEL.Elementarydegcourse = txtElementaryDegCource.Text;
            if (txtElemFrom.Text.Equals(""))
            { EducationalBGEL.ElementaryFrom = "N/A"; }
            else EducationalBGEL.ElementaryFrom = txtElemFrom.Text;
            if (txtElemFrom.Text.Equals(""))
            { EducationalBGEL.ElementaryFrom = "N/A"; }
            else EducationalBGEL.ElementaryFrom = txtElemFrom.Text;
            if (txtElemTo.Text.Equals(""))
            { EducationalBGEL.ElementaryTo = "N/A"; }
            else EducationalBGEL.ElementaryTo = txtElemTo.Text;
            if (txtElemUnits.Text.Equals(""))
            { EducationalBGEL.Elementaryunitearned.Equals("0"); }
            else EducationalBGEL.Elementaryunitearned = txtElemUnits.Text;





        }
            private void FrmADDEMPLOYEEEDUCBG_Load(object sender, EventArgs e)
        {

        }
    }
}
