using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LosPollosSystem
{
    public partial class AreaVendas : Form
    {

        //conecta banco
        SqlConnection sqlconn = null;
        private string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Isac Ramos\Desktop\Sistema-de-Varejo-e-ERP\programa\LosPollosSystem\LosPollosSystem\POLLOS.mdf;Integrated Security=True";

        //CRIA AS SQL COMMAND PARA REALIZAR AS OPERAÇÕES EM SQL
        SqlCommand cmdconsultaprod = new SqlCommand();
        SqlCommand cmdConsultaCli = new SqlCommand();
        SqlCommand cmdConcluirVenda = new SqlCommand();

        public AreaVendas()
        {
            InitializeComponent();
        }

        private void AreaVendas_Load(object sender, EventArgs e)
        {
            sqlconn = new SqlConnection(strconn);


            //comando acessa banco
            cmdconsultaprod.Connection = sqlconn;
            cmdConsultaCli.Connection = sqlconn;
            cmdConcluirVenda.Connection = sqlconn;
        }

        public void venda()
        {
            //VARIAIS
            string produto;

            //VARIAVEIS RECEBEM:
            produto = txtcodigoprod.Text;

            //ABRE CONEXAO
            sqlconn.Open();

            //CRIA COMANDO PARA CONSULTA
            cmdconsultaprod.CommandText = "SELECT * FROM produto WHERE id_produto = @produto";
            cmdconsultaprod.Parameters.Clear();
            cmdconsultaprod.Parameters.Add("@produto", SqlDbType.VarChar).Value = produto;
            //EXECUTA O COMANDO
            cmdconsultaprod.ExecuteNonQuery();
            try
            {
                //VARIAVEL DE CONSULTA READER RECEBE COMANDO E EXECUTA
                SqlDataReader dr = cmdconsultaprod.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Cadastro não encontrado!");
  
                }


                //CASO PASSE PELA VALIDAÇÃO MOSTRA RESULTADO
                dr.Read();
                listProd.Items.Add((Convert.ToString(dr["PRODUTO"])+(Convert.ToString(" - "))+(Convert.ToString(dr["PRECO"]))));
                //listProd.Items.Add(Convert.ToString(dr["PRODUTO"]));
                /////////////////txtcodigoprod.Clear();
            }
            //EXCEPTION
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //FECHA CONEXÃO
                sqlconn.Close();
            }
        }

        public void cliente()
        {
            //VARIAIS
            string CPF;

            //VARIAVEIS RECEBEM:
            CPF = txtcpf.Text;

            //ABRE CONEXAO
            sqlconn.Open();

            //CRIA COMANDO PARA CONSULTA
            cmdConsultaCli.CommandText = "SELECT * FROM CLIENTES WHERE CPF = @CPF";
            cmdConsultaCli.Parameters.Clear();
            cmdConsultaCli.Parameters.Add("@CPF", SqlDbType.VarChar).Value = CPF;
            //EXECUTA O COMANDO
            cmdConsultaCli.ExecuteNonQuery();

            //EXECUTA CONSULTA NO BANCO DE DADOS E MOSTRA RESULTADO NA TELA
            try
            {
                //VARIAVEL DE CONSULTA READER RECEBE COMANDO E EXECUTA
                SqlDataReader dr = cmdConsultaCli.ExecuteReader();

                //SE COMANDO NÃO TROUXER RESULTADO MOSTRA ALERTA
                if (dr.HasRows == false)
                {
                    throw new Exception("Cadastro não encontrado!");
                    //txtcliente.Clear();

                }

                //CASO PASSE PELA VALIDAÇÃO MOSTRA RESULTADO
                dr.Read();
                txtcliente.Text = Convert.ToString(dr["CLIENTE_VAREJO"]);
            }
            //EXCEPTION
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //FECHA CONEXÃO
                sqlconn.Close();

            }
        }

        public void finalizavenda()
        {

        }

            private void btnpesquisaprod_Click(object sender, EventArgs e)
        {
            //CHAMA METODO VENDA
            venda();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnpescli_Click(object sender, EventArgs e)
        {
            //CHAMA METODO CLIENTE
            cliente();
        }

        private void btnfinaliza_Click(object sender, EventArgs e)
        {
            //se os campos clientes e email estiverem preenchidos o sistema procegue
            if (txtcodigoprod.Text != "" && txtcpf.Text != "")
            {
                //abre conexão
                sqlconn.Open();

                //inserindo e executando
                cmdConcluirVenda.CommandText = "INSERT INTO VENDAS (CPF, PRODUTO, DATA_VENDA) VALUES ('" + txtcpf.Text + "','" + txtcodigoprod.Text + "', GETDATE())";
                cmdConcluirVenda.ExecuteNonQuery();

                //Diz que Cliente foi Cadastrado

                MessageBox.Show("Venda Registrada!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //fecha conexão
                sqlconn.Close();

            }
            else
            {
                //Caso if não for respeita exibi mensagem de erro
                MessageBox.Show("Favor inserir os dados", "Erro ao Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFimVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda Concluida!", "Volte Sempre!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
