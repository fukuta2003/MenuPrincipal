using MenuPrincipalB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Models
{
    public partial class fPedido : Form
    {

        Pedido Ped = new Pedido();
        Clientes Cli = new Clientes();
        Vendedores Vnd = new Vendedores();
        Validacao Fun = new Validacao();
        Produtos Pro = new Produtos();
        Marcas Mar = new Marcas();
        Grupos Gru = new Grupos();
        FormasPagamento Fpg = new FormasPagamento();
        Transportadores Tra = new Transportadores();
        Estoque Est = new Estoque();

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

        public fPedido()
        {
            InitializeComponent();
        }

        private void fPedido_Load(object sender, EventArgs e)
        {

        }


        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.AnalisaInteiro(e);

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (!string.IsNullOrEmpty(txtCliente.Text))
                {
                    if (Cli.ConsultaClienteId(int.Parse(txtCliente.Text)))
                    {
                        lblCliente.Text = Cli.Nome.ToString();
                        txtVendedor.Focus();
                    }
                    else
                    {
                        lblCliente.Text = "Cliente não encontrado !";
                        txtCliente.Focus();
                    }

                }
                else
                {
                    txtCliente.Focus();
                }
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {

                fShow fsw = new fShow("cliente",
                    new string[] { "Id", "Nome", "CPF", "Endereco", "Cidade", "Estado", "Telefone" }, "nome");

                fsw.ShowDialog();

                txtCliente.Text = fsw.ParametroID.ToString();
                if (!string.IsNullOrEmpty(txtCliente.Text))
                {
                    SendKeys.SendWait("{ENTER}");
                }
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {

                fShow fsw = new fShow("Vendedores",
                    new string[] { "Id", "Nome", "CPF", "Endereco", "Cidade", "Estado", "Telefone" }, "nome");

                fsw.ShowDialog();

                txtVendedor.Text = fsw.ParametroID.ToString();
                if (!string.IsNullOrEmpty(txtVendedor.Text))
                {
                    SendKeys.SendWait("{ENTER}");
                }
            }
        }

        private void txtVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.AnalisaInteiro(e); // somente numeros inteiros 

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (!string.IsNullOrEmpty(txtVendedor.Text))
                {
                    if (Vnd.ConsultaId(int.Parse(txtVendedor.Text)))
                    {
                        lblVendedor.Text = Vnd.Nome.ToString();
                        GrdPro.Focus();
                        SendKeys.SendWait("{ENTER}");

                    }
                    else
                    {
                        lblVendedor.Text = "Cliente não encontrado !";
                        txtVendedor.Focus();
                    }

                }
                else
                {
                    txtVendedor.Focus();
                }
            }

        }

        private void GrdPro_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {

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
            if (Fun.Confirma("Posso Salvar o Pedido ?", "Atenção"))
            {
                if (!Verifica_Dados())
                {
                    MessageBox.Show("Dados inconsistentes, verifique dados sem preenchimento");
                    txtCliente.Focus();
                }
                else
                {
                    EnviaDadosClasse();
                    if (Ped.Salvar(wp_Incluir))
                    {
                        MessageBox.Show("Pedido salvo com sucesso !");
                        LimpaTexto();
                        txtPedido.Text = "";
                        gpoDados.Enabled = false;
                        txtPedido.Focus();
                        // limpartexto, retornar ao id
                    }
                    else
                    {
                        MessageBox.Show("Problemas ao salvar o Orçamento !");
                        txtCliente.Focus();
                    }
                }
            }
        }


        private void LimpaTexto()
        {
            txtCliente.Text = "";
            lblCliente.Text = "";
            txtVendedor.Text = "";
            lblVendedor.Text = "";
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
            if (string.IsNullOrEmpty(txtPedido.Text))
            {
                Ped.Id = 0;
            }
            else
            {
                Ped.Id = int.Parse(txtPedido.Text);
            }

            Ped.Data = DateTime.Parse(txtData.Text);
            Ped.Cliente_id = int.Parse(txtCliente.Text);
            Ped.Vendedor_id = int.Parse(txtVendedor.Text);
            Ped.FormaPagamento_id = int.Parse(txtFormaPagamento.Text);
            Ped.Transportadores_id = int.Parse(txtEntrega.Text);
            Ped.TotalBruto = double.Parse(txtTotalBruto.Text);
            Ped.DescontoReal = double.Parse(txtDescontoReal.Text);
            Ped.DescontoPorc = double.Parse(txtDescontoPorc.Text);
            Ped.TaxaEntrega = double.Parse(txtTaxaEntrega.Text);
            Ped.TotalLiquido = double.Parse(txtTotalLiquido.Text);
            Ped.Observacao = txtObservacoes.Text;

            // enviando listview para classe

            Ped.PedDadosPro = GrdPro;

        }

        private bool Verifica_Dados()
        {
            bool ret = true;
            if (string.IsNullOrEmpty(txtVendedor.Text))
            {
                ret = false;
            }
            if (string.IsNullOrEmpty(txtCliente.Text))
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

        private void fPedido_KeyPress(object sender, KeyPressEventArgs e)
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
                else if (ActiveControl.Name.ToUpper() == "TXTPEDIDO")
                {

                    this.Close();

                }
                else
                {

                    LimpaTexto();
                    gpoDados.Enabled = false;
                    txtPedido.Text = "";
                    txtPedido.Focus();

                }


            }
        }

        private void txtFormaPagamento_Leave(object sender, EventArgs e)
        {


            txtFormaPagamento.BackColor = Color.White;

        }

        private void txtCliente_Enter(object sender, EventArgs e)
        {
            txtCliente.BackColor = Color.Yellow;
        }

        private void txtVendedor_Enter(object sender, EventArgs e)
        {
            txtVendedor.BackColor = Color.Yellow;
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            txtCliente.BackColor = Color.White;
        }

        private void txtVendedor_Leave(object sender, EventArgs e)
        {
            txtVendedor.BackColor = Color.White;
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

        private void txtPedido_Enter(object sender, EventArgs e)
        {
            txtPedido.BackColor = Color.Yellow;
        }

        private void txtPedido_Leave(object sender, EventArgs e)
        {
            txtPedido.BackColor = Color.White;
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

        private void txtPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fun.AnalisaInteiro(e);  // NAO DEIXA QUE O CAMPO RECEBA LETRAS / CARACTERES ESPECIAIS 

            if (e.KeyChar == 13)  // TECLA 13 (ENTER)
            {
                e.Handled = true;  // OMITI O BEEP DA TECLA ENTER

                if (string.IsNullOrEmpty(txtPedido.Text))
                {
                    wp_Incluir = true; // VARIAVEL DE CONTROLE PRA INFORMAR SE É PRA INCLUIR OU ALTERAR
                    gpoDados.Enabled = true; // HABILITAR A GROUPBOX (GPODADOS) PARA ACESSAR OS CAMPOS
                    txtData.Focus(); // ENVIA O FOCO DO FORMULARIO PARA O CAMPO TXTDATA;

                }
                else
                {
                    wp_Incluir = false; // ALTERAÇÃO
                    if (Ped.Consulta(int.Parse(txtPedido.Text)))
                    {
                        BuscaDadosClasse();
                        if (Ped.Faturado=="S")
                        {
                            gpoDados.Enabled = false;
                        } else
                        {
                            gpoDados.Enabled = true;
                            txtData.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Orçamento não Encontrado !");
                        txtPedido.Focus();
                    }
                }
            }
        }


        private void BuscaDadosClasse()
        {
            txtData.Text = Ped.Data.ToString("dd/MM/yyyy");
            txtCliente.Text = Ped.Cliente_id.ToString();
            if (Cli.ConsultaClienteId(int.Parse(txtCliente.Text)))
            {
                lblCliente.Text = Cli.Nome.ToString();
            }
            else
            {
                lblCliente.Text = "cliente não encontrado...";
            }
            txtVendedor.Text = Ped.Vendedor_id.ToString();
            if (Vnd.ConsultaId(int.Parse(txtVendedor.Text)))
            {
                lblVendedor.Text = Vnd.Nome.ToString();
            }
            else
            {
                lblVendedor.Text = "vendedor não encontrado...";
            }
            txtFormaPagamento.Text = Ped.FormaPagamento_id.ToString();
            if (Fpg.Consulta(int.Parse(txtFormaPagamento.Text)))
            {
                lblFormaPagamento.Text = Fpg.Descricao.ToString();
            }
            else
            {
                lblFormaPagamento.Text = "forma de pagamento não encontrada";
            }
            txtEntrega.Text = Ped.Transportadores_id.ToString();
            if (Tra.Consulta(int.Parse(txtEntrega.Text)))
            {
                lblEntrega.Text = Tra.Descricao.ToString();
            }
            else
            {
                lblEntrega.Text = "Transportador não encontrado";
            }
            txtTotalBruto.Text = Ped.TotalBruto.ToString("N");
            txtDescontoPorc.Text = Ped.DescontoPorc.ToString("N");
            txtDescontoReal.Text = Ped.DescontoReal.ToString("N");
            txtTaxaEntrega.Text = Ped.TaxaEntrega.ToString("N");
            txtTotalLiquido.Text = Ped.TotalLiquido.ToString("N");
            txtObservacoes.Text = Ped.Observacao.ToString();

            GrdPro.Items.Clear();
            int x = 0;

            for (int y = 0; y <= 99; y++)
            {
                if (string.IsNullOrEmpty(Ped.ListaPro[y, 1]))
                {
                    break;
                }
                grdProdutos = new ListViewItem(Ped.ListaPro[y, 0].ToString());
                grdProdutos.ForeColor = Color.White;
                for (x = 1; x <= 6; x++)
                {
                    if (string.IsNullOrEmpty(Ped.ListaPro[y, x]))
                    {
                        Ped.ListaPro[y, x] = "";
                    }
                    grdProdutos.ForeColor = Color.White;
                    grdProdutos.SubItems.Add(Ped.ListaPro[y, x].ToString());


                }
                GrdPro.Items.Add(grdProdutos);


                if (Ped.Faturado == "S")
                {
                    lblFaturado.Visible = true;
                    gpoDados.Enabled = false;
                } else
                {
                    lblFaturado.Visible = false;
                    
                }



            }



        }

        private void fPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (ActiveControl.Name.ToUpper() == "TXTPEDIDO")
                {

                }
            }
        }

        private void txtData_ValueChanged(object sender, EventArgs e)
        {
            txtCliente.Focus();
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtCliente.Focus();
            }
        }

        private void txtPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.Handled = true;
                fShow fsw = new fShow("PEDIDO", new string[] { "ID", "CLIENTE_ID", "DATA", "TOTALBRUTO", "TOTALLIQUIDO" }, "DATA");
                fsw.ShowDialog();
                if (!string.IsNullOrEmpty(fsw.ParametroID.ToString()))
                {
                    txtPedido.Text = fsw.ParametroID.ToString();
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

        private void btnFaturar_Click(object sender, EventArgs e)
        {

            int xProduto = 0;
            decimal xQuan = 0;
            bool ret = true;  

            if(Fun.Confirma("Confirmar Faturamento ?", "Aviso"))
            {
                ret = true;

                // percorre a grade pra pegar os codigos do produtos 
                // e as quantidades e executa a baixa do estoque
                for (int i = 0; i < GrdPro.Items.Count; i++)
                {
                    if(GrdPro.Items[i].SubItems[0].Text == "")
                    {
                        break;
                    }

                    // baixando os produtos
                    xProduto = int.Parse(GrdPro.Items[i].SubItems[0].Text);
                    xQuan = decimal.Parse(GrdPro.Items[i].SubItems[4].Text);
                    if (!Est.BaixarEstoque(xProduto, xQuan))
                    {
                       
                        ret = false;
                    } else
                    {
                        GrdPro.Items[i].BackColor = Color.Red;  // muda a cor de fundo para produtos baixados
                    }
                }

                if (!ret)
                {
                    MessageBox.Show("Nem todos os produtos foram baixados, verifique !");
                } else
                {

                    if (Ped.FaturaPedido(int.Parse(txtPedido.Text)))
                    {
                        // pedido faturado com sucesso !

                    } else
                    {
                        ret = false;
                    }

                    if(ret) { 
                        
                        MessageBox.Show("Produtos baixados com sucesso !");
                    
                    } else
                    {
                        MessageBox.Show("Problemas no faturamento deste Pedido, verifique !");
                    }
                }


            }
        }

        private void txtPedido_TextChanged(object sender, EventArgs e)
        {

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


        // FINAL DA CLASSE PEDIDO

    }
}
