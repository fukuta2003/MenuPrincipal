using System;
using Sistema.Models;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Sistema
{
    public partial class fContasPagar_Show : Form
    {
        ContasPagar cp = new ContasPagar();
        CentroCustos cc = new CentroCustos();
        Validacao vl = new Validacao();

        ListViewItem item;
        double TotalDocumentos = 0, TotalPago = 0, TotalAberto = 0;
        int xId = 0;

        public String ParametroID
        {
            get { return txtID.Text; }
            set { txtID.Text = value;  }
        }

        public fContasPagar_Show()
        {
            InitializeComponent();
        }

        private void fContasPagar_Show_Load(object sender, EventArgs e)
        {

            listView1.GridLines = true;
            cp.MontaGrade("VENCIMENTO","","","","");

            
            CarregaDadosnaGrade();


        }


        public void CarregaDadosnaGrade()
        {
            TotalDocumentos = 0;
            TotalPago = 0;
            TotalAberto = 0;
            listView1.Items.Clear();
            
            foreach(ContasPagar c in cp.contas)
            {

                item = new ListViewItem(c.Id.ToString());

                item.SubItems.Add(c.Documento.ToString());
                item.SubItems.Add(c.Fornecedor.ToString());
                item.SubItems.Add(c.Fornecedor_Nome.ToString());
                item.SubItems.Add(c.DataEmissao.ToString("dd/MM/yyyy"));
                item.SubItems.Add(c.DataVencimento.ToString("dd/MM/yyyy"));
                if(c.Pago=="S") { 
                    item.SubItems.Add(c.DataPagamento.ToString("dd/MM/yyyy"));
                } else
                {
                    item.SubItems.Add("__/__/____");
                }
                item.SubItems.Add(c.CentroCusto.ToString());
                item.SubItems.Add(c.ValorDocumento.ToString("n"));
                if(c.Pago=="S")
                {
                    item.SubItems.Add("Pago");
                    TotalPago += double.Parse(c.ValorDocumento.ToString());
                } else
                {
                    item.SubItems.Add("Aberto");
                    TotalAberto += double.Parse(c.ValorDocumento.ToString());
                }
                TotalDocumentos += double.Parse(c.ValorDocumento.ToString());

                listView1.Items.Add(item);
            }

            lblTotalDocumentos.Text = TotalDocumentos.ToString("N");
            lblTotalAberto.Text = TotalAberto.ToString("N");
            lblTotalPago.Text = TotalPago.ToString("N");



        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            xId = int.Parse(listView1.SelectedItems[0].Text);
            txtID.Text = xId.ToString();

            this.Close();
            // lblMensagem.Text += "   -  " + listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFornecedor_Leave(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtFornecedor.Text))
            {
                if (cp.ConsultaFornecedorID(int.Parse(txtFornecedor.Text)))
                {
                    lblFornecedor.Text = cp.Fornecedor_Nome.ToString();
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado !");
                    txtFornecedor.Focus();

                }

            } else
            {
                lblFornecedor.Text = "";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(optEmissao.Checked==true) { 
                 cp.MontaGrade("EMISSAO", txtDe.Text, txtAte.Text, txtFornecedor.Text, txtCentroCustos.Text);
            } else if (optVencimento.Checked==true) {
                cp.MontaGrade("VENCIMENTO", txtDe.Text, txtAte.Text, txtFornecedor.Text, txtCentroCustos.Text);
            } else if (optPagamento.Checked==true) {
                cp.MontaGrade("BAIXA", txtDe.Text, txtAte.Text, txtFornecedor.Text, txtCentroCustos.Text);
            }
            CarregaDadosnaGrade();
        }

        private void txtCentroCustos_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtCentroCustos_Leave(object sender, EventArgs e)
        {
            string xCentro;
            xCentro = txtCentroCustos.Text.Replace(" ", "");
            if (xCentro.ToString() == ".")
            {
                xCentro = "";
            }
           
            if (!string.IsNullOrEmpty(xCentro))
            {
                if (cc.Consulta(xCentro.ToString()))
                {
                    lblCentroCusto.Text = cc.Descricao.ToString();
                } else
                {
                    MessageBox.Show("Centro de Custos não encontrado !");

                }

            }
        }

        private void txtCentroCustos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fShow fsw = new fShow("CENTROCUSTOS",
                    new string[] { "Codigo", "Descricao" }, "Codigo");
                fsw.ShowDialog();
                txtCentroCustos.Text = fsw.ParametroID.ToString();
                if (txtCentroCustos.Text != "")
                {
                    SendKeys.SendWait("{TAB}");
                }
            }
        }

        private void chkMesInteiro_Click(object sender, EventArgs e)
        {
            if (chkMesInteiro.Checked == true)
            {
                vl.MesInicioFim();
                txtDe.Text = vl.DataInicial.ToString();
                txtAte.Text = vl.DataFinal.ToString();

            }
        }
    }
}
