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
    public partial class frmADDEMPLOYEEINFO : Form
    {
        HRIS.EL.manageEmployees.EmployeeEL EmployeeEL = new EL.manageEmployees.EmployeeEL();
        HRIS.EL.manageEmployees.AddressEL AddressEL = new EL.manageEmployees.AddressEL();
        HRIS.EL.manageEmployees.FullnameEL FullnameEL = new EL.manageEmployees.FullnameEL();
        HRIS.EL.manageEmployees.CitizenshipEL CitizenshipEL = new EL.manageEmployees.CitizenshipEL();
        //HRIS.EL.manageEmployees.CountryEL CountryEL = new EL.manageEmployees.CountryEL();
        //HRIS.EL.manageEmployees.ChildrenEL ChildrenEL = new EL.manageEmployees.ChildrenEL();
        //HRIS.EL.manageEmployees.CSEligibilityEL CSEligibilityEL = new EL.manageEmployees.CSEligibilityEL();
        //HRIS.EL.manageEmployees.EducationalBGEL EducationalBGEL = new EL.manageEmployees.EducationalBGEL();
        HRIS.EL.manageEmployees.InsuranceEL InsuranceEL = new EL.manageEmployees.InsuranceEL();


        public frmADDEMPLOYEEINFO()
        {
            InitializeComponent();
        }
        private void disableForm()
        {
            CboxByNaturalization.Enabled = false;
            CboxByBirth.Enabled = false;
            cbCountryDualCitezenship.Enabled = false;
        }
        private void getDataFromForm()
        {
///111111111
            if (txt1HouseBlockLot.Text.Equals(""))
            { AddressEL.Houseblklotnumber = "N/A"; }
            else AddressEL.Houseblklotnumber = txt1HouseBlockLot.Text;
            if (txt1Street.Text.Equals(""))
            { AddressEL.Street = "N/A"; }
             else AddressEL.Street = txt1Street.Text;

            if (txt1SubdivisionVillage.Text.Equals(""))
            { AddressEL.Subdvillage = "N/A"; }
            else AddressEL.Subdvillage = txt1SubdivisionVillage.Text;

             AddressEL.Brgy2 = txt1Barangay.Text;
            AddressEL.Citymunicipality2 = txt1CityMunicipality.Text;
            AddressEL.Province2 = txt1Province.Text;
            AddressEL.Zipcode2 = Convert.ToInt32(txt1ZipCode.Text);
////222222222222
            if (txt2HouseBlockLot.Text.Equals(""))
            { AddressEL.Houseblklotnumber2 = "N/A"; }
            else AddressEL.Houseblklotnumber2 = txt2HouseBlockLot.Text;
            if (txt2Street.Text.Equals(""))
            { AddressEL.Street2 = "N/A"; }
            else AddressEL.Street2 = txt2Street.Text;

            if (txt2SubdivisionVillage.Text.Equals(""))
            { AddressEL.Subdvillage2 = "N/A"; }
            else AddressEL.Subdvillage2 = txt2SubdivisionVillage.Text;
            AddressEL.Brgy = txt1Barangay.Text;
            AddressEL.Citymunicipality = txt1CityMunicipality.Text;
            AddressEL.Province = txt1Province.Text;
            AddressEL.Zipcode = Convert.ToInt32(txt1ZipCode.Text);



            FullnameEL.Firstname = txtFirstNAme.Text;
            FullnameEL.Middlename = txtMiddleName.Text;
            FullnameEL.Lastname = txtSurename.Text;
            if (txtNameExtension.Text.Equals(""))
            { FullnameEL.Extname = "N/A"; }
            else FullnameEL.Extname = txtNameExtension.Text;


            EmployeeEL.Dateofbirth = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
            EmployeeEL.Placeofbirth = txtPlaceOfBirth.Text;

            if (txtHeight.Text.Equals(""))
            { EmployeeEL.Heigthm = "N/A"; }
            else EmployeeEL.Heigthm = txtHeight.Text;
            if (txtWeight.Text.Equals(""))
            { EmployeeEL.Weightkg = "N/A"; }
            else EmployeeEL.Weightkg = txtWeight.Text;
            if (cbBloodType.Text.Equals(""))
            { EmployeeEL.Bloodtype = "N/A"; }
            else EmployeeEL.Bloodtype = cbBloodType.Text;

            if (txtMobileNum.Text.Equals(""))
            { EmployeeEL.Mobnumber = "N/A"; }
            else EmployeeEL.Mobnumber = txtMobileNum.Text;
            if (txtTelephoneNum.Text.Equals(""))
            { EmployeeEL.Telnumber = "N/A"; }
            else EmployeeEL.Telnumber = txtTelephoneNum.Text;
            if (txtEmailAdress.Text.Equals(""))
            { EmployeeEL.Emailaddress = "N/A"; }
            else EmployeeEL.Emailaddress = txtEmailAdress.Text;

            if (txtGSISidNum.Text.Equals(""))
            { InsuranceEL.Insurancegsis = "N/A"; }
            else InsuranceEL.Insurancegsis = txtGSISidNum.Text;
            if (txtPAGIBIGidNum.Text.Equals(""))
            { InsuranceEL.Insurancepagibig = "N/A"; }
            else InsuranceEL.Insurancepagibig = txtPAGIBIGidNum.Text;
            if (txtPHILHEALTHidNum.Text.Equals(""))
            { InsuranceEL.Insurancephilhealth = "N/A"; }
            else InsuranceEL.Insurancephilhealth = txtPHILHEALTHidNum.Text;
            if (txtSSSidNum.Text.Equals(""))
            { InsuranceEL.Insurancesss = "N/A"; }
            else InsuranceEL.Insurancesss = txtSSSidNum.Text;
            if (txtTINidNum.Text.Equals(""))
            { InsuranceEL.Insurancetin = "N/A"; }
            else InsuranceEL.Insurancetin = txtTINidNum.Text;
            if (txtAgencyEmployeeIdNum.Text.Equals(""))
            { InsuranceEL.Insuranceagencyid = "N/A"; }
            else InsuranceEL.Insuranceagencyid = txtAgencyEmployeeIdNum.Text;

            if (cbCountryDualCitezenship.Text.Equals(""))
            { CitizenshipEL.Citizenshipdualitycountry = "N/A"; }
            else CitizenshipEL.Citizenshipdualitycountry = cbCountryDualCitezenship.Text;
        }
        bool isChecked = false;
      
        private void RbSameAddress_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbSameAddress.Checked;
            getDataFromForm();
            txt2HouseBlockLot.Text = AddressEL.Houseblklotnumber.ToString();
            txt2Street.Text = AddressEL.Street.ToString();
            txt2SubdivisionVillage.Text = AddressEL.Subdvillage.ToString();
            txt2Barangay.Text = AddressEL.Brgy.ToString();
            txt2CityMunicipality.Text = AddressEL.Citymunicipality.ToString();
            txt2Province.Text = AddressEL.Province.ToString();
            txt2ZipCode.Text = AddressEL.Zipcode.ToString();

        }

        private void RbSameAddress_Click(object sender, EventArgs e)
        {
            if (rbSameAddress.Checked && !isChecked)
            {
                rbSameAddress.Checked = false;

                txt2HouseBlockLot.Clear();
                txt2Street.Clear();
                txt2SubdivisionVillage.Clear();
                txt2Barangay.Clear();
                txt2CityMunicipality.Clear();
                txt2Province.Clear();
                txt2ZipCode.Clear();
            }
            else
            {
                rbSameAddress.Checked = true;
                isChecked = false;
            }

           
        }

        

        private void RbFemale_Click(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                rbMale.Checked = false;
                EmployeeEL.Sex = "Female";
                
            }
        }

        private void RbMale_Click(object sender, EventArgs e)
        {
            if(rbMale.Checked)
            {
                rbFemale.Checked = false;
                EmployeeEL.Sex = "Male";
               

            }

        }

        private void CboxCivilStatusSingle_Click(object sender, EventArgs e)
        {
            if(CboxCivilStatusSingle.Checked)
            {
                EmployeeEL.Civilstatus = "Single";
                CboxCivilStatusMarried.Checked = false;
                CboxCivilStatusWidowed.Checked = false;
                CboxCivilStatusSeparated.Checked = false;
                CboxCivilStatusOthers.Checked = false;
            }
        }

        private void CboxCivilStatusMarried_Click(object sender, EventArgs e)
        {
            if (CboxCivilStatusMarried.Checked)
            {
                EmployeeEL.Civilstatus = "Married";
                CboxCivilStatusSingle.Checked = false;
                CboxCivilStatusWidowed.Checked = false;
                CboxCivilStatusSeparated.Checked = false;
                CboxCivilStatusOthers.Checked = false;
            }
        }

        private void CboxCivilStatusWidowed_Click(object sender, EventArgs e)
        {
            if (CboxCivilStatusWidowed.Checked)
            {
                EmployeeEL.Civilstatus = "Widowed";
                CboxCivilStatusSingle.Checked = false;
                CboxCivilStatusMarried.Checked = false;
                CboxCivilStatusSeparated.Checked = false;
                CboxCivilStatusOthers.Checked = false;
            }
        }

        private void CboxCivilStatusSeparated_Click(object sender, EventArgs e)
        {
            if (CboxCivilStatusSeparated.Checked)
            {
                EmployeeEL.Civilstatus = "Separated";
                CboxCivilStatusSingle.Checked = false;
                CboxCivilStatusMarried.Checked = false;
                CboxCivilStatusWidowed.Checked = false;
                CboxCivilStatusOthers.Checked = false;
            }
        }

        private void CboxCivilStatusOthers_Click(object sender, EventArgs e)
        {
            if (CboxCivilStatusOthers.Checked)
            {
                EmployeeEL.Civilstatus = "Other";
                CboxCivilStatusSingle.Checked = false;
                CboxCivilStatusMarried.Checked = false;
                CboxCivilStatusWidowed.Checked = false;
                CboxCivilStatusSeparated.Checked = false;
            }
        }

        private void CboxByBirth_Click(object sender, EventArgs e)
        {
            if(CboxByBirth.Checked)
            {
                CitizenshipEL.Citizenshipaquiredby = "By Birth";
                CboxByNaturalization.Checked = false;

            }
        }

        private void CboxByNaturalization_Click(object sender, EventArgs e)
        {
            if (CboxByNaturalization.Checked)
            {
                CitizenshipEL.Citizenshipaquiredby = "By Naturalization";
                CboxByBirth.Checked = false;

            }
        }

        private void CboxFilipino_Click(object sender, EventArgs e)
        {
            
            if (CboxFilipino.Checked)
            {
               
                CboxDualCitizenship.Checked = false;
                CboxByBirth.Checked = false;
                CboxByNaturalization.Checked = false;
                cbCountryDualCitezenship.ResetText();
                disableForm();
                CitizenshipEL.Citizenshiptype = "Filipino";

            }

        }

        private void CboxDualCitizenship_Click(object sender, EventArgs e)
        {
            

            if (CboxDualCitizenship.Checked)
            {
                CboxFilipino.Checked = false;
                CboxByBirth.Enabled = true;
                CboxByNaturalization.Enabled = true;
                cbCountryDualCitezenship.Enabled = true;
                CitizenshipEL.Citizenshiptype = "Dual Citizenship";

            }

        }
        private bool validations()
        {
            bool status = true;

            if (txtSurename.Text.Equals(""))
            {
                errorProvider1.SetError(txtSurename, "Please fill out this field.");
                status = false;
            }
            else
                errorProvider1.SetError(txtSurename, "");

            if (txtFirstNAme.Text.Equals(""))
            {
                errorProvider1.SetError(txtFirstNAme, "Please fill out this field.");
                status = false;
            }
            else
                errorProvider1.SetError(txtFirstNAme, "");

            if (txtMiddleName.Text.Equals(""))
            {
                errorProvider1.SetError(txtMiddleName, "Please fill out this field.");
                status = false;
            }
            else
                errorProvider1.SetError(txtMiddleName, "");
//////////
            if (dtpDateOfBirth.Equals(DateTime.Now.ToString("yyyy-MM-dd")))
            {
                errorProvider1.SetError(dtpDateOfBirth, "Please Input the right Date!");
                status = false;
            }
            else
                errorProvider1.SetError(dtpDateOfBirth, "");
            
            if (txtPlaceOfBirth.Text.Equals(""))
            {
                errorProvider1.SetError(txtPlaceOfBirth, "Please fill out this field!");
                status = false;
            }
            else
                errorProvider1.SetError(txtPlaceOfBirth, "");

            if (rbFemale.Checked.Equals(false) && rbMale.Checked.Equals(false))
            {
                errorProvider1.SetError(panel22, "Please select gender!");

                status = false;
            }
            else
                
                errorProvider1.SetError(panel22, "");

            if (CboxCivilStatusMarried.Checked.Equals(false) && CboxCivilStatusOthers.Checked.Equals(false) && CboxCivilStatusSingle.Checked.Equals(false) && CboxCivilStatusSeparated.Checked.Equals(false) && CboxCivilStatusWidowed.Checked.Equals(false))
            {
                errorProvider1.SetError(panel21, "Please select Civil Status!");

                status = false;
            }
            else

                errorProvider1.SetError(panel21, "");

            if (CboxFilipino.Checked.Equals(false) && CboxDualCitizenship.Checked.Equals(false))
            {
                errorProvider1.SetError(panel24, "Please select Citizenship!");

                status = false;
            }
            else

                errorProvider1.SetError(panel24, "");

            if (CboxDualCitizenship.Checked.Equals(true) && CboxByBirth.Checked.Equals(false) && CboxByNaturalization.Checked.Equals(false) && cbCountryDualCitezenship.Text.Equals(""))
            {
                errorProvider1.SetError(panel24, "Please indicate how you aquired the citizenship!");

                status = false;
            }
            else

                errorProvider1.SetError(panel24, "");

            if (txt1Barangay.Text.Equals(""))
            {
                errorProvider1.SetError(txt1Barangay, "Please fill out this field!");
                status = false;
            }
            else
                errorProvider1.SetError(txt1Barangay, "");

            if (txt2Barangay.Text.Equals(""))
            {
                errorProvider1.SetError(txt2Barangay, "Please fill out this field!");
                status = false;
            }
            else
                errorProvider1.SetError(txt2Barangay, "");

            if (txt1CityMunicipality.Text.Equals(""))
            {
                errorProvider1.SetError(txt1CityMunicipality, "Please fill out this field!");
                status = false;
            }
            else
                errorProvider1.SetError(txt1CityMunicipality, "");

            if (txt2CityMunicipality.Text.Equals(""))
            {
                errorProvider1.SetError(txt2CityMunicipality, "Please fill out this field!");
                status = false;
            }
            else
                errorProvider1.SetError(txt2CityMunicipality, "");

            if (txt1Barangay.Text.Equals(""))
            {
                errorProvider1.SetError(txt1Barangay, "Please fill out this field!");
                status = false;
            }
            else
                errorProvider1.SetError(txt1Barangay, "");

            if (txt2Barangay.Text.Equals(""))
            {
                errorProvider1.SetError(txt2Barangay, "Please fill out this field!");
                status = false;
            }
            else
                errorProvider1.SetError(txt2Barangay, "");

            if (txt1ZipCode.Text.Equals(""))
            {
                errorProvider1.SetError(txt1ZipCode, "Please fill out this field!");
                status = false;
            }
            else
                errorProvider1.SetError(txt1ZipCode, "");

            if (txt2ZipCode.Text.Equals(""))
            {
                errorProvider1.SetError(txt2ZipCode, "Please fill out this field!");
                status = false;
            }
            else
                errorProvider1.SetError(txt2ZipCode, "");

            /*if (cbCountryDualCitezenship.Text.Equals(""))
            {
                errorProvider1.SetError(cbCountryDualCitezenship, "Please fill out this field!");
                status = false;
            }
            else
                errorProvider1.SetError(cbCountryDualCitezenship, "");*/

            return status;
        }

        private void FrmADDEMPLOYEEINFO_Load(object sender, EventArgs e)
        {
            disableForm();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (validations())
            {
                MessageBox.Show(FullnameEL.Firstname);
                MessageBox.Show(FullnameEL.Middlename);
                MessageBox.Show(FullnameEL.Lastname);
                MessageBox.Show(FullnameEL.Extname);
                MessageBox.Show(EmployeeEL.Dateofbirth);
                MessageBox.Show(EmployeeEL.Placeofbirth);
                MessageBox.Show(EmployeeEL.Sex);
                MessageBox.Show(EmployeeEL.Civilstatus);
                MessageBox.Show(EmployeeEL.Heigthm);
                MessageBox.Show(EmployeeEL.Weightkg);
                MessageBox.Show(EmployeeEL.Bloodtype);
                MessageBox.Show(EmployeeEL.Telnumber);
                MessageBox.Show(EmployeeEL.Mobnumber);
                MessageBox.Show(EmployeeEL.Emailaddress);
                MessageBox.Show(InsuranceEL.Insuranceagencyid);
                MessageBox.Show(InsuranceEL.Insurancepagibig);
                MessageBox.Show(InsuranceEL.Insurancegsis);
                MessageBox.Show(InsuranceEL.Insurancephilhealth);
                MessageBox.Show(InsuranceEL.Insurancetin);
                MessageBox.Show(InsuranceEL.Insurancesss);
                MessageBox.Show(AddressEL.Houseblklotnumber);
                MessageBox.Show(AddressEL.Street);
                MessageBox.Show(AddressEL.Subdvillage);
                MessageBox.Show(AddressEL.Brgy);
                MessageBox.Show(AddressEL.Citymunicipality);
                MessageBox.Show(AddressEL.Province);
                MessageBox.Show(AddressEL.Zipcode.ToString());
                MessageBox.Show(AddressEL.Houseblklotnumber2);
                MessageBox.Show(AddressEL.Street2);
                MessageBox.Show(AddressEL.Subdvillage2);
                MessageBox.Show(AddressEL.Brgy2);
                MessageBox.Show(AddressEL.Citymunicipality2);
                MessageBox.Show(AddressEL.Province2);
                MessageBox.Show(AddressEL.Zipcode2.ToString());
                MessageBox.Show(CitizenshipEL.Citizenshiptype);
                MessageBox.Show(CitizenshipEL.Citizenshipaquiredby);
                MessageBox.Show(CitizenshipEL.Citizenshipdualitycountry);

            }
        }
    }
}
