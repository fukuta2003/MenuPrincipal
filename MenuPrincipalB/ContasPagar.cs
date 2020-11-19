using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;
using Sistema.Models;

namespace SistemaPadrao
{
    public class ContasPagar : Db
    {
        public List<ContasPagar> contas;
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public String Documento { get; set; }
        public int Fornecedor { get; set; }
        public String Fornecedor_Nome { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public double ValorBruto { get; set; }
        public double Juros { get; set; }
        public double Desconto { get; set; }
        public double ValorDocumento { get; set; }
        public String CentroCusto { get; set; }
        public String CentroCusto_Descricao { get; set; }
        public String Historico { get; set; }
        public string Pago { get; set; }
        public double ValorPago { get; set; }
        
        public ArrayList wlFornecedores = new ArrayList();
        public ArrayList wlCentroCustos = new ArrayList();

       
        public SqlDataReader dr;

        //construtor da classe

        public ContasPagar()
        {

        }

        public ContasPagar(int id, string documento, int fornecedor, string fornecedor_Nome, DateTime dataEmissao, DateTime dataVencimento, DateTime dataPagamento, double valorDocumento, string centroCusto, string pago)
        {
            Id = id;
            Documento = documento;
            Fornecedor = fornecedor;
            Fornecedor_Nome = fornecedor_Nome;
            DataEmissao = dataEmissao;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
            ValorDocumento = valorDocumento;
            CentroCusto = centroCusto;
            Pago = pago;
        }

        public ContasPagar(string documento, int fornecedor, DateTime dataEmissao, DateTime dataVencimento, double valorBruto, string centroCusto, string historico)
        {
            Documento = documento;
            Fornecedor = fornecedor;
            DataEmissao = dataEmissao;
            DataVencimento = dataVencimento;
            ValorBruto = valorBruto;
            CentroCusto = centroCusto;
            Historico = historico;
        }

        public double TotalPagar(double valorbruto, double juros, double desconto)
        {
            ValorDocumento = (valorbruto + juros) - desconto;
            Juros = juros;
            Desconto = desconto;
            return ValorDocumento;
        }

       
        public void MontaGrade(string pOrdem, string pDe, string pAte, string pFornecedor, string pCentroCusto)
        {
            // pOrdem -> EMISSAO , VENCIMENTO , BAIXA

            contas = new List<ContasPagar>();
            string StrQuery = "";

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string xOrdem = pOrdem.ToString();

            switch (xOrdem)
            {
                case "EMISSAO":
                   StrQuery = "SELECT * FROM CONTASPagar WITH (INDEX(i_EMISSAO)) WHERE " +
                        "EMISSAO >= '"+pDe.ToString() + 
                        "' AND EMISSAO <= '" + pAte.ToString() + "'";
                   break;
                case "VENCIMENTO":
                    StrQuery = "SELECT * FROM CONTASPagar WITH (INDEX(i_Vencimento)) WHERE " +
                        "VENCIMENTO >= '" + pDe.ToString() +
                        "' AND VENCIMENTO <= '" + pAte.ToString() + "'";
                    break;
                case "BAIXA":
                    StrQuery = "SELECT * FROM CONTASPagar WITH (INDEX(i_Baixa)) WHERE " +
                        "BAIXA >= '" + pDe.ToString() +
                        "' AND BAIXA <= '" + pAte.ToString() + "'";
                    break;
                default:
                    StrQuery = "SELECT * FROM CONTASPagar WITH (INDEX(i_Vencimento))";
                    break;
            }

            if (!string.IsNullOrEmpty(pFornecedor.ToString()))
            {
                StrQuery += " AND FORNECEDOR = " + pFornecedor.ToString();
            }

            pCentroCusto = pCentroCusto.Replace(" ", "");

            if (pCentroCusto.ToString() == ".")
            {
                pCentroCusto = "";
            }

            if (!string.IsNullOrEmpty(pCentroCusto.ToString()))
            {
                StrQuery += " AND CENTROCUSTO = " + pCentroCusto.ToString();
            }


            SqlCommand CMD = new SqlCommand();
            CMD.CommandText = StrQuery;
            CMD.CommandType = CommandType.Text;
            CMD.Connection = conn;
            dr = CMD.ExecuteReader();
            string xData = "";
            while (dr.Read())
            {
                if(DBNull.Value.Equals(dr["baixa"]))
                {
                    xData = "01/01/1980";
                } else
                {
                    xData = dr["baixa"].ToString();
                }
                contas.Add(
                    new ContasPagar(
                        int.Parse(dr["Id"].ToString()),
                        dr["Documento"].ToString(),
                        int.Parse(dr["fornecedor"].ToString()),
                        dr["fornecedor_nome"].ToString(),
                        DateTime.Parse(dr["emissao"].ToString()),
                        DateTime.Parse(dr["vencimento"].ToString()),
                        DateTime.Parse(xData.ToString()),
                        double.Parse(dr["valordocumento"].ToString()),
                        dr["centrocusto"].ToString(),
                        dr["pago"].ToString()));

            }

            conn.Close();

        }


        public void CarregaCentroCustos()
        {
            if(!Conecta())
            {
                MessageBox.Show("Banco de Dados não conectado !");
                return;
            }

            String StrQuery = "SELECT Codigo, Descricao FROM CENTROCUSTOS WITH (INDEX(i_DESCRICAO)) ORDER BY DESCRICAO";

            SqlCommand CMD = new SqlCommand();

            CMD = new SqlCommand(StrQuery, conn);

            dr = CMD.ExecuteReader();

            string xcodigo = "";
            string xdescricao = "";

            while (dr.Read())
            {
                xcodigo = dr["codigo"].ToString();
                xdescricao = dr["descricao"].ToString();

                wlCentroCustos.Add(xcodigo.ToString() + "-" + xdescricao);

            }

            conn.Close();
        }

        public void ConsultaCentroCustosID(string pCodigo)
        {

            if (!Conecta())
            {
                MessageBox.Show("Banco de Dados não conectado !");
                return;
            }

            string StrQuery = "SELECT CODIGO,DESCRICAO FROM CENTROCUSTOS WITH (INDEX(i_CODIGO)) WHERE CODIGO='" + pCodigo + "'";
            SqlCommand CMD = new SqlCommand();
            CMD.CommandText = StrQuery;
            CMD.CommandType = CommandType.Text;
            CMD.Connection = conn;
            dr = CMD.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (dr["codigo"].ToString() == pCodigo.ToString())
                {
                    CentroCusto_Descricao = dr["descricao"].ToString();
                }
            }

            conn.Close();

        }

