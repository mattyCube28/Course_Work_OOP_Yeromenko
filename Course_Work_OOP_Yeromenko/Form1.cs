using System.Drawing.Text;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Course_Work_OOP_Yeromenko
{
    public partial class Form1 : Form
    {

        private CriminalCollection criminalCollection = new CriminalCollection();
        private List<Criminal> _lastFilteredCriminals = new List<Criminal>();
        private string _role;

        public Form1(string role)
        {
            InitializeComponent();
            _role = role;
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            RefreshCards();
            flpCriminals.BorderStyle = BorderStyle.FixedSingle;

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

            cmbProfession.SelectedIndex = -1;


            if (_role == "User")
            {
                btnAdd.Visible = false;
            }
            pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\Interpol_(Logo).png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }






        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(query))
            {
                FilterCards(query);
            }
            else
            {
                RefreshCards();
            }
        }



        private void FilterCards(string query)
        {

            _lastFilteredCriminals = criminalCollection.criminals.Where(c =>
        c.FirstName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        c.LastName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        c.Nickname.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        c.Height.ToString().Contains(query) ||
        c.HairColor.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        c.EyeColor.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        c.Citizenship.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        c.DistinctiveMarks.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        c.BirthPlace.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        c.BirthDate.ToShortDateString().Contains(query) ||
        c.LastAddress.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        c.Languages.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        c.CriminalProfession.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        c.CaseStatus.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        (c.GangName != null && c.GangName.Contains(query, StringComparison.OrdinalIgnoreCase))
    ).ToList();

            flpCriminals.Controls.Clear();
            foreach (var criminal in _lastFilteredCriminals)
            {
                var card = new CriminalCard(criminal, _role);
                card.CriminalUpdated += CriminalCard_CriminalUpdated;
                card.DeleteRequested += (s, e) => DeleteCriminal(criminal);
                flpCriminals.Controls.Add(card);
            }
        }



        private void FilterByProperties()
        {

            bool heightFromParsed = int.TryParse(txtHeight.Text, out int heightFrom);
            bool heightToParsed = int.TryParse(txtHeightTo.Text, out int heightTo);
            bool ageFromParsed = int.TryParse(txtAgeFrom.Text, out int ageFrom);
            bool ageToParsed = int.TryParse(txtAgeTo.Text, out int ageTo);

            if (!string.IsNullOrWhiteSpace(txtAgeFrom.Text) && !int.TryParse(txtAgeFrom.Text, out _))
            {
                MessageBox.Show("Please enter a valid number in the 'Age From' field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtAgeTo.Text) && !int.TryParse(txtAgeTo.Text, out _))
            {
                MessageBox.Show("Please enter a valid number in the 'Age To' field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ageFromParsed && ageToParsed && ageFrom > ageTo)
            {
                MessageBox.Show("'Age From' cannot be greater than 'Age To'.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtHeight.Text) && !int.TryParse(txtHeight.Text, out _))
            {
                MessageBox.Show("Please enter a valid number in the 'Height' field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtHeightTo.Text) && !heightToParsed)
            {
                MessageBox.Show("Please enter a valid number in the 'Height To' field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (heightFromParsed && heightToParsed && heightFrom > heightTo)
            {
                MessageBox.Show("'Height From' cannot be greater than 'Height To'.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!IsTextOnly(txtFirstName.Text))
            {
                MessageBox.Show("The 'First Name' field must contain letters only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsTextOnly(txtLastName.Text))
            {
                MessageBox.Show("The 'Last Name' field must contain letters only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsTextOnly(txtNickname.Text))
            {
                MessageBox.Show("The 'Nickname' field must contain letters only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsTextOnly(txtHairColor.Text))
            {
                MessageBox.Show("The 'Hair Color' field must contain letters only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsTextOnly(txtEyeColor.Text))
            {
                MessageBox.Show("The 'Eye Color' field must contain letters only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsTextOnly(txtCitizenship.Text))
            {
                MessageBox.Show("The 'Citizenship' field must contain letters only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsTextOnly(txtBirthPlace.Text))
            {
                MessageBox.Show("The 'Birth Place' field must contain letters only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsTextOnly(txtLanguages.Text))
            {
                MessageBox.Show("The 'Languages' field must contain letters only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var filtered = criminalCollection.criminals.Where(c =>
                (string.IsNullOrWhiteSpace(txtFirstName.Text) || c.FirstName.Contains(txtFirstName.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtLastName.Text) || c.LastName.Contains(txtLastName.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtNickname.Text) || c.Nickname.Contains(txtNickname.Text, StringComparison.OrdinalIgnoreCase)) &&
                (!heightFromParsed || c.Height >= heightFrom) &&
                (!heightToParsed || c.Height <= heightTo) &&
                (string.IsNullOrWhiteSpace(txtHairColor.Text) || c.HairColor.Contains(txtHairColor.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtEyeColor.Text) || c.EyeColor.Contains(txtEyeColor.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtCitizenship.Text) || c.Citizenship.Contains(txtCitizenship.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtMarks.Text) || c.DistinctiveMarks.Contains(txtMarks.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtBirthPlace.Text) || c.BirthPlace.Contains(txtBirthPlace.Text, StringComparison.OrdinalIgnoreCase)) &&
                (ageFromParsed == false || CalculateAge(c.BirthDate) >= ageFrom) &&
                (ageToParsed == false || CalculateAge(c.BirthDate) <= ageTo) &&
                (string.IsNullOrWhiteSpace(txtLastAddress.Text) || c.LastAddress.Contains(txtLastAddress.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtLanguages.Text) || c.Languages.Contains(txtLanguages.Text, StringComparison.OrdinalIgnoreCase)) &&
                (cmbProfession.SelectedIndex == -1 || c.CriminalProfession.Equals(cmbProfession.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtCaseStatus.Text) || c.CaseStatus.Contains(txtCaseStatus.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtGangName.Text) || (c.GangName != null && c.GangName.Contains(txtGangName.Text, StringComparison.OrdinalIgnoreCase)))
            ).ToList();
            _lastFilteredCriminals = filtered;

            flpCriminals.Controls.Clear();
            foreach (var criminal in filtered)
            {
                var card = new CriminalCard(criminal, _role);
                card.CriminalUpdated += CriminalCard_CriminalUpdated;
                card.DeleteRequested += (s, e) => DeleteCriminal(criminal);
                flpCriminals.Controls.Add(card);
            }
        }
        private bool IsTextOnly(string input)
        {
            return string.IsNullOrWhiteSpace(input) || input.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }
        private int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }

        private void ExportFilteredToTextFile(List<Criminal> criminals)
        {
            if (criminals == null || criminals.Count == 0)
            {
                MessageBox.Show("No data to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text File (*.txt)|*.txt";
                saveFileDialog.FileName = "FilteredCriminals.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var c in criminals)
                        {
                            writer.WriteLine($"Name: {c.FirstName} {c.LastName} | Nickname: {c.Nickname} | Profession: {c.CriminalProfession}");
                            writer.WriteLine($"Birth: {c.BirthPlace}, {c.BirthDate.ToShortDateString()} | Citizenship: {c.Citizenship}");
                            writer.WriteLine($"Height: {c.Height}, Hair: {c.HairColor}, Eyes: {c.EyeColor}");
                            writer.WriteLine($"Address: {c.LastAddress} | Case: {c.CaseStatus} | Gang: {c.GangName}");
                            writer.WriteLine($"Languages: {c.Languages}");
                            writer.WriteLine("-------------------------------------------------------------");
                        }
                    }

                    MessageBox.Show("File saved successfully.", "Task complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExportFilteredToTextFile(_lastFilteredCriminals);
        }
        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            FilterByProperties();
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            criminalCollection.Add();
            RefreshCards();
        }
        public void RefreshCards()
        {
            flpCriminals.Controls.Clear();
            foreach (var criminal in criminalCollection.criminals)
            {
                var card = new CriminalCard(criminal, _role);
                card.CriminalUpdated += CriminalCard_CriminalUpdated;
                card.DeleteRequested += (s, e) => DeleteCriminal(criminal);
                flpCriminals.Controls.Add(card);
            }

        }


        private void CriminalCard_CriminalUpdated(object sender, UpdateInfoEventArgs e)
        {

            criminalCollection.Update(e.oldCriminal, e.newCriminal);
            RefreshCards();

        }

        private void DeleteCriminal(Criminal criminal)
        {
            criminalCollection.Remove(criminal);
            RefreshCards();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        
    }
}
