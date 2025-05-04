using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_OOP_Yeromenko
{
    public partial class LoginForm : Form
    {

        private List<User> users;
        public LoginForm()
        {
            InitializeComponent();
            users = new List<User>
            {
                new User { Username = "admin", Password = "AD", Role = "Admin" },
                new User { Username = "user", Password = "US", Role = "User" }
            };
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\Interpol.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text;
            string password = txtPassword.Text;

            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                var mainForm = new Form1(user.Role);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Невірне ім'я користувача або пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
