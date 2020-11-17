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


namespace Sistema.Models
{
    class ContasReceber:Db
    {
        public List<ContasReceber> contas;
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Documento { get; set; }
        public int Cliente { get; set; }
        public String Cliente_Nome { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public double ValorBruto { get; set; }
        public double Juros { get; set; }
        public double Desconto { get; set; }
        public double ValorDocumento { get; set; }
        public string CentroVENDAS { get; set; }
        public string CentroVENDAS_Descricao { get; set; }
        public string Historico { get; set; }
        public string Pago { get; set; }
        public double ValorPago { get; set; }

        public ArrayList wlClientes = new ArrayList();
        public ArrayList wlCentroVENDAS = new ArrayList();


        public SqlDataReader dr;

        
        //construtor da classe

        public ContasReceber()
        {
        }

        public ContasReceber(int id, string documento, int cliente, string cliente_Nome, DateTime dataEmissao, DateTime dataVencimento, DateTime dataPagamento, double valorDocumento, string centroVenda, string pago)
        {
            Id = id;
            Documento = documento;
            Cliente = cliente;
            Cliente_Nome = cliente_Nome;
            DataEmissao = dataEmissao;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
            ValorDocumento = valorDocumento;
            CentroVENDAS = centroVenda;
            Pago = pago;
        }

        public ContasReceber(string documento, int cliente, DateTime dataEmissao, DateTime dataVencimento, double valorBruto, string centroVenda, string historico)
        {
            Documento = documento;
            Cliente = cliente;
            DataEmissao = dataEmissao;
            DataVencimento = dataVencimento;
            ValorBruto = valorBruto;
            CentroVENDAS = centroVenda;
            Historico = historico;
        }

        public double TotalReceber(double valorbruto, double juros, double desconto)
        {
            ValorDocumento = (valorbruto + juros) - desconto;
            Juros = juros;
            Desconto = desconto;
            return ValorDocumento;
        }

        public void MontaGrade(string pOrdem, string pDe, string pAte, string pCliente, string pCentroVenda)
        {
            // pOrdem -> EMISSAO , VENCIMENTO , BAIXA

            contas = new List<ContasReceber>();
            string StrQuery = "";

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string xOrdem = pOrdem.ToString();

            switch (xOrdem)
            {
                case "EMISSAO":
                    StrQuery = "SELECT * FROM CONTASRECEBER WITH (INDEX(i_EMISSAO)) WHERE " +
                         "EMISSAO >= '" + pDe.ToString() +
                         "' AND EMISSAO <= '" + pAte.ToString() + "'";
                    break;
                case "VENCIMENTO":
                    StrQuery = "SELECT * FROM CONTASRECEBER WITH (INDEX(i_Vencimento)) WHERE " +
                        "VENCIMENTO >= '" + pDe.ToString() +
                        "' AND VENCIMENTO <= '" + pAte.ToString() + "'";
                    break;
                case "BAIXA":
                    StrQuery = "SELECT * FROM CONTASRECEBER WITH (INDEX(i_Baixa)) WHERE " +
                        "BAIXA >= '" + pDe.ToString() +
                        "' AND BAIXA <= '" + pAte.ToString() + "'";
                    break;
                default:
                    StrQuery = "SELECT * FROM CONTASRECEBER WITH (INDEX(i_Vencimento))";
                    break;
            }

            if (!string.IsNullOrEmpty(pCliente.ToString()))
            {
                StrQuery += " AND CLIENTE = " + pCliente.ToString();
            }

            pCentroVenda = pCentroVenda.Replace(" ", "");

            if (pCentroVenda.ToString() == ".")
            {
                pCentroVenda = "";
            }

            if (!string.IsNullOrEmpty(pCentroVenda.ToString()))
            {
                StrQuery += " AND CENTROVENDAS = " + pCentroVenda.ToString();
            }


            SqlCommand CMD = new SqlCommand();
            CMD.CommandText = StrQuery;
            CMD.CommandType = CommandType.Text;
            CMD.Connection = conn;
            dr = CMD.ExecuteReader();
            string xData = "";
            while (dr.Read())
            {
                if (DBNull.Value.Equals(dr["baixa"]))
                {
                    xData = "01/01/1980";
                }
                else
                {
                    xData = dr["baixa"].ToString();
                }

                contas.Add(
                    new ContasReceber(
                        int.Parse(dr["Id"].ToString()),
                        dr["Documento"].ToString(),
                        int.Parse(dr["cliente"].ToString()),
                        dr["cliente_nome"].ToString(),
                        DateTime.Parse(dr["emissao"].ToString()),
                        DateTime.Parse(dr["vencimento"].ToString()),
                        DateTime.Parse(xData.ToString()),
                        double.Parse(dr["valordocumento"].ToString()),
                        dr["centrovenda"].ToString(),
                        dr["pago"].ToString()));

            }

            conn.Close();

        }

        public void CarregaCentroVENDAS()
        {
            if (!Conecta())
            {
                MessageBox.Show("Banco de Dados não conectado !");
                return;
            }

            String StrQuery = "SELECT Codigo, Descricao FROM CENTROVENDAS WITH (INDEX(i_DESCRICAO)) ORDER BY DESCRICAO";

            SqlCommand CMD = new SqlCommand();

            CMD = new SqlCommand(StrQuery, conn);

            dr = CMD.ExecuteReader();

            string xcodigo = "";
            string xdescricao = "";

            while (dr.Read())
            {
                xcodigo = dr["codigo"].ToString();
                xdescricao = dr["descricao"].ToString();

                wlCentroVENDAS.Add(xcodigo.ToString() + "-" + xdescricao);

            }

            conn.Close();
        }

        public void ConsultaCentroVENDASID(string pCodigo)
        {

            if (!Conecta())
            {
                MessageBox.Show("Banco de Dados não conectado !");
                return;
            }

            string StrQuery = "SELECT CODIGO,DESCRICAO FROM CENTROVENDAS WITH (INDEX(i_CODIGO)) WHERE CODIGO='" + pCodigo + "'";
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
                    CentroVENDAS_Descricao = dr["descricao"].ToString();
                }
            }

