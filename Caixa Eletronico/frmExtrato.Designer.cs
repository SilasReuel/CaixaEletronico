namespace Caixa_Eletronico
{
    partial class frmExtrato
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
            components = new System.ComponentModel.Container();
            btnVoltar = new Button();
            singletonBindingSource = new BindingSource(components);
            dgvExtrato = new DataGridView();
            valorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duplicataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transacaoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)singletonBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExtrato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transacaoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 29);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // singletonBindingSource
            // 
            singletonBindingSource.DataSource = typeof(Singleton);
            // 
            // dgvExtrato
            // 
            dgvExtrato.AutoGenerateColumns = false;
            dgvExtrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExtrato.Columns.AddRange(new DataGridViewColumn[] { valorDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, duplicataDataGridViewTextBoxColumn, contaDataGridViewTextBoxColumn });
            dgvExtrato.DataSource = transacaoBindingSource;
            dgvExtrato.Location = new Point(52, 79);
            dgvExtrato.Name = "dgvExtrato";
            dgvExtrato.RowHeadersWidth = 51;
            dgvExtrato.Size = new Size(719, 310);
            dgvExtrato.TabIndex = 1;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            valorDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            valorDataGridViewTextBoxColumn.ReadOnly = true;
            valorDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // duplicataDataGridViewTextBoxColumn
            // 
            duplicataDataGridViewTextBoxColumn.DataPropertyName = "Duplicata";
            duplicataDataGridViewTextBoxColumn.HeaderText = "Duplicata";
            duplicataDataGridViewTextBoxColumn.MinimumWidth = 6;
            duplicataDataGridViewTextBoxColumn.Name = "duplicataDataGridViewTextBoxColumn";
            duplicataDataGridViewTextBoxColumn.Width = 125;
            // 
            // contaDataGridViewTextBoxColumn
            // 
            contaDataGridViewTextBoxColumn.DataPropertyName = "Conta";
            contaDataGridViewTextBoxColumn.HeaderText = "Conta";
            contaDataGridViewTextBoxColumn.MinimumWidth = 6;
            contaDataGridViewTextBoxColumn.Name = "contaDataGridViewTextBoxColumn";
            contaDataGridViewTextBoxColumn.ReadOnly = true;
            contaDataGridViewTextBoxColumn.Width = 125;
            // 
            // transacaoBindingSource
            // 
            transacaoBindingSource.DataSource = typeof(Classes.Transacao);
            // 
            // frmExtrato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvExtrato);
            Controls.Add(btnVoltar);
            Name = "frmExtrato";
            Text = "frmExtrato";
            Load += frmExtrato_Load;
            ((System.ComponentModel.ISupportInitialize)singletonBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExtrato).EndInit();
            ((System.ComponentModel.ISupportInitialize)transacaoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private BindingSource singletonBindingSource;
        private DataGridView dgvExtrato;
        private DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duplicataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contaDataGridViewTextBoxColumn;
        private BindingSource transacaoBindingSource;
    }
}