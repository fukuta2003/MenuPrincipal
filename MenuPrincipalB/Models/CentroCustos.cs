using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Sistema.Models;

namespace Sistema
{
    public class CentroCustos : Db
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Janeiro { get; set; }
        public decimal Fevereiro { get; set; }
        public decimal Marco { get; set; }
        public decimal Abril { get; set; }
        public decimal Maio { get; set; }
        public decimal Junho { get; set; }
        public decimal Julho { get; set; }
        public decimal Agosto { get; set; }
        public decimal Setembro { get; set; }
        public decimal Outubro { get; set; }
        public decimal Novembro { get; set; }
        public decimal Dezembro { get; set; }

        public SqlDataReader dr;  // datareader para dados

        // construtor padrao para criar objeto sem passar dados
        public CentroCustos()
        {
            Inicializa();
        }

        // inicializa dados dos objetos da classe para não ficar nulos
        public void Inicializa()
        {
            Id = 0;
            Codigo = "";
            Descricao = "";
            Janeiro = 0; Fevereiro = 0; Marco = 0; Abril = 0; Maio = 0;
            Junho = 0; Julho = 0; Agosto = 0; Setembro = 0; Outubro = 0;
            Novembro = 0; Dezembro = 0;


        }

        // Consulta --> CONSULTA POR ID os dados do fornecedor
        public bool Consulta(string pCodigo)
        {
            bool ret = false;

            Inicializa();
            if (!Conecta())
            {
                MessageBox.Show("Erro: O Banco de Dados não está conectado !");
                return false;
            }

            string StrQuery = "SELECT * FROM CENTROCUSTOS WITH (INDEX(i_CODIGO)) WHERE codigo = '" + pCodigo.ToString()+"'";
            SqlCommand cmd = new SqlCommand(StrQuery, conn);
            //cmd.CommandText = StrQuery;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (dr["codigo"].ToString() == pCodigo.ToString())
                {
                    Descricao = dr["descricao"].ToString();
                    Janeiro = decimal.Parse(dr["janeiro"].ToString());
                    Fevereiro = decimal.Parse(dr["fevereiro"].ToString());
                    Marco = decimal.Parse(dr["marco"].ToString());
                    Abril = decimal.Parse(dr["abril"].ToString());
                    Maio = decimal.Parse(dr["maio"].ToString());
                    Junho = decimal.Parse(dr["junho"].ToString());
                    Julho = decimal.Parse(dr["julho"].ToString());
                    Agosto = decimal.Parse(dr["agosto"].ToString());
                    Setembro = decimal.Parse(dr["setembro"].ToString());
                    Outubro = decimal.Parse(dr["outubro"].ToString());
                    Novembro = decimal.Parse(dr["novembro"].ToString());
                    Dezembro = decimal.Parse(dr["dezembro"].ToString());

                    ret = true;
                }
                else
                {
                    Inicializa();

                    ret = false;
                }
            }

