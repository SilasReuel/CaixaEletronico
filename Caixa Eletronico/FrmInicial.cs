using Caixa_Eletronico.Classes;
using System.Security.Cryptography.X509Certificates;

namespace Caixa_Eletronico
{
    public partial class FrmInicial : Form
    {
        public List<Conta> contas = new List<Conta>();
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            Singleton s = Singleton.Instance;

        }

        private void btAdm_Click(object sender, EventArgs e)
        {
            frmAdm adm = new frmAdm();
            adm.Show();
            this.Hide();
        }

        private void FrmInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btCaixa_Click(object sender, EventArgs e)
        {
            login adm = new login();
            adm.Show();
            this.Hide();
        }

    }
}

