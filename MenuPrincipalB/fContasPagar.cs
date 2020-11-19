using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Sistema.Models;


namespace Sistema
{
    public partial class fContasPagar : Form
    {

        public SqlDataReader dr;

        DateTime DataHoje;

        // ***********
        // variavel para controlar se vai incluir dados ou somente consultar / alterar
        // caso o usuario clique no botão salvar

        bool wpIncluir = true;

        // quando ela estiver TRUE vai incluir, se tiver FALSE vai somente alterar
        // esse controle TRUE ou FALSE é alterado no EVENTO txtID_LEAVE

        // *************

        int xIdPrincipal;

        ContasPagar cp3 = new ContasPagar();  // instancia um objeto da  classe sem argumentos

        public fContasPagar()
        {
            InitializeComponent();
        }
        public fContasPagar(string pId) : this()
        {

           // xIdPrincipal = int.Parse(pId.ToString());
            
        }
        private void fContasPagar_Activated(object sender, EventArgs e)
        {

           // txtID.Text = xIdPrincipal.ToString();

        }

        private void fContasPagar_Load(object sender, EventArgs e)
        {
            cp3.CarregaFornecedores();
            cp3.CarregaCentroCustos();

            cmbFornecedores.Items.AddRange(cp3.wlFornecedores.ToArray());
            cmbCentroCustos.Items.AddRange(cp3.wlCentroCustos.ToArray());


            /*
            foreach (string i in cp3.wlFornecedores)
            {
                if (i != null)
                {
                    cmbFornecedores.Items.Add(i);
                }
             }
             */


            /*
            cmbCentroCustos.Items.Add("001.001 - DESPESAS DIVERSAS");
            cmbCentroCustos.Items.Add("001.002 - ENERGIA ELÉTRICA");
            cmbCentroCustos.Items.Add("001.003 - TELEFONIA E INTERNET");
            cmbCentroCustos.Items.Add("001.004 - ÁGUA - SABESP");
            cmbCentroCustos.Items.Add("001.005 - AUTOMÓVEIS");
            */


          
            DataHoje = DateTime.Today;
            txtData.Text = DataHoje.ToString("dd/MM/yyyy");
            cp3.Documento = "";
            txtDocumento.Text = cp3.Documento.ToString();

            
            
        }

              

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
          
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
                        
            if (Verifica()==true)
            {
                InsereDadosnaClasse();  // PASSAR CONTEUDO DO FORMULARIO PARA CLASSE
                cp3.InserirDados(wpIncluir); // SALVAR NO BANCO DE DADOS
                LimpaCaixasTexto();
                txtID.Focus();
                
            } else
            {
                MessageBox.Show("Erro, existem campos obrigatórios em Branco !");
                txtDocumento.Focus();
            }


        }

