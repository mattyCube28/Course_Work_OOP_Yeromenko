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
            btnSearch = new Button();
            txtSearch = new TextBox();
            flpCriminals = new FlowLayoutPanel();
            btnAdd = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(flpCriminals);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 9F);
            panel1.Location = new Point(55, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 516);
            panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(941, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(131, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(771, 31);
            txtSearch.TabIndex = 10;
            // 
            // flpCriminals
            // 
            flpCriminals.AutoScroll = true;
            flpCriminals.BackColor = SystemColors.ActiveCaption;
            flpCriminals.Location = new Point(59, 92);
            flpCriminals.Name = "flpCriminals";
            flpCriminals.Size = new Size(979, 352);
            flpCriminals.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.Location = new Point(488, 467);
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
            label1.Location = new Point(3, 21);
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
            ClientSize = new Size(1192, 576);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btnAdd;
        private FlowLayoutPanel flpCriminals;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
