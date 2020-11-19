using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sistema.Models;

namespace Sistema
{
    public partial class fTecnicos : Form
    {
        public bool wpCria; // variavel controle para informar se vai ser um novo cliente ou alteracao
        CrudTecnicos cl = new CrudTecnicos();
        Validacao fun = new Validacao();

        public fTecnicos()
        {
            InitializeComponent();
        }

        private void fTecnicos_Load(object sender, EventArgs e)
        {
            cl.ComboPesquisa = "";
            cl.StringPesquisa = "";
            cl.Pesquisa("");
            MontarGrade();

            wpCria = false;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            cl.ComboPesquisa = cmbPesquisa.Text;
            cl.StringPesquisa = txtPesquisa.Text;
            cl.Pesquisa(txtPesquisa.Text);
            Grid1.DataSource = null;
            MontarGrade();

        }

        private void MontarGrade()
        {
            Grid1.DataSource = cl.dt;  // REFERENCIA A TABELA DE DADOS NA GRID
                                       // PERCORRE A GRID E DEFINE OS TAMANHOS DE LARGURA DE CADA CAMPO
            foreach (DataGridViewColumn column in Grid1.Columns)
            {
                if (column.DataPropertyName == "Id")
                {
                    column.Width = 50; //tamanho fixo da primeira coluna
                    //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else if (column.DataPropertyName == "Nome")
                {
                    column.Width = 400; //tamanho fixo da primeira coluna
                }
                else if (column.DataPropertyName == "Cidade")
                {
                    column.Width = 100;
                }
                else if (column.DataPropertyName == "Telefone")
                {
                    column.Width = 100;
                }
                else if (column.DataPropertyName == "Celular")
                {
                    column.Width = 100;
                }
                else if (column.DataPropertyName == "Whatsapp")
                {
                    column.Width = 80;
                    Grid1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else if (column.DataPropertyName == "Cidade")
                {
                    column.Width = 260;
                }
                else if (column.DataPropertyName == "Estado")
                {
                    column.Width = 60;
                    Grid1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }


            }

            // ATUALIZA A GRID
            Grid1.Update();

        }

        private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gpoCadastro.Visible = true;
            wpCria = false;
            cmdSalvar.Enabled = true;
            cmdExcluir.Enabled = true;
            cmdExcluir.Visible = true;
            HabilitaCampos();

            int x = int.Parse(Grid1.SelectedRows[0].Cells[0].Value.ToString());
            BuscaDados(x); // CHAMA A FUNCAO BuscaDados informando o valor de X
        }

        private void BuscaDados(int id)
        {
            HabilitaCampos();
            cmdSalvar.Enabled = true;
            // CONECTA NO BANCO DE DADOS
            cl.Id = id;
            cl.StringPesquisa = txtPesquisa.Text;
            cl.ComboPesquisa = cmbPesquisa.Text;
            // cl.Pesquisa(txtPesquisa.Text);
            cl.Consulta_Dados(id);
            lblID.Text = cl.Id.ToString();
            txtNome.Text = cl.Nome;
            txtEndereco.Text = cl.Endereco;
            txtBairro.Text = cl.Bairro;
            txtCidade.Text = cl.Cidade;
            txtEstado.Text = cl.Estado;
            txtCep.Text = cl.Cep;
            txtTelefone.Text = cl.Telefone;
            txtCelular.Text = cl.Celular;
            txtRG.Text = cl.Rg;
            txtCPF.Text = cl.Cpf;
            txtEmail.Text = cl.Email;
            txtNascimento.Text = cl.Nascimento.ToString("dd/MM/yyyy");
            txtComissao.Text = cl.Comissao.ToString();
            wpCria = false;

            if (cl.Whatsapp.Equals(true))
            {
                chkWhatsapp.Checked = true;
            }
            else
            {
                chkWhatsapp.Checked = false;
            }

            // INSTANCIA O DATAREADER PARA GERAR AS LINHAS DA TABELA ABERTA

            if (cl.Whatsapp.Equals(true)) // VERIFICA SE O CAMPO WHATSAPP É VERDADEIRO OU FALSO
            {
                chkWhatsapp.Checked = true; // SE FOR VERDADEIRO MARCA A CAIXA 
            }
            else
            {
                chkWhatsapp.Checked = false; // SE FOR FALSO DESMARCA
            }
            if (fun.Verifica_CPF(txtCPF.Text)) // CHAMA A FUNCAO DE VERIFICA_CPF PARA RETORNAR SE É VALIDO OU NAO
            {
                imgOK.Visible = true;  // HABILITA A IMAGEM OK
                imgNo.Visible = false; // DESABILITA A IMAGEM INVALIDO
            }
            else
            {
                imgOK.Visible = false; // DESABILITA A IMAGEM OK
                imgNo.Visible = true; // HABILITA A IMAGEM INVALIDO
            }

        }

        private void Grid1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = int.Parse(Grid1.SelectedRows[0].Cells[0].Value.ToString());

            BuscaDados(x);
        }

        private void Grid1_DoubleClick(object sender, EventArgs e)
        {
            int x = int.Parse(Grid1.SelectedRows[0].Cells[0].Value.ToString());

            BuscaDados(x);
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            gpoCadastro.Visible = true;
            wpCria = true;  // instancia a variavel com o valor true dizendo que é pra incluir um novo cliente
            cmdSalvar.Enabled = true; // habilitar o botao pra salvar e incluir o novo cliente 
            cmdExcluir.Visible = false; // quando é novo cliente, nao precisa do botao excluir
            HabilitaCampos(); // habilita os campos para preenchimento
            LimpaDados(); // se houver alguma informacao de dados, essa função limpa os campos textbox
            txtNome.Focus(); // envia o foco do cursor para o campo txtNome

        }

