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
    public partial class fServicos : Form
    {
        public bool wpCria; // variavel controle para informar se vai ser um novo cliente ou alteracao
        CrudServicos cl = new CrudServicos();

        public fServicos()
        {
            InitializeComponent();
            Validacao.AplicarEventosValores(txtValorVista);
            Validacao.AplicarEventosValores(txtValorPrazo);

        }

        private void fServicos_Load(object sender, EventArgs e)
        {
            cl.ComboPesquisa = "";
            cl.StringPesquisa = "";
            cl.Pesquisa("");
            MontarGrade();

            wpCria = false;

        }

        private void cmdNovo_Click_1(object sender, EventArgs e)
        {
            gpoCadastro.Visible = true;
            wpCria = true;  // instancia a variavel com o valor true dizendo que é pra incluir um novo cliente
            cmdSalvar.Enabled = true; // habilitar o botao pra salvar e incluir o novo cliente 
            cmdExcluir.Visible = false; // quando é novo cliente, nao precisa do botao excluir
            HabilitaCampos(); // habilita os campos para preenchimento
            LimpaDados(); // se houver alguma informacao de dados, essa função limpa os campos textbox
            txtDescricao.Focus(); // envia o foco do cursor para o campo txtNome
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
                else if (column.DataPropertyName == "Descricao")
                {
                    column.Width = 730; //tamanho fixo da primeira coluna
                }
                else if (column.DataPropertyName == "ValorVista")
                {
                    column.Width = 100;
                    Grid1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                }
                else if (column.DataPropertyName == "ValorPrazo")
                {
                    column.Width = 100;
                    Grid1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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

        // CRIACAO OU INSTANCIA DA FUNCAO BUSCADADOS
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
            txtDescricao.Text = cl.Descricao;
            txtValorVista.Text = cl.ValorVista.ToString("C2");
            txtValorPrazo.Text = cl.ValorPrazo.ToString("C2");

            wpCria = false;

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


        // habilita todos os campos para preenchimento
        private void HabilitaCampos()
        {
            txtDescricao.Enabled = true;
            txtValorPrazo.Enabled = true;
            txtValorVista.Enabled = true;

        }
        // desabilita todos os campos para nao poder preencher
        private void DesabilitaCampos()
        {
            lblID.Enabled = false;
            txtDescricao.Enabled = true;
            txtValorVista.Enabled = true;
            txtValorPrazo.Enabled = true;

        }
        // funcao que apaga o conteudo dos campos no formulario (nao no banco de dados)
        private void LimpaDados()
        {
            lblID.Text = "";
            txtDescricao.Text = "";
            txtValorPrazo.Text = "";
            txtValorVista.Text = "";

        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            bool Salvar = true;

            if (!wpCria)
            {
                cl.Id = int.Parse(Grid1.SelectedRows[0].Cells[0].Value.ToString());

            }
            cl.Descricao = txtDescricao.Text;

            /* 
             * COMANDO ABAIXO RETIRA O SINAL DE R$ DAS VARIAVEIS PARA SER GRAVADOS NO SQL SERVER
             */

            char[] MyChar = { 'R', '$' };
            txtValorVista.Text = txtValorVista.Text.TrimStart(MyChar);
            txtValorPrazo.Text = txtValorPrazo.Text.TrimStart(MyChar);

            cl.ValorVista = double.Parse(txtValorVista.Text);
            cl.ValorPrazo = double.Parse(txtValorPrazo.Text);

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

        private void fServicos_KeyDown(object sender, KeyEventArgs e)
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

        private void Grid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex > -1)

            {

                if (e.RowIndex % 2 == 0)

                    e.CellStyle.BackColor = Color.PaleTurquoise;

                else

                    e.CellStyle.BackColor = Color.White;

               // e.CellStyle.ForeColor = Color.IndianRed;

            }


        }
    }
}
