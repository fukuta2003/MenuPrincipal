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
    public partial class fContasReceber : Form
    {

        ContasReceber cr = new ContasReceber();
        CentroVendas cv = new CentroVendas();
        Validacao funcoes = new Validacao();

        bool wpIncluir;

        public fContasReceber()
        {
            InitializeComponent();
        }

        private void fContasReceber_Load(object sender, EventArgs e)
        {

        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            LimpaDados();
            Desabilita_Campos();
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                wpIncluir = true;
                LimpaDados();
                Habilita_Campos();
                btnSalvar.Enabled = true;
                btnBaixar.Enabled = false;
                btnExcluir.Enabled = false;
                txtDocumento.Focus();

            }
            else
            {
                cr.Id = int.Parse(txtID.Text);

                if (cr.ConsultaReceberID())
                {

                    BuscaDados();
                    if (cr.Pago == "S")
                    {
                        btnSalvar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnBaixar.Enabled = true;
                        btnBaixar.Text = "Estornar";
                        Desabilita_Campos();

                    }
                    else
                    {
                        btnSalvar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnBaixar.Enabled = true;
                        btnBaixar.Text = "Baixar";
                        Habilita_Campos();

                    }

                    txtDocumento.Focus();


                }
                else
                {
                    MessageBox.Show("ID não encontrado !");
                    txtID.Focus();

                }


            }
        }


        private void fContasReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (ActiveControl.Name.ToUpper() == "TXTID")
                {
                    this.Close();
                }
                else
                {
                    txtID.Focus();
                }
            }




        }

        private void BuscaDados()
        {
            txtDocumento.Text = cr.Documento.ToString();
            txtCliente.Text = cr.Cliente.ToString();
            if (cr.ConsultaClienteID(int.Parse(txtCliente.Text)))
            {
                lblCliente.Text = cr.Cliente_Nome.ToString();
            }
            txtEmissao.Text = cr.DataEmissao.ToString("dd/MM/yyyy");
            txtVencimento.Text = cr.DataVencimento.ToString("dd/MM/yyyy");
            if (cr.Pago == "S")
            {
                lblDataPagamento.Text = cr.DataPagamento.ToString("dd/MM/yyyy");
                imgPago.Visible = true;
            }
            else
            {
                imgPago.Visible = false;
            }

            txtValorBruto.Text = cr.ValorBruto.ToString("N");
            txtJuros.Text = cr.Juros.ToString("N");
            txtDesconto.Text = cr.Desconto.ToString("N");
            lblTotalDocumento.Text = cr.ValorDocumento.ToString("N");
            txtCentroVendas.Text = cr.CentroVENDAS.ToString();
            cr.ConsultaCentroVENDASID(txtCentroVendas.Text);
            lblCentroVendas.Text = cr.CentroVENDAS_Descricao.ToString();
            txtHistorico.Text = cr.Historico.ToString();

        }
        private void LimpaDados()
        {

            txtDocumento.Text = "";
            txtCliente.Text = "";
            lblCliente.Text = "";
            txtEmissao.Text = "";
            txtVencimento.Text = "";
            lblDataPagamento.Text = "";
            txtValorBruto.Text = "";
            txtJuros.Text = "";
            txtDesconto.Text = "";
            lblTotalDocumento.Text = "";
            txtCentroVendas.Text = "";
            lblCentroVendas.Text = "";
            txtHistorico.Text = "";
            imgPago.Visible = false;
        }
        private void Desabilita_Campos()
        {
            txtDocumento.Enabled = false;
            txtCliente.Enabled = false;
            lblCliente.Enabled = false;
            txtEmissao.Enabled = false;
            txtVencimento.Enabled = false;
            lblDataPagamento.Enabled = false;
            txtValorBruto.Enabled = false;
            txtJuros.Enabled = false;
            txtDesconto.Enabled = false;
            lblTotalDocumento.Enabled = false;
            txtCentroVendas.Enabled = false;
            lblCentroVendas.Enabled = false;
            txtHistorico.Enabled = false;

        }
        private void Habilita_Campos()
        {
            txtDocumento.Enabled = true;
            txtCliente.Enabled = true;
            lblCliente.Enabled = true;
            txtEmissao.Enabled = true;
            txtVencimento.Enabled = true;
            lblDataPagamento.Enabled = true;
            txtValorBruto.Enabled = true;
            txtJuros.Enabled = true;
            txtDesconto.Enabled = true;
            lblTotalDocumento.Enabled = true;
            txtCentroVendas.Enabled = true;
            lblCentroVendas.Enabled = true;
            txtHistorico.Enabled = true;

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
            }
            else
            {
                xDesconto = double.Parse(txtDesconto.Text);
            }

            if (txtJuros.Text == "")
            {
                xJuros = 0;

            }
            else
            {
                xJuros = double.Parse(txtJuros.Text);
            }

            xBruto = double.Parse(txtValorBruto.Text);

            xTotal = (xBruto + xJuros) - xDesconto;

            lblTotalDocumento.Text = xTotal.ToString("n");

        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.AnalisaMoeda(e);
        }

        private void txtValorBruto_Leave(object sender, EventArgs e)
        {
            txtValorBruto.Text = funcoes.Formata_Moeda(txtValorBruto.Text);
            CalculaValorDocumento();
        }

        private void txtJuros_Leave(object sender, EventArgs e)
        {
            txtJuros.Text = funcoes.Formata_Moeda(txtJuros.Text);
            CalculaValorDocumento();
        }

        private void txtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.AnalisaMoeda(e);
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            txtDesconto.Text = funcoes.Formata_Moeda(txtDesconto.Text);
            CalculaValorDocumento();
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.AnalisaMoeda(e);
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fContasReceber_Show fcrs = new fContasReceber_Show();
                fcrs.ShowDialog();
                txtID.Text = fcrs.ParametroID.ToString();
                if (txtID.Text != "")
                {
                    SendKeys.SendWait("{TAB}");
                }
                else
                {
                    txtID.Focus();
                }
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fShow fs = new fShow("CLIENTE",
                    new string[] { "ID", "NOME", "CIDADE", "TELEFONE", "CELULAR" }, "ID");
                fs.ShowDialog();
                txtCliente.Text = fs.ParametroID.ToString();
                if (txtCliente.Text != "")
                {
                    SendKeys.SendWait("{TAB}");
                }
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                if (cr.ConsultaClienteID(int.Parse(txtCliente.Text)))
                {
                    lblCliente.Text = cr.Cliente_Nome.ToString();

                }
                else
                {
                    MessageBox.Show("Cliente não encontrado !");
                    txtCliente.Focus();
                }
            }
            else
            {
                txtCliente.Focus();
            }
        }

        private void txtCentroVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fShow fs = new fShow("CENTROVENDAS",
                    new string[] { "CODIGO", "DESCRICAO" }, "CODIGO");
                fs.ShowDialog();
                txtCentroVendas.Text = fs.ParametroID.ToString();
                if (txtCentroVendas.Text != "")
                {
                    SendKeys.SendWait("{TAB}");
                }
            }
        }

        private void txtCentroVendas_Leave(object sender, EventArgs e)
        {
            if (txtCentroVendas.Text != "")
            {
                if (cv.Consulta(txtCentroVendas.Text))
                {
                    lblCentroVendas.Text = cv.Descricao.ToString();
                    txtHistorico.Focus();
                }
                else
                {
                    MessageBox.Show("Centro de Vendas não encontrado !");
                    txtCentroVendas.Focus();
                }
            }
            else
            {
                txtCentroVendas.Focus();
            }
        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            if (Verifica())
            {
                if(funcoes.Confirma("Posso Gravar ?", "Atenção"))
                {
                    PassaDadosClasse();
                    if (cr.InserirDados(wpIncluir))
                    {
                        MessageBox.Show("Documento salvo com sucesso !");
                    } else
                    {
                        MessageBox.Show("Houve erro ao salvar dados !");
                        btnSalvar.Focus();
                    }
                }
            } else
            {
                MessageBox.Show("Nem todos os documentos foram preenchidos !");
                txtDocumento.Focus();
            }

        
        }


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

    if (txtCliente.Text == "")
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


    if (txtCentroVendas.Text == "")
    {
        xret = false;
    }

    if (txtHistorico.Text == "")
    {
        xret = false;
    }

    return xret;

}

