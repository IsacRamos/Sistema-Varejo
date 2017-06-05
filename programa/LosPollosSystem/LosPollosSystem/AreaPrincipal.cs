using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosPollosSystem
{
    public partial class AreaPrincipal : Form
    {
        public AreaPrincipal()
        {
            InitializeComponent();
        }

        private void btnvendas_Click(object sender, EventArgs e)
        {
            AreaVendas frmvendas = new AreaVendas();

            frmvendas.ShowDialog();
        }

        private void btnCadaCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente frmCadCli = new CadastroCliente();

            frmCadCli.ShowDialog();
        }

        private void btnrelatorios_Click(object sender, EventArgs e)
        {
            Relatorios frmRelatorio = new Relatorios();

            frmRelatorio.ShowDialog();
        }
    }
}
