using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Sistema.Models;

namespace Sistema
{
    class CrudTecnicos : Db
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool Whatsapp { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime Nascimento { get; set; }
        public double Comissao { get; set; }

        public string StringPesquisa { get; set; }
        public string ComboPesquisa { get; set; }

        public DataTable dt = new DataTable();   // para gridview1
        private DataSet ds = new DataSet();      // para gridview1


        public SqlDataReader dr;

        public void Deleta_Dados(int Id)
        {
            conn.Open();
            string sql = "DELETE FROM Tecnico WHERE Id=" + Id.ToString() + "";
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

                sql = "INSERT INTO Tecnico (Nome, Cpf, Rg, Cep, Endereco, Bairro, Cidade, Estado," +
                      "Telefone, Celular, Whatsapp, Email, Nascimento, Comissao) VALUES (@nome, @cpf, @rg, @cep, @endereco, @bairro, @cidade, @estado, @telefone, @celular, @whatsapp, @email, @nascimento, @comissao)";

            }
            else
            {

                sql = "UPDATE Tecnico SET Nome=@nome, Cpf=@cpf, Rg=@rg," +
                             "Cep=@cep, Endereco=@endereco, Bairro=@bairro, " +
                             "Cidade=@cidade, Estado=@estado, Telefone=@telefone, Celular=@celular, Whatsapp=@whatsapp, Email=@email, Nascimento=@nascimento, Comissao=@comissao WHERE id=" + xID;
            }

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.Parameters.AddWithValue("@rg", Rg);
            cmd.Parameters.AddWithValue("@cep", Cep);
            cmd.Parameters.AddWithValue("@endereco", Endereco);
            cmd.Parameters.AddWithValue("@bairro", Bairro);
            cmd.Parameters.AddWithValue("@cidade", Cidade);
            cmd.Parameters.AddWithValue("@estado", Estado);
            cmd.Parameters.AddWithValue("@telefone", Telefone);
            cmd.Parameters.AddWithValue("@celular", Celular);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@nascimento", Nascimento.ToString());
            cmd.Parameters.AddWithValue("@whatsapp", Whatsapp);
            cmd.Parameters.AddWithValue("@comissao", Comissao);

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
                cmd.CommandText = "SELECT * FROM Tecnico WHERE id=" + Identificador + "";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    if (dr["Id"].ToString() == Id.ToString())
                    {
                        Nome = dr["Nome"].ToString();
                        Endereco = dr["endereco"].ToString();
                        Bairro = dr["bairro"].ToString();
                        Cidade = dr["Cidade"].ToString();
                        Estado = dr["Estado"].ToString();
                        Cep = dr["cep"].ToString();
                        Telefone = dr["Telefone"].ToString();
                        Celular = dr["Celular"].ToString();
                        Comissao = double.Parse(dr["Comissao"].ToString());
                        if (dr["whatsapp"].Equals(true))
                        {
                            Whatsapp = true;
                        }
                        else
                        {
                            Whatsapp = false;

                        }
                        Cpf = dr["Cpf"].ToString();
                        Rg = dr["Rg"].ToString();
                        Email = dr["Email"].ToString();
                        Nascimento = Convert.ToDateTime(dr["Nascimento"].ToString());
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
            if (ComboPesquisa == "Nome" && StringPesquisa != "")
            {
                StrQuery = "select Id,Nome,Cidade,Estado,Telefone,Celular,Whatsapp,Cpf from Tecnico where Nome LIKE '%"
                   + StringPesquisa + "%' order by Nome";

            }
            if (ComboPesquisa == "CPF" && StringPesquisa != "")
            {
                StrQuery = "select Id,Nome,Cidade,Estado,Telefone,Celular,Whatsapp,Cpf from Tecnico where Cpf='"
                   + StringPesquisa + "'";

            }
            if (ComboPesquisa == "Cidade" && StringPesquisa != "")
            {
                StrQuery = "select Id,Nome,Cidade,Estado,Telefone,Celular,Whatsapp,Cpf from Tecnico where Cidade='"
                   + StringPesquisa + "'";

            }
            else if (ComboPesquisa == "Id" && StringPesquisa != "")
            {
                StrQuery = "select Id,Nome,Cidade,Estado,Telefone,Celular,Whatsapp,Cpf from Tecnico where Id=" +
                    StringPesquisa + "";
            }
            else if (StringPesquisa == "")
            {
                StrQuery = "select Id,Nome,Cidade,Estado,Telefone,Celular,Whatsapp,Cpf from Tecnico order by Nome";

            }

            cmd = new SqlCommand(StrQuery, conn);

            // gera o datareader atraves da string de abertura da tabela (SQLCOMMAND)
            SqlDataReader dr = cmd.ExecuteReader();
            // Cria o datatable para criar as colunas de dados
            DataTable dataTable = new DataTable();
            // estancia as colunas de dados no DATATABLE

            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Cidade");
            dataTable.Columns.Add("Estado");
            dataTable.Columns.Add("Telefone");
            dataTable.Columns.Add("Celular");
            dataTable.Columns.Add("Whatsapp");
            dataTable.Columns.Add("Cpf");
            // LAÇO WHILE no dr.Read() --> onde contem os dados
            while (dr.Read())
            {
                // cria um DATAROW que é um dicionario de dados onde vai referenciar
                // para cada campo, seus dados.
                DataRow row = dataTable.NewRow();

                row["Id"] = dr["Id"].ToString();  // na linha a coluna ID recebe o conteudo dr(tabela de dados) do campo Id do SQL SERVER.
                row["Nome"] = dr["Nome"].ToString();
                row["Cidade"] = dr["Cidade"].ToString();
                row["Estado"] = dr["Estado"].ToString();
                row["Telefone"] = dr["Telefone"].ToString();
                row["Celular"] = dr["Celular"].ToString();
                if (dr["whatsapp"].Equals(true))
                {
                    row["Whatsapp"] = "Sim";
                }
                else
                {
                    row["Whatsapp"] = "Não";
                }
                dataTable.Rows.Add(row);
                row["Cpf"] = dr["Cpf"].ToString();
            }
            conn.Close();
            SqlDataAdapter SDA = new SqlDataAdapter(StrQuery, conn);
            dt.Clear();
            SDA.Fill(ds);
            dt = ds.Tables[0];

            //            Read_Data();


        }

        public void Read_Data()
        {

        }



        public void FechaConexao()
        {
            conn.Close();
        }




    }
}
