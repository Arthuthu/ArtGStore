using ArtGStore.Negocios;
using System;
using System.Windows.Forms;

namespace ArtGStore
{
    public partial class ListarJogosForm : Form
    {
        int idProduto = 0;
        public ListarJogosForm()
        {
            InitializeComponent();
            Application.DoEvents();
            this.Text = "Novo Cadastro";
            idListarJogosTextBox.Text = "Automático";
            idListarJogosTextBox.TabStop = false;
        }
        public ListarJogosForm(int idProduto)
        {
            InitializeComponent();
            Application.DoEvents();
            this.Text = "Alteração de produto";
            this.idProduto = idProduto;
            idListarJogosTextBox.TabStop = false;
        }

        private void ListarJogosForm_Shown(object sender, EventArgs e)
        {
            var lista = new CategoriaDAO().Listar();
            categoriaComboBox.DisplayMember = "Nome";
            categoriaComboBox.ValueMember = "ID";
            categoriaComboBox.DataSource = lista;

            if (idProduto > 0)
            {
                var produto = new ProdutoDAO().Buscar(idProduto);

                idListarJogosTextBox.Text = produto["ID"].ToString();
                categoriaComboBox.SelectedValue = Convert.ToInt32(produto["IDCategoria"]);
                nomeListarJogosTextBox.Text = produto["Nome"].ToString();
                quantidadeNumericUpDown.Value = Convert.ToInt32(produto["Quantidade"]);
                valorUnitarioNumericUpDown.Value = Convert.ToDecimal(produto["ValorUnitario"]);
                valorTotalNumericUpDown.Value = Convert.ToDecimal(quantidadeNumericUpDown.Value * valorUnitarioNumericUpDown.Value);
            }
        }





        private void idListarJogosLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelarListarJogosButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ListarJogosForm_Load(object sender, EventArgs e)
        {

        }

        private void salvarListarJogosButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nomeListarJogosTextBox.Text))
            {
                MessageBox.Show("O nome é obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = false;

            if (idProduto == 0)
            {
                resultado = new ProdutoDAO().Inserir(
                    Convert.ToInt32(categoriaComboBox.SelectedValue),
                    nomeListarJogosTextBox.Text,
                    Convert.ToInt32(quantidadeNumericUpDown.Value),
                    Convert.ToDecimal(valorUnitarioNumericUpDown.Value));
            }
            else
            {
                resultado = new ProdutoDAO().Alterar(
                   idProduto,
                   Convert.ToInt32(categoriaComboBox.SelectedValue),
                   nomeListarJogosTextBox.Text,
                   Convert.ToInt32(quantidadeNumericUpDown.Value),
                   Convert.ToDecimal(valorUnitarioNumericUpDown.Value));
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

        private void categoriaListarJogosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idListarJogosTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeListarJogosTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
