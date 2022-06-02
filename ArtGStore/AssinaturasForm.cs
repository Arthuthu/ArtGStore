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
    public partial class AssinaturasForm : Form
    {
        public AssinaturasForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        private void assinaturasFecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void assinaturasNovoButton_Click(object sender, EventArgs e)
        {
            new ListarAssinaturasForm().ShowDialog();

            assinaturasBuscarButton.PerformClick();
        }

        private void assinaturasBuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new AssinaturaDAO().BuscarTodasAssinaturas();
            assinaturasAlterarButton.Enabled = lista.Rows.Count > 0;
            assinaturasExcluirButton.Enabled = lista.Rows.Count > 0;

            assinaturasDataGridView.DataSource = lista;
        }

        private void assinaturasAlterarButton_Click(object sender, EventArgs e)
        {
            {
                var id = Convert.ToInt32(assinaturasDataGridView.SelectedRows[0].Cells["idColumn"].Value);

                new ListarAssinaturasForm(id).ShowDialog();

                assinaturasBuscarButton.PerformClick();
            }
        }

        private void assinaturasExcluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(assinaturasDataGridView.SelectedRows[0].Cells["idColumn"].Value);
                var nome = assinaturasDataGridView.SelectedRows[0].Cells["nomeColumn"].Value.ToString();

                if (MessageBox.Show(
                    $"Confirma exclusão da assinatura {nome.ToUpper()}?\nEsta ação não poderá ser desfeita.",
                    ProductName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (new AssinaturaDAO().Apagar(id))
                    {
                        assinaturasBuscarButton.PerformClick();

                        MessageBox.Show("Assinatura apagada com sucesso!",
                            ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir",
                           ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione uma categoria antes", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
