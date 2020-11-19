using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sistema.Models
{
    class CrudOrdemServicos : Db
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }

        public DataTable dt = new DataTable();   // para gridview1
        private DataSet ds = new DataSet();      // para gridview1
        
        public string BuscaClienteId(int id)
        {
            conn.Open();
            string sql = "SELECT Nome FROM Cliente WHERE Id=" + id + "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string ret = "";
            if (dr.HasRows)
            {
                ret = dr["Nome"].ToString();
            } else
            {
                ret = "";
            }

            conn.Close();
            return ret;
            
        }


        public DataTable MontaComboClientes()
        {
            conn.Open();
            string sql = "SELECT * FROM Cliente ORDER BY Nome";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Nome");

            while (dr.Read())
            {
                // cria um DATAROW que é um dicionario de dados onde vai referenciar
                // para cada campo, seus dados.
                DataRow row = dataTable.NewRow();
                row["Id"] = dr["Id"].ToString();
                row["Nome"] = dr["Nome"].ToString();
                dataTable.Rows.Add(row);
            }
            conn.Close();
            SqlDataAdapter SDA = new SqlDataAdapter(sql, conn);
            dt.Clear();
            SDA.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        
        }
    }
}
