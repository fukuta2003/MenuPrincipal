using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema.Models
{
    class CrudServicos : Db
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorVista { get; set; }
        public double ValorPrazo { get; set; }

        public string StringPesquisa { get; set; }
        public string ComboPesquisa { get; set; }

        public DataTable dt = new DataTable();   // para gridview1
        private DataSet ds = new DataSet();      // para gridview1


        public SqlDataReader dr;

        public void Deleta_Dados(int Id)
        {
            conn.Open();
            string sql = "DELETE FROM Servico WHERE Id=" + Id.ToString() + "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public bool Salvar_Dados(bool Criar)
        {
            conn.Open();
            int xID = 0;
            DateTime xDataHoje = DateTime.Now;
            // salvar os dados
            if (Criar == false)
            {
                xID = Id;
            }

            string sql = "";
            if (Criar)
            {

                sql = "INSERT INTO Servico (Descricao, ValorVista, ValorPrazo) VALUES (@descricao, @valorvista, @valorprazo)";

            }
            else
            {

                sql = "UPDATE Servico SET Descricao=@descricao, ValorVista=@valorvista, ValorPrazo=@valorprazo" +
                             " WHERE id=" + xID;
            }

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@descricao", Descricao);
            cmd.Parameters.AddWithValue("@valorvista", ValorVista);
            cmd.Parameters.AddWithValue("@valorprazo", ValorPrazo);

            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
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



        public bool Consulta_Dados(int Identificador)
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM Servico WHERE id=" + Identificador + "";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    if (dr["Id"].ToString() == Id.ToString())
                    {
                        Descricao = dr["Descricao"].ToString();
                        ValorVista = double.Parse(dr["ValorVista"].ToString());
                        ValorPrazo = double.Parse(dr["ValorPrazo"].ToString());
                        conn.Close();
                        return true;
                    }
                    else
                    {

                        conn.Close();
                        return false;
                    }

                }
                conn.Close();
                return false;
            }

        }

        // pesquisa por tipo de campo
        public void Pesquisa(string StringPesquisa)
        {
            conn.Open();

            // estancia SQLCOMMAND para poder passar a string de abertuda da tabela de dados
            SqlCommand cmd = new SqlCommand();

            string StrQuery = "";
            // conforme a selecao na combobox, faz a pesquisa por nome, cidade, id, cpf
            if (ComboPesquisa == "Descrição" && StringPesquisa != "")
            {
                StrQuery = "select Id,Descricao,ValorVista,ValorPrazo from Servico where Descricao LIKE '%"
                   + StringPesquisa + "%' order by Descricao";

            }
            else if (ComboPesquisa == "Id" && StringPesquisa != "")
            {
                StrQuery = "select Id,Descricao,ValorVista,ValorPrazo from Servico where Id=" +
                    StringPesquisa + "";
            }
            else if (StringPesquisa == "")
            {
                StrQuery = "select Id,Descricao,ValorVista,ValorPrazo from Servico order by Descricao";

            }

            cmd = new SqlCommand(StrQuery, conn);

            // gera o datareader atraves da string de abertura da tabela (SQLCOMMAND)
            SqlDataReader dr = cmd.ExecuteReader();
            // Cria o datatable para criar as colunas de dados
            DataTable dataTable = new DataTable();
            // estancia as colunas de dados no DATATABLE

            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Descricao");
            dataTable.Columns.Add("ValorVista");
            dataTable.Columns.Add("ValorPrazo");
            // LAÇO WHILE no dr.Read() --> onde contem os dados
            while (dr.Read())
            {
                // cria um DATAROW que é um dicionario de dados onde vai referenciar
                // para cada campo, seus dados.
                DataRow row = dataTable.NewRow();

                row["Id"] = dr["Id"].ToString();  // na linha a coluna ID recebe o conteudo dr(tabela de dados) do campo Id do SQL SERVER.
                row["Descricao"] = dr["Descricao"].ToString();
                row["ValorVista"] = dr["ValorVista"].ToString();
                row["ValorPrazo"] = dr["ValorPrazo"].ToString();
                dataTable.Rows.Add(row);
            }
            conn.Close();
            SqlDataAdapter SDA = new SqlDataAdapter(StrQuery, conn);
            dt.Clear();
            SDA.Fill(ds);
            dt = ds.Tables[0];

        }

        public void FechaConexao()
        {
            conn.Close();
        }

    }
}
