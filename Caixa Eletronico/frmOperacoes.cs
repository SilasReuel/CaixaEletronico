using Caixa_Eletronico.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletronico
{

    public partial class frmOperacoes : Form
    {
        Singleton s;
        private String tipo;
        public frmOperacoes()
        {
            s = Singleton.Instance;
        }
        public frmOperacoes(String tipo) : this()
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numValor_ValueChanged(object sender, EventArgs e)
        {
            double valor = 0;
        }

        private void frmOperacoes_Load(object sender, EventArgs e)
        {
            
            if (tipo == "T")
            {
                txtDestino.Visible = true;
                lblDestino.Visible = true;
                lblTipo.Text = "Transferência";
            }
            else
            {
                txtDestino.Visible = false;
                lblDestino.Visible = false;
                if (tipo == "D")
                {
                    lblTipo.Text = "Depósito";
                }
                else if(tipo == "S") {
                    lblTipo.Text = "Saque";
                }
            }

        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (tipo == "S")
            {
                double valor = (double)numValor.Value;
                if (s.logada.Sacar(valor))
                {
                    MessageBox.Show("Saque realizado");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente");
                }

            }
            if (tipo == "D")
            {
                double valor = (double)numValor.Value;
                if (s.logada.Depositar(valor))
                {
                    MessageBox.Show("Deposito realizado");
                }
                else
                {
                    MessageBox.Show("Algo deu errado");
                }

            }
            if (tipo == "T")
            {
                double valor = (double)numValor.Value;
                Conta destino = s.BuscarConta(txtDestino.Text);
                if (destino != null)
                {
                    if (s.logada.Transferir(destino, valor))
                    {
                        MessageBox.Show("Transferencia realizada");
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente");
                    }
                }
                else
                {
                    MessageBox.Show("Conta inexistente");
                }

            }

        }

        private void btnVoltarOP_Click(object sender, EventArgs e)
        {
            telaprincipal frm = new telaprincipal();
            frm.Show();
            this.Hide();
        }
    }
}