            conn.Close();

        }

        public bool ConsultaReceberID()
        {
            bool xRetorno = false;

            if (!Conecta())
            {
                MessageBox.Show("Banco de Dados não conectado !");
                return false;
            }

            int xId = int.Parse(Id.ToString());

            string StrQuery = "SELECT * FROM CONTASReceber WITH (INDEX(i_ID)) WHERE Id=" + xId.ToString() + "";
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
                    Cliente = int.Parse(dr["Cliente"].ToString());
                    Cliente_Nome = dr["Cliente_nome"].ToString();
                    DataEmissao = DateTime.Parse(dr["emissao"].ToString());
                    DataVencimento = DateTime.Parse(dr["vencimento"].ToString());
                    Pago = "N";
                    if (!string.IsNullOrEmpty(dr["baixa"].ToString()))
                    {
                        DataPagamento = DateTime.Parse(dr["baixa"].ToString());
                        Pago = dr["pago"].ToString();

                    }

                    ValorBruto = double.Parse(dr["valorbruto"].ToString());
                    Desconto = double.Parse(dr["desconto"].ToString());
                    Juros = double.Parse(dr["juros"].ToString());
                    ValorDocumento = double.Parse(dr["valordocumento"].ToString());
                    CentroVENDAS = dr["CentroVenda"].ToString();
                    CentroVENDAS_Descricao = dr["CentroVenda_descricao"].ToString();
                    Historico = dr["historico"].ToString();

                    xRetorno = true;
                }
                else
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
            if (!Conecta())
            {
                MessageBox.Show("O banco de dados não está conectado !");
                return false;
            }

            String strquery;


            strquery = "UPDATE CONTASReceber SET " +
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
            if (pBaixar)
            {
                cmd.Parameters.AddWithValue("@valorpago", ValorPago);
                cmd.Parameters.AddWithValue("@pago", Pago);
                cmd.Parameters.AddWithValue("@baixa", DataPagamento);

            }
            else
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
                    if (pBaixar)
                    {
                        MessageBox.Show("Documento baixado com sucesso !");

                    } else
                    {
                        MessageBox.Show("Documento <Estornado> com sucesso !");
                    }
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

