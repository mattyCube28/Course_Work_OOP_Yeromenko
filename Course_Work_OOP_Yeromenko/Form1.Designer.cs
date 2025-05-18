using System.Runtime.CompilerServices;

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
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            cmbProfession = new ComboBox();
            txtGangName = new TextBox();
            txtCaseStatus = new TextBox();
            txtLanguages = new TextBox();
            txtLastAddress = new TextBox();
            txtAgeTo = new TextBox();
            txtAgeFrom = new TextBox();
            txtBirthPlace = new TextBox();
            txtMarks = new TextBox();
            txtCitizenship = new TextBox();
            txtEyeColor = new TextBox();
            txtHairColor = new TextBox();
            txtHeight = new TextBox();
            txtNickname = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnAdvancedSearch = new Button();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            flpCriminals = new FlowLayoutPanel();
            btnAdd = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(flpCriminals);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 9F);
            panel1.Location = new Point(55, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 782);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1028, 732);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(701, 75);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cmbProfession);
            panel2.Controls.Add(txtGangName);
            panel2.Controls.Add(txtCaseStatus);
            panel2.Controls.Add(txtLanguages);
            panel2.Controls.Add(txtLastAddress);
            panel2.Controls.Add(txtAgeTo);
            panel2.Controls.Add(txtAgeFrom);
            panel2.Controls.Add(txtBirthPlace);
            panel2.Controls.Add(txtMarks);
            panel2.Controls.Add(txtCitizenship);
            panel2.Controls.Add(txtEyeColor);
            panel2.Controls.Add(txtHairColor);
            panel2.Controls.Add(txtHeight);
            panel2.Controls.Add(txtNickname);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(btnAdvancedSearch);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel2.Location = new Point(770, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 696);
            panel2.TabIndex = 13;
            // 
            // cmbProfession
            // 
            cmbProfession.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbProfession.FormattingEnabled = true;
            cmbProfession.Location = new Point(140, 509);
            cmbProfession.Name = "cmbProfession";
            cmbProfession.Size = new Size(207, 33);
            cmbProfession.TabIndex = 47;
            // 
            // txtGangName
            // 
            txtGangName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtGangName.Location = new Point(140, 587);
            txtGangName.Multiline = true;
            txtGangName.Name = "txtGangName";
            txtGangName.Size = new Size(207, 32);
            txtGangName.TabIndex = 46;
            // 
            // txtCaseStatus
            // 
            txtCaseStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtCaseStatus.Location = new Point(140, 547);
            txtCaseStatus.Multiline = true;
            txtCaseStatus.Name = "txtCaseStatus";
            txtCaseStatus.Size = new Size(207, 31);
            txtCaseStatus.TabIndex = 45;
            // 
            // txtLanguages
            // 
            txtLanguages.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLanguages.Location = new Point(140, 478);
            txtLanguages.Multiline = true;
            txtLanguages.Name = "txtLanguages";
            txtLanguages.Size = new Size(207, 28);
            txtLanguages.TabIndex = 43;
            // 
            // txtLastAddress
            // 
            txtLastAddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLastAddress.Location = new Point(140, 445);
            txtLastAddress.Multiline = true;
            txtLastAddress.Name = "txtLastAddress";
            txtLastAddress.Size = new Size(207, 27);
            txtLastAddress.TabIndex = 42;
            // 
            // txtAgeTo
            // 
            txtAgeTo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtAgeTo.Location = new Point(235, 410);
            txtAgeTo.Multiline = true;
            txtAgeTo.Name = "txtAgeTo";
            txtAgeTo.Size = new Size(112, 29);
            txtAgeTo.TabIndex = 41;
            // 
            // txtAgeFrom
            // 
            txtAgeFrom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtAgeFrom.Location = new Point(73, 410);
            txtAgeFrom.Multiline = true;
            txtAgeFrom.Name = "txtAgeFrom";
            txtAgeFrom.Size = new Size(112, 29);
            txtAgeFrom.TabIndex = 40;
            // 
            // txtBirthPlace
            // 
            txtBirthPlace.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBirthPlace.Location = new Point(128, 340);
            txtBirthPlace.Multiline = true;
            txtBirthPlace.Name = "txtBirthPlace";
            txtBirthPlace.Size = new Size(219, 30);
            txtBirthPlace.TabIndex = 39;
            // 
            // txtMarks
            // 
            txtMarks.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtMarks.Location = new Point(164, 302);
            txtMarks.Multiline = true;
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(183, 30);
            txtMarks.TabIndex = 38;
            // 
            // txtCitizenship
            // 
            txtCitizenship.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtCitizenship.Location = new Point(128, 268);
            txtCitizenship.Multiline = true;
            txtCitizenship.Name = "txtCitizenship";
            txtCitizenship.Size = new Size(219, 28);
            txtCitizenship.TabIndex = 37;
            // 
            // txtEyeColor
            // 
            txtEyeColor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtEyeColor.Location = new Point(128, 235);
            txtEyeColor.Multiline = true;
            txtEyeColor.Name = "txtEyeColor";
            txtEyeColor.Size = new Size(219, 28);
            txtEyeColor.TabIndex = 36;
            // 
            // txtHairColor
            // 
            txtHairColor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtHairColor.Location = new Point(128, 199);
            txtHairColor.Multiline = true;
            txtHairColor.Name = "txtHairColor";
            txtHairColor.Size = new Size(219, 30);
            txtHairColor.TabIndex = 35;
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtHeight.Location = new Point(128, 163);
            txtHeight.Multiline = true;
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(219, 30);
            txtHeight.TabIndex = 34;
            // 
            // txtNickname
            // 
            txtNickname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNickname.Location = new Point(128, 128);
            txtNickname.Multiline = true;
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(219, 28);
            txtNickname.TabIndex = 33;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLastName.Location = new Point(128, 89);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(219, 29);
            txtLastName.TabIndex = 32;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtFirstName.Location = new Point(128, 53);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(219, 28);
            txtFirstName.TabIndex = 31;
            // 
            // btnAdvancedSearch
            // 
            btnAdvancedSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdvancedSearch.Location = new Point(140, 645);
            btnAdvancedSearch.Name = "btnAdvancedSearch";
            btnAdvancedSearch.Size = new Size(112, 34);
            btnAdvancedSearch.TabIndex = 30;
            btnAdvancedSearch.Text = "Search";
            btnAdvancedSearch.UseVisualStyleBackColor = true;
            btnAdvancedSearch.Click += btnAdvancedSearch_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label19.Location = new Point(19, 594);
            label19.Name = "label19";
            label19.Size = new Size(58, 25);
            label19.TabIndex = 29;
            label19.Text = "Gang:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label18.Location = new Point(17, 553);
            label18.Name = "label18";
            label18.Size = new Size(106, 25);
            label18.TabIndex = 28;
            label18.Text = "Case Status:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label17.Location = new Point(17, 516);
            label17.Name = "label17";
            label17.Size = new Size(125, 25);
            label17.TabIndex = 27;
            label17.Text = "Cr. Profession:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label16.Location = new Point(15, 481);
            label16.Name = "label16";
            label16.Size = new Size(101, 25);
            label16.TabIndex = 26;
            label16.Text = "Languages:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label15.Location = new Point(17, 450);
            label15.Name = "label15";
            label15.Size = new Size(117, 25);
            label15.TabIndex = 25;
            label15.Text = "Last Address:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label14.Location = new Point(203, 418);
            label14.Name = "label14";
            label14.Size = new Size(28, 21);
            label14.TabIndex = 24;
            label14.Text = "To:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.Location = new Point(17, 418);
            label13.Name = "label13";
            label13.Size = new Size(50, 21);
            label13.TabIndex = 23;
            label13.Text = "From:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label12.Location = new Point(164, 377);
            label12.Name = "label12";
            label12.Size = new Size(57, 30);
            label12.TabIndex = 22;
            label12.Text = "Age:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(17, 345);
            label11.Name = "label11";
            label11.Size = new Size(97, 25);
            label11.TabIndex = 21;
            label11.Text = "Birth Place:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(15, 307);
            label10.Name = "label10";
            label10.Size = new Size(150, 25);
            label10.TabIndex = 20;
            label10.Text = "Distinctive Marks:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(17, 271);
            label9.Name = "label9";
            label9.Size = new Size(101, 25);
            label9.TabIndex = 19;
            label9.Text = "Citizenship:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(17, 238);
            label8.Name = "label8";
            label8.Size = new Size(91, 25);
            label8.TabIndex = 18;
            label8.Text = "Eye Color:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(17, 204);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 17;
            label7.Text = "Hair Color:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(19, 170);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 16;
            label6.Text = "Height:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(17, 135);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 15;
            label5.Text = "Nickname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(17, 95);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 14;
            label4.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(17, 57);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 13;
            label3.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(76, 8);
            label2.Name = "label2";
            label2.Size = new Size(202, 29);
            label2.TabIndex = 12;
            label2.Text = "Advanced Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(652, 108);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(150, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(494, 31);
            txtSearch.TabIndex = 10;
            // 
            // flpCriminals
            // 
            flpCriminals.AutoScroll = true;
            flpCriminals.BackColor = SystemColors.ActiveCaption;
            flpCriminals.Location = new Point(48, 177);
            flpCriminals.Name = "flpCriminals";
            flpCriminals.Size = new Size(668, 346);
            flpCriminals.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.Location = new Point(317, 561);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F);
            label1.Location = new Point(15, 117);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 1;
            label1.Text = "Type to search:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 818);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btnAdd;
        private FlowLayoutPanel flpCriminals;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panel2;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox txtFirstName;
        private Button btnAdvancedSearch;
        private Label label19;
        private TextBox txtHeight;
        private TextBox txtNickname;
        private TextBox txtLastName;
        private TextBox txtBirthPlace;
        private TextBox txtMarks;
        private TextBox txtCitizenship;
        private TextBox txtEyeColor;
        private TextBox txtHairColor;
        private TextBox txtLastAddress;
        private TextBox txtAgeTo;
        private TextBox txtAgeFrom;
        private ComboBox cmbProfession;
        private TextBox txtGangName;
        private TextBox txtCaseStatus;
        private TextBox txtLanguages;
        private PictureBox pictureBox1;
        private Button btnExit;
    }
}
