using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Course_Work_OOP_Yeromenko
{
    public partial class CriminalForm : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Criminal CriminalData { get; private set; }
        private List<string> gangs;
        private bool isEditMode;
        public CriminalForm(List<string> gangs)
        {
            InitializeComponent();
            this.gangs = gangs;


            cmbProfession.Items.AddRange(new string[]
            {
        "Terrorist",
        "Hacker",
        "Murderer",
        "Rapist",
        "Robber",
        "Hitman",
        "Fraudster",
        "Drugdealer",
        "Kidnapper"

             });


        }

        public CriminalForm(List<string> gangs, Criminal criminalToEdit) : this(gangs)
        {
            isEditMode = true;
            this.CriminalData = criminalToEdit;
            FillFields(criminalToEdit);
        }
        public void FillFields(Criminal c)
        {
            txtLastName.Text = c.LastName;
            txtFirstName.Text = c.FirstName;
            txtNickname.Text = c.Nickname;
            txtHeight.Text = c.Height.ToString();
            txtHairColor.Text = c.HairColor;
            txtEyeColor.Text = c.EyeColor;
            txtCitizenship.Text = c.Citizenship;
            txtDistinctiveMarks.Text = c.DistinctiveMarks;
            txtBirthPlace.Text = c.BirthPlace;
            dtpBirthDate.Value = c.BirthDate;
            txtLastAddress.Text = c.LastAddress;
            txtLanguages.Text = c.Languages;
            cmbProfession.SelectedItem = c.CriminalProfession;
            txtCaseStatus.Text = c.CaseStatus;
            txtGang.Text = c.GangName;

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                string.IsNullOrWhiteSpace(txtLastName.Text) &&
                string.IsNullOrWhiteSpace(txtNickname.Text) &&
                string.IsNullOrWhiteSpace(txtHeight.Text) &&
                string.IsNullOrWhiteSpace(txtHairColor.Text) &&
                string.IsNullOrWhiteSpace(txtEyeColor.Text) &&
                string.IsNullOrWhiteSpace(txtCitizenship.Text) &&
                string.IsNullOrWhiteSpace(txtDistinctiveMarks.Text) &&
                string.IsNullOrWhiteSpace(txtBirthPlace.Text) &&
                string.IsNullOrWhiteSpace(txtLastAddress.Text) &&
                string.IsNullOrWhiteSpace(txtLanguages.Text) &&
                cmbProfession.SelectedIndex == -1)
            {

                MessageBox.Show("Please, fill the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbProfession.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a profession before saving.",
                    "Missing Profession",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (CriminalData == null)
            {
                switch (cmbProfession.SelectedItem.ToString())
                {
                    case "Terrorist":
                        CriminalData = new Terrorist();
                        break;
                    case "Hacker":
                        CriminalData = new Hacker();
                        break;
                    case "Murderer":
                        CriminalData = new Murderer();
                        break;
                    case "Rapist":
                        CriminalData = new Rapist();
                        break;
                    case "Robber":
                        CriminalData = new Robber();
                        break;
                    case "Hitman":
                        CriminalData = new Hitman();
                        break;
                    case "Fraudster":
                        CriminalData = new Fraudster();
                        break;
                    case "Drugdealer":
                        CriminalData = new DrugDealer();
                        break;
                    case "Kidnapper":
                        CriminalData = new Kidnapper();
                        break;
                    default:
                        CriminalData = new Criminal();
                        break;
                }

            }
            if (CriminalData == null)
            {
                CriminalData = new Criminal();
            }
            CriminalData.LastName = txtLastName.Text;
            CriminalData.FirstName = txtFirstName.Text;
            CriminalData.Nickname = txtNickname.Text;
            CriminalData.Height = int.TryParse(txtHeight.Text, out int h) ? h : 0;
            CriminalData.HairColor = txtHairColor.Text;
            CriminalData.EyeColor = txtEyeColor.Text;
            CriminalData.Citizenship = txtCitizenship.Text;
            CriminalData.DistinctiveMarks = txtDistinctiveMarks.Text;
            CriminalData.BirthPlace = txtBirthPlace.Text;
            CriminalData.BirthDate = dtpBirthDate.Value;
            CriminalData.LastAddress = txtLastAddress.Text;
            CriminalData.Languages = txtLanguages.Text;
            CriminalData.CaseStatus = txtCaseStatus.Text;
            CriminalData.GangName = txtGang.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
