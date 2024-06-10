using Caixa_Eletronico.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletronico
{
    public partial class frmAdm : Form
    {

        Singleton s;
        public frmAdm()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void frmAdm_Load(object sender, EventArgs e)
        {
            Recarregar();
            btSalvar.Enabled = false;
            btExcluir.Enabled = false;
        }

        public void Recarregar()
        {
            var source = new BindingSource();
            source.DataSource = s.contas;
            dgvContas.DataSource = source;
        }

        public void LimparCampos()
        {
            txtNumero.Text = "";
            txtNumero.Enabled = true;
            cboxTipo.SelectedIndex = -1;
            cboxTipo.Enabled = true;
            numLimite.Value = 0;
            numSaldo.Value = 0;
            
            chbStatus.Checked = true;

            btSalvar.Enabled = false;
            btExcluir.Enabled = false;
            btCadastrar.Enabled = true;
        }


        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text;

            Conta dup = s.BuscarConta(numero);

            if (dup == null)
            {
                switch (cboxTipo.SelectedIndex)
                {
                    case 0:
                        CCorrente c = new CCorrente(numero, (double)numLimite.Value)
                        {
                        };
                        s.contas.Add(c);
                        break;
                    case 1:
                        s.contas.Add(new CPoupanca(numero));
                        break;
                }

                Recarregar();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Já existe uma conta com esse número!");
            }
        }

        private void frmAdm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTipo.SelectedIndex == 1)
            {
                numLimite.Value = 0;
                numLimite.Enabled = false;
                
            }
            else
            {
                numLimite.Enabled = true;
                
            }
        }

        private void dgvContas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int linha = dgvContas.SelectedCells[0].RowIndex;
                string numero = dgvContas.Rows[linha].Cells[0].Value + "";

                Conta conta = s.BuscarConta(numero);
                txtNumero.Text = conta.Numero;
                txtNumero.Enabled = false;
                numLimite.Value = (decimal)conta.Limite;
                numSaldo.Value = (decimal)conta.Saldo;
                cboxTipo.Enabled = false;
                chbStatus.Checked = conta.Status;

                if (conta is CCorrente cc)
                {
                    cboxTipo.SelectedIndex = 0;
                    
                }
                else
                {
                    cboxTipo.SelectedIndex = 1;
                }

                btCadastrar.Enabled = false;
                btSalvar.Enabled = true;
                btExcluir.Enabled = true;
            }
            catch (Exception ex) { }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Conta c = s.BuscarConta(txtNumero.Text);
            c.Limite = (double)numLimite.Value;
            if (c is CCorrente cc)
            {
                
            }
            MessageBox.Show("Alterado com sucesso!");
            LimparCampos();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Conta c = s.BuscarConta(txtNumero.Text);
            DialogResult r = MessageBox.Show($"Deseja mesmo excluir a conta número {c.Numero}?", "CTiBank - Confirmação", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                c.Status = false;
                MessageBox.Show("Conta excluída com sucesso");
            }
            Recarregar();
            LimparCampos();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            FrmInicial frm = new FrmInicial();
            frm.Show();
            this.Hide();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            string numConta = "";
        }

        private void numLimite_ValueChanged(object sender, EventArgs e)
        {
            double limite = 0;
        }

        private void numSaldo_ValueChanged(object sender, EventArgs e)
        {
            double saldo = 0;
        }

        private void chbStatus_CheckedChanged(object sender, EventArgs e)
        {
            bool status;
            if (chbStatus.Checked)
            {
                status = true;
            }
            else
            {
                status=false;
            }
        }
    }
}
