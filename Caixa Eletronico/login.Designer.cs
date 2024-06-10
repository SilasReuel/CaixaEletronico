namespace Caixa_Eletronico
{
    partial class login
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
            btnLogin = new Button();
            txtNome = new TextBox();
            lblConta = new Label();
            btnAcessar = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 12);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Voltar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(222, 198);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(413, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblConta
            // 
            lblConta.AutoSize = true;
            lblConta.Location = new Point(165, 201);
            lblConta.Name = "lblConta";
            lblConta.Size = new Size(51, 20);
            lblConta.TabIndex = 2;
            lblConta.Text = "Conta:";
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(355, 286);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(94, 29);
            btnAcessar.TabIndex = 3;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAcessar);
            Controls.Add(lblConta);
            Controls.Add(txtNome);
            Controls.Add(btnLogin);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtNome;
        private Label lblConta;
        private Button btnAcessar;
    }
}