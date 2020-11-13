namespace Sistema.Models
{
    partial class fPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblInfo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.txtTaxaEntrega = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescontoPorc = new System.Windows.Forms.TextBox();
            this.txtDescontoReal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalBruto = new System.Windows.Forms.TextBox();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GrdPro = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalLiquido = new System.Windows.Forms.TextBox();
            this.gpoDados = new System.Windows.Forms.GroupBox();
            this.btnFaturar = new System.Windows.Forms.Button();
            this.lblFaturado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpoDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unidade";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quant";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total - R$";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 120;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Red;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(735, 286);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(192, 22);
            this.lblInfo.TabIndex = 34;
            this.lblInfo.Text = "Excluir Produtos = Tecla Del";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Entrega";
            // 
            // lblEntrega
            // 
            this.lblEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEntrega.Location = new System.Drawing.Point(78, 413);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(212, 22);
            this.lblEntrega.TabIndex = 32;
            // 
            // txtEntrega
            // 
            this.txtEntrega.Location = new System.Drawing.Point(12, 413);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(60, 20);
            this.txtEntrega.TabIndex = 11;
            this.txtEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEntrega.Enter += new System.EventHandler(this.txtEntrega_Enter);
            this.txtEntrega.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntrega_KeyDown);
            this.txtEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntrega_KeyPress);
            this.txtEntrega.Leave += new System.EventHandler(this.txtEntrega_Leave);
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFormaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormaPagamento.Location = new System.Drawing.Point(78, 316);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(212, 22);
            this.lblFormaPagamento.TabIndex = 30;
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Location = new System.Drawing.Point(12, 316);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(60, 20);
            this.txtFormaPagamento.TabIndex = 8;
            this.txtFormaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFormaPagamento.Enter += new System.EventHandler(this.txtFormaPagamento_Enter);
            this.txtFormaPagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFormaPagamento_KeyDown);
            this.txtFormaPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFormaPagamento_KeyPress);
            this.txtFormaPagamento.Leave += new System.EventHandler(this.txtFormaPagamento_Leave);
            // 
            // txtEditor
            // 
            this.txtEditor.BackColor = System.Drawing.Color.Yellow;
            this.txtEditor.Location = new System.Drawing.Point(9, 159);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(63, 20);
            this.txtEditor.TabIndex = 7;
            this.txtEditor.Visible = false;
            this.txtEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEditor_KeyDown);
            this.txtEditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditor_KeyPress);
            // 
            // txtTaxaEntrega
            // 
            this.txtTaxaEntrega.Location = new System.Drawing.Point(131, 443);
            this.txtTaxaEntrega.Name = "txtTaxaEntrega";
            this.txtTaxaEntrega.Size = new System.Drawing.Size(159, 20);
            this.txtTaxaEntrega.TabIndex = 12;
            this.txtTaxaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxaEntrega.Enter += new System.EventHandler(this.txtTaxaEntrega_Enter);
            this.txtTaxaEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxaEntrega_KeyPress);
            this.txtTaxaEntrega.Leave += new System.EventHandler(this.txtTaxaEntrega_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 449);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Taxa Entrega";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(716, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 80);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Navy;
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(591, 385);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(86, 80);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(301, 316);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(271, 149);
            this.txtObservacoes.TabIndex = 13;
            this.txtObservacoes.Enter += new System.EventHandler(this.txtObservacoes_Enter);
            this.txtObservacoes.Leave += new System.EventHandler(this.txtObservacoes_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Observações Finais";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "%";
            // 
            // txtDescontoPorc
            // 
            this.txtDescontoPorc.Location = new System.Drawing.Point(131, 378);
            this.txtDescontoPorc.Name = "txtDescontoPorc";
            this.txtDescontoPorc.Size = new System.Drawing.Size(48, 20);
            this.txtDescontoPorc.TabIndex = 10;
            this.txtDescontoPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescontoPorc.Enter += new System.EventHandler(this.txtDescontoPorc_Enter);
            this.txtDescontoPorc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontoPorc_KeyPress);
            this.txtDescontoPorc.Leave += new System.EventHandler(this.txtDescontoPorc_Leave);
            // 
            // txtDescontoReal
            // 
            this.txtDescontoReal.Enabled = false;
            this.txtDescontoReal.Location = new System.Drawing.Point(185, 378);
            this.txtDescontoReal.Name = "txtDescontoReal";
            this.txtDescontoReal.Size = new System.Drawing.Size(105, 20);
            this.txtDescontoReal.TabIndex = 15;
            this.txtDescontoReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Desconto";
            // 
            // txtTotalBruto
            // 
            this.txtTotalBruto.Enabled = false;
            this.txtTotalBruto.Location = new System.Drawing.Point(131, 345);
            this.txtTotalBruto.Name = "txtTotalBruto";
            this.txtTotalBruto.Size = new System.Drawing.Size(159, 20);
            this.txtTotalBruto.TabIndex = 9;
            this.txtTotalBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Observação";
            this.columnHeader7.Width = 160;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Navy;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(22, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Total Líquido- R$";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unitário R$";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "F2 - Cadastrados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Bruto - R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Pedido Nº";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Forma de Pagamento";
            // 
            // GrdPro
            // 
            this.GrdPro.AutoArrange = false;
            this.GrdPro.BackColor = System.Drawing.Color.SteelBlue;
            this.GrdPro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.GrdPro.FullRowSelect = true;
            this.GrdPro.GridLines = true;
            this.GrdPro.HideSelection = false;
            this.GrdPro.Location = new System.Drawing.Point(9, 75);
            this.GrdPro.MultiSelect = false;
            this.GrdPro.Name = "GrdPro";
            this.GrdPro.ShowGroups = false;
            this.GrdPro.Size = new System.Drawing.Size(918, 208);
            this.GrdPro.TabIndex = 6;
            this.GrdPro.UseCompatibleStateImageBehavior = false;
            this.GrdPro.View = System.Windows.Forms.View.Details;
            this.GrdPro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrdPro_KeyDown);
            this.GrdPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GrdPro_KeyPress);
            this.GrdPro.MouseLeave += new System.EventHandler(this.GrdPro_MouseLeave);
            this.GrdPro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GrdPro_MouseMove);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição do Produto";
            this.columnHeader2.Width = 350;
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(15, 42);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(89, 20);
            this.txtPedido.TabIndex = 0;
            this.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPedido.TextChanged += new System.EventHandler(this.txtPedido_TextChanged);
            this.txtPedido.Enter += new System.EventHandler(this.txtPedido_Enter);
            this.txtPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPedido_KeyDown);
            this.txtPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPedido_KeyPress);
            this.txtPedido.Leave += new System.EventHandler(this.txtPedido_Leave);
            // 
            // lblVendedor
            // 
            this.lblVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblVendedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVendedor.Location = new System.Drawing.Point(636, 47);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(291, 22);
            this.lblVendedor.TabIndex = 7;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(563, 47);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(67, 20);
            this.txtVendedor.TabIndex = 4;
            this.txtVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVendedor.Enter += new System.EventHandler(this.txtVendedor_Enter);
            this.txtVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendedor_KeyDown);
            this.txtVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendedor_KeyPress);
            this.txtVendedor.Leave += new System.EventHandler(this.txtVendedor_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vendedor - F2 - Cadastrados";
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCliente.Location = new System.Drawing.Point(204, 47);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(352, 22);
            this.lblCliente.TabIndex = 4;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(131, 47);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(67, 20);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCliente.Enter += new System.EventHandler(this.txtCliente_Enter);
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente - F2 - Cadastrados";
            // 
            // txtData
            // 
            this.txtData.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(9, 47);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(106, 20);
            this.txtData.TabIndex = 2;
            this.txtData.ValueChanged += new System.EventHandler(this.txtData_ValueChanged);
            this.txtData.Enter += new System.EventHandler(this.txtData_Enter);
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtData_KeyPress);
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtTotalLiquido);
            this.panel1.Location = new System.Drawing.Point(591, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 52);
            this.panel1.TabIndex = 27;
            // 
            // txtTotalLiquido
            // 
            this.txtTotalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLiquido.Location = new System.Drawing.Point(160, 11);
            this.txtTotalLiquido.Name = "txtTotalLiquido";
            this.txtTotalLiquido.Size = new System.Drawing.Size(156, 31);
            this.txtTotalLiquido.TabIndex = 17;
            this.txtTotalLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gpoDados
            // 
            this.gpoDados.Controls.Add(this.btnFaturar);
            this.gpoDados.Controls.Add(this.lblInfo);
            this.gpoDados.Controls.Add(this.label12);
            this.gpoDados.Controls.Add(this.lblEntrega);
            this.gpoDados.Controls.Add(this.txtEntrega);
            this.gpoDados.Controls.Add(this.lblFormaPagamento);
            this.gpoDados.Controls.Add(this.txtFormaPagamento);
            this.gpoDados.Controls.Add(this.txtEditor);
            this.gpoDados.Controls.Add(this.txtTaxaEntrega);
            this.gpoDados.Controls.Add(this.label14);
            this.gpoDados.Controls.Add(this.btnCancelar);
            this.gpoDados.Controls.Add(this.btnGravar);
            this.gpoDados.Controls.Add(this.txtObservacoes);
            this.gpoDados.Controls.Add(this.label11);
            this.gpoDados.Controls.Add(this.label10);
            this.gpoDados.Controls.Add(this.txtDescontoPorc);
            this.gpoDados.Controls.Add(this.txtDescontoReal);
            this.gpoDados.Controls.Add(this.label9);
            this.gpoDados.Controls.Add(this.txtTotalBruto);
            this.gpoDados.Controls.Add(this.label8);
            this.gpoDados.Controls.Add(this.label7);
            this.gpoDados.Controls.Add(this.GrdPro);
            this.gpoDados.Controls.Add(this.lblVendedor);
            this.gpoDados.Controls.Add(this.txtVendedor);
            this.gpoDados.Controls.Add(this.label6);
            this.gpoDados.Controls.Add(this.lblCliente);
            this.gpoDados.Controls.Add(this.txtCliente);
            this.gpoDados.Controls.Add(this.label3);
            this.gpoDados.Controls.Add(this.txtData);
            this.gpoDados.Controls.Add(this.label2);
            this.gpoDados.Controls.Add(this.panel1);
            this.gpoDados.Enabled = false;
            this.gpoDados.Location = new System.Drawing.Point(15, 70);
            this.gpoDados.Name = "gpoDados";
            this.gpoDados.Size = new System.Drawing.Size(933, 471);
            this.gpoDados.TabIndex = 1;
            this.gpoDados.TabStop = false;
            this.gpoDados.Text = "Dados do Pedido";
            // 
            // btnFaturar
            // 
            this.btnFaturar.BackColor = System.Drawing.Color.Red;
            this.btnFaturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturar.ForeColor = System.Drawing.Color.White;
            this.btnFaturar.Location = new System.Drawing.Point(841, 385);
            this.btnFaturar.Name = "btnFaturar";
            this.btnFaturar.Size = new System.Drawing.Size(86, 80);
            this.btnFaturar.TabIndex = 35;
            this.btnFaturar.Text = "Faturar";
            this.btnFaturar.UseVisualStyleBackColor = false;
            this.btnFaturar.Click += new System.EventHandler(this.btnFaturar_Click);
            // 
            // lblFaturado
            // 
            this.lblFaturado.BackColor = System.Drawing.Color.Red;
            this.lblFaturado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFaturado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFaturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturado.ForeColor = System.Drawing.Color.White;
            this.lblFaturado.Location = new System.Drawing.Point(747, 23);
            this.lblFaturado.Name = "lblFaturado";
            this.lblFaturado.Size = new System.Drawing.Size(195, 33);
            this.lblFaturado.TabIndex = 40;
            this.lblFaturado.Text = "F A T U R A D O";
            this.lblFaturado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFaturado.Visible = false;
            // 
            // fPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 551);
            this.Controls.Add(this.lblFaturado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.gpoDados);
            this.KeyPreview = true;
            this.Name = "fPedido";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.fPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fPedido_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fPedido_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpoDados.ResumeLayout(false);
            this.gpoDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.TextBox txtEntrega;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.TextBox txtTaxaEntrega;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescontoPorc;
        private System.Windows.Forms.TextBox txtDescontoReal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalBruto;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView GrdPro;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalLiquido;
        private System.Windows.Forms.GroupBox gpoDados;
        private System.Windows.Forms.Button btnFaturar;
        private System.Windows.Forms.Label lblFaturado;
    }
}