namespace ArtGStore
{
    partial class UsuariosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.usuarioFormPanel = new System.Windows.Forms.Panel();
            this.usuariosBuscarButton = new System.Windows.Forms.Button();
            this.usuariosTextBox = new System.Windows.Forms.TextBox();
            this.usuariosFormLabel = new System.Windows.Forms.Label();
            this.usuariosBottomPanel = new System.Windows.Forms.Panel();
            this.usuariosBottomPanel2 = new System.Windows.Forms.Panel();
            this.usuariosAlterarButton = new System.Windows.Forms.Button();
            this.usuariosExcluirButton = new System.Windows.Forms.Button();
            this.usuariosNovoButton = new System.Windows.Forms.Button();
            this.usuariosFecharButton = new System.Windows.Forms.Button();
            this.usuariosFormDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acessaCategoriasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acessaProdutosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acessaUsuariosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioFormPanel.SuspendLayout();
            this.usuariosBottomPanel.SuspendLayout();
            this.usuariosBottomPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosFormDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioFormPanel
            // 
            this.usuarioFormPanel.Controls.Add(this.usuariosBuscarButton);
            this.usuarioFormPanel.Controls.Add(this.usuariosTextBox);
            this.usuarioFormPanel.Controls.Add(this.usuariosFormLabel);
            this.usuarioFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usuarioFormPanel.Location = new System.Drawing.Point(0, 0);
            this.usuarioFormPanel.Name = "usuarioFormPanel";
            this.usuarioFormPanel.Size = new System.Drawing.Size(800, 61);
            this.usuarioFormPanel.TabIndex = 0;
            this.usuarioFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.usuarioFormPanel_Paint);
            // 
            // usuariosBuscarButton
            // 
            this.usuariosBuscarButton.Location = new System.Drawing.Point(288, 26);
            this.usuariosBuscarButton.Name = "usuariosBuscarButton";
            this.usuariosBuscarButton.Size = new System.Drawing.Size(75, 23);
            this.usuariosBuscarButton.TabIndex = 2;
            this.usuariosBuscarButton.Text = "Buscar";
            this.usuariosBuscarButton.UseVisualStyleBackColor = true;
            this.usuariosBuscarButton.Click += new System.EventHandler(this.usuariosBuscarButton_Click);
            // 
            // usuariosTextBox
            // 
            this.usuariosTextBox.Location = new System.Drawing.Point(15, 26);
            this.usuariosTextBox.Name = "usuariosTextBox";
            this.usuariosTextBox.Size = new System.Drawing.Size(267, 20);
            this.usuariosTextBox.TabIndex = 1;
            // 
            // usuariosFormLabel
            // 
            this.usuariosFormLabel.AutoSize = true;
            this.usuariosFormLabel.Location = new System.Drawing.Point(12, 9);
            this.usuariosFormLabel.Name = "usuariosFormLabel";
            this.usuariosFormLabel.Size = new System.Drawing.Size(124, 13);
            this.usuariosFormLabel.TabIndex = 0;
            this.usuariosFormLabel.Text = "Digite o nome do usuario";
            // 
            // usuariosBottomPanel
            // 
            this.usuariosBottomPanel.Controls.Add(this.usuariosBottomPanel2);
            this.usuariosBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usuariosBottomPanel.Location = new System.Drawing.Point(0, 404);
            this.usuariosBottomPanel.Name = "usuariosBottomPanel";
            this.usuariosBottomPanel.Size = new System.Drawing.Size(800, 46);
            this.usuariosBottomPanel.TabIndex = 1;
            // 
            // usuariosBottomPanel2
            // 
            this.usuariosBottomPanel2.Controls.Add(this.usuariosAlterarButton);
            this.usuariosBottomPanel2.Controls.Add(this.usuariosExcluirButton);
            this.usuariosBottomPanel2.Controls.Add(this.usuariosNovoButton);
            this.usuariosBottomPanel2.Controls.Add(this.usuariosFecharButton);
            this.usuariosBottomPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.usuariosBottomPanel2.Location = new System.Drawing.Point(385, 0);
            this.usuariosBottomPanel2.Name = "usuariosBottomPanel2";
            this.usuariosBottomPanel2.Size = new System.Drawing.Size(415, 46);
            this.usuariosBottomPanel2.TabIndex = 0;
            // 
            // usuariosAlterarButton
            // 
            this.usuariosAlterarButton.Enabled = false;
            this.usuariosAlterarButton.Location = new System.Drawing.Point(166, 11);
            this.usuariosAlterarButton.Name = "usuariosAlterarButton";
            this.usuariosAlterarButton.Size = new System.Drawing.Size(75, 23);
            this.usuariosAlterarButton.TabIndex = 4;
            this.usuariosAlterarButton.Text = "Alterar";
            this.usuariosAlterarButton.UseVisualStyleBackColor = true;
            this.usuariosAlterarButton.Click += new System.EventHandler(this.usuariosAlterarButton_Click);
            // 
            // usuariosExcluirButton
            // 
            this.usuariosExcluirButton.Enabled = false;
            this.usuariosExcluirButton.Location = new System.Drawing.Point(247, 11);
            this.usuariosExcluirButton.Name = "usuariosExcluirButton";
            this.usuariosExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.usuariosExcluirButton.TabIndex = 5;
            this.usuariosExcluirButton.Text = "Excluir";
            this.usuariosExcluirButton.UseVisualStyleBackColor = true;
            this.usuariosExcluirButton.Click += new System.EventHandler(this.usuariosExcluirButton_Click);
            // 
            // usuariosNovoButton
            // 
            this.usuariosNovoButton.Location = new System.Drawing.Point(85, 11);
            this.usuariosNovoButton.Name = "usuariosNovoButton";
            this.usuariosNovoButton.Size = new System.Drawing.Size(75, 23);
            this.usuariosNovoButton.TabIndex = 3;
            this.usuariosNovoButton.Text = "Novo";
            this.usuariosNovoButton.UseVisualStyleBackColor = true;
            this.usuariosNovoButton.Click += new System.EventHandler(this.usuariosNovoButton_Click);
            // 
            // usuariosFecharButton
            // 
            this.usuariosFecharButton.Location = new System.Drawing.Point(328, 11);
            this.usuariosFecharButton.Name = "usuariosFecharButton";
            this.usuariosFecharButton.Size = new System.Drawing.Size(75, 23);
            this.usuariosFecharButton.TabIndex = 2;
            this.usuariosFecharButton.Text = "Fechar";
            this.usuariosFecharButton.UseVisualStyleBackColor = true;
            this.usuariosFecharButton.Click += new System.EventHandler(this.usuariosFecharButton_Click);
            // 
            // usuariosFormDataGridView
            // 
            this.usuariosFormDataGridView.AllowUserToAddRows = false;
            this.usuariosFormDataGridView.AllowUserToDeleteRows = false;
            this.usuariosFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosFormDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nomeColumn,
            this.emailColumn,
            this.acessaCategoriasColumn,
            this.acessaProdutosColumn,
            this.acessaUsuariosColumn,
            this.ativoColumn});
            this.usuariosFormDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuariosFormDataGridView.Location = new System.Drawing.Point(0, 61);
            this.usuariosFormDataGridView.Name = "usuariosFormDataGridView";
            this.usuariosFormDataGridView.ReadOnly = true;
            this.usuariosFormDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuariosFormDataGridView.Size = new System.Drawing.Size(800, 343);
            this.usuariosFormDataGridView.TabIndex = 2;
            this.usuariosFormDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuariosFormDataGridView_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "ID";
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // nomeColumn
            // 
            this.nomeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeColumn.DataPropertyName = "Nome";
            this.nomeColumn.HeaderText = "Nome";
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            // 
            // emailColumn
            // 
            this.emailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.emailColumn.DataPropertyName = "Email";
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            this.emailColumn.Width = 400;
            // 
            // acessaCategoriasColumn
            // 
            this.acessaCategoriasColumn.DataPropertyName = "AcessaCategorias";
            this.acessaCategoriasColumn.HeaderText = "Acesso a Categorias";
            this.acessaCategoriasColumn.Name = "acessaCategoriasColumn";
            this.acessaCategoriasColumn.ReadOnly = true;
            // 
            // acessaProdutosColumn
            // 
            this.acessaProdutosColumn.DataPropertyName = "AcessaProdutos";
            this.acessaProdutosColumn.HeaderText = "Acesso a Produtos";
            this.acessaProdutosColumn.Name = "acessaProdutosColumn";
            this.acessaProdutosColumn.ReadOnly = true;
            // 
            // acessaUsuariosColumn
            // 
            this.acessaUsuariosColumn.DataPropertyName = "AcessaUsuarios";
            this.acessaUsuariosColumn.HeaderText = "Acesso a Usuarios";
            this.acessaUsuariosColumn.Name = "acessaUsuariosColumn";
            this.acessaUsuariosColumn.ReadOnly = true;
            // 
            // ativoColumn
            // 
            this.ativoColumn.DataPropertyName = "Ativo";
            this.ativoColumn.HeaderText = "Ativo";
            this.ativoColumn.Name = "ativoColumn";
            this.ativoColumn.ReadOnly = true;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usuariosFormDataGridView);
            this.Controls.Add(this.usuariosBottomPanel);
            this.Controls.Add(this.usuarioFormPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuariosForm";
            this.Text = "Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            this.usuarioFormPanel.ResumeLayout(false);
            this.usuarioFormPanel.PerformLayout();
            this.usuariosBottomPanel.ResumeLayout(false);
            this.usuariosBottomPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosFormDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel usuarioFormPanel;
        private System.Windows.Forms.Label usuariosFormLabel;
        private System.Windows.Forms.TextBox usuariosTextBox;
        private System.Windows.Forms.Button usuariosBuscarButton;
        private System.Windows.Forms.Panel usuariosBottomPanel;
        private System.Windows.Forms.Panel usuariosBottomPanel2;
        private System.Windows.Forms.Button usuariosFecharButton;
        private System.Windows.Forms.DataGridView usuariosFormDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acessaCategoriasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acessaProdutosColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acessaUsuariosColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativoColumn;
        private System.Windows.Forms.Button usuariosNovoButton;
        private System.Windows.Forms.Button usuariosAlterarButton;
        private System.Windows.Forms.Button usuariosExcluirButton;
    }
}