        // habilita todos os campos para preenchimento
        private void HabilitaCampos()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtCep.Enabled = true;
            txtEmail.Enabled = true;
            txtNascimento.Enabled = true;
            chkWhatsapp.Enabled = true;
            txtCPF.Enabled = true;
            txtRG.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtComissao.Enabled = true;
            imgOK.Visible = false;

        }

        // desabilita todos os campos para nao poder preencher
        private void DesabilitaCampos()
        {
            lblID.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtCep.Enabled = false;
            txtEmail.Enabled = false;
            txtNascimento.Enabled = false;
            chkWhatsapp.Enabled = false;
            txtCPF.Enabled = false;
            txtRG.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtComissao.Enabled = false;
            imgOK.Visible = false;

        }
        // funcao que apaga o conteudo dos campos no formulario (nao no banco de dados)
        private void LimpaDados()
        {
            lblID.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtCep.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            chkWhatsapp.Checked = false;
            txtCPF.Text = "";
            txtRG.Text = "";
            txtNascimento.Text = "";
            txtComissao.Text = "0.00";
            imgOK.Visible = false;

        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            bool Salvar = true;

            if (!wpCria)
            {
                cl.Id = int.Parse(Grid1.SelectedRows[0].Cells[0].Value.ToString());

            }
            cl.Nome = txtNome.Text;
            cl.Endereco = txtEndereco.Text;
            cl.Bairro = txtBairro.Text;
            cl.Cidade = txtCidade.Text;
            cl.Estado = txtEstado.Text;
            cl.Cep = txtCep.Text;
            cl.Telefone = txtTelefone.Text;
            cl.Celular = txtCelular.Text;
            cl.Comissao = double.Parse(txtComissao.Text);
            if (chkWhatsapp.Checked.Equals(true))
            {
                cl.Whatsapp = true;
            }
            else
            {
                cl.Whatsapp = false;
            }
            if (txtNascimento.Value == null)
            {
                MessageBox.Show("Data Nula");
            }
            cl.Nascimento = txtNascimento.Value;
            cl.Cpf = txtCPF.Text;
            cl.Rg = txtRG.Text;
            cl.Email = txtEmail.Text;

            if (Salvar)
            {
                cl.Salvar_Dados(wpCria);

            }

            LimpaDados();
            gpoCadastro.Visible = false;
            DesabilitaCampos();
            cmdExcluir.Enabled = false;
            cmdSalvar.Enabled = false;
            txtPesquisa.Text = "";
            cl.Pesquisa("");
            txtPesquisa.Focus();
        }

        // funcao acionada pelo botao EXCLUIR
        // SE CONFIRMADO SIM, EXCLUI OS DADOS DO ID SELECIONADO NO BANCO DE DADOS
        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            int xID = 0;
            if (wpCria == false)
            {
                var opt = MessageBox.Show("Confirma a Exclusão ?", "Atenção", MessageBoxButtons.YesNo);
                if (opt == DialogResult.Yes)
                {
                    xID = int.Parse(Grid1.SelectedRows[0].Cells[0].Value.ToString());

                    cl.Deleta_Dados(xID);
                    LimpaDados();
                    gpoCadastro.Visible = false;
                    DesabilitaCampos();
                    cmdExcluir.Enabled = false;
                    cmdSalvar.Enabled = false;
                    txtPesquisa.Text = "";
                    cl.Pesquisa("");
                    txtPesquisa.Focus();
                }
            }
        }


        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text.Length == 14)
            {
                if (fun.Verifica_CPF(txtCPF.Text))
                {
                    imgOK.Visible = true;
                    imgNo.Visible = false;
                    txtRG.Focus();
                }
                else
                {
                    imgOK.Visible = false;
                    imgNo.Visible = true;
                }
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (txtCPF.Text.Length == 11 && txtCPF.Text.Substring(3, 1) != ".")
            {
                txtCPF.Text = Convert.ToUInt64(txtCPF.Text).ToString(@"000\.000\.000\-00");
                SendKeys.Send("{END}");
            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (txtCep.Text.Length == 8)
            {

                if (txtCep.Text.Substring(5, 1) != "-")
                {
                    txtCep.Text = Convert.ToUInt64(txtCep.Text).ToString(@"00000\-000");
                    SendKeys.Send("{END}");
                }


            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefone.Text.Length == 10 && txtTelefone.Text.Substring(0, 1) != "(")
            {
                if (txtTelefone.Text.Substring(8, 1) != "-")
                {
                    txtTelefone.Text = Convert.ToUInt64(txtTelefone.Text).ToString(@"\(00\)0000\-0000");
                    SendKeys.Send("{END}");
                }
            }
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            if (txtCelular.Text.Length == 11 && txtCelular.Text.Substring(0, 1) != "(")
            {
                if (txtCelular.Text.Substring(9, 1) != "-")
                {
                    txtCelular.Text = Convert.ToUInt64(txtCelular.Text).ToString(@"\(00\)00000\-0000");
                    SendKeys.Send("{END}");
                }
            }
        }

        private void fTecnicos_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void fTecnicos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                if (gpoCadastro.Visible == true)
                {
                    gpoCadastro.Visible = false;
                    Grid1.Focus();
                }
                else
                {
                    var opt = MessageBox.Show("Quer mesmo sair do Cadastro ?", "Atenção", MessageBoxButtons.YesNo);
                    if (opt == DialogResult.Yes)
                    {
                        this.Close();
                    }

                }

            }

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtComissao_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)  // diferente de numeros e backspace
            {
                e.Handled = true;  // diz que a tecla foi manuseada e tratada
            }
        }

       
        private void txtNome_Leave(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Preenchimento Obrigatório do campo Nome !");
                txtNome.Focus();
            }
        }
    }
}

