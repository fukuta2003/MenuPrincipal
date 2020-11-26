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
    public partial class fEntradas : Form
    {

        Entradas Ent = new Entradas();
        Fornecedores Forn = new Fornecedores();
        Compradores Vnd = new Compradores();
        Validacao Fun = new Validacao();
        Produtos Pro = new Produtos();
        Marcas Mar = new Marcas();
        Grupos Gru = new Grupos();
        FormasPagamento Fpg = new FormasPagamento();
        Transportadores Tra = new Transportadores();

        ListViewItem grdProdutos; // RECEBER OS DADOS DOS PRODUTOS SEJA NA INCLUSAO OU CONSULTA/ALTERAÇÃO

        // variaveis do sistema
        double xTotalBruto = 0;
        double xTotalLiquido = 0;
        double xTaxaEntrega = 0;
        double xDescontoReal = 0;
        double xDescontoPorc = 0;
        double xQuant = 0;
        double xTotalProduto = 0;
        bool ret = false; // variavel para controle de return dos eventos
        bool wp_Incluir = false; // controlar se vai ser inclusao ou alteraçao
        int locX, locY = 0;

        public fEntradas()
        {
            InitializeComponent();
        }

        private void fEntradas_Load(object sender, EventArgs e)
        {

        }





        private void GrdPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                int y = 0;
                locX = 9;
                locY = 100;
                if (GrdPro.Items.Count > 0)
                {
                    for (y = 0; y <= GrdPro.Items.Count - 1; y++)
                    {
                        if (GrdPro.Items[y].SubItems[0].Text == "")
                        {
                            break;
                        }
                        else
                        {
                            if (locY <= 220)
                            {
                                locY += 20;
                            }
                        }
                    }


                }

                txtEditor.Location = new Point(locX, locY);

                txtEditor.Visible = true;
                txtEditor.Focus();
            }
        }

        private void GrdPro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = GrdPro.Items.Count - 1; i >= 0; i--)
                {
                    if (GrdPro.Items[i].Selected)
                    {
                        GrdPro.Items[i].Remove();
                    }
                }
            }

        }

        private void txtEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                // produtos
                if (!string.IsNullOrEmpty(txtEditor.Text))
                {

                    if (!ProcuraMesmoProduto(txtEditor.Text))  // procura o mesmo produto dentro da grade
                    {

                        if (txtEditor.Text.Length < 13) // procura por id quando o codigo informado for menor que 13 digitos
                        {

                            if (Pro.Consulta(int.Parse(txtEditor.Text)))
                            {
                                AdicionaGrade();
                            }
                            else
                            {
                                MessageBox.Show("Item não encontrado !");
                                txtEditor.Focus();
                            }


                        }
                        else
                        {
                            // consulta por codigo de barras para codigos de barras de 13 digitos ou mais.

                            if (Pro.Consulta(0, txtEditor.Text))
                            {
                                AdicionaGrade();
                            }
                            else
                            {
                                MessageBox.Show("Código de Barras não encontrado no Banco de Dados !");
                                txtEditor.Focus();
                            }


                        }

                    }
                    else
                    {

                        CalculaTotal();
                        txtEditor.Text = "";
                        txtEditor.Visible = false;
                        GrdPro.Focus();
                        SendKeys.SendWait("{DOWN}");
                    }

                }

            }
        }

        private void AdicionaGrade()
        {
            if (txtEditor.Text.Length >= 13)
            {
                txtEditor.Text = Pro.Id.ToString();
            }
            //GrdPro.Columns.Add(txtEditor.Text);
            grdProdutos = new ListViewItem(txtEditor.Text);
            grdProdutos.ForeColor = Color.White;
            grdProdutos.SubItems.Add(Pro.Descricao.ToString());
            grdProdutos.SubItems.Add(Pro.Unidade.ToString());
            grdProdutos.SubItems.Add(Pro.Preco_Venda.ToString("N"));
            grdProdutos.SubItems.Add("1");
            grdProdutos.SubItems.Add(Pro.Preco_Venda.ToString("N"));
            grdProdutos.SubItems.Add(Pro.Local_Estoque.ToString());

            GrdPro.Items.Add(grdProdutos);
            CalculaTotal();
            txtEditor.Text = "";
            txtEditor.Visible = false;
            GrdPro.Focus();
            SendKeys.SendWait("{END}");

        }

        private void CalculaTotal()
        {
            xTotalBruto = 0;
            for (int i = 0; i < GrdPro.Items.Count; i++)
            {
                // MessageBox.Show(GrdPro.Items[i].SubItems[j].Text);

                xTotalBruto += double.Parse(GrdPro.Items[i].SubItems[5].Text); // 5 é o valor total do produto na grade

            }

            txtTotalBruto.Text = xTotalBruto.ToString("N");

            if (string.IsNullOrEmpty(txtTaxaEntrega.Text))
            {
                txtTaxaEntrega.Text = "0,00";
            }

            xTaxaEntrega = double.Parse(txtTaxaEntrega.Text);

            if (!string.IsNullOrEmpty(txtDescontoPorc.Text))
            {
                xDescontoReal = ((xTotalBruto * double.Parse(txtDescontoPorc.Text) / 100));
                txtDescontoReal.Text = xDescontoReal.ToString("N");
            }

            xTotalLiquido = (xTotalBruto - xDescontoReal) + xTaxaEntrega;

            txtTotalLiquido.Text = xTotalLiquido.ToString("N");

        }



        private void txtEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.Handled = true;
                fShow fsw = new fShow("PRODUTOS",
                    new string[] { "ID", "DESCRICAO", "CODEBAR", "ESTOQUE_ATUAL", "PRECO_VENDA" }, "DESCRICAO");
                fsw.ShowDialog();
                txtEditor.Text = int.Parse(fsw.ParametroID.ToString()).ToString();
                if (!string.IsNullOrEmpty(txtEditor.Text))
                {
                    SendKeys.SendWait("{ENTER}");
                    txtEditor.Visible = false;
                    GrdPro.Focus();
                }
            }
        }

        private void txtDescontoPorc_Leave(object sender, EventArgs e)
        {
            txtDescontoPorc.BackColor = Color.White;
            txtDescontoReal.BackColor = Color.White;
            txtDescontoPorc.Text = Fun.Formata_Moeda(txtDescontoPorc.Text);
            CalculaTotal();
        }

        private void txtTaxaEntrega_Leave(object sender, EventArgs e)
        {
            txtTaxaEntrega.BackColor = Color.White;
            txtTaxaEntrega.Text = Fun.Formata_Moeda(txtTaxaEntrega.Text);
            CalculaTotal();
        }

        private void txtDescontoPorc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescontoPorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.AnalisaMoeda(e);   // somente numeros e ,(virgula)
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtEntrega.Focus();
            }
        }

        private void txtTaxaEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.AnalisaMoeda(e);  // somente numeros e virgulas
            if (e.KeyChar == 13)
            {
                txtObservacoes.Focus();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Fun.Confirma("Posso Salvar o Orçamento ?", "Atenção"))
            {
                if (!Verifica_Dados())
                {
                    MessageBox.Show("Dados inconsistentes, verifique dados sem preenchimento");
                    txtFornecedor.Focus();
                }
                else
                {
                    EnviaDadosClasse();
                    if (Ent.Salvar(wp_Incluir))
                    {
                        MessageBox.Show("Orçamento salvo com sucesso !");
                        LimpaTexto();
                        txtEntrada.Text = "";
                        gpoDados.Enabled = false;
                        txtEntrada.Focus();
                        // limpartexto, retornar ao id
                    }
                    else
                    {
                        MessageBox.Show("Problemas ao salvar o Orçamento !");
                        txtFornecedor.Focus();
                    }
                }
            }
        }


        private void LimpaTexto()
        {
            txtFornecedor.Text = "";
            lblFornecedor.Text = "";
            txtComprador.Text = "";
            lblComprador.Text = "";
            txtData.Text = "";
            GrdPro.Items.Clear();
            txtTotalBruto.Text = "";
            txtDescontoPorc.Text = "";
            txtDescontoReal.Text = "";
            txtEntrega.Text = "";
            txtTaxaEntrega.Text = "";
            txtObservacoes.Text = "";
            txtTotalLiquido.Text = "";

        }

        private void EnviaDadosClasse()
        {
            if (string.IsNullOrEmpty(txtEntrada.Text))
            {
                Ent.Id = 0;
            }
            else
            {
                Ent.Id = int.Parse(txtEntrada.Text);
            }

            Ent.Data = DateTime.Parse(txtData.Text);
            Ent.Fornecedor_id = int.Parse(txtFornecedor.Text);
            Ent.Comprador_id = int.Parse(txtComprador.Text);
            Ent.FormaPagamento_id = int.Parse(txtFormaPagamento.Text);
            Ent.Transportadores_id = int.Parse(txtEntrega.Text);
            Ent.TotalBruto = double.Parse(txtTotalBruto.Text);
            Ent.DescontoReal = double.Parse(txtDescontoReal.Text);
            Ent.DescontoPorc = double.Parse(txtDescontoPorc.Text);
            Ent.TaxaEntrega = double.Parse(txtTaxaEntrega.Text);
            Ent.TotalLiquido = double.Parse(txtTotalLiquido.Text);
            Ent.Observacao = txtObservacoes.Text;

            // enviando listview para classe

            Ent.EntDadosPro = GrdPro;

        }

        private bool Verifica_Dados()
        {
            bool ret = true;
            if (string.IsNullOrEmpty(txtComprador.Text))
            {
                ret = false;
            }
            if (string.IsNullOrEmpty(txtFornecedor.Text))
            {
                ret = false;
            }
            if (string.IsNullOrEmpty(txtEntrega.Text))
            {
                ret = false;
            }
            if (string.IsNullOrEmpty(txtFormaPagamento.Text))
            {
                ret = false;
            }
            if (string.IsNullOrEmpty(txtTotalLiquido.Text))
            {
                ret = false;
            }
            return ret;
        }

        private void fOrcamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                e.Handled = true;

                if (ActiveControl.Name.ToUpper() == "GRDPRO")
                {
                    CalculaTotal();
                    txtFormaPagamento.BackColor = Color.Yellow;
                    txtFormaPagamento.Focus();

                }
                else if (ActiveControl.Name.ToUpper() == "TXTEDITOR")
                {
                    txtEditor.Visible = false;
                    CalculaTotal();
                    GrdPro.Focus();

                }
                else if (ActiveControl.Name.ToUpper() == "TXTORCAMENTO")
                {

                    this.Close();

                }
                else
                {

                    LimpaTexto();
                    gpoDados.Enabled = false;
                    txtEntrada.Text = "";
                    txtEntrada.Focus();

                }


            }
        }

        private void txtFormaPagamento_Leave(object sender, EventArgs e)
        {


            txtFormaPagamento.BackColor = Color.White;

        }


        private void txtFormaPagamento_Enter(object sender, EventArgs e)
        {
            txtFormaPagamento.BackColor = Color.Yellow;
        }

        private void txtDescontoPorc_Enter(object sender, EventArgs e)
        {
            txtDescontoPorc.BackColor = Color.Yellow;
            txtDescontoReal.BackColor = Color.Yellow;
        }

        private void txtTaxaEntrega_Enter(object sender, EventArgs e)
        {
            txtTaxaEntrega.BackColor = Color.Yellow;
        }

        private void txtEntrega_Enter(object sender, EventArgs e)
        {
            txtEntrega.BackColor = Color.Yellow;
        }

        private void txtEntrega_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEntrega.Text))
            {
                txtEntrega.Text = "1";
            }
            if (Tra.Consulta(int.Parse(txtEntrega.Text)))
            {
                txtTaxaEntrega.Text = Tra.Taxa.ToString("N");
                lblEntrega.Text = Tra.Descricao.ToString();
                txtTaxaEntrega.Focus();
            }
            else
            {
                lblEntrega.Text = "Não encontrado...";
                txtEntrega.Focus();
            }
            txtEntrega.BackColor = Color.White;
        }

        private void txtEntrada_Enter(object sender, EventArgs e)
        {
            txtEntrada.BackColor = Color.Yellow;
        }

        private void txtEntrada_Leave(object sender, EventArgs e)
        {
            txtEntrada.BackColor = Color.White;
        }

        private void txtData_Enter(object sender, EventArgs e)
        {
            txtData.CalendarMonthBackground = Color.Yellow;
        }

        private void txtData_Leave(object sender, EventArgs e)
        {
            txtData.CalendarMonthBackground = Color.White;
        }

        private void txtObservacoes_Enter(object sender, EventArgs e)
        {
            txtObservacoes.BackColor = Color.Yellow;
        }

        private void txtObservacoes_Leave(object sender, EventArgs e)
        {
            txtObservacoes.BackColor = Color.White;
        }

        private void txtEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.AnalisaInteiro(e);
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                // busca forma de entreg

                txtTaxaEntrega.Focus();
            }
        }

        private void txtFormaPagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFormaPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.AnalisaInteiro(e);
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                if (Fpg.Consulta(int.Parse(txtFormaPagamento.Text)))
                {
                    lblFormaPagamento.Text = Fpg.Descricao.ToString();
                    txtDescontoPorc.Focus();
                }
                else
                {
                    lblFormaPagamento.Text = "Forma não encontrada !";
                    txtFormaPagamento.Focus();
                }
            }
        }

        private void txtFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {

                e.Handled = true;
                fShow fsw = new fShow("FormasPagamento", new string[] { "Id", "Descricao" }, "Descricao");
                fsw.ShowDialog();
                txtFormaPagamento.Text = int.Parse(fsw.ParametroID.ToString()).ToString();
                if (!string.IsNullOrEmpty(txtFormaPagamento.Text))
                {
                    SendKeys.SendWait("{ENTER}");
                }

            }
        }

        private void txtEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.Handled = true;
                fShow fsw = new fShow("TRANSPORTADORES", new string[] { "ID", "DESCRICAO", "TAXA" }, "DESCRICAO");
                fsw.ShowDialog();
                if (!string.IsNullOrEmpty(fsw.ParametroID.ToString()))
                {
                    txtEntrega.Text = int.Parse(fsw.ParametroID.ToString()).ToString();
                    SendKeys.SendWait("{ENTER}");
                }
            }
        }

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.AnalisaInteiro(e);  // NAO DEIXA QUE O CAMPO RECEBA LETRAS / CARACTERES ESPECIAIS 

            if (e.KeyChar == 13)  // TECLA 13 (ENTER)
            {
                e.Handled = true;  // OMITI O BEEP DA TECLA ENTER

                if (string.IsNullOrEmpty(txtEntrada.Text))
                {
                    wp_Incluir = true; // VARIAVEL DE CONTROLE PRA INFORMAR SE É PRA INCLUIR OU ALTERAR
                    gpoDados.Enabled = true; // HABILITAR A GROUPBOX (GPODADOS) PARA ACESSAR OS CAMPOS
                    txtData.Focus(); // ENVIA O FOCO DO FORMULARIO PARA O CAMPO TXTDATA;

                }
                else
                {
                    wp_Incluir = false; // ALTERAÇÃO
                    if (Ent.Consulta(int.Parse(txtEntrada.Text)))
                    {
                        BuscaDadosClasse();
                        gpoDados.Enabled = true;
                        txtData.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Orçamento não Encontrado !");
                        txtEntrada.Focus();
                    }
                }
            }
        }


        private void BuscaDadosClasse()
        {
            txtData.Text = Ent.Data.ToString("dd/MM/yyyy");
            txtFornecedor.Text = Ent.Fornecedor_id.ToString();
            if (Forn.ConsultaFornecedorId(int.Parse(txtFornecedor.Text)))
            {
                lblFornecedor.Text = Forn.Nome.ToString();
            }
            else
            {
                lblFornecedor.Text = "Fornecedor não encontrado...";
            }
            txtComprador.Text = Ent.Fornecedor_id.ToString();
            if (Vnd.ConsultaId(int.Parse(txtComprador.Text)))
            {
                lblComprador.Text = Vnd.Nome.ToString();
            }
            else
            {
                lblComprador.Text = "Comprador não encontrado...";
            }
            txtFormaPagamento.Text = Ent.FormaPagamento_id.ToString();
            if (Fpg.Consulta(int.Parse(txtFormaPagamento.Text)))
            {
                lblFormaPagamento.Text = Fpg.Descricao.ToString();
            }
            else
            {
                lblFormaPagamento.Text = "forma de pagamento não encontrada";
            }
            txtEntrega.Text = Ent.Transportadores_id.ToString();
            if (Tra.Consulta(int.Parse(txtEntrega.Text)))
            {
                lblEntrega.Text = Tra.Descricao.ToString();
            }
            else
            {
                lblEntrega.Text = "Transportador não encontrado";
            }
            txtTotalBruto.Text = Ent.TotalBruto.ToString("N");
            txtDescontoPorc.Text = Ent.DescontoPorc.ToString("N");
            txtDescontoReal.Text = Ent.DescontoReal.ToString("N");
            txtTaxaEntrega.Text = Ent.TaxaEntrega.ToString("N");
            txtTotalLiquido.Text = Ent.TotalLiquido.ToString("N");
            txtObservacoes.Text = Ent.Observacao.ToString();

            GrdPro.Items.Clear();
            int x = 0;

            for (int y = 0; y <= 99; y++)
            {
                if (string.IsNullOrEmpty(Ent.ListaPro[y, 1]))
                {
                    break;
                }
                grdProdutos = new ListViewItem(Ent.ListaPro[y, 0].ToString());
                grdProdutos.ForeColor = Color.White;
                for (x = 1; x <= 6; x++)
                {
                    if (string.IsNullOrEmpty(Ent.ListaPro[y, x]))
                    {
                        Ent.ListaPro[y, x] = "";
                    }
                    grdProdutos.ForeColor = Color.White;
                    grdProdutos.SubItems.Add(Ent.ListaPro[y, x].ToString());


                }
                GrdPro.Items.Add(grdProdutos);

            }



        }

        private void fOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (ActiveControl.Name.ToUpper() == "TXTORCAMENTO")
                {

                }
            }
        }

        private void txtData_ValueChanged(object sender, EventArgs e)
        {
            txtFornecedor.Focus();
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtFornecedor.Focus();
            }
        }

        private void txtOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.Handled = true;
                fShow fsw = new fShow("ORCAMENTO", new string[] { "ID", "CLIENTE_ID", "DATA", "TOTALBRUTO", "TOTALLIQUIDO" }, "DATA");
                fsw.ShowDialog();
                if (!string.IsNullOrEmpty(fsw.ParametroID.ToString()))
                {
                    txtEntrada.Text = fsw.ParametroID.ToString();
                    SendKeys.SendWait("{ENTER}");
                }

            }
        }

        private void GrdPro_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfo.Visible = true;
        }

        private void GrdPro_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void txtOrcamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.AnalisaInteiro(e);

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (!string.IsNullOrEmpty(txtFornecedor.Text))
                {
                    if (Forn.ConsultaFornecedorId(int.Parse(txtFornecedor.Text)))
                    {
                        lblFornecedor.Text = Forn.Nome.ToString();
                        txtComprador.Focus();
                    }
                    else
                    {
                        lblFornecedor.Text = "Fornecedor não encontrado !";
                        txtFornecedor.Focus();
                    }

                }
                else
                {
                    txtFornecedor.Focus();
                }
            }
        }

        private void txtFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {

                fShow fsw = new fShow("Fornecedor",
                    new string[] { "Id", "Nome", "CNPJ", "Endereco", "Cidade", "Estado", "Telefone" }, "nome");

                fsw.ShowDialog();

                txtFornecedor.Text = fsw.ParametroID.ToString();
                if (!string.IsNullOrEmpty(txtFornecedor.Text))
                {
                    SendKeys.SendWait("{ENTER}");
                }
            }
        }

        private void txtComprador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {

                fShow fsw = new fShow("Compradores",
                    new string[] { "Id", "Nome", "CPF", "Endereco", "Cidade", "Estado", "Telefone" }, "nome");

                fsw.ShowDialog();

                txtComprador.Text = fsw.ParametroID.ToString();
                if (!string.IsNullOrEmpty(txtComprador.Text))
                {
                    SendKeys.SendWait("{ENTER}");
                }
            }
        }

        private void txtComprador_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.AnalisaInteiro(e); // somente numeros inteiros 

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (!string.IsNullOrEmpty(txtComprador.Text))
                {
                    if (Vnd.ConsultaId(int.Parse(txtComprador.Text)))
                    {
                        lblComprador    .Text = Vnd.Nome.ToString();
                        GrdPro.Focus();
                        SendKeys.SendWait("{ENTER}");

                    }
                    else
                    {
                        lblComprador.Text = "Cliente não encontrado !";
                        txtComprador.Focus();
                    }

                }
                else
                {
                    txtComprador.Focus();
                }
            }

        }

        private bool ProcuraMesmoProduto(string CodProduto = "")
        {
            xQuant = 0;
            ret = false;
            if (CodProduto.Length >= 13) // se for codigo de barras, procura o produto e retorna o id dele
            {
                if (Pro.Consulta(0, CodProduto.ToString()))
                {
                    CodProduto = Pro.Id.ToString();
                }
            }

            for (int i = 0; i < GrdPro.Items.Count; i++)
            {
                // MessageBox.Show(GrdPro.Items[i].SubItems[j].Text);

                if (GrdPro.Items[i].SubItems[0].Text == CodProduto.ToString())
                {
                    xQuant = double.Parse(GrdPro.Items[i].SubItems[4].Text) + 1;
                    GrdPro.Items[i].SubItems[4].Text = xQuant.ToString();

                    // calcular o valor total do produto
                    xQuant = double.Parse(GrdPro.Items[i].SubItems[4].Text);
                    xTotalProduto = double.Parse(GrdPro.Items[i].SubItems[3].Text) * xQuant;
                    GrdPro.Items[i].SubItems[5].Text = xTotalProduto.ToString("N");

                    ret = true;
                    break;
                }


            }

            return ret;


        }




        // FIM DA CLASSE
    }
}
