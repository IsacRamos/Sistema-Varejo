using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadEstoque FrmCadEstoque = new CadEstoque();
            FrmCadEstoque.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisEstoque FrmVisEstoque = new VisEstoque();
            FrmVisEstoque.Show();
        }
    }
}
