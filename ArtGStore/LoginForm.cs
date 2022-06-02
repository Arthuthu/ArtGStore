using ArGStore.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void senhaLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelarLoginButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void entrarLoginButton_Click(object sender, EventArgs e)
        {
            Sessao.UsuarioLogado = new UsuarioDAO().Login(usuarioTextBox.Text, senhaTextBox.Text);

            if (Sessao.UsuarioLogado == null)
            {
                usuarioTextBox.Focus();
                senhaTextBox.Clear();

                MessageBox.Show("Usuário ou senha inválido!",
                    ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            else if (Sessao.UsuarioLogado.Ativo == false)
            {
                Sessao.UsuarioLogado = null;

                MessageBox.Show("O usuário está inativo. Procure o RH.",
                 ProductName,
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
            }

            //ArtGStore.Properties.Settings.Default.email = usuarioTextBox.Text;
            ArtGStore.Properties.Settings.Default.Save();

            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
