namespace ArtGStore
{
    partial class ProdutosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutosForm));
            this.produtosFormTopPanel = new System.Windows.Forms.Panel();
            this.produtosFormBuscarButton = new System.Windows.Forms.Button();
            this.produtosFormTextBox = new System.Windows.Forms.TextBox();
            this.produtosFormLabel = new System.Windows.Forms.Label();
            this.produtosFormBottomPanel = new System.Windows.Forms.Panel();
            this.produtosFormBottomPanel2 = new System.Windows.Forms.Panel();
            this.produtosFormNovoButton = new System.Windows.Forms.Button();
            this.produtosFormAlterarButton = new System.Windows.Forms.Button();
            this.produtosFormFecharButton = new System.Windows.Forms.Button();
            this.produtosFormExcluirButton = new System.Windows.Forms.Button();
            this.produtosFormDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaNomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosFormTopPanel.SuspendLayout();
            this.produtosFormBottomPanel.SuspendLayout();
            this.produtosFormBottomPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosFormDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produtosFormTopPanel
            // 
            this.produtosFormTopPanel.Controls.Add(this.produtosFormBuscarButton);
            this.produtosFormTopPanel.Controls.Add(this.produtosFormTextBox);
            this.produtosFormTopPanel.Controls.Add(this.produtosFormLabel);
            this.produtosFormTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.produtosFormTopPanel.Location = new System.Drawing.Point(0, 0);
            this.produtosFormTopPanel.Name = "produtosFormTopPanel";
            this.produtosFormTopPanel.Size = new System.Drawing.Size(800, 57);
            this.produtosFormTopPanel.TabIndex = 0;
            // 
            // produtosFormBuscarButton
            // 
            this.produtosFormBuscarButton.Location = new System.Drawing.Point(291, 23);
            this.produtosFormBuscarButton.Name = "produtosFormBuscarButton";
            this.produtosFormBuscarButton.Size = new System.Drawing.Size(75, 23);
            this.produtosFormBuscarButton.TabIndex = 2;
            this.produtosFormBuscarButton.Text = "Buscar";
            this.produtosFormBuscarButton.UseVisualStyleBackColor = true;
            this.produtosFormBuscarButton.Click += new System.EventHandler(this.produtosFormBuscarButton_Click);
            // 
            // produtosFormTextBox
            // 
            this.produtosFormTextBox.Location = new System.Drawing.Point(13, 25);
            this.produtosFormTextBox.Name = "produtosFormTextBox";
            this.produtosFormTextBox.Size = new System.Drawing.Size(272, 20);
            this.produtosFormTextBox.TabIndex = 1;
            this.produtosFormTextBox.TextChanged += new System.EventHandler(this.produtosFormTextBox_TextChanged);
            // 
            // produtosFormLabel
            // 
            this.produtosFormLabel.AutoSize = true;
            this.produtosFormLabel.Location = new System.Drawing.Point(10, 9);
            this.produtosFormLabel.Name = "produtosFormLabel";
            this.produtosFormLabel.Size = new System.Drawing.Size(110, 13);
            this.produtosFormLabel.TabIndex = 0;
            this.produtosFormLabel.Text = "Digite o nome do jogo";
            // 
            // produtosFormBottomPanel
            // 
            this.produtosFormBottomPanel.Controls.Add(this.produtosFormBottomPanel2);
            this.produtosFormBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.produtosFormBottomPanel.Location = new System.Drawing.Point(0, 402);
            this.produtosFormBottomPanel.Name = "produtosFormBottomPanel";
            this.produtosFormBottomPanel.Size = new System.Drawing.Size(800, 48);
            this.produtosFormBottomPanel.TabIndex = 1;
            // 
            // produtosFormBottomPanel2
            // 
            this.produtosFormBottomPanel2.Controls.Add(this.produtosFormNovoButton);
            this.produtosFormBottomPanel2.Controls.Add(this.produtosFormAlterarButton);
            this.produtosFormBottomPanel2.Controls.Add(this.produtosFormFecharButton);
            this.produtosFormBottomPanel2.Controls.Add(this.produtosFormExcluirButton);
            this.produtosFormBottomPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.produtosFormBottomPanel2.Location = new System.Drawing.Point(399, 0);
            this.produtosFormBottomPanel2.Name = "produtosFormBottomPanel2";
            this.produtosFormBottomPanel2.Size = new System.Drawing.Size(401, 48);
            this.produtosFormBottomPanel2.TabIndex = 2;
            this.produtosFormBottomPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.produtosFormBottomPanel2_Paint);
            // 
            // produtosFormNovoButton
            // 
            this.produtosFormNovoButton.Location = new System.Drawing.Point(71, 13);
            this.produtosFormNovoButton.Name = "produtosFormNovoButton";
            this.produtosFormNovoButton.Size = new System.Drawing.Size(75, 23);
            this.produtosFormNovoButton.TabIndex = 3;
            this.produtosFormNovoButton.Text = "Novo";
            this.produtosFormNovoButton.UseVisualStyleBackColor = true;
            this.produtosFormNovoButton.Click += new System.EventHandler(this.produtosFormNovoButton_Click);
            // 
            // produtosFormAlterarButton
            // 
            this.produtosFormAlterarButton.Enabled = false;
            this.produtosFormAlterarButton.Location = new System.Drawing.Point(152, 13);
            this.produtosFormAlterarButton.Name = "produtosFormAlterarButton";
            this.produtosFormAlterarButton.Size = new System.Drawing.Size(75, 23);
            this.produtosFormAlterarButton.TabIndex = 5;
            this.produtosFormAlterarButton.Text = "Alterar";
            this.produtosFormAlterarButton.UseVisualStyleBackColor = true;
            this.produtosFormAlterarButton.Click += new System.EventHandler(this.produtosFormAlterarButton_Click);
            // 
            // produtosFormFecharButton
            // 
            this.produtosFormFecharButton.Location = new System.Drawing.Point(314, 13);
            this.produtosFormFecharButton.Name = "produtosFormFecharButton";
            this.produtosFormFecharButton.Size = new System.Drawing.Size(75, 23);
            this.produtosFormFecharButton.TabIndex = 2;
            this.produtosFormFecharButton.Text = "Fechar";
            this.produtosFormFecharButton.UseVisualStyleBackColor = true;
            this.produtosFormFecharButton.Click += new System.EventHandler(this.produtosFormFecharButton_Click);
            // 
            // produtosFormExcluirButton
            // 
            this.produtosFormExcluirButton.Enabled = false;
            this.produtosFormExcluirButton.Location = new System.Drawing.Point(233, 13);
            this.produtosFormExcluirButton.Name = "produtosFormExcluirButton";
            this.produtosFormExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.produtosFormExcluirButton.TabIndex = 4;
            this.produtosFormExcluirButton.Text = "Excluir";
            this.produtosFormExcluirButton.UseVisualStyleBackColor = true;
            this.produtosFormExcluirButton.Click += new System.EventHandler(this.produtosFormExcluirButton_Click);
            // 
            // produtosFormDataGridView
            // 
            this.produtosFormDataGridView.AllowUserToAddRows = false;
            this.produtosFormDataGridView.AllowUserToDeleteRows = false;
            this.produtosFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosFormDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nomeColumn,
            this.categoriaNomeColumn,
            this.idCategoriaColumn,
            this.quantidadeColumn,
            this.valorUnitarioColumn,
            this.valorTotalColumn});
            this.produtosFormDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produtosFormDataGridView.Location = new System.Drawing.Point(0, 57);
            this.produtosFormDataGridView.MultiSelect = false;
            this.produtosFormDataGridView.Name = "produtosFormDataGridView";
            this.produtosFormDataGridView.ReadOnly = true;
            this.produtosFormDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtosFormDataGridView.Size = new System.Drawing.Size(800, 345);
            this.produtosFormDataGridView.TabIndex = 2;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "ID";
            this.idColumn.FillWeight = 200F;
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // nomeColumn
            // 
            this.nomeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeColumn.DataPropertyName = "Nome";
            this.nomeColumn.FillWeight = 200F;
            this.nomeColumn.HeaderText = "Nome";
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            // 
            // categoriaNomeColumn
            // 
            this.categoriaNomeColumn.DataPropertyName = "NomeCategoria";
            this.categoriaNomeColumn.FillWeight = 300F;
            this.categoriaNomeColumn.HeaderText = "Plataforma";
            this.categoriaNomeColumn.Name = "categoriaNomeColumn";
            this.categoriaNomeColumn.ReadOnly = true;
            this.categoriaNomeColumn.Width = 300;
            // 
            // idCategoriaColumn
            // 
            this.idCategoriaColumn.DataPropertyName = "IDCategoria";
            this.idCategoriaColumn.FillWeight = 200F;
            this.idCategoriaColumn.HeaderText = "IDCategoria";
            this.idCategoriaColumn.Name = "idCategoriaColumn";
            this.idCategoriaColumn.ReadOnly = true;
            this.idCategoriaColumn.Visible = false;
            // 
            // quantidadeColumn
            // 
            this.quantidadeColumn.DataPropertyName = "Quantidade";
            this.quantidadeColumn.FillWeight = 300F;
            this.quantidadeColumn.HeaderText = "Quantidade";
            this.quantidadeColumn.Name = "quantidadeColumn";
            this.quantidadeColumn.ReadOnly = true;
            // 
            // valorUnitarioColumn
            // 
            this.valorUnitarioColumn.DataPropertyName = "ValorUnitario";
            this.valorUnitarioColumn.FillWeight = 300F;
            this.valorUnitarioColumn.HeaderText = "Valor Unitario";
            this.valorUnitarioColumn.Name = "valorUnitarioColumn";
            this.valorUnitarioColumn.ReadOnly = true;
            // 
            // valorTotalColumn
            // 
            this.valorTotalColumn.DataPropertyName = "ValorTotal";
            this.valorTotalColumn.FillWeight = 300F;
            this.valorTotalColumn.HeaderText = "Valor Total";
            this.valorTotalColumn.Name = "valorTotalColumn";
            this.valorTotalColumn.ReadOnly = true;
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.produtosFormDataGridView);
            this.Controls.Add(this.produtosFormBottomPanel);
            this.Controls.Add(this.produtosFormTopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProdutosForm";
            this.ShowInTaskbar = false;
            this.Text = "Jogos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProdutosForm_Load);
            this.produtosFormTopPanel.ResumeLayout(false);
            this.produtosFormTopPanel.PerformLayout();
            this.produtosFormBottomPanel.ResumeLayout(false);
            this.produtosFormBottomPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produtosFormDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel produtosFormTopPanel;
        private System.Windows.Forms.Button produtosFormBuscarButton;
        private System.Windows.Forms.TextBox produtosFormTextBox;
        private System.Windows.Forms.Label produtosFormLabel;
        private System.Windows.Forms.Panel produtosFormBottomPanel;
        private System.Windows.Forms.Panel produtosFormBottomPanel2;
        private System.Windows.Forms.Button produtosFormNovoButton;
        private System.Windows.Forms.Button produtosFormAlterarButton;
        private System.Windows.Forms.Button produtosFormFecharButton;
        private System.Windows.Forms.Button produtosFormExcluirButton;
        private System.Windows.Forms.DataGridView produtosFormDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaNomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalColumn;
    }
}