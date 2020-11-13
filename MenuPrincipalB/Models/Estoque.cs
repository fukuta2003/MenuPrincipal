using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema.Models
{
    public class Estoque : Db
    {

        public SqlDataReader Dr;
        public bool Ret = false;
        public string Erro = "";
        public decimal EstoqueAtual = 0;

        public Estoque()
        {

        }
        
        public bool BaixarEstoque(int pProduto, decimal pQuant)
        {
            Ret = false;
            if (!Conecta())
            {
                return Ret;
            }

            EstoqueAtual = 0;
            // consultar estoque atual
            string StrQuery = "select estoque_atual from produtos where id=" + pProduto;

            using (SqlCommand cmd = new SqlCommand(StrQuery, conn))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                Dr = cmd.ExecuteReader();
                Dr.Read();
                if (Dr.HasRows)
                {
                    EstoqueAtual = decimal.Parse(Dr["estoque_atual"].ToString());
                }

                cmd.Dispose();


            }

            Dr.Close();
            conn.Close();

            // baixar o estoque
            if (!Conecta())
            {
                return Ret;
            }

            StrQuery = "update produtos set Estoque_Atual = @EstoqueAtual" +
                    " where id=" + pProduto; 

            using (SqlCommand cmd = new SqlCommand(StrQuery , conn ))
            {
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@EstoqueAtual", EstoqueAtual - pQuant);

                try
                {

                    int i = 0;
                    i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Ret = true;
                        Erro = "";
                    }

                } catch (SqlException e)
                {
                    Erro = e.ToString();
                   // System.Windows.Forms.MessageBox.Show(e.ToString());
                    Ret = false;
                }

                conn.Close();


            }


            return Ret;
        }




        // fim da classe

    }
}
