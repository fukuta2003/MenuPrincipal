using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Models
{
    class Empresa : Db
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public string Cnpj { get; set; }
        public string Iestadual { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Validade { get; set; }

        public SqlDataReader dr;
        public string strQuery = "";

        public Empresa()
        {
        }

        public Empresa(int id, string razaoSocial, string fantasia, string cnpj, string iestadual, string endereco, string bairro, string cidade, string estado, string cep, string telefone, string email, DateTime validade)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Iestadual = iestadual;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Telefone = telefone;
            Email = email;
            Validade = validade;
        }


        public bool Consulta(int pID)
        {
            bool xret = true;

            if (!Conecta())
            {
                xret = false;
                return xret;
            }

            strQuery = "SELECT * FROM EMPRESA WHERE ID=1";
            SqlCommand cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Id = int.Parse(dr["id"].ToString());
                RazaoSocial = dr["razaosocial"].ToString();
                Fantasia = dr["fantasia"].ToString();
                Cnpj = dr["cnpj"].ToString();
                Iestadual = dr["iestadual"].ToString();
                Endereco = dr["endereco"].ToString();
                Bairro = dr["bairro"].ToString();
                Cidade = dr["cidade"].ToString();
                Estado = dr["estado"].ToString();
                Cep = dr["cep"].ToString();
                Telefone = dr["Telefone"].ToString();
                Email = dr["email"].ToString();
                Validade = DateTime.Parse(dr["validade"].ToString());
                xret = true;
            }

            dr.Close();
            conn.Close();
            return xret;


        }


    }
}
