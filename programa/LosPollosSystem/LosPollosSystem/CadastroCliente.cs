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
    public partial class CadastroCliente : Form
    {
        //conecta banco
        SqlConnection sqlconn = null;
        private string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Isac Ramos\Desktop\Sistema-de-Varejo-e-ERP\programa\LosPollosSystem\LosPollosSystem\POLLOS.mdf;Integrated Security=True";
        
        //CRIA AS SQL COMMAND PARA REALIZAR AS OPERAÇÕES EM SQL
        SqlCommand cmdInsertCli = new SqlCommand();
        SqlCommand cmdConsultaCli = new SqlCommand();
        // SqlDataReader dr;

        Validacao v = new Validacao();



        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void cLIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOLLOSDataSet);

        }

        private void cLIENTESBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOLLOSDataSet);

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pOLLOSDataSet.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTESTableAdapter.Fill(this.pOLLOSDataSet.CLIENTES);
            //recebe conexão
            sqlconn = new SqlConnection(strconn);


            //comando acessa banco
            cmdInsertCli.Connection = sqlconn;
            cmdConsultaCli.Connection = sqlconn;
        }

        private void brnInserirCli_Click(object sender, EventArgs e)
        {
            //se os campos clientes e email estiverem preenchidos o sistema procegue
            if (txtcliente.Text != "" && txtCPF.Text != "")
            {
                //abre conexão
                sqlconn.Open();

                //inserindo e executando
                cmdInsertCli.CommandText = "INSERT INTO CLIENTES (CLIENTE_VAREJO, EMAIL, DDD, TELEFONE, ENREDECO, PAIS, ESTADO, CIDADE, CPF) VALUES ('" + txtcliente.Text + "','" + txtemail.Text + "','" + txtddd.Text + "','" + txtfone.Text + "','" + txtendereco.Text + "','" + txtpais.Text + "','" + txtestado.Text + "','" + txtcidade.Text + "','" +txtCPF.Text+ "')";
                cmdInsertCli.ExecuteNonQuery();

                //Diz que Cliente foi Cadastrado
                MessageBox.Show("Cliente Cadastrado com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //fecha conexão
                sqlconn.Close();

            }
            else {
                //Caso if não for respeita exibi mensagem de erro
                MessageBox.Show("Favor inserir os dados", "Erro ao Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void GrbCadastroCli_Enter(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //SAI DA APLICAÇÃO
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //LIMPA CAMPOS DO CADASTRO DE CLIENTE
            txtcliente.Text = "";
            txtemail.Text = "";
            txtddd.Text = "";
            txtfone.Text = "";
            txtendereco.Text = "";
            txtpais.Text = "";
            txtestado.Text = "";
            txtcidade.Text = "";
            txtCPF.Text = "";
        }

        //CRIÃNDO METODO PARA CHAMALO NO BOTAO FUTURAMENTE
        public void consulta()
        {
            //VARIAIS
            string CPF;

            //VARIAVEIS RECEBEM:
            CPF = txtCPF.Text;

            //FECHA CONEXAO
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
                txtemail.Text = Convert.ToString(dr["EMAIL"]);
                txtddd.Text = Convert.ToString(dr["DDD"]);
                txtfone.Text = Convert.ToString(dr["TELEFONE"]);
                txtendereco.Text = Convert.ToString(dr["ENREDECO"]);
                txtpais.Text = Convert.ToString(dr["PAIS"]);
                txtestado.Text = Convert.ToString(dr["ESTADO"]);
                txtcidade.Text = Convert.ToString(dr["CIDADE"]);
                txtCPF.Text = Convert.ToString(dr["CPF"]);

            }
            //EXCEPTION
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //FECHA CONEXÃO
                sqlconn.Close();
                
            }


            //sqlconn.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            //CHAMA METODO DE CONSULTA
            consulta();
        }

        private void txtddd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtddd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CLASSE VALIDAÇÃO CRIADA PARA DEFINIR APENAS NUMEROS NO CAMPO
            v.sonumeros(e);
        }

        private void txtfone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CLASSE VALIDAÇÃO CRIADA PARA DEFINIR APENAS NUMEROS NO CAMPO
            v.sonumeros(e);
        }

        private void btnDeletarCli_Click(object sender, EventArgs e)
        {
            if (txtcliente.Text != "" && txtCPF.Text != "")
            {
                //ABRE CONEXÃO
                sqlconn.Open();

                //CRIA COMANDO PARA DELETAR CLIENTE
                cmdInsertCli.CommandText = "DELETE FROM CLIENTES WHERE CLIENTE_VAREJO = '"+txtcliente.Text+"' and CPF = '"+txtCPF.Text+"'";

                //EXECUTA COMANDO
                cmdInsertCli.ExecuteNonQuery();

                //INFORMA QUE CLIENTE FOI DELETADO
                MessageBox.Show("Cliente Deletado com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //FECHA CONEXÃO
                sqlconn.Close();
                
                //LIMPA TELA
                txtcliente.Text = "";
                txtemail.Text = "";
                txtddd.Text = "";
                txtfone.Text = "";
                txtendereco.Text = "";
                txtpais.Text = "";
                txtestado.Text = "";
                txtcidade.Text = "";
                txtCPF.Text = "";

            }
            else
            {
                //CADO IF NÃO SEJA RESPEITADO
                MessageBox.Show("Favor inserir os dados", "Erro ao Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void brnAlterarCli_Click(object sender, EventArgs e)
        {
            if (txtcliente.Text != "" && txtCPF.Text != "")
            {
                //ABRE CONEXÃO
                sqlconn.Open();

                //COMANDO PARA ALTERAR CLIENTE
                cmdInsertCli.CommandText = "UPDATE CLIENTES SET CLIENTE_VAREJO = '" + txtcliente.Text + "', EMAIL = '" + txtemail.Text + "', DDD = '" + txtddd.Text + "',TELEFONE = '" + txtfone.Text + "', ENREDECO = '" + txtendereco.Text + "', PAIS = '" + txtpais.Text + "', ESTADO = '" + txtestado.Text + "', CIDADE = '" + txtcidade.Text + "', CPF = '"+txtCPF.Text+"' WHERE CLIENTE_VAREJO = '" + txtcliente.Text + "' and EMAIL = '" + txtemail.Text + "' AND TELEFONE = '"+txtfone.Text+"'";
                
                //EXECUTA COMANDO
                cmdInsertCli.ExecuteNonQuery();

                //INFORMA QUE CLIENTE FOI ALTERADO
                MessageBox.Show("Cliente Alterado com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlconn.Close();

            }
            else
            {
                //CASO IF NAO SEJA RESPEITADO
                MessageBox.Show("Favor inserir os dados", "Erro ao Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CLASSE VALIDAÇÃO CRIADA PARA DEFINIR APENAS NUMEROS NO CAMPO
            v.sonumeros(e);
        }
    }
}
