namespace Caixa_Eletronico
{
    partial class frmOperacoes
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
            lblTipo = new Label();
            numValor = new NumericUpDown();
            lblTxtValor = new Label();
            btnRealizar = new Button();
            btnVoltarOP = new Button();
            txtDestino = new TextBox();
            lblDestino = new Label();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(396, 13);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(52, 20);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "*TIPO*";
            lblTipo.Click += label1_Click;
            // 
            // numValor
            // 
            numValor.Location = new Point(348, 204);
            numValor.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            numValor.Name = "numValor";
            numValor.Size = new Size(328, 27);
            numValor.TabIndex = 1;
            numValor.ValueChanged += numValor_ValueChanged;
            // 
            // lblTxtValor
            // 
            lblTxtValor.AutoSize = true;
            lblTxtValor.Location = new Point(254, 206);
            lblTxtValor.Name = "lblTxtValor";
            lblTxtValor.Size = new Size(46, 20);
            lblTxtValor.TabIndex = 2;
            lblTxtValor.Text = "Valor:";
            // 
            // btnRealizar
            // 
            btnRealizar.Location = new Point(364, 341);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(94, 29);
            btnRealizar.TabIndex = 3;
            btnRealizar.Text = "Realizar";
            btnRealizar.UseVisualStyleBackColor = true;
            btnRealizar.Click += btnRealizar_Click;
            // 
            // btnVoltarOP
            // 
            btnVoltarOP.Location = new Point(12, 12);
            btnVoltarOP.Name = "btnVoltarOP";
            btnVoltarOP.Size = new Size(94, 29);
            btnVoltarOP.TabIndex = 4;
            btnVoltarOP.Text = "Voltar";
            btnVoltarOP.UseVisualStyleBackColor = true;
            btnVoltarOP.Click += btnVoltarOP_Click;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(348, 258);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(328, 27);
            txtDestino.TabIndex = 5;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(254, 261);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(93, 20);
            lblDestino.TabIndex = 6;
            lblDestino.Text = "Destinatario:";
            // 
            // frmOperacoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 512);
            Controls.Add(lblDestino);
            Controls.Add(txtDestino);
            Controls.Add(btnVoltarOP);
            Controls.Add(btnRealizar);
            Controls.Add(lblTxtValor);
            Controls.Add(numValor);
            Controls.Add(lblTipo);
            Name = "frmOperacoes";
            Text = "frmOperacoes";
            Load += frmOperacoes_Load;
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipo;
        private NumericUpDown numValor;
        private Label lblTxtValor;
        private Button btnRealizar;
        private Button btnVoltarOP;
        private TextBox txtDestino;
        private Label lblDestino;
    }
}