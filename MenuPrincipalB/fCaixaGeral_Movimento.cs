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

namespace SistemaPadrao
{
    public partial class fCaixaGeral_Movimento : Form
    {
        Validacao func = new Validacao();
        CaixaGeral caixa = new CaixaGeral();
        CaixaGeralMovimento CaixaMov = new CaixaGeralMovimento();
        DateTime Agora = new DateTime();
        decimal SaldoInicial = 0, SaldoAtual = 0, Debitos = 0, Creditos=0;
        ListViewItem item;

        public fCaixaGeral_Movimento()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fCaixaGeral_Movimento_Load(object sender, EventArgs e)
        {
            DesabilitaCampos();
            caixa.CarregaCaixasAbertos();
            int i = 0;

            while(int.Parse(caixa.CaixasAbertos[i,0].ToString()) != 0)
            {
                if(i==0)
                {
                    this.monthCalendar1.MinDate = new System.DateTime(int.Parse(caixa.CaixasAbertos[i, 0].ToString()),
                    int.Parse(caixa.CaixasAbertos[i, 1].ToString()),
                    int.Parse(caixa.CaixasAbertos[i, 2].ToString()));
                }
                this.monthCalendar1.BoldedDates = new System.DateTime[] {
                    new System.DateTime(int.Parse(caixa.CaixasAbertos[i,0].ToString()),
                    int.Parse(caixa.CaixasAbertos[i,1].ToString()),
                    int.Parse(caixa.CaixasAbertos[i,2].ToString()), 0, 0, 0, 0)};

                i++;
            }

            this.monthCalendar1.MaxDate = new System.DateTime(int.Parse(caixa.CaixasAbertos[i-1, 0].ToString()),
            int.Parse(caixa.CaixasAbertos[i-1, 1].ToString()),
            int.Parse(caixa.CaixasAbertos[i-1, 2].ToString()));


        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            VerificarCaixaAberto();
            CarregaDadosNaGrade();

        }

        private void VerificarCaixaAberto()
        {
            int hora = Agora.Hour;
            int minuto = Agora.Minute;
            int segundo = Agora.Second;

            lblData.Text = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy");
            if (ConsultaCaixaAberto(DateTime.Parse(lblData.Text)))
            {
                HabilitaCampos();
                cmbTipo.Focus();
            }
            else
            {
                DesabilitaCampos();

            }
        }

        private void DesabilitaCampos()
        {
            txtSaldoCaixa.Enabled = false;
            cmbTipo.Enabled = false;
            txtHistorico.Enabled = false;
            txtValor.Enabled = false;
            cmdSalvar.Enabled = false;
        }
        private void HabilitaCampos()
        {
            cmbTipo.Enabled = true;
            txtHistorico.Enabled = true;
            txtValor.Enabled = true;
            cmdSalvar.Enabled = true;
        }
        private bool ConsultaCaixaAberto(DateTime xData)
        {
            bool xret = false;
            SaldoInicial = 0;
            SaldoAtual = 0;
            Debitos = 0;
            Creditos = 0;
            lblCreditos.Text = "0,00";
            lblDebitos.Text = "0,00";
            lblSaldoAnterior.Text = "0,00";
            txtSaldoCaixa.Text = "0,00";
            
            if (caixa.ConsultaDataAberta(xData))
            {
                HabilitaCampos();
                SaldoInicial = caixa.SaldoAbertura;
                SaldoAtual = CaixaMov.ConsultaSaldoCaixa(caixa.Id);
                txtSaldoCaixa.Text = SaldoAtual.ToString("N");
                lblTitulo.BackColor = Color.Red;
                lblTitulo.ForeColor = Color.White;
                lblTitulo.Text = "CAIXA DO DIA - " + lblData.Text + " ID: " + caixa.Id.ToString() + "  (ABERTO) ";
                xret = true;
            }
            else
            {
                lblTitulo.BackColor = Color.Black;
                lblTitulo.ForeColor = Color.White;
                lblTitulo.Text = "CAIXA GERAL DO DIA FECHADO";
                xret = false;
                DesabilitaCampos();
            }

            return xret;

        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            if(!Verifica())
            {
                MessageBox.Show("Existem dados incompletos, verifique !");
                cmbTipo.Focus();
                return;
            } else
            {
                CaixaMov.Idcaixa = caixa.Id;
                CaixaMov.Tipo = cmbTipo.Text;
                CaixaMov.Historico = txtHistorico.Text;
                if(cmbTipo.Text=="ENTRADA")
                {
                    CaixaMov.Debito = 0;
                    CaixaMov.Credito = decimal.Parse(txtValor.Text);

                } else
                {
                    CaixaMov.Credito = 0;
                    CaixaMov.Debito = decimal.Parse(txtValor.Text);
                }

                if(CaixaMov.Salvar(caixa.Id))
                {
                    MessageBox.Show("Movimento lançado com sucesso !");
                    // mostrar na grade os movimentos
                    CarregaDadosNaGrade();
                    cmbTipo.Focus();
                } else
                {
                    MessageBox.Show("Erro ao lançar os movimentos !");
                    cmbTipo.Focus();
                }


            }





        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipo.Text != "")
            {
                cmbTipo.Focus();
            }
            txtHistorico.Text = "";
            txtHistorico.Focus();
        }

