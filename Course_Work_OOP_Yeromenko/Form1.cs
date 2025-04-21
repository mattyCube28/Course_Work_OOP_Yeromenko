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
            SeedData();
            RefreshGrid();
        }
        private void SeedData()
        {
            gangs.Add(new Gang { Name = "La Cosa Nostra", Country = "²òàë³ÿ" });
            gangs.Add(new Gang { Name = "Yakudza", Country = "ßïîí³ÿ" });
        }
        private void RefreshGrid()
        {
            dgvCriminals.DataSource = null;
            dgvCriminals.DataSource = criminals;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new CriminalForm(gangs);
            if (form.ShowDialog() == DialogResult.OK)
            {
                criminals.Add(form.CriminalData);
                RefreshGrid();
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
            if(dgvCriminals.CurrentRow == null) return;
            int  index = dgvCriminals.CurrentRow.Index;
            var selected = criminals[index];
            var form = new CriminalForm(gangs, selected);
            if(form.ShowDialog() == DialogResult.OK)
            {
                criminals[index] = form.CriminalData;
                RefreshGrid();
            }
        }
    }
}
