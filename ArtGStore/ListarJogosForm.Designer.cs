namespace ArtGStore
{
    partial class ListarJogosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarJogosForm));
            this.idListarJogosLabel = new System.Windows.Forms.Label();
            this.categoriaListarJogosLabel = new System.Windows.Forms.Label();
            this.nomeListarJogosLabel = new System.Windows.Forms.Label();
            this.idListarJogosTextBox = new System.Windows.Forms.TextBox();
            this.nomeListarJogosTextBox = new System.Windows.Forms.TextBox();
            this.salvarListarJogosButton = new System.Windows.Forms.Button();
            this.fecharListarJogosButton = new System.Windows.Forms.Button();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valorUnitarioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valorTotalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantidadeListarJogosLabel = new System.Windows.Forms.Label();
            this.valorUnitarioListarJogosLabel = new System.Windows.Forms.Label();
            this.valorTotalListarJogosLabel = new System.Windows.Forms.Label();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorUnitarioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorTotalNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // idListarJogosLabel
            // 
            this.idListarJogosLabel.AutoSize = true;
            this.idListarJogosLabel.Location = new System.Drawing.Point(12, 9);
            this.idListarJogosLabel.Name = "idListarJogosLabel";
            this.idListarJogosLabel.Size = new System.Drawing.Size(18, 13);
            this.idListarJogosLabel.TabIndex = 0;
            this.idListarJogosLabel.Text = "ID";
            this.idListarJogosLabel.Click += new System.EventHandler(this.idListarJogosLabel_Click);
            // 
            // categoriaListarJogosLabel
            // 
            this.categoriaListarJogosLabel.AutoSize = true;
            this.categoriaListarJogosLabel.Location = new System.Drawing.Point(115, 9);
            this.categoriaListarJogosLabel.Name = "categoriaListarJogosLabel";
            this.categoriaListarJogosLabel.Size = new System.Drawing.Size(52, 13);
            this.categoriaListarJogosLabel.TabIndex = 1;
            this.categoriaListarJogosLabel.Text = "Categoria";
            // 
            // nomeListarJogosLabel
            // 
            this.nomeListarJogosLabel.AutoSize = true;
            this.nomeListarJogosLabel.Location = new System.Drawing.Point(12, 48);
            this.nomeListarJogosLabel.Name = "nomeListarJogosLabel";
            this.nomeListarJogosLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeListarJogosLabel.TabIndex = 3;
            this.nomeListarJogosLabel.Text = "Nome";
            // 
            // idListarJogosTextBox
            // 
            this.idListarJogosTextBox.Location = new System.Drawing.Point(12, 25);
            this.idListarJogosTextBox.Name = "idListarJogosTextBox";
            this.idListarJogosTextBox.ReadOnly = true;
            this.idListarJogosTextBox.Size = new System.Drawing.Size(100, 20);
            this.idListarJogosTextBox.TabIndex = 0;
            this.idListarJogosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.idListarJogosTextBox.TextChanged += new System.EventHandler(this.idListarJogosTextBox_TextChanged);
            // 
            // nomeListarJogosTextBox
            // 
            this.nomeListarJogosTextBox.Location = new System.Drawing.Point(12, 64);
            this.nomeListarJogosTextBox.MaxLength = 150;
            this.nomeListarJogosTextBox.Name = "nomeListarJogosTextBox";
            this.nomeListarJogosTextBox.Size = new System.Drawing.Size(378, 20);
            this.nomeListarJogosTextBox.TabIndex = 2;
            this.nomeListarJogosTextBox.TextChanged += new System.EventHandler(this.nomeListarJogosTextBox_TextChanged);
            // 
            // salvarListarJogosButton
            // 
            this.salvarListarJogosButton.Location = new System.Drawing.Point(315, 139);
            this.salvarListarJogosButton.Name = "salvarListarJogosButton";
            this.salvarListarJogosButton.Size = new System.Drawing.Size(75, 23);
            this.salvarListarJogosButton.TabIndex = 7;
            this.salvarListarJogosButton.Text = "Salvar";
            this.salvarListarJogosButton.UseVisualStyleBackColor = true;
            this.salvarListarJogosButton.Click += new System.EventHandler(this.salvarListarJogosButton_Click);
            // 
            // fecharListarJogosButton
            // 
            this.fecharListarJogosButton.Location = new System.Drawing.Point(12, 139);
            this.fecharListarJogosButton.Name = "fecharListarJogosButton";
            this.fecharListarJogosButton.Size = new System.Drawing.Size(75, 23);
            this.fecharListarJogosButton.TabIndex = 8;
            this.fecharListarJogosButton.Text = "Fechar";
            this.fecharListarJogosButton.UseVisualStyleBackColor = true;
            this.fecharListarJogosButton.Click += new System.EventHandler(this.cancelarListarJogosButton_Click);
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(15, 113);
            this.quantidadeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(97, 20);
            this.quantidadeNumericUpDown.TabIndex = 9;
            this.quantidadeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantidadeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valorUnitarioNumericUpDown
            // 
            this.valorUnitarioNumericUpDown.Location = new System.Drawing.Point(118, 113);
            this.valorUnitarioNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valorUnitarioNumericUpDown.Name = "valorUnitarioNumericUpDown";
            this.valorUnitarioNumericUpDown.Size = new System.Drawing.Size(128, 20);
            this.valorUnitarioNumericUpDown.TabIndex = 10;
            this.valorUnitarioNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valorUnitarioNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // valorTotalNumericUpDown
            // 
            this.valorTotalNumericUpDown.DecimalPlaces = 2;
            this.valorTotalNumericUpDown.Location = new System.Drawing.Point(252, 113);
            this.valorTotalNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valorTotalNumericUpDown.Name = "valorTotalNumericUpDown";
            this.valorTotalNumericUpDown.ReadOnly = true;
            this.valorTotalNumericUpDown.Size = new System.Drawing.Size(138, 20);
            this.valorTotalNumericUpDown.TabIndex = 11;
            this.valorTotalNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantidadeListarJogosLabel
            // 
            this.quantidadeListarJogosLabel.AutoSize = true;
            this.quantidadeListarJogosLabel.Location = new System.Drawing.Point(12, 97);
            this.quantidadeListarJogosLabel.Name = "quantidadeListarJogosLabel";
            this.quantidadeListarJogosLabel.Size = new System.Drawing.Size(62, 13);
            this.quantidadeListarJogosLabel.TabIndex = 12;
            this.quantidadeListarJogosLabel.Text = "Quantidade";
            // 
            // valorUnitarioListarJogosLabel
            // 
            this.valorUnitarioListarJogosLabel.AutoSize = true;
            this.valorUnitarioListarJogosLabel.Location = new System.Drawing.Point(115, 97);
            this.valorUnitarioListarJogosLabel.Name = "valorUnitarioListarJogosLabel";
            this.valorUnitarioListarJogosLabel.Size = new System.Drawing.Size(70, 13);
            this.valorUnitarioListarJogosLabel.TabIndex = 13;
            this.valorUnitarioListarJogosLabel.Text = "Valor Unitario";
            // 
            // valorTotalListarJogosLabel
            // 
            this.valorTotalListarJogosLabel.AutoSize = true;
            this.valorTotalListarJogosLabel.Location = new System.Drawing.Point(249, 97);
            this.valorTotalListarJogosLabel.Name = "valorTotalListarJogosLabel";
            this.valorTotalListarJogosLabel.Size = new System.Drawing.Size(58, 13);
            this.valorTotalListarJogosLabel.TabIndex = 14;
            this.valorTotalListarJogosLabel.Text = "Valor Total";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(118, 25);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(272, 21);
            this.categoriaComboBox.TabIndex = 15;
            // 
            // ListarJogosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 166);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.valorTotalListarJogosLabel);
            this.Controls.Add(this.valorUnitarioListarJogosLabel);
            this.Controls.Add(this.quantidadeListarJogosLabel);
            this.Controls.Add(this.valorTotalNumericUpDown);
            this.Controls.Add(this.valorUnitarioNumericUpDown);
            this.Controls.Add(this.quantidadeNumericUpDown);
            this.Controls.Add(this.fecharListarJogosButton);
            this.Controls.Add(this.salvarListarJogosButton);
            this.Controls.Add(this.nomeListarJogosTextBox);
            this.Controls.Add(this.idListarJogosTextBox);
            this.Controls.Add(this.nomeListarJogosLabel);
            this.Controls.Add(this.categoriaListarJogosLabel);
            this.Controls.Add(this.idListarJogosLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarJogosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.ListarJogosForm_Load);
            this.Shown += new System.EventHandler(this.ListarJogosForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorUnitarioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorTotalNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idListarJogosLabel;
        private System.Windows.Forms.Label categoriaListarJogosLabel;
        private System.Windows.Forms.Label nomeListarJogosLabel;
        private System.Windows.Forms.TextBox idListarJogosTextBox;
        private System.Windows.Forms.TextBox nomeListarJogosTextBox;
        private System.Windows.Forms.Button salvarListarJogosButton;
        private System.Windows.Forms.Button fecharListarJogosButton;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.NumericUpDown valorUnitarioNumericUpDown;
        private System.Windows.Forms.NumericUpDown valorTotalNumericUpDown;
        private System.Windows.Forms.Label quantidadeListarJogosLabel;
        private System.Windows.Forms.Label valorUnitarioListarJogosLabel;
        private System.Windows.Forms.Label valorTotalListarJogosLabel;
        private System.Windows.Forms.ComboBox categoriaComboBox;
    }
}