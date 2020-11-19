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
using System.Data.SqlClient;

namespace Sistema
{
    public partial class fLogin : Form
    {

        CLogin cl = new CLogin();

        public String ParametroID
        {
            get { return txtUsuario.Text; }
        }

        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            /*
            TextBox txtNome = new TextBox();
            txtNome.MaxLength = 50;
            txtNome.Location = new Point(187, 51);
            this.Controls.Add(txtNome);
            txtNome.Visible = true;
            */

            if (!cl.Abre_BancoDados())
            {
                MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
                Application.Exit();
            } else
            {
                cl.conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cl.Login = "EXIT";
            cl.Password = "EXIT";
            txtUsuario.Text = cl.Login;
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {

            cl.Login = txtUsuario.Text;
            cl.Password = txtSenha.Text;
            if(cl.Consulta_Login())
            {
               
                this.Close();
                
            } else
            {
                MessageBox.Show("Usuário ou Senha Inválidos");
                txtUsuario.Focus();
            }
            cl.conn.Close();
           
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;  // tira o beep do windows
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;  // tira o beep do windows
                cmdLogin.Focus();
            }
        }
    }
}
