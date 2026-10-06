using Firebase.Auth;
using Firebase.Auth.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class IniciarSesionView : Form
    {
        FirebaseAuthClient? firebaseAuthClient;
        int intentos = 0;
        public IniciarSesionView()
        {
            InitializeComponent();
            ConfiguracionFirebaseAuthClient();
        }

        private void ConfiguracionFirebaseAuthClient()
        {
            var configAuthClient = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyBYn7__S4mmTj8WnIpxsxNGZKakwN4AsWY",
                AuthDomain = "inventarioisp20ale.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }
            };

            firebaseAuthClient = new FirebaseAuthClient(configAuthClient);
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await firebaseAuthClient!
                            .SignInWithEmailAndPasswordAsync(txtUsuario.Text, txtPassword.Text);
                if (user == null)
                {
                    MessageBox.Show($"Usuario o contraseña incorrectos");
                    intentos++;
                    return;
                }
                MessageBox.Show($"Bienvenido");
                this.Hide();
                var mainView = new MenuPrincipalView();
                mainView.ShowDialog();
                this.Close();

            }
            catch (FirebaseAuthException error)
            {
                MessageBox.Show($"Ha ocurrido un error: {error.Reason}");
                intentos++;
            }
            if (intentos >= 3)
            {
                MessageBox.Show($"Ha superado el número de intentos permitidos");
                Application.Exit();
            }
        }

        private void checkVerPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar= checkVerPassword.Checked ? '\0' : '*';
        }
    }
}
