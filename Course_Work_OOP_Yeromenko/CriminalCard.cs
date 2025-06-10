using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_OOP_Yeromenko
{
    public partial class CriminalCard : UserControl
    {
        public delegate void UpdateEventHandler(object updater, UpdateInfoEventArgs updateInfoEventArgs);  
        public event UpdateEventHandler CriminalUpdated;
        public event EventHandler DeleteRequested;
        private Criminal _criminal;
        
        public CriminalCard(Criminal criminal, string role)
        {
            InitializeComponent();
            _criminal = criminal;
            


            lblName.Text = $"Name: {_criminal.FirstName}";
            lblLastName.Text = $"Last name: {_criminal.LastName}";
            lblNickname.Text = $"Nickname: {_criminal.Nickname}";
            lblProfession.Text = $"Cr.Profession: {_criminal.CriminalProfession}";
            lblBirthDate.Text = $"Birth date: {_criminal.BirthDate.ToShortDateString()}";

            btnMore.Click += (s, e) =>
            {
                DetailsForm detailsForm = new DetailsForm(_criminal, role);
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateInfoEventArgs updateInfoEventArgs = new UpdateInfoEventArgs(criminal, _criminal);
                    CriminalUpdated?.Invoke(this, updateInfoEventArgs);
                }
            };

            btnDelete.Click += (s, e) =>
            {
                var result = MessageBox.Show(
                "Are you sure you want to delete?",
                "Confirm Deletion",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
                );
                if (result == DialogResult.OK)
                {
                    DeleteRequested?.Invoke(this, EventArgs.Empty);
                }
            };

            if (role == "User")
            {
                btnDelete.Visible = false;
            }

        }


        private void CriminalCard_Load(object sender, EventArgs e)
        {
            

        }

       
    }
}
