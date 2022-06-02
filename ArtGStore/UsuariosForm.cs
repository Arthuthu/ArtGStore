using ArGStore.Negocios;
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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usuarioFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usuariosFecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usuariosBuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new UsuarioDAO().BuscarTodosUsuarios();
            usuariosAlterarButton.Enabled = lista.Rows.Count > 0;
            usuariosExcluirButton.Enabled = lista.Rows.Count > 0;

            usuariosFormDataGridView.DataSource = lista;
        }

        private void usuariosExcluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(usuariosFormDataGridView.SelectedRows[0].Cells["idColumn"].Value);
                var nome = usuariosFormDataGridView.SelectedRows[0].Cells["nomeColumn"].Value.ToString();

                if (MessageBox.Show(
                    $"Confirma exclusão do usuarios {nome.ToUpper()}?\nEsta ação não poderá ser desfeita.",
                    ProductName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (new UsuarioDAO().ApagarUsuario(id))
                    {
                        usuariosBuscarButton.PerformClick();

                        MessageBox.Show("Usuario deletado com sucesso!",
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

        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void usuariosNovoButton_Click(object sender, EventArgs e)
        {
            new ListarUsuariosForm().ShowDialog();

            usuariosBuscarButton.PerformClick();
        }

        private void usuariosAlterarButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(usuariosFormDataGridView.SelectedRows[0].Cells["idColumn"].Value);

            new ListarUsuariosForm(id).ShowDialog();

            usuariosBuscarButton.PerformClick();
        }

        private void usuariosFormDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
