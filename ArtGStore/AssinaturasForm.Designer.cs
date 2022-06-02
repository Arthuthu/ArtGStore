namespace ArtGStore
{
    partial class AssinaturasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssinaturasForm));
            this.assinaturasBottomPanel = new System.Windows.Forms.Panel();
            this.assinaturasBottomPanel2 = new System.Windows.Forms.Panel();
            this.assinaturasNovoButton = new System.Windows.Forms.Button();
            this.assinaturasFecharButton = new System.Windows.Forms.Button();
            this.assinaturasAlterarButton = new System.Windows.Forms.Button();
            this.assinaturasExcluirButton = new System.Windows.Forms.Button();
            this.assinaturasTopPanel = new System.Windows.Forms.Panel();
            this.assinaturasBuscarButton = new System.Windows.Forms.Button();
            this.assinaturasTextBox = new System.Windows.Forms.TextBox();
            this.assinaturasLabel = new System.Windows.Forms.Label();
            this.assinaturasDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assinaturasBottomPanel.SuspendLayout();
            this.assinaturasBottomPanel2.SuspendLayout();
            this.assinaturasTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assinaturasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // assinaturasBottomPanel
            // 
            this.assinaturasBottomPanel.Controls.Add(this.assinaturasBottomPanel2);
            this.assinaturasBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assinaturasBottomPanel.Location = new System.Drawing.Point(0, 402);
            this.assinaturasBottomPanel.Name = "assinaturasBottomPanel";
            this.assinaturasBottomPanel.Size = new System.Drawing.Size(800, 48);
            this.assinaturasBottomPanel.TabIndex = 1;
            // 
            // assinaturasBottomPanel2
            // 
            this.assinaturasBottomPanel2.Controls.Add(this.assinaturasNovoButton);
            this.assinaturasBottomPanel2.Controls.Add(this.assinaturasFecharButton);
            this.assinaturasBottomPanel2.Controls.Add(this.assinaturasAlterarButton);
            this.assinaturasBottomPanel2.Controls.Add(this.assinaturasExcluirButton);
            this.assinaturasBottomPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.assinaturasBottomPanel2.Location = new System.Drawing.Point(404, 0);
            this.assinaturasBottomPanel2.Name = "assinaturasBottomPanel2";
            this.assinaturasBottomPanel2.Size = new System.Drawing.Size(396, 48);
            this.assinaturasBottomPanel2.TabIndex = 2;
            // 
            // assinaturasNovoButton
            // 
            this.assinaturasNovoButton.Location = new System.Drawing.Point(66, 13);
            this.assinaturasNovoButton.Name = "assinaturasNovoButton";
            this.assinaturasNovoButton.Size = new System.Drawing.Size(75, 23);
            this.assinaturasNovoButton.TabIndex = 2;
            this.assinaturasNovoButton.Text = "Novo";
            this.assinaturasNovoButton.UseVisualStyleBackColor = true;
            this.assinaturasNovoButton.Click += new System.EventHandler(this.assinaturasNovoButton_Click);
            // 
            // assinaturasFecharButton
            // 
            this.assinaturasFecharButton.Location = new System.Drawing.Point(309, 13);
            this.assinaturasFecharButton.Name = "assinaturasFecharButton";
            this.assinaturasFecharButton.Size = new System.Drawing.Size(75, 23);
            this.assinaturasFecharButton.TabIndex = 8;
            this.assinaturasFecharButton.Text = "Fechar";
            this.assinaturasFecharButton.UseVisualStyleBackColor = true;
            this.assinaturasFecharButton.Click += new System.EventHandler(this.assinaturasFecharButton_Click);
            // 
            // assinaturasAlterarButton
            // 
            this.assinaturasAlterarButton.Enabled = false;
            this.assinaturasAlterarButton.Location = new System.Drawing.Point(147, 13);
            this.assinaturasAlterarButton.Name = "assinaturasAlterarButton";
            this.assinaturasAlterarButton.Size = new System.Drawing.Size(75, 23);
            this.assinaturasAlterarButton.TabIndex = 1;
            this.assinaturasAlterarButton.Text = "Alterar";
            this.assinaturasAlterarButton.UseVisualStyleBackColor = true;
            this.assinaturasAlterarButton.Click += new System.EventHandler(this.assinaturasAlterarButton_Click);
            // 
            // assinaturasExcluirButton
            // 
            this.assinaturasExcluirButton.Enabled = false;
            this.assinaturasExcluirButton.Location = new System.Drawing.Point(228, 13);
            this.assinaturasExcluirButton.Name = "assinaturasExcluirButton";
            this.assinaturasExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.assinaturasExcluirButton.TabIndex = 0;
            this.assinaturasExcluirButton.Text = "Excluir";
            this.assinaturasExcluirButton.UseVisualStyleBackColor = true;
            this.assinaturasExcluirButton.Click += new System.EventHandler(this.assinaturasExcluirButton_Click);
            // 
            // assinaturasTopPanel
            // 
            this.assinaturasTopPanel.Controls.Add(this.assinaturasBuscarButton);
            this.assinaturasTopPanel.Controls.Add(this.assinaturasTextBox);
            this.assinaturasTopPanel.Controls.Add(this.assinaturasLabel);
            this.assinaturasTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.assinaturasTopPanel.Location = new System.Drawing.Point(0, 0);
            this.assinaturasTopPanel.Name = "assinaturasTopPanel";
            this.assinaturasTopPanel.Size = new System.Drawing.Size(800, 64);
            this.assinaturasTopPanel.TabIndex = 6;
            // 
            // assinaturasBuscarButton
            // 
            this.assinaturasBuscarButton.Location = new System.Drawing.Point(256, 26);
            this.assinaturasBuscarButton.Name = "assinaturasBuscarButton";
            this.assinaturasBuscarButton.Size = new System.Drawing.Size(75, 23);
            this.assinaturasBuscarButton.TabIndex = 2;
            this.assinaturasBuscarButton.Text = "Buscar";
            this.assinaturasBuscarButton.UseVisualStyleBackColor = true;
            this.assinaturasBuscarButton.Click += new System.EventHandler(this.assinaturasBuscarButton_Click);
            // 
            // assinaturasTextBox
            // 
            this.assinaturasTextBox.Location = new System.Drawing.Point(15, 26);
            this.assinaturasTextBox.Name = "assinaturasTextBox";
            this.assinaturasTextBox.Size = new System.Drawing.Size(235, 20);
            this.assinaturasTextBox.TabIndex = 1;
            // 
            // assinaturasLabel
            // 
            this.assinaturasLabel.AutoSize = true;
            this.assinaturasLabel.Location = new System.Drawing.Point(12, 9);
            this.assinaturasLabel.Name = "assinaturasLabel";
            this.assinaturasLabel.Size = new System.Drawing.Size(138, 13);
            this.assinaturasLabel.TabIndex = 0;
            this.assinaturasLabel.Text = "Digite o nome da assinatura";
            // 
            // assinaturasDataGridView
            // 
            this.assinaturasDataGridView.AllowUserToAddRows = false;
            this.assinaturasDataGridView.AllowUserToDeleteRows = false;
            this.assinaturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assinaturasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nomeColumn,
            this.quantidadeColumn,
            this.valorUnitarioColumn,
            this.valorTotalColumn});
            this.assinaturasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assinaturasDataGridView.Location = new System.Drawing.Point(0, 64);
            this.assinaturasDataGridView.Name = "assinaturasDataGridView";
            this.assinaturasDataGridView.ReadOnly = true;
            this.assinaturasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assinaturasDataGridView.Size = new System.Drawing.Size(800, 338);
            this.assinaturasDataGridView.TabIndex = 7;
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
            // quantidadeColumn
            // 
            this.quantidadeColumn.DataPropertyName = "Quantidade";
            this.quantidadeColumn.HeaderText = "Quantidade";
            this.quantidadeColumn.Name = "quantidadeColumn";
            this.quantidadeColumn.ReadOnly = true;
            this.quantidadeColumn.Width = 150;
            // 
            // valorUnitarioColumn
            // 
            this.valorUnitarioColumn.DataPropertyName = "ValorUnitario";
            this.valorUnitarioColumn.HeaderText = "ValorUnitario";
            this.valorUnitarioColumn.Name = "valorUnitarioColumn";
            this.valorUnitarioColumn.ReadOnly = true;
            this.valorUnitarioColumn.Width = 150;
            // 
            // valorTotalColumn
            // 
            this.valorTotalColumn.DataPropertyName = "ValorTotal";
            this.valorTotalColumn.HeaderText = "ValorTotal";
            this.valorTotalColumn.Name = "valorTotalColumn";
            this.valorTotalColumn.ReadOnly = true;
            this.valorTotalColumn.Width = 150;
            // 
            // AssinaturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.assinaturasDataGridView);
            this.Controls.Add(this.assinaturasTopPanel);
            this.Controls.Add(this.assinaturasBottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssinaturasForm";
            this.Text = "Assinaturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.assinaturasBottomPanel.ResumeLayout(false);
            this.assinaturasBottomPanel2.ResumeLayout(false);
            this.assinaturasTopPanel.ResumeLayout(false);
            this.assinaturasTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assinaturasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel assinaturasBottomPanel;
        private System.Windows.Forms.Panel assinaturasBottomPanel2;
        private System.Windows.Forms.Panel assinaturasTopPanel;
        private System.Windows.Forms.TextBox assinaturasTextBox;
        private System.Windows.Forms.Label assinaturasLabel;
        private System.Windows.Forms.Button assinaturasBuscarButton;
        private System.Windows.Forms.DataGridView assinaturasDataGridView;
        private System.Windows.Forms.Button assinaturasNovoButton;
        private System.Windows.Forms.Button assinaturasFecharButton;
        private System.Windows.Forms.Button assinaturasAlterarButton;
        private System.Windows.Forms.Button assinaturasExcluirButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalColumn;
    }
}