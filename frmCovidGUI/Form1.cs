using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCovidGUI
{
    public partial class Form1 : Form
    {
        info Hospital = new info();

        public Form1()
        {
            InitializeComponent();
            pnlAddPatient.Visible = false;
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setHospitalinfo(Hospital);
            displayHopitalInfo(Hospital);
            pnlAddPatient.Visible = true;
        }

        private void setHospitalinfo(info i)
        {
            i.Hospital_Name = edtHosNameInput.Text;
            i.Hospital_Address = edtHosAddressInput.Text;
            i.CProvince = edtHosProvinceInput.Text[0];

            switch (cbxType.SelectedIndex)
            {
                case 0:
                    i.BType = true;
                    break;
                default:
                    i.BType = false;
                    break;
            }

            clearHospitalInputs();
        }

        private void clearHospitalInputs()
        {
            edtHosNameInput.Text = "";
            edtHosAddressInput.Text = "";
            edtHosProvinceInput.Text = "";
            cbxType.SelectedIndex = -1;
        }

        private void displayHopitalInfo(info i)
        {
            edtHosNameOutput.Text = i.Hospital_Name;
            edtHosAddressOutput.Text = i.Hospital_Address;
            edtHosProvinceOutput.Text = i.CProvince.ToString();
            edtHosTypeOutput.Text = i.BType.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            setPatientDetails(Hospital);
        }

        private void clearPatientInputs()
        {
            edtPID.Clear();
            edtPName.Clear();
            edtSurname.Clear();
            edtMedAid.Clear();
            edtRefDoc.Clear();
            edtBloodType.Clear();
            edtAllergies.Clear();
            edtVaccine.Clear();
            cbxHadCovid.Checked = false;
        }

        private void setPatientDetails(info i)
        {
            string strID = edtPID.Text;
            string strFirstName = edtPName.Text;
            string strSurname = edtSurname.Text;
            string strMedAid = edtMedAid.Text;
            string strRefDoc = edtRefDoc.Text;
            char cBloodType = edtBloodType.Text[0];
            string strAllergies = edtAllergies.Text;
            string strVaccine = edtVaccine.Text;
            bool bHadCovid = cbxHadCovid.Checked;

            i.AddPatient(strID, strMedAid, strFirstName, strSurname, strRefDoc, cBloodType, strAllergies, bHadCovid, strVaccine);
        }
    }
}
