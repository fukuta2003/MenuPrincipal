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
    public partial class fCentroVendas : Form
    {
        public bool wp_Incluir = true;

        CentroVendas cvendas = new CentroVendas();
        Validacao Funcoes = new Validacao();

        public fCentroVendas()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {

                fShow fsw = new fShow("CENTROVENDAS",
                    new string[] { "Codigo", "Descricao" }, "Codigo");
                fsw.ShowDialog();
                txtCodigo.Text = fsw.ParametroID.ToString();
                if (txtCodigo.Text != "")
                {
                    SendKeys.SendWait("{TAB}");
                }

            }
        }

        private void txtCodigo_Leave_1(object sender, EventArgs e)
        {
            
        }


        private void txtCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BuscaDados()
        {
            txtDescricao.Text = cvendas.Descricao.ToString();
            txtJaneiro.Text = cvendas.Janeiro.ToString("n");
            txtFevereiro.Text = cvendas.Fevereiro.ToString("n");
            txtMarco.Text = cvendas.Marco.ToString("n");
            txtAbril.Text = cvendas.Abril.ToString("n");
            txtMaio.Text = cvendas.Maio.ToString("n");
            txtJunho.Text = cvendas.Junho.ToString("n");
            txtJulho.Text = cvendas.Julho.ToString("n");
            txtAgosto.Text = cvendas.Agosto.ToString("n");
            txtSetembro.Text = cvendas.Setembro.ToString("n");
            txtOutubro.Text = cvendas.Outubro.ToString("n");
            txtNovembro.Text = cvendas.Novembro.ToString("n");
            txtDezembro.Text = cvendas.Dezembro.ToString("n");

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

        private void txtJaneiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtFevereiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtMarco_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtAbril_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtMaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtJunho_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtJulho_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtAgosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtSetembro_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtOutubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtNovembro_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtDezembro_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnalisaMoeda(e);
        }

        private void txtJaneiro_Leave(object sender, EventArgs e)
        {
            txtJaneiro.Text = Funcoes.Formata_Moeda(txtJaneiro.Text);
        }

        private void txtFevereiro_Leave(object sender, EventArgs e)
        {
            txtFevereiro.Text = Funcoes.Formata_Moeda(txtFevereiro.Text);
        }

        private void txtMarco_Leave(object sender, EventArgs e)
        {
            txtMarco.Text = Funcoes.Formata_Moeda(txtMarco.Text);
        }

        private void txtAbril_Leave(object sender, EventArgs e)
        {
            txtAbril.Text = Funcoes.Formata_Moeda(txtAbril.Text);
        }

        private void txtMaio_Leave(object sender, EventArgs e)
        {
            txtMaio.Text = Funcoes.Formata_Moeda(txtMaio.Text);
        }

        private void txtJunho_Leave(object sender, EventArgs e)
        {
            txtJunho.Text = Funcoes.Formata_Moeda(txtJunho.Text);
        }

        private void txtJulho_Leave(object sender, EventArgs e)
        {
            txtJulho.Text = Funcoes.Formata_Moeda(txtJulho.Text);

        }

        private void txtAgosto_Leave(object sender, EventArgs e)
        {
            txtAgosto.Text = Funcoes.Formata_Moeda(txtAgosto.Text);
        }

        private void txtSetembro_Leave(object sender, EventArgs e)
        {
            txtSetembro.Text = Funcoes.Formata_Moeda(txtSetembro.Text);
        }

        private void txtOutubro_Leave(object sender, EventArgs e)
        {
            txtOutubro.Text = Funcoes.Formata_Moeda(txtOutubro.Text);
        }

        private void txtNovembro_Leave(object sender, EventArgs e)
        {
            txtNovembro.Text = Funcoes.Formata_Moeda(txtNovembro.Text);
        }

        private void txtDezembro_Leave(object sender, EventArgs e)
        {
            txtDezembro.Text = Funcoes.Formata_Moeda(txtDezembro.Text);
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
          
        }

        private void EnviaDadosClasse()
        {
            cvendas.Codigo = txtCodigo.Text;
            cvendas.Descricao = txtDescricao.Text;
            cvendas.Janeiro = decimal.Parse(txtJaneiro.Text);
            cvendas.Fevereiro = decimal.Parse(txtFevereiro.Text);
            cvendas.Marco = decimal.Parse(txtMarco.Text);
            cvendas.Abril = decimal.Parse(txtAbril.Text);
            cvendas.Maio = decimal.Parse(txtMaio.Text);
            cvendas.Junho = decimal.Parse(txtJunho.Text);
            cvendas.Julho = decimal.Parse(txtJulho.Text);
            cvendas.Agosto = decimal.Parse(txtAgosto.Text);
            cvendas.Setembro = decimal.Parse(txtSetembro.Text);
            cvendas.Outubro = decimal.Parse(txtOutubro.Text);
            cvendas.Novembro = decimal.Parse(txtNovembro.Text);
            cvendas.Dezembro = decimal.Parse(txtDezembro.Text);

        }

        private bool VerificaDados()
        {
            bool xret = true;

            // aqui verificação de todos os campos que não podem ficar em branco

            if (txtDescricao.Text == "")
            {
                xret = false;
            }

            return xret;
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            LimpaFormulario();
        }

        private void LimpaFormulario()
        {
            gpoDados.Enabled = true;
            txtDescricao.Text = "";
            txtJaneiro.Text = "";
            txtFevereiro.Text = "";
            txtMarco.Text = "";
            txtAbril.Text = "";
            txtMaio.Text = "";
            txtJunho.Text = "";
            txtJulho.Text = "";
            txtAgosto.Text = "";
            txtSetembro.Text = "";
            txtOutubro.Text = "";
            txtNovembro.Text = "";
            txtDezembro.Text = "";
            gpoDados.Enabled = false;

        }

        private void fCentroVendass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                if (ActiveControl.Name.ToUpper() == "TXTCODIGO")
                {
                    e.Handled = true;
                    this.Close();

                }
                else
                {
                    LimpaFormulario();
                    txtCodigo.Focus();

                }
            }
        }

        private void txtJaneiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void fCentroVendas_Load(object sender, EventArgs e)
        {
            
        }

        private void txtCodigo_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            // MessageBox.Show("*"+txtCodigo.Text.Replace(" ","")+"*");
            //retira todos espaço da mascara para ver se o dado é branco

       
                if (cvendas.Consulta(txtCodigo.Text))
                {
                    // PASSA DADOS DA CLASSE PARA O FORMULARIO
                    BuscaDados();
                    gpoDados.Enabled = true;
                    txtDescricao.Focus();
                    wp_Incluir = false;
                    lblOperacao.Text = "<<ALTERAÇÃO>>";
                }
                else
                {
                    wp_Incluir = true;
                    gpoDados.Enabled = true;
                    txtDescricao.Focus();
                    lblOperacao.Text = "<<INCLUSÃO>>";

                }

        }

        private void cmdSalvar_Click_1(object sender, EventArgs e)
        {
            if (VerificaDados())
            {
                EnviaDadosClasse();
                if (cvendas.Salvar_Dados(wp_Incluir))
                {
                    MessageBox.Show("Dados salvos com sucesso !");
                    gpoDados.Enabled = false;
                    txtCodigo.Focus();

                }
                else
                {
                    MessageBox.Show("Erro na gravação dos dados !");
                    txtDescricao.Focus();

                }

            }
        }

        private void fCentroVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                if (ActiveControl.Name.ToUpper() == "TXTCODIGO")
                {
                    this.Close();
                }
                else
                {
                    LimpaFormulario();
                    txtCodigo.Focus();
                }

            }
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Posso excluir esse registro ??", "Atenção", MessageBoxButtons.YesNo); 
            if (drs == DialogResult.Yes){
                cvendas.Apaga(txtCodigo.Text);
                LimpaFormulario();
                txtCodigo.Focus();
            }
            
        }

        private void fCentroVendas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.SendWait("{TAB}");
                e.Handled = true;
            }
        }
    }
}
