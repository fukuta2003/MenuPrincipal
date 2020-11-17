using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Models
{
    class CaixaGeralMovimento :Db
    {
        public int Id { get; set; }
        public int Idcaixa { get; set; }
        public string Tipo { get; set; }
        public string Historico { get; set; }
        public decimal Debito { get; set; }
        public decimal Credito { get; set; }
        public decimal Saldo { get; set; }

        public List<CaixaGeralMovimento> Lancamentos;

        public string strQuery = "";

        SqlDataReader dr;

        public CaixaGeralMovimento(int idcaixa, string tipo, string historico, decimal debito, decimal credito)
        {
            this.Idcaixa = idcaixa;
            this.Tipo = tipo;
            this.Historico = historico;
            this.Debito = debito;
            this.Credito = credito;
            
        }

        public CaixaGeralMovimento()
        {

        }


        public void MontaGrade(int pID)
        {
            if (!Conecta())
            {
                return;
            }

            Lancamentos = new List<CaixaGeralMovimento>();
            strQuery = "SELECT * FROM CAIXA_GERAL_MOVIMENTO WHERE idcaixa = " + pID.ToString() + "";

            using (SqlCommand cmd = new SqlCommand(strQuery, conn))
            {
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if(string.IsNullOrEmpty(dr["TIPO"].ToString()))
                    {
                        Tipo = "*****";
                    } else
                    {
                        Tipo = dr["tipo"].ToString();
                    }
                    if (string.IsNullOrEmpty(dr["HISTORICO"].ToString()))
                    {
                        Historico = "*****";
                    }
                    else
                    {
                        Historico = dr["historico"].ToString();
                    }

                    if (string.IsNullOrEmpty(dr["debito"].ToString()))
                    {
                        Debito = 0;
                    }
                    else
                    {
                        Debito = decimal.Parse(dr["debito"].ToString());
                    }

                    if (string.IsNullOrEmpty(dr["credito"].ToString()))
                    {
                        Credito = 0;
                    }
                    else
                    {
                        Credito = decimal.Parse(dr["credito"].ToString());
                    }


                    Lancamentos.Add(new CaixaGeralMovimento(pID, Tipo, Historico, Debito, Credito));


                }

                dr.Close();
                conn.Close();

            }

        }



        public decimal ConsultaSaldoCaixa(int pID)
        {
            
            if (!Conecta())
            {
                return 0;
            }


            strQuery = "SELECT * FROM CAIXA_GERAL WHERE ID=" + pID.ToString() + "";
            Saldo = 0;
            int i = 1;

            using (SqlCommand cmd = new SqlCommand(strQuery, conn))
            {
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    Saldo += decimal.Parse(dr["saldoabertura"].ToString());

                }

            }

            dr.Close();
            conn.Close();

            if(!Conecta())
            {
                return 0;
            }

            strQuery = "SELECT * FROM CAIXA_GERAL " +
                       "INNER JOIN CAIXA_GERAL_MOVIMENTO ON " +
                       "CAIXA_GERAL.id = CAIXA_GERAL_MOVIMENTO.idcaixa WHERE CAIXA_GERAL.ID = " +pID.ToString() + "";
            i = 1;

            using (SqlCommand cmd = new SqlCommand(strQuery, conn))
            {
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                        if(dr["tipo"].ToString()=="ENTRADA")
                        {
                            Saldo += decimal.Parse(dr["CREDITO"].ToString());
                        } else
                        {
                            Saldo -= decimal.Parse(dr["DEBITO"].ToString());
                        }
                    
                }
            }

            dr.Close();
            conn.Close();
            return Saldo;

        }

        public bool Salvar(int pId)
        {
            bool xret = false;

            if (!Conecta())
            {
                return false;
            }

            strQuery = "INSERT INTO CAIXA_GERAL_MOVIMENTO (" +
                "idcaixa, tipo, historico, debito, credito) VALUES (" +
                "@idcaixa, @tipo, @historico, @debito, @credito)";

            using (SqlCommand cmd = new SqlCommand(strQuery,conn))
            {
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@idcaixa", pId);
                cmd.Parameters.AddWithValue("@tipo", Tipo);
                cmd.Parameters.AddWithValue("@historico", Historico);
                cmd.Parameters.AddWithValue("@debito", Debito);
                cmd.Parameters.AddWithValue("@credito", Credito);

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        xret = true;
                    }
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString(), "Erro Salvar Dados");
                    xret = false;
                }

              
                conn.Close();
                return xret;
            }

                /// ___
        }






        /// ___ final
    }
}
