using System.Drawing.Text;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Course_Work_OOP_Yeromenko
{
    public partial class Form1 : Form
    {


        private List<Criminal> criminals = new List<Criminal>();
        private List<string> gangs = new List<string>();
        private string _role;

        public Form1(string role)
        {
            InitializeComponent();
            _role = role;
        }
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            LoadFromFile();
            RefreshCards();


            flpCriminals.BorderStyle = BorderStyle.FixedSingle;

            if (_role == "User")
            {
                btnAdd.Visible = false;

            }
        }



        private void SaveToFile()
        {
            var options = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All

            };
            string json = JsonConvert.SerializeObject(criminals, options);
            File.WriteAllText("criminals.json", json);

        }


        private void LoadFromFile()
        {
            if (File.Exists("criminals.json"))
            {
                string json = File.ReadAllText("criminals.json");
                var options = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All

                };
                criminals = JsonConvert.DeserializeObject<List<Criminal>>(json, options) ?? new List<Criminal>();

            }
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

            var filteredCriminals = criminals.Where(c =>
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
            foreach (var criminal in filteredCriminals)
            {
                var card = new CriminalCard(criminal, _role);
                card.CriminalUpdated += CriminalCard_CriminalUpdated;
                card.DeleteRequested += (s, e) => DeleteCriminal(criminal);
                flpCriminals.Controls.Add(card);
            }
        }



        private void FilterByProperties()
        {


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
            var filtered = criminals.Where(c =>
                (string.IsNullOrWhiteSpace(txtFirstName.Text) || c.FirstName.Contains(txtFirstName.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtLastName.Text) || c.LastName.Contains(txtLastName.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtNickname.Text) || c.Nickname.Contains(txtNickname.Text, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(txtHeight.Text) || c.Height.ToString().Contains(txtHeight.Text)) &&
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var criminalForm = new CriminalForm(gangs);
            if (criminalForm.ShowDialog() == DialogResult.OK)
            {
                Criminal newCriminal = criminalForm.CriminalData;
                criminals.Add(newCriminal);
                RefreshCards();
                SaveToFile();
            }

        }
        private void RefreshCards()
        {
            flpCriminals.Controls.Clear();
            foreach (var criminal in criminals)
            {
                var card = new CriminalCard(criminal, _role);
                card.CriminalUpdated += CriminalCard_CriminalUpdated;
                card.DeleteRequested += (s, e) => DeleteCriminal(criminal);
                flpCriminals.Controls.Add(card);
            }

        }


        private void CriminalCard_CriminalUpdated(object sender, EventArgs e)
        {

            SaveToFile();
            RefreshCards();

        }

        private void DeleteCriminal(Criminal criminal)
        {
            criminals.Remove(criminal);
            RefreshCards();
            SaveToFile();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (flpCriminals.Controls.Count == 0)
            {
                return;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            LoadFromFile();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            FilterByProperties();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
