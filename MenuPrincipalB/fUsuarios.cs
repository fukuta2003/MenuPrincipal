using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Sistema.Models;

namespace Sistema
{
    public partial class fUsuarios : Form
    {

        Usuarios usr = new Usuarios();
        Validacao Funcoes = new Validacao();
        bool wp_Incluir = true;

        public fUsuarios()
        {
            InitializeComponent();
        }

        private void fUsuarios_Load(object sender, EventArgs e)
        {
            usr.Inicializa();
            
            cmbOperacao.Items.AddRange(usr.Operacoes.ToArray());
            
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {

                fShow fsw = new fShow("TABELA_LOGIN",
                    new string[] { "Id", "Nome", "Login"}, "Id");
                fsw.ShowDialog();
                txtID.Text = fsw.ParametroID.ToString();
                if (txtID.Text != "")
                {
                    SendKeys.SendWait("{TAB}");
                }

            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.SendWait("{TAB}");
                e.Handled = true;
            }
        }

        private void fUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {

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

        private void txtID_Leave(object sender, EventArgs e)
        {
            

            if(txtID.Text=="") {
                wp_Incluir = true;
                lblOP.Text = "INCLUIR";
                cmbOperacao.SelectedIndex = 1;
                txtNome.Focus();
            } else
            {
                wp_Incluir = false;
                lblOP.Text = "ALTERAR";
                if (usr.Consulta(int.Parse(txtID.Text))){

                    BuscaDados();


                } else
                {
                    MessageBox.Show("Usuário não encontrado !");
                    txtID.Focus();
                }

            }
        }


        private void BuscaDados()
        {
            txtNome.Text = usr.Nome.ToString();
            txtLogin.Text = usr.Login.ToString();
            txtSenha.Text = usr.Senha.ToString();
            txtSenhaRepete.Text = "";
            cmbOperacao.Text = usr.Operacao.ToString();
            if(usr.Ativo=="S")
            {
                chkAtivo.Checked = true;
            } else
            {
                chkAtivo.Checked = false;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaSenha())
            {
                MessageBox.Show("As senhas não conferem !");
                txtSenha.Focus();
                return;
            }
           DialogResult x = Funcoes.Confirma("Posso salvar os dados ?", "Atenção");
           if(x == DialogResult.Yes)
            {
                DadosparaClasse();
                if(usr.Salva(wp_Incluir))
                {
                    MessageBox.Show("Dados Salvos com Sucesso !");
                    txtID.Focus();
                } else
                {
                    MessageBox.Show("Erro, os dados não foram salvos !");
                    txtNome.Focus();
                }
            }
        }

        private void DadosparaClasse()
        {
            usr.Nome = txtNome.Text;
            usr.Login = txtLogin.Text;
            usr.Senha = txtSenha.Text;
            usr.Operacao = cmbOperacao.Text;
            if(chkAtivo.Checked==true)
            {
                usr.Ativo = "S";
            }
            else
            {
                usr.Ativo = "F";
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            LimpaCaixasTexto();

        }

        private void LimpaCaixasTexto()
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtSenhaRepete.Text = "";
            chkAtivo.Checked = true;
            cmbOperacao.SelectedIndex = 1;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private bool ValidaSenha()
        {
            bool xret = true;

              if(txtSenha.Text != txtSenhaRepete.Text)
                {
                     xret = false;
                }
                else
                {
                xret = true;
                }

            return xret;
        }

        private void txtSenhaRepete_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void fUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.SendWait("{TAB}");
                e.Handled = true;
            }
        }


        // -------------------- fim da classse
    }

}

