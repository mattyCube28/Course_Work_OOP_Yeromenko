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
        public DetailsForm(Criminal criminal)
        {
            InitializeComponent();

            _criminal = criminal;
            ShowInfo();
            SetFieldsEditable(false);
        }
        private void ShowInfo()
        {
            txtLastName.Text = _criminal.LastName;
            txtName.Text = _criminal.FirstName;
            txtNickname.Text = _criminal.Nickname;
            txtProfession.Text = _criminal.CriminalProfession;
            dtpBirthDate.Text = _criminal.BirthDate.ToShortDateString();
            txtHeight.Text = _criminal.Height.ToString();
            txtEyeColor.Text = _criminal.EyeColor;
            txtHairColor.Text = _criminal.HairColor;
            txtCitizenship.Text = _criminal.Citizenship;
            txtBirthPlace.Text = _criminal.BirthPlace;
            txtLastAddress.Text = _criminal.LastAddress;
            txtDistinctiveMarks.Text = _criminal.DistinctiveMarks;
            txtLanguages.Text = _criminal.Languages;
            txtCaseStatus.Text = _criminal.CaseStatus;
            cmbGang.Text = _criminal.Gang?.Name;

        }

        private void SetFieldsEditable(bool editable)
        {
            txtName.ReadOnly = !editable;
            txtLastName.ReadOnly = !editable;
            txtNickname.ReadOnly = !editable;
            txtProfession.ReadOnly = !editable;
            txtHeight.ReadOnly = !editable;
            txtEyeColor.ReadOnly = !editable;
            txtHairColor.ReadOnly = !editable;
            txtCitizenship.ReadOnly = !editable;
            txtBirthPlace.ReadOnly = !editable;
            txtLastAddress.ReadOnly = !editable;
            txtDistinctiveMarks.ReadOnly = !editable;
            txtLanguages.ReadOnly = !editable;
            txtCaseStatus.ReadOnly = !editable;
            cmbGang.Enabled = editable;
            dtpBirthDate.Enabled = editable;
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
            txtName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtNickname.ReadOnly = false;
            txtProfession.ReadOnly = false;
            dtpBirthDate.Enabled = false;
            txtHeight.ReadOnly = false;
            txtEyeColor.ReadOnly = false;
            txtHairColor.ReadOnly = false;
            txtCitizenship.ReadOnly = false;
            txtBirthPlace.ReadOnly = false;
            txtLastAddress.ReadOnly = false;
            txtDistinctiveMarks.ReadOnly = false;
            txtLanguages.ReadOnly = false;
            txtCaseStatus.ReadOnly = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _criminal.FirstName = txtName.Text;
            _criminal.LastName = txtLastName.Text;
            _criminal.Nickname = txtNickname.Text;
            _criminal.CriminalProfession = txtProfession.Text;
            _criminal.BirthDate = DateTime.TryParse(dtpBirthDate.Text, out var birthDate) ? birthDate : _criminal.BirthDate;
            _criminal.Height = int.TryParse(txtHeight.Text, out var height) ? height : _criminal.Height;
            _criminal.EyeColor = txtEyeColor.Text;
            _criminal.HairColor = txtHairColor.Text;
            _criminal.Citizenship = txtCitizenship.Text;
            _criminal.BirthPlace = txtBirthPlace.Text;
            _criminal.LastAddress = txtLastAddress.Text;
            _criminal.DistinctiveMarks = txtDistinctiveMarks.Text;
            _criminal.Languages = txtLanguages.Text;
            _criminal.CaseStatus = txtCaseStatus.Text;

            SetFieldsReadOnly();
            
            this.DialogResult = DialogResult.OK;
            
        }
        private void SetFieldsReadOnly()
        {
            txtName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtNickname.ReadOnly = true;
            txtProfession.ReadOnly = true;
            dtpBirthDate.Enabled = true;
            txtHeight.ReadOnly = true;
            txtEyeColor.ReadOnly = true;
            txtHairColor.ReadOnly = true;
            txtCitizenship.ReadOnly = true;
            txtBirthPlace.ReadOnly = true;
            txtLastAddress.ReadOnly = true;
            txtDistinctiveMarks.ReadOnly = true;
            txtLanguages.ReadOnly = true;
            txtCaseStatus.ReadOnly = true;
        }
    }
}
