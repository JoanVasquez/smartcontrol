namespace SmartControl
{
    public partial class Form1 : Form
    {
        private UserRepository userRepository = new UserRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Debes agregar la contrasena y password");
            } else
            {
                User user = Login(txtUsername.Text, txtPassword.Text);
                if (user != null)
                {
                    SmartControlForm smartControlForm = new SmartControlForm();
                    smartControlForm.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta!");
                }
            }
        }

        private User Login(string username, string password)
        {
            User user = userRepository.Login(username, password);
            return user;
        }
    }
}
