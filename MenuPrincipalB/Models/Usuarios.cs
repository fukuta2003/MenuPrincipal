using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;
namespace Sistema.Models
{
    class Usuarios :Db 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Operacao { get; set; }
        public string Ativo { get; set; }

        public ArrayList Operacoes = new ArrayList();
        public string strQuery = "";
        public SqlDataReader dr;

        

        public Usuarios()
        {

        }

        public Usuarios(int id, string nome, string login, string senha, string operacao, string ativo)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Senha = senha;
            Operacao = operacao;
            Ativo = ativo;
        }


        public void Inicializa()
        {
            Id = 0;
            Nome = "";
            Login = "";
            Senha = "";
            Operacao = "";
            Ativo = "";

            Operacoes.Clear();
            Operacoes.Add("ADMINISTRADOR");
            Operacoes.Add("GERENTE");
            Operacoes.Add("FINANCEIRO");
            Operacoes.Add("OPERADOR");
            Operacoes.Add("CAIXA");

        }


        public bool Consulta(int pId,string pLogin="")
        {
            bool xret = true;

            if (!Conecta())
            {
                xret = false;
                return xret;
            }
            if(pLogin.ToString() == "") { 
                strQuery = "select * from TABELA_LOGIN WHERE id=" + pId.ToString() + "";
            } else
            {
                strQuery = "select * from TABELA_LOGIN WHERE login='" + pLogin.ToString() + "'";
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strQuery;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                    Id = int.Parse(dr["id"].ToString());
                    Nome = dr["nome"].ToString();
                    Login = dr["login"].ToString();
                    Operacao = dr["operacao"].ToString();
                    Senha = dr["password"].ToString();
                    Ativo = dr["ativo"].ToString();

                    xret = true;
          
            }


            dr.Close();
            conn.Close();

            return xret;
        }

        public bool Salva(bool pIncluir)
        {
            bool xret = true;

            if (!Conecta())
            {
                xret = false;
                return xret;
            }

            if (pIncluir)
            {
                // inclusao
                strQuery = "INSERT INTO TABELA_LOGIN (" +
                        "nome," +
                        "login," +
                        "password," +
                        "operacao," +
                        "ativo) VALUES (@nome, @login, @senha, @operacao,@ativo)";
            }
            else
            {
                // ALTERACAO
                strQuery = "UPDATE TABELA_LOGIN SET " +
                    "nome=@nome," +
                    "login=@login," +
                    "password=@senha," +
                    "operacao=@operacao," +
                    "ativo=@ativo WHERE id=" + Id;

            }
            SqlCommand cmd = new SqlCommand(strQuery, conn);
            //  adiciona os dados da classe nos objetos do CMD
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@login", Login);
            cmd.Parameters.AddWithValue("@senha", Senha);
            cmd.Parameters.AddWithValue("@operacao", Operacao);

            if(Ativo=="S") { 
                cmd.Parameters.AddWithValue("@ativo", "S");
            } else
            {
                cmd.Parameters.AddWithValue("@ativo", "N");
            }

            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();  // ESTA LINHA SALVA DOS DADOS NO BANCO DE DADOS E RETORNA QUANTAS LINHAS FORAM AFETADAS.
                if (i > 0)
                    // retorna verdadeiro caso salve com sucesso
                xret=true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro sistema: " + ex.ToString());
                xret = false;
            }
            finally
            {
                conn.Close();
            }

            return xret;
        }

        private void Exclui()
        {

        }












    }



}
