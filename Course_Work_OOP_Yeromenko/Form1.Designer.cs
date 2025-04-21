namespace Course_Work_OOP_Yeromenko
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            btnArchive = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            label1 = new Label();
            dgvCriminals = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtNickname = new TextBox();
            label5 = new Label();
            txtHeight = new TextBox();
            label6 = new Label();
            txtEyeColor = new TextBox();
            label7 = new Label();
            txtHairColor = new TextBox();
            label8 = new Label();
            txtCitizenship = new TextBox();
            label9 = new Label();
            txtBirthPlace = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtLastAdress = new TextBox();
            label12 = new Label();
            txtLanguages = new TextBox();
            label13 = new Label();
            txtProfession = new TextBox();
            label14 = new Label();
            txtCaseStatus = new TextBox();
            dtpBirthDate = new DateTimePicker();
            label15 = new Label();
            txtDistinctiveMarks = new TextBox();
            grpCriminalDetails = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCriminals).BeginInit();
            grpCriminalDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnArchive);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvCriminals);
            panel1.Location = new Point(55, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 400);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(731, 33);
            comboBox1.TabIndex = 2;
            // 
            // btnArchive
            // 
            btnArchive.Location = new Point(757, 357);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(112, 34);
            btnArchive.TabIndex = 8;
            btnArchive.Text = "Архівувати";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(567, 357);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = " Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(374, 357);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(170, 357);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(926, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Знайти";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(33, 15);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 1;
            label1.Text = "Пошук:";
            label1.Click += label1_Click;
            // 
            // dgvCriminals
            // 
            dgvCriminals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCriminals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCriminals.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvCriminals.Location = new Point(33, 58);
            dgvCriminals.Name = "dgvCriminals";
            dgvCriminals.ReadOnly = true;
            dgvCriminals.RowHeadersVisible = false;
            dgvCriminals.RowHeadersWidth = 62;
            dgvCriminals.ScrollBars = ScrollBars.None;
            dgvCriminals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCriminals.Size = new Size(1005, 279);
            dgvCriminals.TabIndex = 3;
            dgvCriminals.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Прізвище";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ім'я";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Злочинна професія";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(33, 38);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 0;
            label2.Text = "Прізвище:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(256, 29);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(757, 37);
            txtLastName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(33, 81);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 2;
            label3.Text = "Ім'я:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(256, 72);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(757, 37);
            txtFirstName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(33, 120);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 4;
            label4.Text = "Кличка:";
            // 
            // txtNickname
            // 
            txtNickname.Font = new Font("Yu Gothic UI", 11F);
            txtNickname.Location = new Point(256, 116);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(757, 37);
            txtNickname.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 10F);
            label5.Location = new Point(33, 162);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 6;
            label5.Text = "Зріст: ";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(256, 159);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(247, 37);
            txtHeight.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 10F);
            label6.Location = new Point(522, 162);
            label6.Name = "label6";
            label6.Size = new Size(118, 28);
            label6.TabIndex = 8;
            label6.Text = "Колір очей:";
            // 
            // txtEyeColor
            // 
            txtEyeColor.Location = new Point(665, 158);
            txtEyeColor.Name = "txtEyeColor";
            txtEyeColor.Size = new Size(348, 37);
            txtEyeColor.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 10F);
            label7.Location = new Point(32, 211);
            label7.Name = "label7";
            label7.Size = new Size(147, 28);
            label7.TabIndex = 10;
            label7.Text = "Колір волосся:";
            // 
            // txtHairColor
            // 
            txtHairColor.Location = new Point(256, 202);
            txtHairColor.Name = "txtHairColor";
            txtHairColor.Size = new Size(757, 37);
            txtHairColor.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 10F);
            label8.Location = new Point(32, 254);
            label8.Name = "label8";
            label8.Size = new Size(146, 28);
            label8.TabIndex = 12;
            label8.Text = "Громадянство:";
            label8.Click += label8_Click;
            // 
            // txtCitizenship
            // 
            txtCitizenship.Location = new Point(256, 245);
            txtCitizenship.Name = "txtCitizenship";
            txtCitizenship.Size = new Size(757, 37);
            txtCitizenship.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI", 10F);
            label9.Location = new Point(32, 293);
            label9.Name = "label9";
            label9.Size = new Size(191, 28);
            label9.TabIndex = 14;
            label9.Text = "Місце народження:";
            label9.Click += label9_Click;
            // 
            // txtBirthPlace
            // 
            txtBirthPlace.Location = new Point(256, 288);
            txtBirthPlace.Name = "txtBirthPlace";
            txtBirthPlace.Size = new Size(757, 37);
            txtBirthPlace.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic UI", 10F);
            label10.Location = new Point(32, 336);
            label10.Name = "label10";
            label10.Size = new Size(179, 28);
            label10.TabIndex = 16;
            label10.Text = "Дата народження:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic UI", 10F);
            label11.Location = new Point(32, 387);
            label11.Name = "label11";
            label11.Size = new Size(206, 28);
            label11.TabIndex = 18;
            label11.Text = "Останнє місце прож.:";
            // 
            // txtLastAdress
            // 
            txtLastAdress.Location = new Point(256, 374);
            txtLastAdress.Name = "txtLastAdress";
            txtLastAdress.Size = new Size(757, 37);
            txtLastAdress.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Yu Gothic UI", 10F);
            label12.Location = new Point(32, 426);
            label12.Name = "label12";
            label12.Size = new Size(125, 28);
            label12.TabIndex = 20;
            label12.Text = "Знання мов:";
            // 
            // txtLanguages
            // 
            txtLanguages.Location = new Point(256, 417);
            txtLanguages.Name = "txtLanguages";
            txtLanguages.Size = new Size(757, 37);
            txtLanguages.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Yu Gothic UI", 10F);
            label13.Location = new Point(32, 469);
            label13.Name = "label13";
            label13.Size = new Size(196, 28);
            label13.TabIndex = 22;
            label13.Text = "Злочинна професія:";
            // 
            // txtProfession
            // 
            txtProfession.Location = new Point(256, 460);
            txtProfession.Name = "txtProfession";
            txtProfession.Size = new Size(757, 37);
            txtProfession.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Yu Gothic UI", 10F);
            label14.Location = new Point(32, 564);
            label14.Name = "label14";
            label14.Size = new Size(144, 28);
            label14.TabIndex = 24;
            label14.Text = "Статус справи:";
            // 
            // txtCaseStatus
            // 
            txtCaseStatus.Location = new Point(256, 555);
            txtCaseStatus.Name = "txtCaseStatus";
            txtCaseStatus.Size = new Size(757, 37);
            txtCaseStatus.TabIndex = 25;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(256, 331);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(757, 37);
            dtpBirthDate.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Yu Gothic UI", 10F);
            label15.Location = new Point(33, 517);
            label15.Name = "label15";
            label15.Size = new Size(198, 28);
            label15.TabIndex = 27;
            label15.Text = "Особливі прикмети:";
            // 
            // txtDistinctiveMarks
            // 
            txtDistinctiveMarks.Location = new Point(256, 508);
            txtDistinctiveMarks.Name = "txtDistinctiveMarks";
            txtDistinctiveMarks.Size = new Size(757, 37);
            txtDistinctiveMarks.TabIndex = 28;
            // 
            // grpCriminalDetails
            // 
            grpCriminalDetails.Controls.Add(txtDistinctiveMarks);
            grpCriminalDetails.Controls.Add(label15);
            grpCriminalDetails.Controls.Add(dtpBirthDate);
            grpCriminalDetails.Controls.Add(txtCaseStatus);
            grpCriminalDetails.Controls.Add(label14);
            grpCriminalDetails.Controls.Add(txtProfession);
            grpCriminalDetails.Controls.Add(label13);
            grpCriminalDetails.Controls.Add(txtLanguages);
            grpCriminalDetails.Controls.Add(label12);
            grpCriminalDetails.Controls.Add(txtLastAdress);
            grpCriminalDetails.Controls.Add(label11);
            grpCriminalDetails.Controls.Add(label10);
            grpCriminalDetails.Controls.Add(txtBirthPlace);
            grpCriminalDetails.Controls.Add(label9);
            grpCriminalDetails.Controls.Add(txtCitizenship);
            grpCriminalDetails.Controls.Add(label8);
            grpCriminalDetails.Controls.Add(txtHairColor);
            grpCriminalDetails.Controls.Add(label7);
            grpCriminalDetails.Controls.Add(txtEyeColor);
            grpCriminalDetails.Controls.Add(label6);
            grpCriminalDetails.Controls.Add(txtHeight);
            grpCriminalDetails.Controls.Add(label5);
            grpCriminalDetails.Controls.Add(txtNickname);
            grpCriminalDetails.Controls.Add(label4);
            grpCriminalDetails.Controls.Add(txtFirstName);
            grpCriminalDetails.Controls.Add(label3);
            grpCriminalDetails.Controls.Add(txtLastName);
            grpCriminalDetails.Controls.Add(label2);
            grpCriminalDetails.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grpCriminalDetails.Location = new Point(55, 427);
            grpCriminalDetails.Name = "grpCriminalDetails";
            grpCriminalDetails.Size = new Size(1094, 611);
            grpCriminalDetails.TabIndex = 2;
            grpCriminalDetails.TabStop = false;
            grpCriminalDetails.Text = "Деталі про злочинця";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 1050);
            Controls.Add(grpCriminalDetails);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCriminals).EndInit();
            grpCriminalDetails.ResumeLayout(false);
            grpCriminalDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btnSearch;
        private DataGridView dgvCriminals;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnArchive;
        private Button btnDelete;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label4;
        private TextBox txtNickname;
        private Label label5;
        private TextBox txtHeight;
        private Label label6;
        private TextBox txtEyeColor;
        private Label label7;
        private TextBox txtHairColor;
        private Label label8;
        private TextBox txtCitizenship;
        private Label label9;
        private TextBox txtBirthPlace;
        private Label label10;
        private Label label11;
        private TextBox txtLastAdress;
        private Label label12;
        private TextBox txtLanguages;
        private Label label13;
        private TextBox txtProfession;
        private Label label14;
        private TextBox txtCaseStatus;
        private DateTimePicker dtpBirthDate;
        private Label label15;
        private TextBox txtDistinctiveMarks;
        private GroupBox grpCriminalDetails;
    }
}
