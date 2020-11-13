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

namespace MenuPrincipalB
{
    public partial class fFornecedores : Form
    {

        Fornecedores forn = new Fornecedores();
        Cep cep = new Cep();
        Validacao Funcoes = new Validacao();

        bool wp_incluir = false;

        public fFornecedores()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(Funcoes.Confirma("Deseja realmente excluir ?", "Atenção"))
            {
                if (forn.Excluir(int.Parse(txtID.Text)))
                {
                    MessageBox.Show("FORNECEDOR EXCLUIDO COM SUCESSO !");
                } else
                {
                    MessageBox.Show("Nãoi foi possível excluir ?");
                }

                LimpaDados();
                gpoDados.Enabled = false;
                txtID.Focus();

            }
        }

        private void fFornecedores_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Clear();
            if (cep.Carrega_Estados())
            {
                cmbEstado.Items.AddRange(cep.Estados.ToArray());
            }

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                e.Handled = true;

                if (string.IsNullOrEmpty(txtID.Text))
                {
                    wp_incluir = true;
                    
                } else
                {
                    
                    wp_incluir = false;
                    if (forn.ConsultaFornecedorId(int.Parse(txtID.Text))){

                        BuscarDadosClasse();

                    }


                }

                gpoDados.Enabled = true;
                txtNome.Focus();

            }



        }

        public void BuscarDadosClasse()
        {
            txtNome.Text = forn.Nome.ToString();
            txtEndereco.Text = forn.Endereco.ToString();
            txtBairro.Text = forn.Bairro.ToString();
            txtCidade.Text = forn.Cidade.ToString();
            cmbEstado.Text = forn.Estado.ToString();
            txtCep.Text = forn.Cep.ToString();
            txtTelefone.Text = forn.Telefone.ToString();
            txtCelular.Text = forn.Celular.ToString();
            txtEmail.Text = forn.Email.ToString();
            cmbPessoa.Text = forn.Pessoa.ToString();
            txtCnpj.Text = forn.Cnpj.ToString();
            txtIE.Text = forn.Ie.ToString();
            txtObs.Text = forn.Obs.ToString();
        }

        public void EnviaDadosClasse()
        {
            if(string.IsNullOrEmpty(txtID.Text))
            {
                forn.Id = 0;

            } else
            {
                forn.Id = int.Parse(txtID.Text);
            }
            forn.Nome = txtNome.Text;
            forn.Endereco = txtEndereco.Text;
            forn.Bairro = txtBairro.Text;
            forn.Cidade = txtCidade.Text;
            forn.Estado = cmbEstado.Text;
            forn.Cep = txtCep.Text;
            forn.Telefone = txtTelefone.Text;
            forn.Celular = txtCelular.Text;
            forn.Email = txtEmail.Text;
            forn.Pessoa = cmbPessoa.Text;
            forn.Cnpj = txtCnpj.Text;
            forn.Ie = txtIE.Text;
            forn.Obs = txtObs.Text;
        }

        public void LimpaDados()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cmbEstado.Text = "";
            txtCep.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            cmbPessoa.Text = "";
            txtCnpj.Text = "";
            txtIE.Text = "";
            txtObs.Text = "";

        }

        private bool VerificaDados()
        {
            bool ret = true;
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                ret = false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                ret = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                ret = false;
            }

            return ret;

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            txtCep.Text = Funcoes.Formata_Cep(txtCep.Text);
            SendKeys.SendWait("{END}");
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            txtTelefone.Text = Funcoes.Formata_TelefoneFixo(txtTelefone.Text);
            SendKeys.SendWait("{END}");
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            txtCelular.Text = Funcoes.Formata_Celular(txtCelular.Text);
            SendKeys.SendWait("{END}");
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            if (cmbPessoa.Text == "FÍSICA")
            {
                txtCnpj.Text = Funcoes.Formata_CPF(txtCnpj.Text);
            }
            if (cmbPessoa.Text == "JURÍDICA")
            {

                txtCnpj.Text = Funcoes.Formata_CNPJ(txtCnpj.Text);
            }

            SendKeys.SendWait("{END}");
        }

        private void gpoDados_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if(Funcoes.Confirma("Atenção","Posso salvar os dados ?"))
            {
                EnviaDadosClasse();
                if (forn.Salvar(wp_incluir))
                {
                    MessageBox.Show("Dados salvos com sucesso !");
                    LimpaDados();
                    gpoDados.Enabled = false;
                    txtID.Focus();

                } else
                {
                    MessageBox.Show("Houve erro no momento salvar !");
                    txtNome.Focus();
                }

            }

        }

        private void fFornecedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==27)
            {
                e.Handled = true;
                if (ActiveControl.Name.ToUpper() == "TXTID")
                {
                    this.Close();
                } else
                {
                    LimpaDados();
                    gpoDados.Enabled = false;
                    txtID.Focus();
                }
            }
        }

        private void cmbPessoa_Click(object sender, EventArgs e)
        {
           

        }

        private void cmbPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPessoa_TextChanged(object sender, EventArgs e)
        {
            txtCnpj.Text = "";
            if (cmbPessoa.Text == "FÍSICA")
            {
                lblCpf.Text = "CPF";
                lblRg.Text = "RG";

            }
            else
            {
                lblCpf.Text = "CNPJ";
                lblRg.Text = "I.ESTADUAL";
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fShow fsw = new fShow("FORNECEDORES",
                    new string[] { "Id", "Nome", "Endereco", "Cidade", "Cnpj", "Telefone" }, "Nome");

                fsw.ShowDialog();

                txtID.Text = fsw.ParametroID.ToString();
                
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    SendKeys.SendWait("{ENTER}");
                }
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {

            if (cep.ConsultaCep(txtCep.Text))
            {
                txtEndereco.Text = cep.Logradouro.ToString();
                txtBairro.Text = cep.Inicial.ToString();
                txtCidade.Text = cep.Loc_no.ToString();
                cmbEstado.Text = cep.Ufe_sg.ToString();
            }


        }

        // fim da classe

    }
}
