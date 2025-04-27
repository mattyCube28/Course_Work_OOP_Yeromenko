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
        }
        private void ShowInfo()
        {
            lblName.Text = $"Name: {_criminal.FirstName}";
            lblLastName.Text = $"Last name: {_criminal.LastName}";
            lblNickname.Text = $"Nickname: {_criminal.Nickname}";
            lblCriminalProfession.Text = $"Profession: {_criminal.CriminalProfession}";
            lblBirthDate.Text = $"Birth date: {_criminal.BirthDate.ToShortDateString()}";
            lblHeight.Text = $"Height: {_criminal.Height}";
            lblEyeColor.Text = $"Eye color: {_criminal.EyeColor}";
            lblHairColor.Text = $"Hair color: {_criminal.HairColor}";
            lblCitizenship.Text = $"Citizenship: {_criminal.Citizenship}";
            lblBirthPlace.Text = $"Birth place: {_criminal.BirthPlace}";
            lblLastAddress.Text = $"Last adress: {_criminal.LastAddress}";
            lblDistinctiveMarks.Text = $"Distinctive marks: {_criminal.DistinctiveMarks}";
            lblLanguages.Text = $"Languages: {_criminal.Languages}";
            lblCaseStatus.Text = $"Case status: {_criminal.CaseStatus}";
            lblGang.Text = $"Gang: {_criminal.Gang?.Name}";

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
    }
}
