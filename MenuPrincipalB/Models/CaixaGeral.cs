using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Sistema.Models
{
    class CaixaGeral :Db
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal SaldoAbertura { get; set; }
        public string AbertoPor { get; set; }
        public decimal Dinheiro { get; set; }
        public decimal Cheque { get; set; }
        public decimal Vales { get; set; }
        public decimal Refeicao { get; set; }
        public decimal Cartao_Credito { get; set; }
        public decimal Cartao_Debito { get; set; }
        public decimal Transferencia { get; set; }
        public decimal TotalCaixa { get; set; }
        public string FechadoPor { get; set; }
        public DateTime DataFechamento { get; set; }
        public string Fechado { get; set; }

        public SqlDataReader dr;
        public string StrQuery = "";
        public int[,] CaixasAbertos = new int[30,3];


        public CaixaGeral()
        {
        }

        // construtor para abrir um caixa
        public CaixaGeral(DateTime data, decimal saldoAbertura, string abertopor)  // para abrir diretamente um caixa geral
        {
            Data = data;
            SaldoAbertura = saldoAbertura;
            AbertoPor = abertopor;
        }

        // construtor para fechar o caixa
        public CaixaGeral(decimal dinheiro, decimal cheque, decimal vales, decimal refeicao, decimal cartao_Credito, decimal cartao_Debito, decimal transferencia, decimal totalCaixa, string fechadoPor, DateTime dataFechamento)
        {
            Dinheiro = dinheiro;
            Cheque = cheque;
            Vales = vales;
            Refeicao = refeicao;
            Cartao_Credito = cartao_Credito;
            Cartao_Debito = cartao_Debito;
            Transferencia = transferencia;
            TotalCaixa = totalCaixa;
            FechadoPor = fechadoPor;
            DataFechamento = dataFechamento;
        }

        

        public void CarregaCaixasAbertos()
        {
            Validacao vl = new Validacao();
            vl.MesInicioFim();
            DateTime xDataInicial;
            DateTime xDataFinal;
            int i = 0;
            xDataInicial = DateTime.Parse(vl.DataInicial.ToString());
            xDataFinal = DateTime.Parse(vl.DataFinal.ToString());
            while(xDataInicial <= xDataFinal)
            {
                if (ConsultaDataAberta(xDataInicial))
                {
                    CaixasAbertos[i, 0] = xDataInicial.Year;
                    CaixasAbertos[i, 1] = xDataInicial.Month;
                    CaixasAbertos[i, 2] = xDataInicial.Day;
                    i++;
                }
                xDataInicial = xDataInicial.AddDays(1);
                
            }

        }

        public bool ConsultaDataAberta(DateTime pData)
        {
            bool xret = false;
            if (!Conecta())
            {
                return xret;
            }

            string xDia = pData.Day.ToString().PadLeft(2, '0');
            string xMes = pData.Month.ToString().PadLeft(2, '0');
            string xAno = pData.Year.ToString().PadLeft(2, '0');
            string ConsultaData = xAno + "" + xMes + "" + xDia;


            StrQuery = "SELECT * FROM CAIXA_GERAL WHERE FECHADO='N' AND DATA BETWEEN '" + ConsultaData + " 00:00' AND '" + ConsultaData + " 23:59'";
            // select* from caixa_geral where data between '20200614 00:00' and '20200614 23:59'
           
            using (SqlCommand cmd = new SqlCommand(StrQuery, conn))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    Id = int.Parse(dr["id"].ToString());
                    SaldoAbertura = decimal.Parse(dr["saldoabertura"].ToString());
                    xret = true;
                } else
                {
                    xret = false;
                }
            }
            conn.Close();
            dr.Close();
            return xret;
        }


        public bool SalvarAbertura()
        {
            bool xret = true;
            if (!Conecta())
            {
                xret = false;
                return xret;
            }

            StrQuery = "INSERT INTO CAIXA_GERAL (" +
                       "DATA, SALDOABERTURA, ABERTOPOR, FECHADO) VALUES (" +
                       "@DATA, @SALDOABERTURA, @ABERTOPOR, @FECHADO)";

            SqlCommand cmd = new SqlCommand(StrQuery, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            Fechado = "N";

            cmd.Parameters.AddWithValue("@DATA", Data);
            cmd.Parameters.AddWithValue("@SALDOABERTURA", SaldoAbertura);
            cmd.Parameters.AddWithValue("@ABERTOPOR", AbertoPor);
            cmd.Parameters.AddWithValue("@FECHADO", Fechado);

            try
            {
                int i = cmd.ExecuteNonQuery();
                if(i > 0 )
                {
                    xret = true;
                } 
            }catch (SqlException e)
            {
                MessageBox.Show("Erro:" + e.ToString(), "Erro: Salvar Dados");
                xret = false;
            }

          
            conn.Close();
            return xret;
        }

        // ******* interligacao de tabelas com SQL SERVER
        // SELECT *
        // FROM CAIXA_GERAL INNER JOIN
        // CAIXA_GERAL_MOVIMENTO ON CAIXA_GERAL.id = CAIXA_GERAL_MOVIMENTO.idcaixa



    }
}
