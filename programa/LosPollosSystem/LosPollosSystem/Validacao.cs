using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosPollosSystem
{
    class Validacao
    {
        public void sonumeros(KeyPressEventArgs e)
        {

            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }

        }
    }
}
