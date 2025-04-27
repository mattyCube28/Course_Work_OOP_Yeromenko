using System.Drawing.Text;

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
            //LoadFromFile();
            RefreshCards();
            flpCriminals.BorderStyle = BorderStyle.FixedSingle;
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
            }
        }
        private void RefreshCards()
        {
            flpCriminals.Controls.Clear();
            foreach(var criminal in criminals)
            {
                var card = new CriminalCard(criminal);
                flpCriminals.Controls.Add(card);
            }
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
