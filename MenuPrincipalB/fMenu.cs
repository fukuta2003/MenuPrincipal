using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sistema.Models;
using System.Linq;

namespace Sistema
{
    
    public partial class fMenu : Form
    {

        public bool bdExiste = false;
        public string LoginOperacao = ""; // tipo de operador (Administrador,Gerente,Financeiro,Caixa ECF,Operador)
        public string LoginUsuario = "";

        Db bancodados = new Db();
        Empresa emp = new Empresa();

       
        public fMenu()
        {
            if (!bancodados.Conecta())
            {
                MessageBox.Show("Erro de conexão com banco de dados !");
                Application.Exit();
                bdExiste = false;
            } else
            {
                bdExiste = true;
            }
            InitializeComponent();
        }

        private void fMenu_Load(object sender, EventArgs e)
        {

            panel1.Top = this.Bottom - 110;

            DateTime xData = DateTime.Today;

            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.DarkRed;

            if (emp.Consulta(1))
            {
                toolNomeEmpresa.Text = emp.RazaoSocial.ToString();
                toolNomeUsuarioAtivo.Text = "";
                toolDataSistema.Text = DateTime.Now.ToString("dd-MM-yyyy");

                if (emp.Validade < xData)
                {
                    MessageBox.Show("Problemas de conexão com o Banco de Dados \nverifique com o Desenvolvedor ou Revendedor", "Erro 1806");
                    Application.Exit();
                }    

            } else
            {
                toolNomeEmpresa.Text = "EMPRESA NÃO REGISTRADA";
                Application.Exit();
            }


            if (bdExiste == true)
            {
                fLogin frmLogin = new fLogin();
               // frmLogin.MdiParent = this;
                frmLogin.StartPosition = FormStartPosition.CenterScreen;
                frmLogin.ShowDialog();

                if(frmLogin.ParametroID.ToString()=="EXIT")
                {
                    Application.Exit();

                } else { 

                        Usuarios usr = new Usuarios();
                        if (usr.Consulta(0, frmLogin.ParametroID.ToString())){

                            toolNomeUsuarioAtivo.Text = "( " + usr.Login.ToString() + " ) - " + usr.Nome.ToString() + " -> " + usr.Operacao.ToString();
                            LoginOperacao = usr.Operacao.ToString();
                            LoginUsuario = usr.Login.ToString();
                        } else
                        {
                            toolNomeUsuarioAtivo.Text = "";
                        }

                }

            } else
            {
                MessageBox.Show("CLIQUE EM OK para sair do sistema !");
                Application.Exit();
            }
        }
    


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaClientes();         
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChamaUsuarios()
        {
            fUsuarios usr = new fUsuarios();
            usr.MdiParent = this;
            usr.StartPosition = FormStartPosition.CenterScreen;
            usr.Show();

        }


        private void ChamaCentroVendas()
        {
            fCentroVendas fcv = new fCentroVendas();
            fcv.MdiParent = this;
            fcv.StartPosition = FormStartPosition.CenterScreen;
            fcv.Show();

        }

        private void ChamaClientes()
        {
            fClientes cli = new fClientes();
            cli.MdiParent = this;
            cli.StartPosition = FormStartPosition.CenterScreen;
            cli.Show();

        }

        private void ChamaFornecedores()
        {
            fFornecedores fd = new fFornecedores();
            fd.MdiParent = this;
            fd.StartPosition = FormStartPosition.CenterScreen;
            fd.Show();

        }

       
        private void ChamaContasReceber()
        {
            fContasReceber fcp = new fContasReceber();
            fcp.MdiParent = this;
            fcp.StartPosition = FormStartPosition.CenterScreen;
            fcp.Show();

        }
        private void ChamaContasPagar()
        {
            fContasPagar fcp = new fContasPagar();
            fcp.MdiParent = this;
            fcp.StartPosition = FormStartPosition.CenterScreen;
            fcp.Show();

        }

        private void ChamaEmpresa()
        {
            fEmpresa femp = new fEmpresa();
            femp.MdiParent = this;
            femp.StartPosition = FormStartPosition.CenterScreen;
            femp.Show();
        }

        private void ChamaCaixaAbertura()
        {
            if(LoginOperacao.ToUpper()=="ADMINISTRADOR" || LoginOperacao.ToUpper()=="GERENTE" || LoginOperacao.ToUpper()=="FINANCEIRO")
            {
                fCaixaGeral_Abertura fcga = new fCaixaGeral_Abertura();
                fcga.StartPosition = FormStartPosition.CenterScreen;
                fcga.ParametroID = LoginUsuario.ToString();
                fcga.ShowDialog();

            } else
            {
                MessageBox.Show("Permissão Negada !");

            }
            
        }

        private void ChamaCaixaMovimento()
        {
            if (LoginOperacao.ToUpper() == "ADMINISTRADOR" || LoginOperacao.ToUpper() == "GERENTE" || LoginOperacao.ToUpper() == "FINANCEIRO")
            {
                fCaixaGeral_Movimento fcgm = new fCaixaGeral_Movimento();
                fcgm.StartPosition = FormStartPosition.CenterScreen;
                //fcgm.ParametroID = LoginUsuario.ToString();
                fcgm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Permissão Negada !");

            }

        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChamaClientes();            
        }

        private void compradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fServicos ser = new fServicos();
            ser.MdiParent = this;
            ser.BackColor = Color.White;
            ser.StartPosition = FormStartPosition.CenterScreen;
            ser.Show();
        }

        private void transportadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTecnicos tec = new fTecnicos();
            tec.MdiParent = this;
            tec.StartPosition = FormStartPosition.CenterScreen;
            tec.Show();
        }

        private void ordemDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fOrdemServicos os = new fOrdemServicos();
            os.MdiParent = this;
            os.StartPosition = FormStartPosition.CenterScreen;
            os.Show();
        }

        private void centroDeCustosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCentroCustos cc = new fCentroCustos();
            cc.MdiParent = this;
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.Show();
        }

        private void ChamaOrcamento()
        {
            fOrcamento fo = new fOrcamento();
            fo.MdiParent = this;
            fo.StartPosition = FormStartPosition.CenterScreen;
            fo.Show();

        }
        private void ChamaPedidos()
        {
            fPedido fp = new fPedido();
            fp.MdiParent = this;
            fp.StartPosition = FormStartPosition.CenterScreen;
            fp.Show();

        }
        private void ChamaFormasPagamento()
        {
            fFormasPagamento fp = new fFormasPagamento();
            fp.MdiParent = this;
            fp.StartPosition = FormStartPosition.CenterScreen;
            fp.Show();

        }

        private void ChamaEntrada()
        {
            fEntradas ent = new fEntradas();
            ent.MdiParent = this;
            ent.StartPosition = FormStartPosition.CenterScreen;
            ent.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaContasReceber();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaFornecedores();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChamaFornecedores();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ChamaContasPagar();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaCentroVendas();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ChamaContasReceber();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaContasPagar();
        }

        private void dadosDaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaEmpresa();
        }

        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChamaUsuarios();
        }

        private void aberturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaCaixaAbertura();
        }

        private void fMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.U && e.Control)
            {
                fMenu_Load("", e);
            }

            if (e.KeyCode == Keys.X && e.Control)
            {
                DialogResult xsim = MessageBox.Show("Deseja mesmo Sair ?", "Atenção", MessageBoxButtons.YesNo);
                if(xsim == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }


        }

        private void movimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaCaixaMovimento();
        }

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaOrcamento();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaPedidos();
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaFormasPagamento();
        }

        private void entradaDeMercadoriaComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaEntrada();
        }
    }

}
