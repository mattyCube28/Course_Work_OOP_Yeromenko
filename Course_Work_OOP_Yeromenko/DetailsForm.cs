using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_OOP_Yeromenko
{
    public partial class DetailsForm : Form
    {
        private Criminal _criminal;
        private string _role;
        public DetailsForm(Criminal criminal, string role)
        {
            InitializeComponent();

            _criminal = criminal;
            _role = role;
            PopulateProfessionComboBox();
            ShowInfo();
            SetFieldsEditable(false);
            if (_role == "User")
            {
                btnSave.Visible = false;
                btnEdit.Visible = false;
            }
        }
        private void ShowInfo()
        {
            txtLastName.Text = _criminal.LastName;
            txtName.Text = _criminal.FirstName;
            txtNickname.Text = _criminal.Nickname;
            txtHeight.Text = _criminal.Height.ToString();
            txtHairColor.Text = _criminal.HairColor;
            txtEyeColor.Text = _criminal.EyeColor;
            txtCitizenship.Text = _criminal.Citizenship;
            txtDistinctiveMarks.Text = _criminal.DistinctiveMarks;
            txtBirthPlace.Text = _criminal.BirthPlace;
            dtpBirthDate.Text = _criminal.BirthDate.ToShortDateString();
            txtLastAddress.Text = _criminal.LastAddress;
            txtLanguages.Text = _criminal.Languages;

            if (cmbProfession.Items.Contains(_criminal.CriminalProfession))
            {
                cmbProfession.SelectedItem = _criminal.CriminalProfession;
            }
            else
            {
                cmbProfession.Text = _criminal.CriminalProfession;
            }

            txtCaseStatus.Text = _criminal.CaseStatus;
            txtGang.Text = _criminal.GangName;

        }

        private void PopulateProfessionComboBox()
        {
            cmbProfession.Items.Clear();
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

        private void SetFieldsEditable(bool editable)
        {
            txtLastName.ReadOnly = !editable;
            txtName.ReadOnly = !editable;
            txtNickname.ReadOnly = !editable;
            txtHeight.ReadOnly = !editable;
            txtHairColor.ReadOnly = !editable;
            txtEyeColor.ReadOnly = !editable;
            txtCitizenship.ReadOnly = !editable;
            txtDistinctiveMarks.ReadOnly = !editable;
            txtBirthPlace.ReadOnly = !editable;
            dtpBirthDate.Enabled = editable;
            txtLastAddress.ReadOnly = !editable;
            txtLanguages.ReadOnly = !editable;
            cmbProfession.Enabled = editable;
            txtCaseStatus.ReadOnly = !editable;
            txtGang.ReadOnly = !editable;
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetFieldsEditable(true);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            _criminal.FirstName = txtName.Text;
            _criminal.LastName = txtLastName.Text;
            _criminal.Nickname = txtNickname.Text;
            _criminal.Height = int.TryParse(txtHeight.Text, out var height) ? height : _criminal.Height;
            _criminal.HairColor = txtHairColor.Text;
            _criminal.EyeColor = txtEyeColor.Text;
            _criminal.Citizenship = txtCitizenship.Text;
            _criminal.DistinctiveMarks = txtDistinctiveMarks.Text;
            _criminal.BirthPlace = txtBirthPlace.Text;
            _criminal.BirthDate = DateTime.TryParse(dtpBirthDate.Text, out var birthDate) ? birthDate : _criminal.BirthDate;
            _criminal.LastAddress = txtLastAddress.Text;
            _criminal.Languages = txtLanguages.Text;
            _criminal.CriminalProfession = cmbProfession.Text;
            _criminal.CaseStatus = txtCaseStatus.Text;
            _criminal.GangName = txtGang.Text;

            SetFieldsReadOnly();
            
            this.DialogResult = DialogResult.OK;
            
        }
        private void SetFieldsReadOnly()
        {
            txtLastName.ReadOnly = true;
            txtName.ReadOnly = true;
            txtNickname.ReadOnly = true;
            txtHeight.ReadOnly = true;
            txtHairColor.ReadOnly = true;
            txtEyeColor.ReadOnly = true;
            txtCitizenship.ReadOnly = true;
            txtDistinctiveMarks.ReadOnly = true;
            txtBirthPlace.ReadOnly = true;
            dtpBirthDate.Enabled = true;
            txtLastAddress.ReadOnly = true;
            txtLanguages.ReadOnly = true;
            cmbProfession.Enabled = false;
            txtCaseStatus.ReadOnly = true;
            txtGang.ReadOnly = true;
        }
    }
}
