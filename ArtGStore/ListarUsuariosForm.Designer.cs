namespace ArtGStore
{
    partial class ListarUsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarUsuariosForm));
            this.listarUsuarioIDLabel = new System.Windows.Forms.Label();
            this.listarUsuarioNomeLabel = new System.Windows.Forms.Label();
            this.listarUsuarioEmailLabel = new System.Windows.Forms.Label();
            this.listarUsuariosIDTextBox = new System.Windows.Forms.TextBox();
            this.listarUsuariosNomeTextBox = new System.Windows.Forms.TextBox();
            this.listarUsuarioSenhaLabel = new System.Windows.Forms.Label();
            this.listarUsuariosSenhaTextBox = new System.Windows.Forms.TextBox();
            this.listarUsuariosEmailTextBox = new System.Windows.Forms.TextBox();
            this.listarUsuarioAtivoCheckBox = new System.Windows.Forms.CheckBox();
            this.listarUsuarioCategoriaCheckBox = new System.Windows.Forms.CheckBox();
            this.listarUsuarioJogosCheckBox = new System.Windows.Forms.CheckBox();
            this.listarUsuarioAssinaturasCheckBox = new System.Windows.Forms.CheckBox();
            this.listarUsuarioUsuariosCheckBox = new System.Windows.Forms.CheckBox();
            this.listarUsuariosFecharButton = new System.Windows.Forms.Button();
            this.listarUsuariosSalvarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listarUsuarioIDLabel
            // 
            this.listarUsuarioIDLabel.AutoSize = true;
            this.listarUsuarioIDLabel.Location = new System.Drawing.Point(12, 9);
            this.listarUsuarioIDLabel.Name = "listarUsuarioIDLabel";
            this.listarUsuarioIDLabel.Size = new System.Drawing.Size(18, 13);
            this.listarUsuarioIDLabel.TabIndex = 0;
            this.listarUsuarioIDLabel.Text = "ID";
            // 
            // listarUsuarioNomeLabel
            // 
            this.listarUsuarioNomeLabel.AutoSize = true;
            this.listarUsuarioNomeLabel.Location = new System.Drawing.Point(9, 48);
            this.listarUsuarioNomeLabel.Name = "listarUsuarioNomeLabel";
            this.listarUsuarioNomeLabel.Size = new System.Drawing.Size(35, 13);
            this.listarUsuarioNomeLabel.TabIndex = 2;
            this.listarUsuarioNomeLabel.Text = "Nome";
            // 
            // listarUsuarioEmailLabel
            // 
            this.listarUsuarioEmailLabel.AutoSize = true;
            this.listarUsuarioEmailLabel.Location = new System.Drawing.Point(12, 87);
            this.listarUsuarioEmailLabel.Name = "listarUsuarioEmailLabel";
            this.listarUsuarioEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.listarUsuarioEmailLabel.TabIndex = 4;
            this.listarUsuarioEmailLabel.Text = "Email";
            // 
            // listarUsuariosIDTextBox
            // 
            this.listarUsuariosIDTextBox.Location = new System.Drawing.Point(12, 25);
            this.listarUsuariosIDTextBox.Name = "listarUsuariosIDTextBox";
            this.listarUsuariosIDTextBox.ReadOnly = true;
            this.listarUsuariosIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.listarUsuariosIDTextBox.TabIndex = 5;
            // 
            // listarUsuariosNomeTextBox
            // 
            this.listarUsuariosNomeTextBox.Location = new System.Drawing.Point(12, 64);
            this.listarUsuariosNomeTextBox.Name = "listarUsuariosNomeTextBox";
            this.listarUsuariosNomeTextBox.Size = new System.Drawing.Size(406, 20);
            this.listarUsuariosNomeTextBox.TabIndex = 6;
            this.listarUsuariosNomeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listarUsuarioSenhaLabel
            // 
            this.listarUsuarioSenhaLabel.AutoSize = true;
            this.listarUsuarioSenhaLabel.Location = new System.Drawing.Point(120, 9);
            this.listarUsuarioSenhaLabel.Name = "listarUsuarioSenhaLabel";
            this.listarUsuarioSenhaLabel.Size = new System.Drawing.Size(38, 13);
            this.listarUsuarioSenhaLabel.TabIndex = 7;
            this.listarUsuarioSenhaLabel.Text = "Senha";
            // 
            // listarUsuariosSenhaTextBox
            // 
            this.listarUsuariosSenhaTextBox.Location = new System.Drawing.Point(123, 25);
            this.listarUsuariosSenhaTextBox.Name = "listarUsuariosSenhaTextBox";
            this.listarUsuariosSenhaTextBox.Size = new System.Drawing.Size(295, 20);
            this.listarUsuariosSenhaTextBox.TabIndex = 8;
            // 
            // listarUsuariosEmailTextBox
            // 
            this.listarUsuariosEmailTextBox.Location = new System.Drawing.Point(12, 103);
            this.listarUsuariosEmailTextBox.Name = "listarUsuariosEmailTextBox";
            this.listarUsuariosEmailTextBox.Size = new System.Drawing.Size(406, 20);
            this.listarUsuariosEmailTextBox.TabIndex = 9;
            // 
            // listarUsuarioAtivoCheckBox
            // 
            this.listarUsuarioAtivoCheckBox.AutoSize = true;
            this.listarUsuarioAtivoCheckBox.Location = new System.Drawing.Point(257, 152);
            this.listarUsuarioAtivoCheckBox.Name = "listarUsuarioAtivoCheckBox";
            this.listarUsuarioAtivoCheckBox.Size = new System.Drawing.Size(50, 17);
            this.listarUsuarioAtivoCheckBox.TabIndex = 10;
            this.listarUsuarioAtivoCheckBox.Text = "Ativo";
            this.listarUsuarioAtivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // listarUsuarioCategoriaCheckBox
            // 
            this.listarUsuarioCategoriaCheckBox.AutoSize = true;
            this.listarUsuarioCategoriaCheckBox.Location = new System.Drawing.Point(88, 152);
            this.listarUsuarioCategoriaCheckBox.Name = "listarUsuarioCategoriaCheckBox";
            this.listarUsuarioCategoriaCheckBox.Size = new System.Drawing.Size(123, 17);
            this.listarUsuarioCategoriaCheckBox.TabIndex = 11;
            this.listarUsuarioCategoriaCheckBox.Text = "Acesso a Categorias";
            this.listarUsuarioCategoriaCheckBox.UseVisualStyleBackColor = true;
            // 
            // listarUsuarioJogosCheckBox
            // 
            this.listarUsuarioJogosCheckBox.AutoSize = true;
            this.listarUsuarioJogosCheckBox.Location = new System.Drawing.Point(168, 129);
            this.listarUsuarioJogosCheckBox.Name = "listarUsuarioJogosCheckBox";
            this.listarUsuarioJogosCheckBox.Size = new System.Drawing.Size(101, 17);
            this.listarUsuarioJogosCheckBox.TabIndex = 12;
            this.listarUsuarioJogosCheckBox.Text = "Acesso a Jogos";
            this.listarUsuarioJogosCheckBox.UseVisualStyleBackColor = true;
            // 
            // listarUsuarioAssinaturasCheckBox
            // 
            this.listarUsuarioAssinaturasCheckBox.AutoSize = true;
            this.listarUsuarioAssinaturasCheckBox.Location = new System.Drawing.Point(304, 129);
            this.listarUsuarioAssinaturasCheckBox.Name = "listarUsuarioAssinaturasCheckBox";
            this.listarUsuarioAssinaturasCheckBox.Size = new System.Drawing.Size(127, 17);
            this.listarUsuarioAssinaturasCheckBox.TabIndex = 13;
            this.listarUsuarioAssinaturasCheckBox.Text = "Acesso a Assinaturas";
            this.listarUsuarioAssinaturasCheckBox.UseVisualStyleBackColor = true;
            // 
            // listarUsuarioUsuariosCheckBox
            // 
            this.listarUsuarioUsuariosCheckBox.AutoSize = true;
            this.listarUsuarioUsuariosCheckBox.Location = new System.Drawing.Point(12, 129);
            this.listarUsuarioUsuariosCheckBox.Name = "listarUsuarioUsuariosCheckBox";
            this.listarUsuarioUsuariosCheckBox.Size = new System.Drawing.Size(114, 17);
            this.listarUsuarioUsuariosCheckBox.TabIndex = 14;
            this.listarUsuarioUsuariosCheckBox.Text = "Acesso a Usuarios";
            this.listarUsuarioUsuariosCheckBox.UseVisualStyleBackColor = true;
            // 
            // listarUsuariosFecharButton
            // 
            this.listarUsuariosFecharButton.Location = new System.Drawing.Point(12, 178);
            this.listarUsuariosFecharButton.Name = "listarUsuariosFecharButton";
            this.listarUsuariosFecharButton.Size = new System.Drawing.Size(75, 23);
            this.listarUsuariosFecharButton.TabIndex = 15;
            this.listarUsuariosFecharButton.Text = "Fechar";
            this.listarUsuariosFecharButton.UseVisualStyleBackColor = true;
            this.listarUsuariosFecharButton.Click += new System.EventHandler(this.listarUsuariosCancelarButton_Click);
            // 
            // listarUsuariosSalvarButton
            // 
            this.listarUsuariosSalvarButton.Location = new System.Drawing.Point(345, 178);
            this.listarUsuariosSalvarButton.Name = "listarUsuariosSalvarButton";
            this.listarUsuariosSalvarButton.Size = new System.Drawing.Size(75, 23);
            this.listarUsuariosSalvarButton.TabIndex = 16;
            this.listarUsuariosSalvarButton.Text = "Salvar";
            this.listarUsuariosSalvarButton.UseVisualStyleBackColor = true;
            this.listarUsuariosSalvarButton.Click += new System.EventHandler(this.listarUsuariosSalvarButton_Click);
            // 
            // ListarUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 209);
            this.Controls.Add(this.listarUsuariosSalvarButton);
            this.Controls.Add(this.listarUsuariosFecharButton);
            this.Controls.Add(this.listarUsuarioUsuariosCheckBox);
            this.Controls.Add(this.listarUsuarioAssinaturasCheckBox);
            this.Controls.Add(this.listarUsuarioJogosCheckBox);
            this.Controls.Add(this.listarUsuarioCategoriaCheckBox);
            this.Controls.Add(this.listarUsuarioAtivoCheckBox);
            this.Controls.Add(this.listarUsuariosEmailTextBox);
            this.Controls.Add(this.listarUsuariosSenhaTextBox);
            this.Controls.Add(this.listarUsuarioSenhaLabel);
            this.Controls.Add(this.listarUsuariosNomeTextBox);
            this.Controls.Add(this.listarUsuariosIDTextBox);
            this.Controls.Add(this.listarUsuarioEmailLabel);
            this.Controls.Add(this.listarUsuarioNomeLabel);
            this.Controls.Add(this.listarUsuarioIDLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarUsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.ListarUsuariosForm_Load);
            this.Shown += new System.EventHandler(this.ListarUsuariosForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listarUsuarioIDLabel;
        private System.Windows.Forms.Label listarUsuarioNomeLabel;
        private System.Windows.Forms.Label listarUsuarioEmailLabel;
        private System.Windows.Forms.TextBox listarUsuariosIDTextBox;
        private System.Windows.Forms.TextBox listarUsuariosNomeTextBox;
        private System.Windows.Forms.Label listarUsuarioSenhaLabel;
        private System.Windows.Forms.TextBox listarUsuariosSenhaTextBox;
        private System.Windows.Forms.TextBox listarUsuariosEmailTextBox;
        private System.Windows.Forms.CheckBox listarUsuarioAtivoCheckBox;
        private System.Windows.Forms.CheckBox listarUsuarioCategoriaCheckBox;
        private System.Windows.Forms.CheckBox listarUsuarioJogosCheckBox;
        private System.Windows.Forms.CheckBox listarUsuarioAssinaturasCheckBox;
        private System.Windows.Forms.CheckBox listarUsuarioUsuariosCheckBox;
        private System.Windows.Forms.Button listarUsuariosFecharButton;
        private System.Windows.Forms.Button listarUsuariosSalvarButton;
    }
}