        public bool ConsultaPagarID()
        {
            bool xRetorno = false;

            if (!Conecta())
            {
                MessageBox.Show("Banco de Dados não conectado !");
                return false;
            }

            int xId = int.Parse(Id.ToString());

            string StrQuery = "SELECT * FROM CONTASPagar WITH (INDEX(i_ID)) WHERE Id=" + xId.ToString() + ""; 
            SqlCommand CMD = new SqlCommand();
            CMD.CommandText = StrQuery;
            CMD.CommandType = CommandType.Text;
            CMD.Connection = conn;
            dr = CMD.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (dr["Id"].ToString() == Id.ToString())
                {
                    Data = DateTime.Parse(dr["data"].ToString());
                    Documento = dr["documento"].ToString();
                    Fornecedor = int.Parse(dr["fornecedor"].ToString());
                    Fornecedor_Nome = dr["fornecedor_nome"].ToString();
                    DataEmissao = DateTime.Parse(dr["emissao"].ToString());
                    DataVencimento = DateTime.Parse(dr["vencimento"].ToString());
                    Pago = "N";
                    if(dr["pago"].ToString()=="S")
                    {
                        DataPagamento = DateTime.Parse(dr["baixa"].ToString());
                        Pago = dr["pago"].ToString();

                    } 
                   
                    ValorBruto = double.Parse(dr["valorbruto"].ToString());
                    Desconto = double.Parse(dr["desconto"].ToString());
                    Juros = double.Parse(dr["juros"].ToString());
                    ValorDocumento = double.Parse(dr["valordocumento"].ToString());
                    CentroCusto = dr["centrocusto"].ToString();
                    CentroCusto_Descricao = dr["centrocusto_descricao"].ToString();
                    Historico = dr["historico"].ToString();

                    xRetorno = true;
                } else
                {
                    xRetorno = false;
                }
            }

            conn.Close();
            return xRetorno;
        }


        // ------------- baixa de documentos


