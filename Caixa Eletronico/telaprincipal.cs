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
    public partial class telaprincipal : Form
    {
        Singleton s;
        public telaprincipal()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            frmOperacoes frm = new frmOperacoes("D");
            frm.Show();
            this.Hide();

        }

        private void telaprincipal_Load(object sender, EventArgs e)
        {
            lblSaldoNUM.Text = s.logada.Saldo.ToString();
        }

        private void btnVoltarprincipal_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            frmOperacoes frm = new frmOperacoes("S");
            frm.Show();
            this.Hide();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            frmOperacoes frm = new frmOperacoes("T");
            frm.Show();
            this.Hide();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            frmExtrato frm = new frmExtrato();
            frm.Show();
            this.Hide();
        }
    }
}
