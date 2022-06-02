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
    public partial class ListarUsuariosForm : Form
    {

        int idUsuario = 0;
        public ListarUsuariosForm()
        {
            InitializeComponent();
            Application.DoEvents();
            this.Text = "Novo Cadastro";
            listarUsuariosIDTextBox.Text = "Automático";
            listarUsuariosIDTextBox.TabStop = false;
        }

        public ListarUsuariosForm(int idUsuario)
        {
            InitializeComponent();
            Application.DoEvents();
            this.Text = "Alteração de cadastro";
            this.idUsuario = idUsuario;
            listarUsuariosIDTextBox.TabStop = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listarUsuariosCancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarUsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void ListarUsuariosForm_Shown(object sender, EventArgs e)
        {
            if (idUsuario > 0)
            {
                var assinatura = new UsuarioDAO().BuscarUsuario(idUsuario);

                listarUsuariosIDTextBox.Text = assinatura["ID"].ToString();
                listarUsuariosNomeTextBox.Text = assinatura["Nome"].ToString();
                listarUsuariosEmailTextBox.Text = assinatura["Email"].ToString();
                listarUsuariosSenhaTextBox.Text = assinatura["Senha"].ToString();
                listarUsuarioUsuariosCheckBox.Checked = Convert.ToBoolean(assinatura["AcessaUsuarios"]);
                listarUsuarioJogosCheckBox.Checked = Convert.ToBoolean(assinatura["AcessaProdutos"]);
                listarUsuarioCategoriaCheckBox.Checked = Convert.ToBoolean(assinatura["AcessaCategorias"]);
                listarUsuarioAssinaturasCheckBox.Checked = Convert.ToBoolean(assinatura["AcessaAssinaturas"]);
                listarUsuarioAtivoCheckBox.Checked = Convert.ToBoolean(assinatura["Ativo"]);
            }
        }

        private void listarUsuariosSalvarButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(listarUsuariosNomeTextBox.Text))
            {
                MessageBox.Show("O nome é obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = false;

            if (idUsuario == 0)
            {
                resultado = new UsuarioDAO().InserirUsuario(
                    listarUsuariosNomeTextBox.Text,
                    listarUsuariosEmailTextBox.Text,
                    listarUsuariosSenhaTextBox.Text,
                    listarUsuarioUsuariosCheckBox.Checked,
                    listarUsuarioCategoriaCheckBox.Checked,
                    listarUsuarioJogosCheckBox.Checked,
                    listarUsuarioAtivoCheckBox.Checked,
                    listarUsuarioAssinaturasCheckBox.Checked
                    );

            }
            else
            {
                resultado = new UsuarioDAO().AlterarUsuario(
                    idUsuario,
                    listarUsuariosNomeTextBox.Text,
                    listarUsuariosEmailTextBox.Text,
                    listarUsuariosSenhaTextBox.Text,
                    listarUsuarioUsuariosCheckBox.Checked,
                    listarUsuarioCategoriaCheckBox.Checked,
                    listarUsuarioJogosCheckBox.Checked,
                    listarUsuarioAtivoCheckBox.Checked,
                    listarUsuarioAssinaturasCheckBox.Checked
                    );
            }

            if (resultado)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao gravar dados.");
            }
        }
    }
}
