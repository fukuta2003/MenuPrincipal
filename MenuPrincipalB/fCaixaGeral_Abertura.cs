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
    public partial class fCaixaGeral_Abertura : Form
    {
        Validacao Funcoes = new Validacao();
        CaixaGeral Caixa = new CaixaGeral();
        DateTime Agora = new DateTime();

        public String ParametroID
        {
            set { cmbAbertoPor.Text = value; }
        }

        public fCaixaGeral_Abertura()
        {
            InitializeComponent();
        }

        private void DesabilitaCampos()
        {
            txtSaldoAbertura.Enabled = false;
            cmdSalvar.Enabled = false;
        }
        private void HabilitaCampos()
        {
                txtSaldoAbertura.Enabled = true;
                cmdSalvar.Enabled = true;

        }
        private bool ConsultaCaixaAberto(DateTime xData)
        {
            bool xret = false;
            if (Caixa.ConsultaDataAberta(xData))
            {
                DesabilitaCampos();
                lblTitulo.BackColor = Color.Red;
                lblTitulo.ForeColor = Color.White;
                lblTitulo.Text = "CAIXA DO DIA - " + lblData.Text + " (ABERTO) ";
                xret = true;
            }
            else
            {
                lblTitulo.BackColor = Color.Black;
                lblTitulo.ForeColor = Color.White;
                lblTitulo.Text = "ABERTURA DO CAIXA GERAL";
                xret = false;
            }

            return xret;

        }
        private void fCaixaGeral_Abertura_Load(object sender, EventArgs e)
        {
            lblData.Text = Calendario.SelectionRange.Start.ToString();
            cmbAbertoPor.Enabled = false;
            if (ConsultaCaixaAberto(DateTime.Parse(lblData.Text)))
            {
                DesabilitaCampos();

            } else
            {
                HabilitaCampos();
            }
          
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            int hora = Agora.Hour;
            int minuto = Agora.Minute;
            int segundo = Agora.Second;

            lblData.Text = Calendario.SelectionRange.Start.ToString();
            if (ConsultaCaixaAberto(DateTime.Parse(lblData.Text)))
            {
                DesabilitaCampos();

            }
            else
            {
                HabilitaCampos();
                txtSaldoAbertura.Focus();
            }

        }

        private void txtSaldoAbertura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.AnalisaMoeda(e);
        }

        private void txtSaldoAbertura_Leave(object sender, EventArgs e)
        {
            txtSaldoAbertura.Text = Funcoes.Formata_Moeda(txtSaldoAbertura.Text);
            cmdSalvar.Enabled = true;
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            int xDia = 0;
            int xMes = 0;
            int xAno = 0;
            int xHora = 0;
            int xMin = 0;
            int xSec = 0;

            Agora = DateTime.Now;

            xDia = Calendario.SelectionRange.Start.Day;
            xMes = Calendario.SelectionRange.Start.Month;
            xAno = Calendario.SelectionRange.Start.Year;
            xHora = Agora.Hour;
            xMin = Agora.Minute;
            xSec = Agora.Second;


            DateTime xData = new DateTime(xAno,xMes,xDia,xHora,xMin,xSec);
            

            if(Verifica())
            {
                CaixaGeral cg = new CaixaGeral(
                                    xData,
                                    decimal.Parse(txtSaldoAbertura.Text),
                                    cmbAbertoPor.Text
                                    );
                if(cg.SalvarAbertura())
                {
                    MessageBox.Show("Caixa Aberto com Sucesso !","Financeiro");
                    txtSaldoAbertura.Enabled = false;
                    cmdSalvar.Enabled = false;
                    cmdImprimir.Enabled = true;

                }
            }

        }

        private bool Verifica()
        {
            bool xret = true;
            if(string.IsNullOrEmpty(txtSaldoAbertura.Text))
            {
                xret = false;
            }
            if(string.IsNullOrEmpty(cmbAbertoPor.Text))
            {
                xret = false;
            }

            return xret;
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        //-----------
    }
}
