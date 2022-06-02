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
    public partial class ListarCategoriasForm : Form
    {
        int idCategoria = 0;
        public ListarCategoriasForm()
        {
            InitializeComponent();
            Application.DoEvents();
            this.Text = "Novo Cadastro";
            listarCategoriasIDTextBox.Text = "Automático";
            listarCategoriasIDTextBox.TabStop = false;
        }

        public ListarCategoriasForm(int idCategoria)
        {
            InitializeComponent();
            Application.DoEvents();
            this.Text = "Alteração de categoria";
            this.idCategoria = idCategoria;
            listarCategoriasIDTextBox.TabStop = false;
        }

        private void listarCategoriasFecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listarCategoriasSalvarButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(listarCategoriasNomeTextBox.Text))
            {
                MessageBox.Show("O nome é obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = false;

            if (idCategoria == 0)
            {
                resultado = new CategoriaDAO().InserirCategoria(
                    listarCategoriasNomeTextBox.Text);
            }
            else
            {
                resultado = new CategoriaDAO().AlterarCategoria(
                   idCategoria,
                   listarCategoriasNomeTextBox.Text);
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

        private void ListarCategoriasForm_Load(object sender, EventArgs e)
        {

        }

        private void ListarCategoriasForm_Shown(object sender, EventArgs e)
        {
            if (idCategoria > 0)
            {
                var categoria = new CategoriaDAO().Buscar(idCategoria);

                listarCategoriasIDTextBox.Text = categoria["ID"].ToString();
                listarCategoriasNomeTextBox.Text = categoria["Nome"].ToString();
            }
        }
    }
}
