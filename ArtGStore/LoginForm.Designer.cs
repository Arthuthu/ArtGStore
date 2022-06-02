namespace ArtGStore
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.cancelarLoginButton = new System.Windows.Forms.Button();
            this.entrarLoginButton = new System.Windows.Forms.Button();
            this.labelArtGStore = new System.Windows.Forms.Label();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(12, 98);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(80, 13);
            this.usuarioLabel.TabIndex = 0;
            this.usuarioLabel.Text = "Digite o usuario";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(12, 148);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(75, 13);
            this.senhaLabel.TabIndex = 1;
            this.senhaLabel.Text = "Digite a senha";
            this.senhaLabel.Click += new System.EventHandler(this.senhaLabel_Click);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(15, 114);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(342, 20);
            this.usuarioTextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(15, 164);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(342, 20);
            this.senhaTextBox.TabIndex = 3;
            // 
            // cancelarLoginButton
            // 
            this.cancelarLoginButton.Location = new System.Drawing.Point(12, 190);
            this.cancelarLoginButton.Name = "cancelarLoginButton";
            this.cancelarLoginButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarLoginButton.TabIndex = 4;
            this.cancelarLoginButton.Text = "Cancelar";
            this.cancelarLoginButton.UseVisualStyleBackColor = true;
            this.cancelarLoginButton.Click += new System.EventHandler(this.cancelarLoginButton_Click);
            // 
            // entrarLoginButton
            // 
            this.entrarLoginButton.Location = new System.Drawing.Point(282, 190);
            this.entrarLoginButton.Name = "entrarLoginButton";
            this.entrarLoginButton.Size = new System.Drawing.Size(75, 23);
            this.entrarLoginButton.TabIndex = 5;
            this.entrarLoginButton.Text = "Entrar";
            this.entrarLoginButton.UseVisualStyleBackColor = true;
            this.entrarLoginButton.Click += new System.EventHandler(this.entrarLoginButton_Click);
            // 
            // labelArtGStore
            // 
            this.labelArtGStore.AutoSize = true;
            this.labelArtGStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtGStore.Location = new System.Drawing.Point(152, 37);
            this.labelArtGStore.Name = "labelArtGStore";
            this.labelArtGStore.Size = new System.Drawing.Size(100, 24);
            this.labelArtGStore.TabIndex = 6;
            this.labelArtGStore.Text = "ArtGStore";
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Image = global::ArtGStore.Properties.Resources.Controller64;
            this.loginPictureBox.InitialImage = global::ArtGStore.Properties.Resources.Controller128;
            this.loginPictureBox.Location = new System.Drawing.Point(99, 22);
            this.loginPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(50, 50);
            this.loginPictureBox.TabIndex = 7;
            this.loginPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 225);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.labelArtGStore);
            this.Controls.Add(this.entrarLoginButton);
            this.Controls.Add(this.cancelarLoginButton);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button cancelarLoginButton;
        private System.Windows.Forms.Button entrarLoginButton;
        private System.Windows.Forms.Label labelArtGStore;
        private System.Windows.Forms.PictureBox loginPictureBox;
    }
}