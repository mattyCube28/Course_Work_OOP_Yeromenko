using System.Drawing.Text;
using System.Text.Json;

namespace Course_Work_OOP_Yeromenko
{
    public partial class Form1 : Form
    {
        private List<Criminal> criminals = new List<Criminal>();
        private List<Gang> gangs = new List<Gang>();

        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromFile();
            RefreshCards();
            flpCriminals.BorderStyle = BorderStyle.FixedSingle;
        }

        private void SaveToFile()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve
            
            };
            string json = JsonSerializer.Serialize(criminals, options);
            File.WriteAllText("criminals.json", json);

        }
        private void LoadFromFile()
        {
            if(File.Exists("criminals.json"))
            {
                string json = File.ReadAllText("criminals.json");
                var options = new JsonSerializerOptions
                { 
                    ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve


                
                };
                criminals = JsonSerializer.Deserialize<List<Criminal>>(json, options) ?? new List<Criminal>();

            }
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
            if(criminalForm.ShowDialog() == DialogResult.OK)
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
            foreach(var criminal in criminals)
            {
                var card = new CriminalCard(criminal);
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
            if(flpCriminals.Controls.Count == 0)
            {
                return;
            }
        }
        
    }
}