        private void cmbTipo_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            func.AnalisaMoeda(e);
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            txtValor.Text = func.Formata_Moeda(txtValor.Text);
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void listView1_Enter(object sender, EventArgs e)
        {
            SendKeys.SendWait("{END}");
            
        }

        private void CarregaDadosNaGrade()
        {
            
            listView1.Items.Clear();

            VerificarCaixaAberto();

            CaixaMov.MontaGrade(caixa.Id);

            int i = 1;

            lblSaldoAnterior.Text = SaldoInicial.ToString("N2");

            foreach (CaixaGeralMovimento c in CaixaMov.Lancamentos)
            {
                
                if (i == 1)
                {
                    item = new ListViewItem("x");
                    item.SubItems.Add("***");
                    item.SubItems.Add("Saldo Anterior");
                    item.SubItems.Add("0,00");
                    item.SubItems.Add("0,00");
                    item.SubItems.Add(SaldoInicial.ToString("N2"));
                    listView1.Items.Add(item);

                    item = new ListViewItem("1º");
                    item.SubItems.Add(c.Tipo.ToString());
                    item.SubItems.Add(c.Historico.ToString());
                    item.SubItems.Add(c.Debito.ToString("N"));
                    item.SubItems.Add(c.Credito.ToString("N"));
                    Debitos += c.Debito;
                    Creditos += c.Credito;
                    SaldoInicial = (SaldoInicial + c.Credito) - c.Debito;
                    item.SubItems.Add(SaldoInicial.ToString("N"));
                    listView1.Items.Add(item);


                }
                else
                {
                    item = new ListViewItem(c.Idcaixa.ToString());
                    item.SubItems.Add(c.Tipo.ToString());
                    item.SubItems.Add(c.Historico.ToString());
                    item.SubItems.Add(c.Debito.ToString("N"));
                    item.SubItems.Add(c.Credito.ToString("N"));
                    Debitos += c.Debito;
                    Creditos += c.Credito;
                    SaldoInicial = (SaldoInicial + c.Credito) - c.Debito;
                    item.SubItems.Add(SaldoInicial.ToString("N"));
                    listView1.Items.Add(item);
                   

                }
                i++;
            }

            lblCreditos.Text = Creditos.ToString("N2");
            lblDebitos.Text = Debitos.ToString("N2");
            listView1.Focus();


        }

        private bool Verifica()
        {
            bool xret = true;
            if(string.IsNullOrEmpty(cmbTipo.Text))
            {
                xret = false;
            }

            if(string.IsNullOrEmpty(txtHistorico.Text))
            {
                xret = false;
            }

            if(string.IsNullOrEmpty(txtValor.Text))
            {
                xret = false;
            }

            return xret;

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }


        //----->
    }
}