private void PassaDadosClasse()
{
    cr.Documento = txtDocumento.Text;
    cr.Cliente = int.Parse(txtCliente.Text);
    cr.Cliente_Nome = lblCliente.Text;
    cr.Data = DateTime.Parse(txtData.Text);
    cr.DataEmissao = DateTime.Parse(txtEmissao.Text);
    cr.DataVencimento = DateTime.Parse(txtVencimento.Text);
    cr.ValorBruto = double.Parse(txtValorBruto.Text);
    cr.Juros = double.Parse(txtJuros.Text);
    cr.Desconto = double.Parse(txtDesconto.Text);
    cr.ValorDocumento = double.Parse(lblTotalDocumento.Text);
    cr.Historico = txtHistorico.Text;
    cr.CentroVENDAS = txtCentroVendas.Text;
    cr.CentroVENDAS_Descricao = lblCentroVendas.Text;

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

    fContasReceber_Baixa crb = new fContasReceber_Baixa();
    crb.ParametroID = txtID.Text;
    crb.ParametroCaixaId = Caixa.Id.ToString();
    crb.StartPosition = FormStartPosition.CenterParent;
    crb.ShowDialog();
    txtID.Focus();
}

private void txtID_KeyPress(object sender, KeyPressEventArgs e)
{
    funcoes.AnalisaMoeda(e, "Somente Números !");
    if (e.KeyChar == 13)  // tecla enter
    {
        SendKeys.Send("{TAB}");
        e.Handled = true;
    }
}

private void txtCentroVendas_KeyPress(object sender, KeyPressEventArgs e)
{
    funcoes.AnalisaMoeda(e, "Somente Números !");
    if (e.KeyChar == 13)  // tecla enter
    {
        SendKeys.Send("{TAB}");
        e.Handled = true;
    }
}

private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
{
    funcoes.AnalisaMoeda(e, "Somente Números !");

    if (e.KeyChar == 13)
    {
        SendKeys.Send("{TAB}");
        e.Handled = true;
    }

}

private void fContasReceber_KeyPress(object sender, KeyPressEventArgs e)
{
    if (e.KeyChar == Convert.ToChar(Keys.Enter))
    {


        if (ActiveControl.Name.ToUpper() != "TXTID" &&
            ActiveControl.Name.ToUpper() != "TXTCLIENTE" &&
            ActiveControl.Name.ToUpper() != "TXTCENTROVENDAS")
        {
            SendKeys.SendWait("{TAB}");
            e.Handled = true;

        }
    }
}

private void btnFechar_Click(object sender, EventArgs e)
{
    this.Close();
}
    }
}
