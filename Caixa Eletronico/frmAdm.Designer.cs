namespace Caixa_Eletronico
{
    partial class frmAdm
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
            dgvContas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNumero = new TextBox();
            numLimite = new NumericUpDown();
            numSaldo = new NumericUpDown();
            cboxTipo = new ComboBox();
            btCadastrar = new Button();
            chbStatus = new CheckBox();
            btSalvar = new Button();
            btExcluir = new Button();
            btVoltar = new Button();
            btCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLimite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSaldo).BeginInit();
            SuspendLayout();
            // 
            // dgvContas
            // 
            dgvContas.AllowUserToAddRows = false;
            dgvContas.AllowUserToDeleteRows = false;
            dgvContas.AllowUserToResizeColumns = false;
            dgvContas.AllowUserToResizeRows = false;
            dgvContas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContas.Location = new Point(14, 16);
            dgvContas.Margin = new Padding(3, 4, 3, 4);
            dgvContas.Name = "dgvContas";
            dgvContas.ReadOnly = true;
            dgvContas.RowHeadersWidth = 51;
            dgvContas.Size = new Size(514, 568);
            dgvContas.TabIndex = 0;
            dgvContas.CellClick += dgvContas_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 63);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 1;
            label1.Text = "Número da conta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(648, 173);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Limite:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 233);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "Saldo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(659, 115);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 4;
            label4.Text = "Tipo:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(704, 59);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(140, 27);
            txtNumero.TabIndex = 1;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // numLimite
            // 
            numLimite.Location = new Point(704, 171);
            numLimite.Margin = new Padding(3, 4, 3, 4);
            numLimite.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numLimite.Name = "numLimite";
            numLimite.Size = new Size(137, 27);
            numLimite.TabIndex = 3;
            numLimite.ValueChanged += numLimite_ValueChanged;
            // 
            // numSaldo
            // 
            numSaldo.Location = new Point(704, 231);
            numSaldo.Margin = new Padding(3, 4, 3, 4);
            numSaldo.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numSaldo.Name = "numSaldo";
            numSaldo.ReadOnly = true;
            numSaldo.Size = new Size(137, 27);
            numSaldo.TabIndex = 4;
            numSaldo.ValueChanged += numSaldo_ValueChanged;
            // 
            // cboxTipo
            // 
            cboxTipo.FormattingEnabled = true;
            cboxTipo.Items.AddRange(new object[] { "Conta Corrente", "Conta Poupança" });
            cboxTipo.Location = new Point(704, 111);
            cboxTipo.Margin = new Padding(3, 4, 3, 4);
            cboxTipo.Name = "cboxTipo";
            cboxTipo.Size = new Size(138, 28);
            cboxTipo.TabIndex = 2;
            cboxTipo.SelectedIndexChanged += cboxTipo_SelectedIndexChanged;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(550, 553);
            btCadastrar.Margin = new Padding(3, 4, 3, 4);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(122, 31);
            btCadastrar.TabIndex = 7;
            btCadastrar.Text = "&Cadastrar Conta";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // chbStatus
            // 
            chbStatus.AutoSize = true;
            chbStatus.Enabled = false;
            chbStatus.Location = new Point(704, 283);
            chbStatus.Margin = new Padding(3, 4, 3, 4);
            chbStatus.Name = "chbStatus";
            chbStatus.Size = new Size(71, 24);
            chbStatus.TabIndex = 6;
            chbStatus.Text = "Status";
            chbStatus.UseVisualStyleBackColor = true;
            chbStatus.CheckedChanged += chbStatus_CheckedChanged;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(679, 553);
            btSalvar.Margin = new Padding(3, 4, 3, 4);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(123, 31);
            btSalvar.TabIndex = 8;
            btSalvar.Text = "&Salvar Alterações";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(809, 553);
            btExcluir.Margin = new Padding(3, 4, 3, 4);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(86, 31);
            btExcluir.TabIndex = 9;
            btExcluir.Text = "E&xcluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(14, 592);
            btVoltar.Margin = new Padding(3, 4, 3, 4);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(86, 31);
            btVoltar.TabIndex = 10;
            btVoltar.Text = "&Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(106, 592);
            btCancelar.Margin = new Padding(3, 4, 3, 4);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(86, 31);
            btCancelar.TabIndex = 11;
            btCancelar.Text = "Ca&ncelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // frmAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 633);
            Controls.Add(btCancelar);
            Controls.Add(btVoltar);
            Controls.Add(btExcluir);
            Controls.Add(btSalvar);
            Controls.Add(chbStatus);
            Controls.Add(btCadastrar);
            Controls.Add(cboxTipo);
            Controls.Add(numSaldo);
            Controls.Add(numLimite);
            Controls.Add(txtNumero);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvContas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CTiBank - Acesso Administrativo";
            FormClosing += frmAdm_FormClosing;
            Load += frmAdm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLimite).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSaldo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNumero;
        private NumericUpDown numLimite;
        private NumericUpDown numSaldo;
        private ComboBox cboxTipo;
        private Button btCadastrar;
        private CheckBox chbStatus;
        private Button btSalvar;
        private Button btExcluir;
        private Button btVoltar;
        private Button btCancelar;
    }
}