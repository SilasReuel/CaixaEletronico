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
    public partial class login : Form
    {
        Singleton s;
        public login()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            s = Singleton.Instance;
            String noome = txtNome.Text;
            Conta conta = s.BuscarConta(noome);
            if (conta != null)
            {
                s.logada = conta;
                telaprincipal frm = new telaprincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Conta inexistente");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmInicial frm = new FrmInicial();
            frm.Show();
            this.Hide();
        }
    }
}
