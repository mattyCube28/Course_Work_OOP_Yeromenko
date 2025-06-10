namespace Course_Work_OOP_Yeromenko
{
    partial class CriminalCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblLastName = new Label();
            lblNickname = new Label();
            lblProfession = new Label();
            lblBirthDate = new Label();
            btnMore = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(25, 65);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(96, 25);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last name:";
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Location = new Point(25, 103);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(94, 25);
            lblNickname.TabIndex = 2;
            lblNickname.Text = "Nickname:";
            // 
            // lblProfession
            // 
            lblProfession.AutoSize = true;
            lblProfession.Location = new Point(25, 138);
            lblProfession.Name = "lblProfession";
            lblProfession.Size = new Size(99, 25);
            lblProfession.TabIndex = 3;
            lblProfession.Text = "Profession:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(25, 175);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(92, 25);
            lblBirthDate.TabIndex = 4;
            lblBirthDate.Text = "Birth date:";
            // 
            // btnMore
            // 
            btnMore.Location = new Point(89, 215);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(112, 34);
            btnMore.TabIndex = 5;
            btnMore.Text = "More";
            btnMore.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(326, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            
            // 
            // CriminalCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnDelete);
            Controls.Add(btnMore);
            Controls.Add(lblBirthDate);
            Controls.Add(lblProfession);
            Controls.Add(lblNickname);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Name = "CriminalCard";
            Size = new Size(550, 262);
            Load += CriminalCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLastName;
        private Label lblNickname;
        private Label lblProfession;
        private Label lblBirthDate;
        private Button btnMore;
        private Button btnDelete;
    }
}
