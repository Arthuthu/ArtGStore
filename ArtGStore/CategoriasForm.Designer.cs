namespace ArtGStore
{
    partial class CategoriasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriasForm));
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.categoriasFormBuscarButton = new System.Windows.Forms.Button();
            this.categoriaTopPanel = new System.Windows.Forms.Panel();
            this.categoriaBottomPanel = new System.Windows.Forms.Panel();
            this.categoriaBottomPanel2 = new System.Windows.Forms.Panel();
            this.categoriasNovoButton = new System.Windows.Forms.Button();
            this.categoriasAlterarButton = new System.Windows.Forms.Button();
            this.categoriasExcluirButton = new System.Windows.Forms.Button();
            this.categoriaFecharButton = new System.Windows.Forms.Button();
            this.categoriasFormDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaTopPanel.SuspendLayout();
            this.categoriaBottomPanel.SuspendLayout();
            this.categoriaBottomPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasFormDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Location = new System.Drawing.Point(12, 9);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(134, 13);
            this.categoriaLabel.TabIndex = 0;
            this.categoriaLabel.Text = "Digite o nome da categoria";
            this.categoriaLabel.Click += new System.EventHandler(this.categoriaLabel_Click);
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Location = new System.Drawing.Point(12, 25);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(260, 20);
            this.categoriaTextBox.TabIndex = 1;
            this.categoriaTextBox.TextChanged += new System.EventHandler(this.categoriaTextBox_TextChanged);
            // 
            // categoriasFormBuscarButton
            // 
            this.categoriasFormBuscarButton.Location = new System.Drawing.Point(278, 25);
            this.categoriasFormBuscarButton.Name = "categoriasFormBuscarButton";
            this.categoriasFormBuscarButton.Size = new System.Drawing.Size(75, 23);
            this.categoriasFormBuscarButton.TabIndex = 2;
            this.categoriasFormBuscarButton.Text = "Buscar";
            this.categoriasFormBuscarButton.UseVisualStyleBackColor = true;
            this.categoriasFormBuscarButton.Click += new System.EventHandler(this.categoriaBuscarButton_Click);
            // 
            // categoriaTopPanel
            // 
            this.categoriaTopPanel.Controls.Add(this.categoriaTextBox);
            this.categoriaTopPanel.Controls.Add(this.categoriasFormBuscarButton);
            this.categoriaTopPanel.Controls.Add(this.categoriaLabel);
            this.categoriaTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriaTopPanel.Location = new System.Drawing.Point(0, 0);
            this.categoriaTopPanel.Name = "categoriaTopPanel";
            this.categoriaTopPanel.Size = new System.Drawing.Size(800, 57);
            this.categoriaTopPanel.TabIndex = 3;
            // 
            // categoriaBottomPanel
            // 
            this.categoriaBottomPanel.Controls.Add(this.categoriaBottomPanel2);
            this.categoriaBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoriaBottomPanel.Location = new System.Drawing.Point(0, 401);
            this.categoriaBottomPanel.Name = "categoriaBottomPanel";
            this.categoriaBottomPanel.Size = new System.Drawing.Size(800, 49);
            this.categoriaBottomPanel.TabIndex = 4;
            // 
            // categoriaBottomPanel2
            // 
            this.categoriaBottomPanel2.Controls.Add(this.categoriasNovoButton);
            this.categoriaBottomPanel2.Controls.Add(this.categoriasAlterarButton);
            this.categoriaBottomPanel2.Controls.Add(this.categoriasExcluirButton);
            this.categoriaBottomPanel2.Controls.Add(this.categoriaFecharButton);
            this.categoriaBottomPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.categoriaBottomPanel2.Location = new System.Drawing.Point(400, 0);
            this.categoriaBottomPanel2.Name = "categoriaBottomPanel2";
            this.categoriaBottomPanel2.Size = new System.Drawing.Size(400, 49);
            this.categoriaBottomPanel2.TabIndex = 0;
            // 
            // categoriasNovoButton
            // 
            this.categoriasNovoButton.Location = new System.Drawing.Point(70, 14);
            this.categoriasNovoButton.Name = "categoriasNovoButton";
            this.categoriasNovoButton.Size = new System.Drawing.Size(75, 23);
            this.categoriasNovoButton.TabIndex = 6;
            this.categoriasNovoButton.Text = "Novo";
            this.categoriasNovoButton.UseVisualStyleBackColor = true;
            this.categoriasNovoButton.Click += new System.EventHandler(this.categoriasNovoButton_Click);
            // 
            // categoriasAlterarButton
            // 
            this.categoriasAlterarButton.Enabled = false;
            this.categoriasAlterarButton.Location = new System.Drawing.Point(151, 14);
            this.categoriasAlterarButton.Name = "categoriasAlterarButton";
            this.categoriasAlterarButton.Size = new System.Drawing.Size(75, 23);
            this.categoriasAlterarButton.TabIndex = 7;
            this.categoriasAlterarButton.Text = "Alterar";
            this.categoriasAlterarButton.UseVisualStyleBackColor = true;
            this.categoriasAlterarButton.Click += new System.EventHandler(this.categoriasAlterarButton_Click);
            // 
            // categoriasExcluirButton
            // 
            this.categoriasExcluirButton.Enabled = false;
            this.categoriasExcluirButton.Location = new System.Drawing.Point(232, 14);
            this.categoriasExcluirButton.Name = "categoriasExcluirButton";
            this.categoriasExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.categoriasExcluirButton.TabIndex = 8;
            this.categoriasExcluirButton.Text = "Excluir";
            this.categoriasExcluirButton.UseVisualStyleBackColor = true;
            this.categoriasExcluirButton.Click += new System.EventHandler(this.categoriasExcluirButton_Click);
            // 
            // categoriaFecharButton
            // 
            this.categoriaFecharButton.Location = new System.Drawing.Point(313, 14);
            this.categoriaFecharButton.Name = "categoriaFecharButton";
            this.categoriaFecharButton.Size = new System.Drawing.Size(75, 23);
            this.categoriaFecharButton.TabIndex = 5;
            this.categoriaFecharButton.Text = "Fechar";
            this.categoriaFecharButton.UseVisualStyleBackColor = true;
            this.categoriaFecharButton.Click += new System.EventHandler(this.categoriaFecharButton_Click);
            // 
            // categoriasFormDataGridView
            // 
            this.categoriasFormDataGridView.AllowUserToAddRows = false;
            this.categoriasFormDataGridView.AllowUserToDeleteRows = false;
            this.categoriasFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriasFormDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nomeColumn});
            this.categoriasFormDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriasFormDataGridView.Location = new System.Drawing.Point(0, 57);
            this.categoriasFormDataGridView.Name = "categoriasFormDataGridView";
            this.categoriasFormDataGridView.ReadOnly = true;
            this.categoriasFormDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriasFormDataGridView.Size = new System.Drawing.Size(800, 344);
            this.categoriasFormDataGridView.TabIndex = 5;
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
            // CategoriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoriasFormDataGridView);
            this.Controls.Add(this.categoriaBottomPanel);
            this.Controls.Add(this.categoriaTopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoriasForm";
            this.Text = "Categorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategoriasForm_Load);
            this.categoriaTopPanel.ResumeLayout(false);
            this.categoriaTopPanel.PerformLayout();
            this.categoriaBottomPanel.ResumeLayout(false);
            this.categoriaBottomPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasFormDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.Button categoriasFormBuscarButton;
        private System.Windows.Forms.Panel categoriaTopPanel;
        private System.Windows.Forms.Panel categoriaBottomPanel;
        private System.Windows.Forms.Panel categoriaBottomPanel2;
        private System.Windows.Forms.Button categoriaFecharButton;
        private System.Windows.Forms.DataGridView categoriasFormDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.Button categoriasNovoButton;
        private System.Windows.Forms.Button categoriasAlterarButton;
        private System.Windows.Forms.Button categoriasExcluirButton;
    }
}