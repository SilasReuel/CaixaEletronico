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
    public partial class frmExtrato : Form
    {
        Singleton s;
        public frmExtrato()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Carregar()
        {
            var source = new BindingSource();
            source.DataSource = s.logada.Transacoes;
            dgvExtrato.DataSource = source;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            telaprincipal frm = new telaprincipal();
            frm.Show();
            this.Hide();
        }

        private void frmExtrato_Load(object sender, EventArgs e)
        {
            Carregar();
        }
    }
}