            conn.Close();
            return ret;

        }


        public bool Salvar_Dados(bool pIncluir)
        {

            if (!Conecta())
            {
                MessageBox.Show("Erro: O Banco de Dados não está conectado !");
                return false;
            }
            String strquery;

            if (pIncluir)
            {
                // inclusao
                strquery = "INSERT INTO CENTROCUSTOS (" +
                        "CODIGO," +
                        "DESCRICAO," +
                        "JANEIRO," +
                        "FEVEREIRO," +
                        "MARCO," +
                        "ABRIL," +
                        "MAIO," +
                        "JUNHO," +
                        "JULHO," +
                        "AGOSTO," +
                        "SETEMBRO," +
                        "OUTUBRO," +
                        "NOVEMBRO," +
                        "DEZEMBRO) VALUES (@CODIGO, @DESCRICAO, @JANEIRO, @FEVEREIRO," +
                        "@MARCO,@ABRIL,@MAIO,@JUNHO,@JULHO,@AGOSTO,@SETEMBRO," +
                        "@OUTUBRO,@NOVEMBRO,@DEZEMBRO)";
            }
            else
            {
                // ALTERACAO
                strquery = "UPDATE CENTROCUSTOS SET " +
                    "DESCRICAO=@DESCRICAO," +
                    "JANEIRO=@JANEIRO," +
                    "FEVEREIRO=@FEVEREIRO," +
                    "MARCO=@MARCO," +
                    "ABRIL=@ABRIL," +
                    "MAIO=@MAIO," +
                    "JUNHO=@JUNHO," +
                    "JULHO=@JULHO," +
                    "AGOSTO=@AGOSTO," +
                    "SETEMBRO=@SETEMBRO," +
                    "OUTUBRO=@OUTUBRO," +
                    "NOVEMBRO=@NOVEMBRO," +
                    "DEZEMBRO=@DEZEMBRO WHERE CODIGO='" + Codigo + "'";

            }
            SqlCommand cmd = new SqlCommand(strquery, conn);
            //  adiciona os dados da classe nos objetos do CMD
            if(pIncluir)
            {
                cmd.Parameters.AddWithValue("@CODIGO", Codigo);
            }
            cmd.Parameters.AddWithValue("@DESCRICAO", Descricao);
            cmd.Parameters.AddWithValue("@JANEIRO", Janeiro);
            cmd.Parameters.AddWithValue("@FEVEREIRO", Fevereiro);
            cmd.Parameters.AddWithValue("@MARCO", Marco);
            cmd.Parameters.AddWithValue("@ABRIL", Abril);
            cmd.Parameters.AddWithValue("@MAIO", Maio);
            cmd.Parameters.AddWithValue("@JUNHO", Junho);
            cmd.Parameters.AddWithValue("@JULHO", Julho);
            cmd.Parameters.AddWithValue("@AGOSTO", Agosto);
            cmd.Parameters.AddWithValue("@SETEMBRO", Setembro);
            cmd.Parameters.AddWithValue("@OUTUBRO", Outubro);
            cmd.Parameters.AddWithValue("@NOVEMBRO", Novembro);
            cmd.Parameters.AddWithValue("@DEZEMBRO", Dezembro);

            // cmd.Parameters.AddWithValue("@baixa", DataPagamento);

            cmd.CommandType = CommandType.Text;

            // TENTA REALIZAR A INCLUSAO, CASO TENHA SUCESSO ELA SALVA OS DADOS E RETORNA (OK)
            // SE ALGUM ERRO ACONTECER, É CRIADA UMA EXCEPTION QUE MOSTRA NA TELA O ERRO OCORRIDO
            // E FINALMENTE (FINNALY) CONCLUI A OPERACAO.

            try
            {
                int i = cmd.ExecuteNonQuery();  // ESTA LINHA SALVA DOS DADOS NO BANCO DE DADOS E RETORNA QUANTAS LINHAS FORAM AFETADAS.
                if (i > 0)

                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro sistema: " + ex.ToString());
            }
            finally
            {

                conn.Close();
            }
            return false;

        }

        public bool Apaga(string pCodigo)
        {
            bool ret = false;

            Inicializa();

            if (!Conecta())
            {
                MessageBox.Show("Erro: O Banco de Dados não está conectado !");
                return false;
            }

            string StrQuery = "DELETE FROM Fornecedores WHERE codigo = '" + pCodigo.ToString() + "'";
            SqlCommand cmd = new SqlCommand(StrQuery, conn);
            //cmd.CommandText = StrQuery;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            int i = cmd.ExecuteNonQuery();  // ESTA LINHA EXECUTA A QUERY DE DADOS E RETORNA QUANTAS LINHAS FORAM AFETADAS.
            if (i > 0)
            {
                ret = true;  // deletou
            }
            else
            {
                ret = false;   // não deletou.
            }

            conn.Close();
            return ret;

        }



    }



}
