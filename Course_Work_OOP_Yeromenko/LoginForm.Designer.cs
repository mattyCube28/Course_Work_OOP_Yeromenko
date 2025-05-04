namespace Course_Work_OOP_Yeromenko
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(301, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 304);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 447);
            label1.Name = "label1";
            label1.Size = new Size(89, 33);
            label1.TabIndex = 1;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(126, 549);
            label2.Name = "label2";
            label2.Size = new Size(136, 33);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(301, 450);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(440, 31);
            txtLogin.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(301, 549);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(440, 31);
            txtPassword.TabIndex = 4;
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Sitka Small", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnLogIn.Location = new Point(439, 631);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(140, 55);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 698);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogIn;
    }
}