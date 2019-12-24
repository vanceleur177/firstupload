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
        HRIS.EL.manageEmployees.CountryEL CountryEL = new EL.manageEmployees.CountryEL();
        HRIS.EL.manageEmployees.ChildrenEL ChildrenEL = new EL.manageEmployees.ChildrenEL();
        HRIS.EL.manageEmployees.CSEligibilityEL CSEligibilityEL = new EL.manageEmployees.CSEligibilityEL();
        HRIS.EL.manageEmployees.EducationalBGEL EducationalBGEL = new EL.manageEmployees.EducationalBGEL();
        HRIS.EL.manageEmployees.EnsuranceEL ensurance = new EL.manageEmployees.EnsuranceEL();


        public frmADDEMPLOYEEINFO()
        {
            InitializeComponent();
        }
        private void getDataFromForm()
        {


            AddressEL.Houseblklotnumber = txt1HouseBlockLot.Text;
            AddressEL.Street = txt1Street.Text;
            AddressEL.Subdvillage = txt1SubdivisionVillage.Text;
            AddressEL.Brgy = txt1Barangay.Text;
            AddressEL.Citymunicipality = txt1CityMunicipality.Text;
            AddressEL.Province = txt1Province.Text;
            AddressEL.Zipcode = Convert.ToInt32(txt1ZipCode.Text);

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
                CboxCivilStatusSingle.Checked = false;
                CboxCivilStatusMarried.Checked = false;
                CboxCivilStatusWidowed.Checked = false;
                CboxCivilStatusSeparated.Checked = false;
            }
        }
    }
}
