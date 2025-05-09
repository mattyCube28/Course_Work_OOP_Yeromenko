﻿using System;
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
        public event EventHandler CriminalUpdated;
        public event EventHandler DeleteRequested;
        private Criminal _criminal;
        
        public CriminalCard(Criminal criminal)
        {
            InitializeComponent();
            _criminal = criminal;
            


            lblName.Text = $"Name: {_criminal.FirstName}";
            lblLastName.Text = $"Last name: {_criminal.LastName}";
            lblNickname.Text = $"Nickname: {_criminal.Nickname}";
            lblProfession.Text = $"Profession: {_criminal.CriminalProfession}";
            lblBirthDate.Text = $"Birth date: {_criminal.BirthDate.ToShortDateString()}";

            btnMore.Click += (s, e) =>
            {
                DetailsForm detailsForm = new DetailsForm(_criminal);
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    CriminalUpdated?.Invoke(this, EventArgs.Empty);
                }
            };

            btnDelete.Click += (s, e) =>
            {
                DeleteRequested?.Invoke(this, EventArgs.Empty);
            };

            
        }


        private void CriminalCard_Load(object sender, EventArgs e)
        {
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }
    }
}
