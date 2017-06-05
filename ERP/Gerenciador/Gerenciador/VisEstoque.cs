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
    public partial class VisEstoque : Form
    {
        public VisEstoque()
        {
            InitializeComponent();
        }

        private void eSTOQUEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eSTOQUEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOLLOSDataSet);

        }

        private void VisEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pOLLOSDataSet.ESTOQUE'. Você pode movê-la ou removê-la conforme necessário.
            this.eSTOQUETableAdapter.Fill(this.pOLLOSDataSet.ESTOQUE);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.eSTOQUETableAdapter.ConsProduto(this.pOLLOSDataSet.ESTOQUE, cmbProd.Text);
        }
    }
}
