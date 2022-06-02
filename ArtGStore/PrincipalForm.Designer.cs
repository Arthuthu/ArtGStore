namespace ArtGStore
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.entrarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriasButton = new System.Windows.Forms.ToolStripButton();
            this.jogosButton = new System.Windows.Forms.ToolStripButton();
            this.usuarioButton = new System.Windows.Forms.ToolStripButton();
            this.assinaturasButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastToolStripMenuItem
            // 
            this.cadastToolStripMenuItem.Enabled = false;
            this.cadastToolStripMenuItem.Name = "cadastToolStripMenuItem";
            this.cadastToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastToolStripMenuItem.Text = "Cadastros";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarButton,
            this.toolStripSeparator1,
            this.categoriasButton,
            this.jogosButton,
            this.usuarioButton,
            this.assinaturasButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // entrarButton
            // 
            this.entrarButton.Image = ((System.Drawing.Image)(resources.GetObject("entrarButton.Image")));
            this.entrarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(42, 35);
            this.entrarButton.Text = "Entrar";
            this.entrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.entrarButton.Click += new System.EventHandler(this.entrarButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // categoriasButton
            // 
            this.categoriasButton.Enabled = false;
            this.categoriasButton.Image = global::ArtGStore.Properties.Resources.Categoria;
            this.categoriasButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.categoriasButton.Name = "categoriasButton";
            this.categoriasButton.Size = new System.Drawing.Size(67, 35);
            this.categoriasButton.Text = "Categorias";
            this.categoriasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.categoriasButton.Click += new System.EventHandler(this.categoriasButton_Click);
            // 
            // jogosButton
            // 
            this.jogosButton.Enabled = false;
            this.jogosButton.Image = global::ArtGStore.Properties.Resources.Produtos;
            this.jogosButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.jogosButton.Name = "jogosButton";
            this.jogosButton.Size = new System.Drawing.Size(41, 35);
            this.jogosButton.Text = "Jogos";
            this.jogosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.jogosButton.Click += new System.EventHandler(this.produtosButton_Click);
            // 
            // usuarioButton
            // 
            this.usuarioButton.Enabled = false;
            this.usuarioButton.Image = global::ArtGStore.Properties.Resources.Usuario;
            this.usuarioButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usuarioButton.Name = "usuarioButton";
            this.usuarioButton.Size = new System.Drawing.Size(56, 35);
            this.usuarioButton.Text = "Usuarios";
            this.usuarioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usuarioButton.Click += new System.EventHandler(this.usuariosButton_Click);
            // 
            // assinaturasButton
            // 
            this.assinaturasButton.Enabled = false;
            this.assinaturasButton.Image = global::ArtGStore.Properties.Resources.subscription;
            this.assinaturasButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.assinaturasButton.Name = "assinaturasButton";
            this.assinaturasButton.Size = new System.Drawing.Size(71, 35);
            this.assinaturasButton.Text = "Assinaturas";
            this.assinaturasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.assinaturasButton.Click += new System.EventHandler(this.assinaturasButton_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Sistema ArtGStore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing_1);
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton entrarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton categoriasButton;
        private System.Windows.Forms.ToolStripButton jogosButton;
        private System.Windows.Forms.ToolStripButton usuarioButton;
        private System.Windows.Forms.ToolStripButton assinaturasButton;
    }
}

