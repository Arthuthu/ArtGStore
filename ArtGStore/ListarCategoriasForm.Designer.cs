namespace ArtGStore
{
    partial class ListarCategoriasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarCategoriasForm));
            this.listarCategoriasIDLabel = new System.Windows.Forms.Label();
            this.listarCategoriasNomeLabel = new System.Windows.Forms.Label();
            this.listarCategoriasFecharButton = new System.Windows.Forms.Button();
            this.listarCategoriasSalvarButton = new System.Windows.Forms.Button();
            this.listarCategoriasIDTextBox = new System.Windows.Forms.TextBox();
            this.listarCategoriasNomeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listarCategoriasIDLabel
            // 
            this.listarCategoriasIDLabel.AutoSize = true;
            this.listarCategoriasIDLabel.Location = new System.Drawing.Point(12, 9);
            this.listarCategoriasIDLabel.Name = "listarCategoriasIDLabel";
            this.listarCategoriasIDLabel.Size = new System.Drawing.Size(18, 13);
            this.listarCategoriasIDLabel.TabIndex = 0;
            this.listarCategoriasIDLabel.Text = "ID";
            // 
            // listarCategoriasNomeLabel
            // 
            this.listarCategoriasNomeLabel.AutoSize = true;
            this.listarCategoriasNomeLabel.Location = new System.Drawing.Point(9, 48);
            this.listarCategoriasNomeLabel.Name = "listarCategoriasNomeLabel";
            this.listarCategoriasNomeLabel.Size = new System.Drawing.Size(35, 13);
            this.listarCategoriasNomeLabel.TabIndex = 1;
            this.listarCategoriasNomeLabel.Text = "Nome";
            // 
            // listarCategoriasFecharButton
            // 
            this.listarCategoriasFecharButton.Location = new System.Drawing.Point(12, 94);
            this.listarCategoriasFecharButton.Name = "listarCategoriasFecharButton";
            this.listarCategoriasFecharButton.Size = new System.Drawing.Size(75, 23);
            this.listarCategoriasFecharButton.TabIndex = 2;
            this.listarCategoriasFecharButton.Text = "Fechar";
            this.listarCategoriasFecharButton.UseVisualStyleBackColor = true;
            this.listarCategoriasFecharButton.Click += new System.EventHandler(this.listarCategoriasFecharButton_Click);
            // 
            // listarCategoriasSalvarButton
            // 
            this.listarCategoriasSalvarButton.Location = new System.Drawing.Point(218, 94);
            this.listarCategoriasSalvarButton.Name = "listarCategoriasSalvarButton";
            this.listarCategoriasSalvarButton.Size = new System.Drawing.Size(75, 23);
            this.listarCategoriasSalvarButton.TabIndex = 3;
            this.listarCategoriasSalvarButton.Text = "Salvar";
            this.listarCategoriasSalvarButton.UseVisualStyleBackColor = true;
            this.listarCategoriasSalvarButton.Click += new System.EventHandler(this.listarCategoriasSalvarButton_Click);
            // 
            // listarCategoriasIDTextBox
            // 
            this.listarCategoriasIDTextBox.Location = new System.Drawing.Point(12, 25);
            this.listarCategoriasIDTextBox.Name = "listarCategoriasIDTextBox";
            this.listarCategoriasIDTextBox.ReadOnly = true;
            this.listarCategoriasIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.listarCategoriasIDTextBox.TabIndex = 4;
            // 
            // listarCategoriasNomeTextBox
            // 
            this.listarCategoriasNomeTextBox.Location = new System.Drawing.Point(12, 64);
            this.listarCategoriasNomeTextBox.Name = "listarCategoriasNomeTextBox";
            this.listarCategoriasNomeTextBox.Size = new System.Drawing.Size(280, 20);
            this.listarCategoriasNomeTextBox.TabIndex = 5;
            // 
            // ListarCategoriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 129);
            this.Controls.Add(this.listarCategoriasNomeTextBox);
            this.Controls.Add(this.listarCategoriasIDTextBox);
            this.Controls.Add(this.listarCategoriasSalvarButton);
            this.Controls.Add(this.listarCategoriasFecharButton);
            this.Controls.Add(this.listarCategoriasNomeLabel);
            this.Controls.Add(this.listarCategoriasIDLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListarCategoriasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova categoria";
            this.Load += new System.EventHandler(this.ListarCategoriasForm_Load);
            this.Shown += new System.EventHandler(this.ListarCategoriasForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listarCategoriasIDLabel;
        private System.Windows.Forms.Label listarCategoriasNomeLabel;
        private System.Windows.Forms.Button listarCategoriasFecharButton;
        private System.Windows.Forms.Button listarCategoriasSalvarButton;
        private System.Windows.Forms.TextBox listarCategoriasIDTextBox;
        private System.Windows.Forms.TextBox listarCategoriasNomeTextBox;
    }
}