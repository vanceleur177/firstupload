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
        /* HRIS.EL.manageEmployees.EmployeeEL EmployeeEL = new EL.manageEmployees.EmployeeEL();
         HRIS.EL.manageEmployees.AddressEL AddressEL = new EL.manageEmployees.AddressEL();
          HRIS.EL.manageEmployees.FullnameEL FullnameEL = new EL.manageEmployees.FullnameEL();
         HRIS.EL.manageEmployees.CitizenshipEL CitizenshipEL = new EL.manageEmployees.CitizenshipEL();
         HRIS.EL.manageEmployees.InsuranceEL InsuranceEL = new EL.manageEmployees.InsuranceEL();*/
        HRIS.BL.manageEmployees.AddressBL addressBL = new BL.manageEmployees.AddressBL();
        HRIS.BL.manageEmployees.FullnameBL FullnameBL = new BL.manageEmployees.FullnameBL();
        HRIS.BL.manageEmployees.CitizenshipBL CitizenshipBL = new BL.manageEmployees.CitizenshipBL();
        HRIS.BL.manageEmployees.InsuranceBL insuranceBL = new BL.manageEmployees.InsuranceBL();
        HRIS.BL.manageEmployees.EmployeeBL EmployeeBL = new BL.manageEmployees.EmployeeBL();
        HRIS.BL.manageEmployees.EducationalBGBL EducationalBGBL = new BL.manageEmployees.EducationalBGBL();

        HRIS.EL.manageEmployees.TypesofAddressEL TypesofAddressEL = new EL.manageEmployees.TypesofAddressEL();
        HRIS.EL.manageEmployees.EmployeeEL employeeEL;
        HRIS.EL.manageEmployees.AddressEL addressEL;
        HRIS.EL.manageEmployees.FullnameEL fullnameEL;
        HRIS.EL.manageEmployees.CitizenshipEL citizenshipEL;
        HRIS.EL.manageEmployees.InsuranceEL insuranceEL;


        HRIS.PL.manageEmployees.frmADDEMPLOYEEINFO frmADDEMPLOYEEINFO;

        public frmADDEMPLOYEEEDUCBG(HRIS.EL.manageEmployees.EmployeeEL EmployeeEL, EL.manageEmployees.FullnameEL Fullname, EL.manageEmployees.AddressEL Address, EL.manageEmployees.CitizenshipEL Citizenship, EL.manageEmployees.InsuranceEL Insurance, frmADDEMPLOYEEINFO FrmADDEMPLOYEEINFO)
        {
            InitializeComponent();
            frmADDEMPLOYEEINFO = FrmADDEMPLOYEEINFO;
            employeeEL = EmployeeEL;
            fullnameEL = Fullname;
            addressEL = Address;
            citizenshipEL = Citizenship;
            insuranceEL = Insurance;
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
            if (txtElemTo.Text.Equals(""))
            { EducationalBGEL.ElementaryTo = "N/A"; }
            else EducationalBGEL.ElementaryTo = txtElemTo.Text;
            if (txtElemUnits.Text.Equals(""))
            { EducationalBGEL.Elementaryunitearned = Convert.ToInt32("0"); }
            else EducationalBGEL.Elementaryunitearned = Convert.ToInt32(txtElemUnits.Text);
            if (txtElemYear.Text.Equals(""))
            { EducationalBGEL.ElementaryYeargraduated = "N/A"; }
            else EducationalBGEL.ElementaryYeargraduated = txtElemYear.Text;
            if (txtElemHonor.Text.Equals(""))
            { EducationalBGEL.ElementaryHonorrecieved = "N/A"; }
            else EducationalBGEL.ElementaryHonorrecieved = txtElemHonor.Text;

            if (txtSecondaryName.Text.Equals(""))
            { EducationalBGEL.Secondaryschoolname = "N/A"; }
            else EducationalBGEL.Secondaryschoolname = txtSecondaryName.Text;
            if (txtSecondaruDegCource.Text.Equals(""))
            { EducationalBGEL.Secondarydegcourse = "N/A"; }
            else EducationalBGEL.Secondarydegcourse = txtSecondaruDegCource.Text;
            if (txtSecFrom.Text.Equals(""))
            { EducationalBGEL.SecondaryFrom = "N/A"; }
            else EducationalBGEL.SecondaryFrom = txtSecFrom.Text;
            if (txtSecTo.Text.Equals(""))
            { EducationalBGEL.SecondaryTo = "N/A"; }
            else EducationalBGEL.SecondaryTo = txtSecTo.Text;
            if (txtSecUnits.Text.Equals(""))
            { EducationalBGEL.Secondaryunitearned = Convert.ToInt32("0"); }
            else EducationalBGEL.Secondaryunitearned = Convert.ToInt32(txtSecUnits.Text);
            if (txtSecYear.Text.Equals(""))
            { EducationalBGEL.SecondaryYeargraduated = "N/A"; }
            else EducationalBGEL.SecondaryYeargraduated = txtSecYear.Text;
            if (txtSecHonor.Text.Equals(""))
            { EducationalBGEL.SecondaryHonorrecieved = "N/A"; }
            else EducationalBGEL.SecondaryHonorrecieved = txtSecHonor.Text;

            if (txtVocationalTradeCourceName.Text.Equals(""))
            { EducationalBGEL.Vocationalschoolname = "N/A"; }
            else EducationalBGEL.Vocationalschoolname = txtVocationalTradeCourceName.Text;
            if (txtVocationalDegreeCource.Text.Equals(""))
            { EducationalBGEL.Vocationaldegcource = "N/A"; }
            else EducationalBGEL.Vocationaldegcource = txtVocationalDegreeCource.Text;
            if (txtVocFrom.Text.Equals(""))
            { EducationalBGEL.VocationalFrom = "N/A"; }
            else EducationalBGEL.VocationalFrom = txtVocFrom.Text;
            if (txtVocTo.Text.Equals(""))
            { EducationalBGEL.VocationalTo = "N/A"; }
            else EducationalBGEL.VocationalTo = txtVocTo.Text;
            if (txtVocUnits.Text.Equals(""))
            { EducationalBGEL.Vocationalunitearned = Convert.ToInt32("0"); }
            else EducationalBGEL.Vocationalunitearned = Convert.ToInt32(txtVocUnits.Text);
            if (txtVocYear.Text.Equals(""))
            { EducationalBGEL.VocationalYeargraduated = "N/A"; }
            else EducationalBGEL.VocationalYeargraduated = txtVocYear.Text;
            if (txtVocHonors.Text.Equals(""))
            { EducationalBGEL.VocationalHonorrecieved = "N/A"; }
            else EducationalBGEL.VocationalHonorrecieved = txtVocHonors.Text;

            if (txtCollegeName.Text.Equals(""))
            { EducationalBGEL.Collegeschoolname = "N/A"; }
            else EducationalBGEL.Collegeschoolname = txtCollegeName.Text;
            if (txtCollegeDegreeCoure.Text.Equals(""))
            { EducationalBGEL.Collegdegcourse = "N/A"; }
            else EducationalBGEL.Collegdegcourse = txtCollegeDegreeCoure.Text;
            if (txtCollegeFrom.Text.Equals(""))
            { EducationalBGEL.CollegeFrom = "N/A"; }
            else EducationalBGEL.CollegeFrom = txtCollegeFrom.Text;
            if (txtCollegeTo.Text.Equals(""))
            { EducationalBGEL.CollegeTo = "N/A"; }
            else EducationalBGEL.CollegeTo = txtCollegeTo.Text;
            if (txtCollegeUnits.Text.Equals(""))
            { EducationalBGEL.Collegeunitearned = Convert.ToInt32("0"); }
            else EducationalBGEL.Collegeunitearned = Convert.ToInt32(txtCollegeUnits.Text);
            if (txtCollegeYear.Text.Equals(""))
            { EducationalBGEL.CollegeYeargraduated = "N/A"; }
            else EducationalBGEL.CollegeYeargraduated = txtCollegeYear.Text;
            if (txtCollegeHonor.Text.Equals(""))
            { EducationalBGEL.CollegeHonorrecieved = "N/A"; }
            else EducationalBGEL.CollegeHonorrecieved = txtCollegeHonor.Text;

            if (txtGraduateStudiesName.Text.Equals(""))
            { EducationalBGEL.Graduateschoolname = "N/A"; }
            else EducationalBGEL.Graduateschoolname = txtGraduateStudiesName.Text;
            if (txtGraduateDegreeCource.Text.Equals(""))
            { EducationalBGEL.Graduatedegcourse = "N/A"; }
            else EducationalBGEL.Graduatedegcourse = txtGraduateDegreeCource.Text;
            if (txtGradFrom.Text.Equals(""))
            { EducationalBGEL.GraduateFrom = "N/A"; }
            else EducationalBGEL.GraduateFrom = txtGradFrom.Text;
            if (txtGradTo.Text.Equals(""))
            { EducationalBGEL.GraduateTo = "N/A"; }
            else EducationalBGEL.GraduateTo = txtGradTo.Text;
            if (txtGradUnits.Text.Equals(""))
            { EducationalBGEL.Graduateunitearned = Convert.ToInt32("0"); }
            else EducationalBGEL.Graduateunitearned = Convert.ToInt32(txtGradUnits.Text);
            if (txtGraduateYear.Text.Equals(""))
            { EducationalBGEL.GraduateschoolGraduated = "N/A"; }
            else EducationalBGEL.GraduateschoolGraduated = txtGraduateYear.Text;
            if (txtGraduateHonor.Text.Equals(""))
            { EducationalBGEL.GraduateschoolGraduated = "N/A"; }
            else EducationalBGEL.GraduateschoolGraduated = txtGraduateHonor.Text;





        }
        private void FrmADDEMPLOYEEEDUCBG_Load(object sender, EventArgs e)
        {
            /*MessageBox.Show(fullnameEL.Firstname);
            MessageBox.Show(fullnameEL.Middlename);
            MessageBox.Show(fullnameEL.Lastname);
            MessageBox.Show(fullnameEL.Extname);
            MessageBox.Show(employeeEL.Dateofbirth);
            MessageBox.Show(employeeEL.Placeofbirth);
            MessageBox.Show(employeeEL.Sex);
            MessageBox.Show(employeeEL.Civilstatus);
            MessageBox.Show(employeeEL.Heigthm);
            MessageBox.Show(employeeEL.Weightkg);
            MessageBox.Show(employeeEL.Bloodtype);
            MessageBox.Show(employeeEL.Telnumber);
            MessageBox.Show(employeeEL.Mobnumber);
            MessageBox.Show(employeeEL.Emailaddress);
            MessageBox.Show(insuranceEL.Insuranceagencyid);
            MessageBox.Show(insuranceEL.Insurancepagibig);
            MessageBox.Show(insuranceEL.Insurancegsis);
            MessageBox.Show(insuranceEL.Insurancephilhealth);
            MessageBox.Show(insuranceEL.Insurancetin);
            MessageBox.Show(insuranceEL.Insurancesss);*/
           /* MessageBox.Show(addressEL.Houseblklotnumber);
            MessageBox.Show(addressEL.Street);
            MessageBox.Show(addressEL.Subdvillage);
            MessageBox.Show(addressEL.Brgy);
            MessageBox.Show(addressEL.Citymunicipality);
            MessageBox.Show(addressEL.Province);
            MessageBox.Show(addressEL.Zipcode.ToString());
            MessageBox.Show(addressEL.Houseblklotnumber2);
            MessageBox.Show(addressEL.Street2);
            MessageBox.Show(addressEL.Subdvillage2);
            MessageBox.Show(addressEL.Brgy2);
            MessageBox.Show(addressEL.Citymunicipality2);
            MessageBox.Show(addressEL.Province2);
            MessageBox.Show(addressEL.Zipcode2.ToString());
            MessageBox.Show(citizenshipEL.Citizenshiptype);
            MessageBox.Show(citizenshipEL.Citizenshipaquiredby);
            MessageBox.Show(citizenshipEL.Citizenshipdualitycountry);*/
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            long fullnameid;
            long insuranceid;
            long citizenshipid;
            long employeeid;
            long addressID;
            
            if ((fullnameid = FullnameBL.Insert(fullnameEL)) > 0)
            {
                employeeEL.Fullnameid = Convert.ToInt32(fullnameid);
                MessageBox.Show(employeeEL.Fullnameid.ToString());

            }

           if ((citizenshipid = CitizenshipBL.Insert(citizenshipEL)) > 0)
            {
                employeeEL.Citizinshipid = Convert.ToInt32(citizenshipid);




            }
            if ((insuranceid = insuranceBL.Insert(insuranceEL)) > 0)
            {
                employeeEL.Insuranceid = Convert.ToInt32(insuranceid);


            }

            if ((employeeid = EmployeeBL.Insert(employeeEL)) > 0)
            {
                employeeEL.Employeeid = Convert.ToInt32(employeeid);
                EducationalBGEL.Employeeid = Convert.ToInt32(employeeid);
                addressEL.Employeeid = Convert.ToInt32(employeeid);


            }

            if (EducationalBGBL.Insertelem(EducationalBGEL) > 0)
            {
                EducationalBGBL.Insertsec(EducationalBGEL);
                EducationalBGBL.Insertvoc(EducationalBGEL);
                EducationalBGBL.Insertcoll(EducationalBGEL);
                EducationalBGBL.Insertgrad(EducationalBGEL);

            }

            if ((addressID = addressBL.InsertResidential(addressEL)) > 0)
            {
                addressBL.InsertPermanent(addressEL);
                addressEL.Typeofaddressid = Convert.ToInt32(addressID);
            }


        }
    }
}
