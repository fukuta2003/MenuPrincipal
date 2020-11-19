using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Models;

namespace Sistema
{
    public partial class fEmpresa : Form
    {

        Empresa emp = new Empresa();
        
        public fEmpresa()
        {
            InitializeComponent();
        }

        private void fEmpresa_Load(object sender, EventArgs e)
        {
            if (emp.Consulta(1))
            {
                BuscaDados();
                DateTime xHoje = DateTime.Today;
                TimeSpan xDias = emp.Validade.Date - xHoje.Date;
                lblRestam.Text = "Restam " + xDias.TotalDays.ToString() + " Dias ";
            }

        }

        private void BuscaDados()
        {
            
            txtRazaoSocial.Text = emp.RazaoSocial.ToString();
            txtFantasia.Text = emp.Fantasia.ToString();
            txtCNPJ.Text = emp.Cnpj.ToString();
            txtIEstadual.Text = emp.Iestadual.ToString();
            txtEndereco.Text = emp.Endereco.ToString();
            txtBairro.Text = emp.Bairro.ToString();
            txtCidade.Text = emp.Cidade.ToString();
            txtEstado.Text = emp.Estado.ToString();
            txtCep.Text = emp.Cep.ToString();
            txtTelefone.Text = emp.Telefone.ToString();
            txtEmail.Text = emp.Email.ToString();
            txtValidade.Text = emp.Validade.ToString();
        }


    }
}
