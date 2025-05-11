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

        private List<User> users = new List<User>();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Role {  get;  set; }
        public LoginForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            users = new List<User>
            {
                new User{ Username = "admin", Password = "admin123", Role = "Admin" },
                new User { Username = "user", Password = "user123", Role = "User" }
            };
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\Interpol.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var user = users.FirstOrDefault(u =>
           u.Username == txtLogin.Text && u.Password == txtPassword.Text);

            if (user != null)
            {
                Role = user.Role;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