        public bool Baixar(bool pBaixar)
        {
            if(!Conecta())
            {
                MessageBox.Show("O banco de dados não está conectado !");
                return false;
            }

            String strquery;
           

            strquery = "UPDATE CONTASPagar SET " +
                "baixa=@baixa," +
                "juros=@juros," +
                "desconto=@desconto," +
                "valordocumento=@valordocumento," +
                "pago=@pago," +
                "valorpago=@valorpago WHERE id=" + Id;

            SqlCommand cmd = new SqlCommand(strquery, conn);
            cmd.Parameters.AddWithValue("@juros", Juros);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.Parameters.AddWithValue("@valordocumento", ValorDocumento);
            if(pBaixar)
            {
                cmd.Parameters.AddWithValue("@valorpago", ValorPago);
                cmd.Parameters.AddWithValue("@pago", Pago);
                cmd.Parameters.AddWithValue("@baixa", DataPagamento);

            } else
            {
                cmd.Parameters.AddWithValue("@valorpago", 0);
                cmd.Parameters.AddWithValue("@pago", "N");
                cmd.Parameters.AddWithValue("@baixa", DateTime.Parse("01/01/1980"));
            }

            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();  // ESTA LINHA SALVA DOS DADOS NO BANCO DE DADOS E RETORNA QUANTAS LINHAS FORAM AFETADAS.
                if (i > 0)
                    MessageBox.Show("Documento baixado com sucesso !");
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

        public bool InserirDados(bool pIncluir)
        {
            if (!Conecta())
            {
                MessageBox.Show("Banco de Dados não conectado !");
                return false;
            }
            String strquery;

            if(pIncluir) { 
                // inclusao
                strquery = "INSERT INTO CONTASPagar (" +
                        "data," +
                        "documento," +
                        "fornecedor," +
                        "fornecedor_nome," +
                        "emissao," +
                        "vencimento," +
                        "valorbruto," +
                        "juros," +
                        "desconto," +
                        "valordocumento," +
                        "centrocusto," +
                        "centrocusto_descricao," +
                        "historico) VALUES (@data, @documento, @fornecedor, @fornecedor_nome," +
                        "@dataemissao,@datavencimento,@valorbruto,@juros,@desconto," +
                        "@valordocumento,@centrocusto,@centrocusto_descricao,@historico)";
            } else
            {
                // ALTERACAO
                strquery = "UPDATE CONTASPagar SET " +
                    "data=@data," +
                    "documento=@documento," +
                    "fornecedor=@fornecedor," +
                    "fornecedor_nome=@fornecedor_nome," +
                    "emissao=@dataemissao," +
                    "vencimento=@datavencimento," +
                    "valorbruto=@valorbruto," +
                    "juros=@juros," +
                    "desconto=@desconto," +
                    "valordocumento=@valordocumento," +
                    "centrocusto=@centrocusto," +
                    "centrocusto_descricao=@centrocusto_descricao," +
                    "historico=@historico WHERE id=" + Id;

            }
            SqlCommand cmd = new SqlCommand(strquery,conn);
            //  adiciona os dados da classe nos objetos do CMD
            cmd.Parameters.AddWithValue("@data", Data);
            cmd.Parameters.AddWithValue("@documento", Documento);
            cmd.Parameters.AddWithValue("@fornecedor", Fornecedor);
            cmd.Parameters.AddWithValue("@fornecedor_nome", Fornecedor_Nome);
            cmd.Parameters.AddWithValue("@dataemissao", DataEmissao);
            cmd.Parameters.AddWithValue("@datavencimento", DataVencimento);
            cmd.Parameters.AddWithValue("@valorbruto", ValorBruto);
            cmd.Parameters.AddWithValue("@juros", Juros);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.Parameters.AddWithValue("@valordocumento", ValorDocumento);
            cmd.Parameters.AddWithValue("@centrocusto", CentroCusto);
            cmd.Parameters.AddWithValue("@centrocusto_descricao", CentroCusto_Descricao);
            cmd.Parameters.AddWithValue("@historico", Historico);

            // cmd.Parameters.AddWithValue("@baixa", DataPagamento);

            cmd.CommandType = CommandType.Text;

            // TENTA REALIZAR A INCLUSAO, CASO TENHA SUCESSO ELA SALVA OS DADOS E RETORNA (OK)
            // SE ALGUM ERRO ACONTECER, É CRIADA UMA EXCEPTION QUE MOSTRA NA TELA O ERRO OCORRIDO
            // E FINALMENTE (FINNALY) CONCLUI A OPERACAO.

            try
            {
                int i = cmd.ExecuteNonQuery();  // ESTA LINHA SALVA DOS DADOS NO BANCO DE DADOS E RETORNA QUANTAS LINHAS FORAM AFETADAS.
                if (i > 0)
                    MessageBox.Show("Registro atualizado com sucesso!");
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

        public bool ConsultaFornecedorID(int pID)
        {
            bool ret = false;

            if (!Conecta())
            {
                MessageBox.Show("Banco de Dados não conectado !");
                return false;
            }

            string StrQuery = "SELECT Id,Nome FROM Fornecedores WITH (INDEX(i_ID)) WHERE Id = " + pID.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StrQuery;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (dr["Id"].ToString() == pID.ToString())
                {
                    Fornecedor_Nome = dr["Nome"].ToString();
                    ret = true;
                } else
                {
                    Fornecedor_Nome = "";
                    ret = false;
                }
            }

            conn.Close();
            return ret;

        }
        public void CarregaFornecedores()
        {
            int x = 0;

            if (!Conecta())
            {
                MessageBox.Show("Banco de Dados não conectado !");
                return;
            }

            String StrQuery = "SELECT Id,Nome FROM Fornecedores WITH (INDEX(i_nome)) ORDER BY Nome";
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(StrQuery, conn);
            dr = cmd.ExecuteReader();

            // gera o datareader atraves da string de abertura da tabela (SQLCOMMAND)
            string xNomes = "";
            string xId = "";
            int z = dr.RecordsAffected;
           // wlFornecedores = new string[50];
            

            while (dr.Read())
            {
                xId = dr["Id"].ToString();
                xNomes = dr["Nome"].ToString();

               //  wlFornecedores[x] = xId.ToString().PadLeft(5,'0') + "-" + xNomes;
                wlFornecedores.Add(xId.ToString().PadLeft(5, '0') + "-" + xNomes);
                x++;

            }

            conn.Close();
            dr.Close();

        }



    }


}