            if (pIncluir)
            {
                // inclusao
                strquery = "INSERT INTO CONTASRECEBER (" +
                        "data," +
                        "documento," +
                        "Cliente," +
                        "Cliente_nome," +
                        "emissao," +
                        "vencimento," +
                        "valorbruto," +
                        "juros," +
                        "desconto," +
                        "valordocumento," +
                        "CentroVenda," +
                        "CentroVenda_descricao," +
                        "historico) VALUES (@data, @documento, @Cliente, @Cliente_nome," +
                        "@dataemissao,@datavencimento,@valorbruto,@juros,@desconto," +
                        "@valordocumento,@CentroVenda,@CentroVenda_descricao,@historico)";
            }
            else
            {
                // ALTERACAO
                strquery = "UPDATE CONTASRECEBER SET " +
                    "data=@data," +
                    "documento=@documento," +
                    "Cliente=@Cliente," +
                    "Cliente_nome=@Cliente_nome," +
                    "emissao=@dataemissao," +
                    "vencimento=@datavencimento," +
                    "valorbruto=@valorbruto," +
                    "juros=@juros," +
                    "desconto=@desconto," +
                    "valordocumento=@valordocumento," +
                    "CentroVenda=@CentroVenda," +
                    "CentroVenda_descricao=@CentroVenda_descricao," +
                    "historico=@historico WHERE id=" + Id;

            }
            SqlCommand cmd = new SqlCommand(strquery, conn);
            //  adiciona os dados da classe nos objetos do CMD
            cmd.Parameters.AddWithValue("@data", Data);
            cmd.Parameters.AddWithValue("@documento", Documento);
            cmd.Parameters.AddWithValue("@Cliente", Cliente);
            cmd.Parameters.AddWithValue("@Cliente_nome", Cliente_Nome);
            cmd.Parameters.AddWithValue("@dataemissao", DataEmissao);
            cmd.Parameters.AddWithValue("@datavencimento", DataVencimento);
            cmd.Parameters.AddWithValue("@valorbruto", ValorBruto);
            cmd.Parameters.AddWithValue("@juros", Juros);
            cmd.Parameters.AddWithValue("@desconto", Desconto);
            cmd.Parameters.AddWithValue("@valordocumento", ValorDocumento);
            cmd.Parameters.AddWithValue("@CentroVenda", CentroVENDAS);
            cmd.Parameters.AddWithValue("@CentroVenda_descricao", CentroVENDAS_Descricao);
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
                   // MessageBox.Show("Registro atualizado com sucesso!");
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

        public bool ConsultaClienteID(int pID)
        {
            bool ret = false;

            if (!Conecta())
            {
                MessageBox.Show("Banco de Dados não conectado !");
                return false;
            }

            string StrQuery = "SELECT Id,Nome FROM Cliente WITH (INDEX(i_ID)) WHERE Id = " + pID.ToString();
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
                    Cliente_Nome = dr["Nome"].ToString();
                    ret = true;
                }
                else
                {
                    Cliente_Nome = "";
                    ret = false;
                }
            }

            conn.Close();
            return ret;

        }
        public void CarregaClientees()
        {
            int x = 0;

            if (!Conecta())
            {
                MessageBox.Show("Banco de Dados não conectado !");
                return;
            }

            String StrQuery = "SELECT Id,Nome FROM Cliente WITH (INDEX(i_nome)) ORDER BY Nome";
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(StrQuery, conn);
            dr = cmd.ExecuteReader();

            // gera o datareader atraves da string de abertura da tabela (SQLCOMMAND)
            string xNomes = "";
            string xId = "";
            int z = dr.RecordsAffected;
            // wlClientees = new string[50];


            while (dr.Read())
            {
                xId = dr["Id"].ToString();
                xNomes = dr["Nome"].ToString();

                //  wlClientees[x] = xId.ToString().PadLeft(5,'0') + "-" + xNomes;
                wlClientes.Add(xId.ToString().PadLeft(5, '0') + "-" + xNomes);
                x++;

            }

            conn.Close();
            dr.Close();

        }





    }
}
