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
    public partial class fContasReceber_Baixa : Form
    {

        ContasReceber cp = new ContasReceber();
        Validacao Funcoes = new Validacao();
        bool wp_Baixar = true;

        public String ParametroID
        {
            get { return txtID.Text; }
            set { txtID.Text = value; }
        }
        public String ParametroCaixaId
        {
            set { txtCaixaId.Text = value; }
        }
        public fContasReceber_Baixa()
        {
            InitializeComponent();
        }

        private void fContasReceber_Baixa_Load(object sender, EventArgs e)
        {
            cp.Id = int.Parse(txtID.Text);

            if (cp.ConsultaReceberID()) // consulta usando metodo da classe CONSULTAReceberID()
            {
                if (cp.Pago == "S")
                {
                    cmdBaixa.Text = "Estornar";  // estornar pagamento ja baixado
                    txtDesconto.Enabled = false;
                    txtJuros.Enabled = false;
                    txtValorPago.Enabled = false;
                    txtPagamento.Text = cp.DataPagamento.ToString();
                    txtPagamento.Enabled = false;
                    wp_Baixar = false;

                }
                else
                {
                    txtPagamento.Enabled = true;
                    txtJuros.Enabled = true;
                    txtDesconto.Enabled = true;
                    txtValorPago.Enabled = true;
                    cmdBaixa.Text = "Baixar"; // baixar pagamento em aberto
                    wp_Baixar = true;
                }

                txtEmissao.Text = cp.DataEmissao.ToString();
                txtVencimento.Text = cp.DataVencimento.ToString();
                lblCliente.Text = cp.Cliente_Nome.ToString();
                lblCentroVendas.Text = cp.CentroVENDAS_Descricao.ToString();

                txtJuros.Text = cp.Juros.ToString("N");
                txtDesconto.Text = cp.Desconto.ToString("N");
                txtValorBruto.Text = cp.ValorBruto.ToString("N");
                txtValorDocumento.Text = cp.ValorDocumento.ToString("N");
                txtValorPago.Text = txtValorDocumento.Text;
                txtJuros.Focus();

            }
            else
            {
                MessageBox.Show("ID de contas a Receber não encontrado !");
            }
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

            txtValorDocumento.Text = xTotal.ToString("n");

        }

        private bool AnalisaMoeda(KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            return e.Handled;
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            txtValorPago.Text = Funcoes.Formata_Moeda(txtValorPago.Text);
            //   CalculaValorDocumento();
        }

        private void txtJuros_Leave(object sender, EventArgs e)
        {
            txtJuros.Text = Funcoes.Formata_Moeda(txtJuros.Text);
            CalculaValorDocumento();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            txtDesconto.Text = Funcoes.Formata_Moeda(txtDesconto.Text);
            CalculaValorDocumento();
        }

        private void txtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);

        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);

        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdBaixa_Click(object sender, EventArgs e)
        {
            if(txtValorPago.Text=="" || txtValorPago.Text != txtValorDocumento.Text)
            {
                MessageBox.Show("Informe o valor correto para Baixar o Título !");
                txtJuros.Focus();
                return;
            }
            if (wp_Baixar)
            {
                DialogResult xSimNao = MessageBox.Show("Confirma a Baixa ?", "Atenção", MessageBoxButtons.YesNo);
                if (xSimNao == DialogResult.Yes)
                {
                    CaixaGeralMovimento CaixaMov = new CaixaGeralMovimento(int.Parse(txtCaixaId.Text),
                     "BAIXA", "REF BAIXA(CR)-ID:" + cp.Id.ToString() + 
                     " TIT. " + cp.Documento.ToString() + " - " + lblCliente.Text
                     , 0, decimal.Parse(txtValorPago.Text));
                    if (CaixaMov.Salvar(int.Parse(txtCaixaId.Text)))
                    {
                        TransfereDadosClasse();
                        cp.Baixar(wp_Baixar);
                    }
                    else
                    {
                        MessageBox.Show("Problemas na baixa, verifique !", "Erro");
                        txtValorPago.Focus();
                    }

                    this.Close();
                }
            }
            else
            {
                DialogResult xSimNao = MessageBox.Show("Confirma o Estorno ?", "Atenção", MessageBoxButtons.YesNo);
                if (xSimNao == DialogResult.Yes)
                {
                    TransfereDadosClasse();
                    cp.Baixar(wp_Baixar);
                    this.Close();
                }

            }



        }

        private void TransfereDadosClasse()
        {

            cp.ValorDocumento = double.Parse(txtValorDocumento.Text);
            cp.Juros = double.Parse(txtJuros.Text);
            cp.Desconto = double.Parse(txtDesconto.Text);
            if (wp_Baixar)
            {
                cp.DataPagamento = DateTime.Parse(txtPagamento.Text);
                cp.ValorPago = double.Parse(txtValorPago.Text);
                cp.Pago = "S";
            }
            else
            {
                cp.DataPagamento = DateTime.Parse("01/01/1980");
                cp.ValorPago = 0;
                cp.Pago = "N";
            }
        }

        private void txtJuros_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdBaixa_Click_1(object sender, EventArgs e)
        {

        }

        private void txtJuros_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDesconto_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txtValorDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void fContasReceber_Baixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.SendWait("{TAB}");
                e.Handled = true;
            }
        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
