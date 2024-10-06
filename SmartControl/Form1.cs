namespace SmartControl
{
    public partial class Form1 : Form
    {
        private UserRepository userRepository = new UserRepository();

        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Este metodo se encargara de hacer login
         */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Este if verifica que se haya ingresado un usuario y una password, en caso de que de no, se le mostrara un mensaje al usuario
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Debes agregar la contrasena y password");
            }
            else
            {
                /*
                 * En caso de que se haya ingresado un usuario y password, llamamos el metodo login que retorna un User
                 */
                User user = Login(txtUsername.Text, txtPassword.Text);

                //Verificamos que el usuario no sea null, osea que exista el usuario
                if (user != null)
                {
                    //Desplegamos el formulario de las transacciones y ocultamos este
                    SmartControlForm smartControlForm = new SmartControlForm();
                    smartControlForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta!");
                }
            }
        }

        //Este metodo llama al metodo login del repositorio (lugar donde estaremos interactuando con la BD), y retornamos el usuario encontrado en la BD
        private User Login(string username, string password)
        {
            User user = userRepository.Login(username, password);
            return user;
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
