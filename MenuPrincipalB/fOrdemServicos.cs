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
    public partial class fOrdemServicos : Form
    {
        CrudOrdemServicos Os = new CrudOrdemServicos();

        public fOrdemServicos()
        {
            InitializeComponent();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            gpoCadastro.Visible = true;
        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fOrdemServicos_Load(object sender, EventArgs e)
        {
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCliente.AutoCompleteMode = AutoCompleteMode.Append;
            cmbCliente.KeyPress += new KeyPressEventHandler(cmbCliente_KeyPress);

            DataTable dtable = Os.MontaComboClientes();
            for(int i=0; i < dtable.Rows.Count; i++)
            {
                cmbCliente.Items.Add(dtable.Rows[i][1].ToString());
            }

            cmbCliente.ValueMember = ("Id");

        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbCliente.DroppedDown = true;
        }

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
            // MessageBox.Show(cmbCliente.SelectedValue.ToString());
        }

        private void txtClienteId_Leave(object sender, EventArgs e)
        {
            int x = int.Parse(txtClienteId.Text);
            cmbCliente.Text = Os.BuscaClienteId(x);
            
        }
    }
}
