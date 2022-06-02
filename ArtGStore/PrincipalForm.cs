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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        void VerificarLogin()
        {
            if (Sessao.UsuarioLogado == null)
            {
                categoriasButton.Enabled = false;
                jogosButton.Enabled = false;
                usuarioButton.Enabled = false;
                assinaturasButton.Enabled = false;
            }
            else
            {

                entrarButton.Text = "Sair";

                categoriasButton.Enabled = Sessao.UsuarioLogado.AcessaCategorias;
                jogosButton.Enabled = Sessao.UsuarioLogado.AcessaProdutos;
                usuarioButton.Enabled = Sessao.UsuarioLogado.AcessaUsuarios;

                categoriasButton.Enabled = Sessao.UsuarioLogado.AcessaCategorias;
                jogosButton.Enabled = Sessao.UsuarioLogado.AcessaProdutos;
                usuarioButton.Enabled = Sessao.UsuarioLogado.AcessaUsuarios;
                assinaturasButton.Enabled = Sessao.UsuarioLogado.AcessaAssinaturas;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            Sessao.UsuarioLogado = null;
            VerificarLogin();

            new LoginForm().ShowDialog();

            VerificarLogin();
        }

        private void categoriasButton_Click(object sender, EventArgs e)
        {
            new CategoriasForm().ShowDialog();
        }

        private void produtosButton_Click(object sender, EventArgs e)
        {
            new ProdutosForm().ShowDialog();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            new UsuariosForm().ShowDialog();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }


        private void PrincipalForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
             if (
             MessageBox.Show(
             "Deseja fechar o sistema?",
             ProductName,
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
             {
             e.Cancel = true;
             } 
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SobreForm().ShowDialog();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void assinaturasButton_Click(object sender, EventArgs e)
        {
            new AssinaturasForm().ShowDialog();
        }
    }
}
