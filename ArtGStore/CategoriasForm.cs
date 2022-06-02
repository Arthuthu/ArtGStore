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
    public partial class CategoriasForm : Form
    {
        public CategoriasForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        private void categoriaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoriaLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoriaFecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void categoriaBuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new CategoriaDAO().BuscarTodasCategorias();
            categoriasAlterarButton.Enabled = lista.Rows.Count > 0;
            categoriasExcluirButton.Enabled = lista.Rows.Count > 0;

            categoriasFormDataGridView.DataSource = lista;
        }

        private void categoriasExcluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(categoriasFormDataGridView.SelectedRows[0].Cells["idColumn"].Value);
                var nome = categoriasFormDataGridView.SelectedRows[0].Cells["nomeColumn"].Value.ToString();

                if (MessageBox.Show(
                    $"Confirma exclusão da categoria {nome.ToUpper()}?\nEsta ação não poderá ser desfeita.",
                    ProductName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (new CategoriaDAO().ApagarCategoria(id))
                    {
                        categoriasFormBuscarButton.PerformClick();

                        MessageBox.Show("Categoria apagada com sucesso!",
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

        private void CategoriasForm_Load(object sender, EventArgs e)
        {

        }

        private void categoriasNovoButton_Click(object sender, EventArgs e)
        {
            new ListarCategoriasForm().ShowDialog();

            categoriasFormBuscarButton.PerformClick();
        }

        private void categoriasAlterarButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(categoriasFormDataGridView.SelectedRows[0].Cells["idColumn"].Value);

            new ListarCategoriasForm(id).ShowDialog();

            categoriasFormBuscarButton.PerformClick();
        }
    }
}
