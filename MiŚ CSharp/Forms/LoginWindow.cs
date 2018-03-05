using MiŚ.UI.Forms;
using MiŚ.Core.User;
using System;
using System.Windows.Forms;

namespace MiŚ.UI
{
    public partial class LoginWindow : Form
    {
        private String username;

        private String password;

        private readonly String errorLogin = "Podano nieprawidłowe dane logowania!";

        private readonly String errorCaption = "Błąd logowania";


        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginPressed(object sender, EventArgs e)
        {
            username = loginUsernameText.Text;
            password = loginPasswordText.Text;
            //TODO podpiąc bazę danych
            if (username == "gówno" && password == "sraka")
            {
                User user = new User(username, password);
                MainWindow mainWindow = new MainWindow(user);
                mainWindow.ShowDialog();
                this.Close();
            }
            else MessageBox.Show(errorLogin, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
