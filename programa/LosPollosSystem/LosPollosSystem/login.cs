using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //ativa conexão sql

namespace LosPollosSystem
{
    public partial class login : Form
    {   //inicia conexão como null e vazio
        SqlConnection sqlconn = null; 
        private string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Isac Ramos\Desktop\Sistema-de-Varejo-e-ERP\programa\LosPollosSystem\LosPollosSystem\POLLOS.mdf;Integrated Security=True"; 
        private string _sql = string.Empty; //fica sempre vazia na inicialização do system

        //variavel que será usada para verificar se foi "LOGADO COM SUCESSO"
        public bool logado = false;

        public login()
        {
            InitializeComponent();
        }

        public void logar()
        {
            //informo a conexão para a variavel sqlconn
            sqlconn = new SqlConnection(strconn);

            //declarando as variaveis
            string user, senha;
            
            //
            try
            {
                // variaveis recebem os txt de login e senha
                user = txtuser.Text;
                senha = txtsenha.Text;

                //faz o select que procura o user e senha no banco
                _sql = "SELECT COUNT(id_usuario) FROM USUARIO WHERE usuario = @usuario and senha = @senha";

                //inicia o comando na conexão
                SqlCommand cmd = new SqlCommand(_sql,sqlconn);

                //pega as variaveis do comando sql e recebe no lugar as variaveis no login
                cmd.Parameters.Add("@usuario",SqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

                //abrindo conexão
                sqlconn.Open();

                //declarando variavel para verificar consulta no BD, aqui estamos verificando se a consulta gera mais de 1 resultado no BD
                int select = (int)cmd.ExecuteScalar();

                //Se os dados digitados forem encontrados no BD ele faz login
                if (select > 0)
                {
                    logado = true;
                    this.Dispose();
                }
                else if (senha == String.Empty && user == String.Empty)
                {
                    MessageBox.Show("Favor Informar Usuario e Senha", "Erro no Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (user == String.Empty)
                {
                    MessageBox.Show("Favor Informar o Usuario", "Erro no Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (senha == String.Empty)
                {
                    MessageBox.Show("Favor Informar a senha", "Erro no Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha incorretos!", "Erro no Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logado = false;
                }


            }
            catch(SqlException error) //caso a conexão nao seja estabelecida a varivael error recebe o erro e mostra na tela
            {
                MessageBox.Show(error+" No Banco");
            }
        }

        private void btnSairLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grbLogin_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //chama o metodo logar no botão
            logar();
        }
    }
}