        private void InsereDadosnaClasse()
        {
            cp3.Data = DateTime.Parse(txtData.Text);
            cp3.Documento = txtDocumento.Text;
            cp3.Fornecedor = int.Parse(txtFornecedor.Text);
            cp3.Fornecedor_Nome = lblFornecedor.Text;
            cp3.DataEmissao = DateTime.Parse(txtEmissao.Text);
            cp3.DataVencimento = DateTime.Parse(txtVencimento.Text);
            
            // data pagamento nao utiliza na inclusao

            cp3.ValorBruto = double.Parse(txtValorBruto.Text);
            cp3.Desconto = double.Parse(txtDesconto.Text);
            cp3.Juros = double.Parse(txtJuros.Text);
            cp3.ValorDocumento = double.Parse(lblTotalDocumento.Text);

            cp3.CentroCusto = txtCentrodeCustos.Text;
            cp3.CentroCusto_Descricao = lblCentrodeCustos.Text;

            cp3.Historico = txtHistorico.Text;


        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            DateTime Agora = DateTime.Today;
            CaixaGeral Caixa = new CaixaGeral();
            if (!Caixa.ConsultaDataAberta(Agora))
            {
                MessageBox.Show("O CAIXA desta data não está aberto\n consulte o Depto. Financeiro", "Atenção...");
                return;
            }


            fContasPagar_Baixa fpb = new fContasPagar_Baixa();
            fpb.WindowState = FormWindowState.Normal;
            fpb.StartPosition = FormStartPosition.CenterScreen;
            fpb.ParametroID = txtID.Text;
            fpb.ParametroIdCaixa = Caixa.Id.ToString();
            fpb.ShowDialog();
            txtID.Focus();

        }

       
        private void txtFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {

                e.Handled = true;
                SendKeys.SendWait("{TAB}");

                
            }
        }

        // PROXIMA AULA, ALTERAR O EVENTO PARA BOOLEAN, PARA CAPTARMOS SE HOUVE ALGUM ERRO
        // E NAO PERMITIR SALVAR OS DADOS.
        public Boolean Verifica()
        {
            Boolean xret = true;

            if (txtData.Text == "")
            {
                xret = false;
            }

            if (txtDocumento.Text == "")
            {
                xret = false;
            }

            if (txtFornecedor.Text == "")
            {
                xret = false;
            }

            if (txtEmissao.Text == "")
            {
                xret = false;
            }

            if (txtVencimento.Text == "")
            {
                xret = false;
            }

            if (txtValorBruto.Text == "")
            {
                xret = false;
            }
            
            
            if (lblTotalDocumento.Text == "")
            {
                xret = false;
            }
            

            if (txtCentrodeCustos.Text == "")
            {
                xret = false;
            }

            if (txtHistorico.Text == "")
            {
                xret = false;
            }

            return xret;

        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                cp3.Documento = txtDocumento.Text;
                txtFornecedor.Focus();
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gpoDoc.Visible = false;
            //txtDocumento.Focus();
        }

        private void fContasPagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                if(ActiveControl.Name.ToUpper() == "TXTID")
                {
                    this.Close();
                } else
                {
                    LimpaCaixasTexto();
                    txtID.Focus();
                }
            }
        }

        private void LimpaCaixasTexto()
        {
            txtID.Text = "";
            txtDocumento.Text = "";
            txtData.Text = "";
            txtFornecedor.Text = "";
            lblFornecedor.Text = "";
            txtEmissao.Text = "";
            txtVencimento.Text = "";
            lblDataPagamento.Text = "";
            txtValorBruto.Text = "";
            txtJuros.Text = "";
            txtDesconto.Text = "";
            lblTotalDocumento.Text = "";
            txtCentrodeCustos.Text = "";
            lblCentrodeCustos.Text = "";
            txtHistorico.Text = "";
        }


        private void txtFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                cmbFornecedores.Visible = true;
                cmbFornecedores.Focus();

            }
        }

        private void cmbCentroCustos_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtCentrodeCustos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCentrodeCustos_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.F2)
            {
                //cmbCentroCustos.Visible = true;
                //cmbCentroCustos.Focus();
            }
            */

            if (e.KeyCode == Keys.F2)
            {

                fShow fsw = new fShow("CENTROCUSTOS",
                    new string[] { "Codigo", "Descricao" }, "Codigo");
                fsw.ShowDialog();
                txtCentrodeCustos.Text = fsw.ParametroID.ToString();
                if (txtCentrodeCustos.Text != "")
                {
                    SendKeys.SendWait("{TAB}");
                }

            }
        }

        private void txtFornecedor_Click(object sender, EventArgs e)
        {
            cmbFornecedores.Visible = false;

        }

        private void txtCentrodeCustos_Click(object sender, EventArgs e)
        {
            cmbCentroCustos.Visible = false;
        }

        private void cmbCentroCustos_TextChanged(object sender, EventArgs e)
        {

            string xNome = cmbCentroCustos.Text;
            txtCentrodeCustos.Text = xNome.Substring(0, 7).ToString();
            lblCentrodeCustos.Text = xNome.Substring(8, xNome.Length - 8).ToString();
            cmbCentroCustos.Visible = false;
            txtHistorico.Focus();

           // lblCentrodeCustos.Text = cmbCentroCustos.Text;
           //  cmbCentroCustos.Visible = false;
        }

        private void txtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("TECLA <F1> PRESSIONADA");
            }
            else if (e.KeyCode == Keys.F2)
            {
                MessageBox.Show("<F2> Abrindo GPO");
                //gpoDoc.Visible = true;
            }
        }

        private void cmbFornecedores_TextChanged(object sender, EventArgs e)
        {
            string xNome = cmbFornecedores.Text;
            txtFornecedor.Text = xNome.Substring(0, 5).ToString();
            lblFornecedor.Text = xNome.Substring(6, xNome.Length - 6).ToString();
            cmbFornecedores.Visible = false;
            txtEmissao.Focus();
        }

        private void txtFornecedor_Leave(object sender, EventArgs e)
        {

            cp3.Fornecedor_Nome = "";

            if (txtFornecedor.Text == "")
            {
                MessageBox.Show("Fornecedor inválido !");
                txtFornecedor.Focus();
            }
            else
            {
                if (cp3.ConsultaFornecedorID(int.Parse(txtFornecedor.Text)))
                {
                    lblFornecedor.Text = cp3.Fornecedor_Nome.ToString();
                    txtEmissao.Focus();
                }
                else
                {
                    MessageBox.Show("Código não encontrado !");
                    txtFornecedor.Focus();

                }

            }
        }

        private void txtEmissao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmissao_Leave(object sender, EventArgs e)
        {
           txtEmissao.Text = string.Format("dd / MM / aaaa", txtEmissao.Text);
        }

        private void txtValorBruto_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtValorBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // (!Char.IsDigit(e.KeyChar) ---> se não foi um número ou seja de 0 a 9
            // e.KeyChar != (char)8  --> se tambem nao foi o BACKSPACE (CARACTER 8)
            // e.KeyChar == '.' -->


            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar == '.') {

                e.Handled = true;
            }
        }

        private void txtValorBruto_Leave(object sender, EventArgs e)
        {
            if (txtValorBruto.Text == "")
            {
                txtValorBruto.Text = "0.00";
            }

            txtValorBruto.Text = Convert.ToDouble(txtValorBruto.Text).ToString("n");
            CalculaValorDocumento();
        }

        private void txtCentrodeCustos_Leave(object sender, EventArgs e) // leave ocorre quando o objeto perde o foco
        {
            if(txtCentrodeCustos.Text != "") { 
                cp3.ConsultaCentroCustosID(txtCentrodeCustos.Text);
                lblCentrodeCustos.Text = cp3.CentroCusto_Descricao.ToString();
            }
            
        }

        private void cmbFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCentroCustos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtJuros_Leave(object sender, EventArgs e)
        {
            if(txtJuros.Text=="")
            {
                txtJuros.Text = "0.00";
            }
            txtJuros.Text = Convert.ToDouble(txtJuros.Text).ToString("N");
            CalculaValorDocumento();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if(txtDesconto.Text=="")
            {
                txtDesconto.Text = "0.00";
            }
            txtDesconto.Text = Convert.ToDouble(txtDesconto.Text).ToString("N");
            CalculaValorDocumento();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculaValorDocumento()
        {
            double xBruto = 0;
            double xJuros = 0;
            double xDesconto = 0;
            double xTotal = 0;
            if (txtDesconto.Text == "")
            {
                xDesconto = 0;
            } else
            {
                xDesconto = double.Parse(txtDesconto.Text);
            }

            if (txtJuros.Text == "")
            {
                xJuros = 0;

            } else
            {
                xJuros = double.Parse(txtJuros.Text);
            }

            xBruto = double.Parse(txtValorBruto.Text);

            xTotal = (xBruto + xJuros) - xDesconto;

            lblTotalDocumento.Text = xTotal.ToString("n");

        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            // CRIAR O PROCEDIMENTO PARA DETECTAR 
            // CADASTRAR OU ALTERAR

            if(txtID.Text=="")
            {
                wpIncluir = true; // INCLUIR AO CLICAR EM SALVAR
                btnSalvar.Enabled = true;
                btnExcluir.Enabled = false;
                btnBaixar.Enabled = false;

            } else
            {
                cp3.Id = int.Parse(txtID.Text); // passando o ID digitado para a classe.

                if (cp3.ConsultaPagarID()==true)
                {
                    // apos fazer a consulta devemos buscar os dados da classe e colocar no formulario
                    // chamando a funcao BuscaDados();
                    // ALTERAR AO CLICAR EM SALVAR

                    BuscaDados(); // função abaixo que retorna os dados da classe para o formulário

                    if (cp3.Pago=="S")
                    {
                        btnSalvar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnBaixar.Enabled = true;
                        btnBaixar.Text = "Estornar";
                        Desabilita_Campos();

                    } else { 
                        btnSalvar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnBaixar.Enabled = true;
                        btnBaixar.Text = "Baixar";
                        Habilita_Campos();
                    }
                    wpIncluir = false; // false não vai incluir, apenas alterar (update)
                    txtDocumento.Focus();

                } else
                {
                    MessageBox.Show("ID Não encontrado !");
                    txtID.Focus();
                }
            }

        }

        private void Desabilita_Campos()
        {
            
            txtDocumento.Enabled = false;
            txtFornecedor.Enabled = false;
            cmbFornecedores.Enabled = false;
            txtValorBruto.Enabled = false;
            txtJuros.Enabled = false;
            txtDesconto.Enabled = false;
            txtCentrodeCustos.Enabled = false;
            cmbCentroCustos.Enabled = false;
            txtHistorico.Enabled = false;
            txtEmissao.Enabled = false;
            txtVencimento.Enabled = false;

        }

        private void Habilita_Campos()
        {
            txtDocumento.Enabled = true;
            txtFornecedor.Enabled = true;
            cmbFornecedores.Enabled = true;
            txtValorBruto.Enabled = true;
            txtJuros.Enabled = true;
            txtDesconto.Enabled = true;
            txtCentrodeCustos.Enabled = true;
            cmbCentroCustos.Enabled = true;
            txtHistorico.Enabled = true;
            txtEmissao.Enabled = true;
            txtVencimento.Enabled = true;

        }

        private void BuscaDados()
        {
            txtData.Text = cp3.Data.ToString();
            txtDocumento.Text = cp3.Documento.ToString();
            txtFornecedor.Text = cp3.Fornecedor.ToString();
            lblFornecedor.Text = cp3.Fornecedor_Nome.ToString();
            txtEmissao.Text = cp3.DataEmissao.ToString();
            txtVencimento.Text = cp3.DataVencimento.ToString();
            txtValorBruto.Text = cp3.ValorBruto.ToString("n");
            txtJuros.Text = cp3.Juros.ToString("n");
            txtDesconto.Text = cp3.Desconto.ToString("n");
            lblTotalDocumento.Text = cp3.ValorDocumento.ToString("n");
            txtCentrodeCustos.Text = cp3.CentroCusto.ToString();
            lblCentrodeCustos.Text = cp3.CentroCusto_Descricao.ToString();
            txtHistorico.Text = cp3.Historico.ToString();
            if(cp3.Pago=="S")
            {
                if (cp3.DataPagamento.ToString() == "01/01/1980 00:00:00" || cp3.DataPagamento.ToString() == "01/01/0001 00:00:00")
                {
                    lblDataPagamento.Text = "";
                    imgPago.Visible = false;
                } else
                {
                    lblDataPagamento.Text = cp3.DataPagamento.ToString("dd/MM/yyyy");
                    imgPago.Visible = true;
                }
            }

            

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                e.Handled = true;
                txtDocumento.Focus(); // tirando o foco do txtdocumento, aciona o LEAVE
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fContasPagar_Show fs = new fContasPagar_Show();
                
                fs.ShowDialog();
                
                txtID.Text = fs.ParametroID;

                SendKeys.SendWait("{ENTER}");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fFornecedores forn = new fFornecedores();
            forn.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fCentroCustos cc = new fCentroCustos();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.KeyPreview = true;
            cc.ShowDialog();


        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBaixar.Enabled = false;
            LimpaCaixasTexto();
            imgPago.Visible = false;

        }

        private void txtJuros_TextChanged(object sender, EventArgs e)
        {

        }

        private void fContasPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {


                if (ActiveControl.Name.ToUpper() != "TXTID" &&
                    ActiveControl.Name.ToUpper() != "TXTFORNECEDOR" &&
                    ActiveControl.Name.ToUpper() != "TXTCENTROCUSTOS")
                {
                    SendKeys.SendWait("{TAB}");
                    e.Handled = true;

                }
            }
        }
    }
}
