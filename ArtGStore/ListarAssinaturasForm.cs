using ArtGStore.Negocios;
using System;
using System.Windows.Forms;

namespace ArtGStore
{
    public partial class ListarAssinaturasForm : Form
    {

        int idAssinatura = 0;
        public ListarAssinaturasForm()
        {
            InitializeComponent();
            Application.DoEvents();
            this.Text = "Novo Cadastro";
            listarAssinaturasTextBoxID.Text = "Automático";
            listarAssinaturasTextBoxID.TabStop = false;
        }

        public ListarAssinaturasForm(int idAssinatura)
        {
            InitializeComponent();
            Application.DoEvents();
            this.Text = "Alteração de assinatura";
            this.idAssinatura = idAssinatura;
            listarAssinaturasTextBoxID.TabStop = false;
        }

        private void listarAssinaturasFecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarAssinaturasForm_Load(object sender, EventArgs e)
        {

        }

        private void ListarAssinaturasForm_Shown(object sender, EventArgs e)
        {
            if (idAssinatura > 0)
            {
                var assinatura = new AssinaturaDAO().BuscarAssinatura(idAssinatura);

                listarAssinaturasTextBoxID.Text = assinatura["ID"].ToString();
                listarAssinaturasTextBoxNome.Text = assinatura["Nome"].ToString();
                listarAssinaturasNumericUpDownQuantidade.Value = Convert.ToInt32(assinatura["Quantidade"]);
                listarAssinaturasNumericUpDowValorUnitario.Value = Convert.ToDecimal(assinatura["ValorUnitario"]);
                listarAssinaturasNumericUpDowValorTotal.Value = Convert.ToDecimal(listarAssinaturasNumericUpDownQuantidade.Value * listarAssinaturasNumericUpDowValorUnitario.Value);
            }
        }

        private void listarAssinaturasSalvarButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(listarAssinaturasTextBoxNome.Text))
            {
                MessageBox.Show("O nome é obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = false;

            if (idAssinatura == 0)
            {
                resultado = new AssinaturaDAO().Inserir(
                    listarAssinaturasTextBoxNome.Text,
                    Convert.ToInt32(listarAssinaturasNumericUpDownQuantidade.Value),
                    Convert.ToDecimal(listarAssinaturasNumericUpDowValorUnitario.Value));
            }
            else
            {
                resultado = new AssinaturaDAO().Alterar(
                   idAssinatura,
                   listarAssinaturasTextBoxNome.Text,
                   Convert.ToInt32(listarAssinaturasNumericUpDownQuantidade.Value),
                   Convert.ToDecimal(listarAssinaturasNumericUpDowValorUnitario.Value));
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
