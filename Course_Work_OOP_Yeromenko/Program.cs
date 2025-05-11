namespace Course_Work_OOP_Yeromenko
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    string role = loginForm.Role;
                    Application.Run(new Form1(role));
                }
                else
                {

                    Application.Exit();
                }
                
            }
        }
    }
}