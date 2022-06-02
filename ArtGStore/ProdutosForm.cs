using ArtGStore.Negocios;
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
    public partial class ProdutosForm : Form
    {
        public ProdutosForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        private void produtosFormFecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void produtosFormNovoButton_Click(object sender, EventArgs e)
        {
            new ListarJogosForm().ShowDialog();

            produtosFormBuscarButton.PerformClick();
        }

        private void produtosFormBuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new ProdutoDAO().BuscarTodos();
            produtosFormExcluirButton.Enabled = lista.Rows.Count > 0;
            produtosFormAlterarButton.Enabled = lista.Rows.Count > 0;

            produtosFormDataGridView.DataSource = lista;
        }

        private void ProdutosForm_Load(object sender, EventArgs e)
        {

        }

        private void produtosFormExcluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(produtosFormDataGridView.SelectedRows[0].Cells["idColumn"].Value);
                var nome = produtosFormDataGridView.SelectedRows[0].Cells["nomeColumn"].Value.ToString();

                if (MessageBox.Show(
                    $"Confirma exclusão do produto {nome.ToUpper()}?\nEsta ação não poderá ser desfeita.",
                    ProductName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (new ProdutoDAO().Apagar(id))
                    {
                        produtosFormBuscarButton.PerformClick();

                        MessageBox.Show("Apagado com sucesso!",
                            ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir!",
                           ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione um produto antes!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void produtosFormAlterarButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(produtosFormDataGridView.SelectedRows[0].Cells["idColumn"].Value);

            new ListarJogosForm(id).ShowDialog();

            produtosFormBuscarButton.PerformClick();
        }

        private void produtosFormBottomPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void produtosFormTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
