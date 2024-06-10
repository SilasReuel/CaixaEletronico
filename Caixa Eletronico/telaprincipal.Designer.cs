namespace Caixa_Eletronico
{
    partial class telaprincipal
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
            btnVoltarprincipal = new Button();
            btnDepositar = new Button();
            btnSacar = new Button();
            btnTransferir = new Button();
            btnExtrato = new Button();
            lblSaldo = new Label();
            lblSaldoNUM = new Label();
            SuspendLayout();
            // 
            // btnVoltarprincipal
            // 
            btnVoltarprincipal.Location = new Point(12, 12);
            btnVoltarprincipal.Name = "btnVoltarprincipal";
            btnVoltarprincipal.Size = new Size(94, 29);
            btnVoltarprincipal.TabIndex = 0;
            btnVoltarprincipal.Text = "Voltar";
            btnVoltarprincipal.UseVisualStyleBackColor = true;
            btnVoltarprincipal.Click += btnVoltarprincipal_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(321, 157);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(289, 29);
            btnDepositar.TabIndex = 1;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(321, 192);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(289, 29);
            btnSacar.TabIndex = 2;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(321, 227);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(289, 29);
            btnTransferir.TabIndex = 3;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // btnExtrato
            // 
            btnExtrato.Location = new Point(321, 262);
            btnExtrato.Name = "btnExtrato";
            btnExtrato.Size = new Size(289, 29);
            btnExtrato.TabIndex = 4;
            btnExtrato.Text = "Ver extrato";
            btnExtrato.UseVisualStyleBackColor = true;
            btnExtrato.Click += btnExtrato_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(704, 21);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(50, 20);
            lblSaldo.TabIndex = 5;
            lblSaldo.Text = "Saldo:";
            // 
            // lblSaldoNUM
            // 
            lblSaldoNUM.AutoSize = true;
            lblSaldoNUM.Location = new Point(755, 20);
            lblSaldoNUM.Name = "lblSaldoNUM";
            lblSaldoNUM.Size = new Size(17, 20);
            lblSaldoNUM.TabIndex = 6;
            lblSaldoNUM.Text = "1";
            // 
            // telaprincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 492);
            Controls.Add(lblSaldoNUM);
            Controls.Add(lblSaldo);
            Controls.Add(btnExtrato);
            Controls.Add(btnTransferir);
            Controls.Add(btnSacar);
            Controls.Add(btnDepositar);
            Controls.Add(btnVoltarprincipal);
            Name = "telaprincipal";
            Text = "telaprincipal";
            Load += telaprincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltarprincipal;
        private Button btnDepositar;
        private Button btnSacar;
        private Button btnTransferir;
        private Button btnExtrato;
        private Label lblSaldo;
        private Label lblSaldoNUM;
    }
}