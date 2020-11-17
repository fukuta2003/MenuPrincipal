namespace Sistema
{
    partial class fContasReceber
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
            this.lblTotalDocumento = new System.Windows.Forms.Label();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtEmissao = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCentroVendas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorBruto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCentroVendas = new System.Windows.Forms.MaskedTextBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.imgPago = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPago)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalDocumento
            // 
            this.lblTotalDocumento.BackColor = System.Drawing.Color.Bisque;
            this.lblTotalDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDocumento.Location = new System.Drawing.Point(327, 190);
            this.lblTotalDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDocumento.Name = "lblTotalDocumento";
            this.lblTotalDocumento.Size = new System.Drawing.Size(100, 20);
            this.lblTotalDocumento.TabIndex = 70;
            this.lblTotalDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.BackColor = System.Drawing.Color.Bisque;
            this.lblDataPagamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPagamento.Location = new System.Drawing.Point(327, 138);
            this.lblDataPagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(100, 20);
            this.lblDataPagamento.TabIndex = 69;
            this.lblDataPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(127, 30);
            this.txtData.Margin = new System.Windows.Forms.Padding(2);
            this.txtData.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(116, 20);
            this.txtData.TabIndex = 68;
            // 
            // txtVencimento
            // 
            this.txtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVencimento.Location = new System.Drawing.Point(163, 138);
            this.txtVencimento.Margin = new System.Windows.Forms.Padding(2);
            this.txtVencimento.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(119, 20);
            this.txtVencimento.TabIndex = 4;
            // 
            // txtEmissao
            // 
            this.txtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEmissao.Location = new System.Drawing.Point(9, 138);
            this.txtEmissao.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmissao.MaxDate = new System.DateTime(2020, 6, 30, 0, 0, 0, 0);
            this.txtEmissao.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtEmissao.Name = "txtEmissao";
            this.txtEmissao.Size = new System.Drawing.Size(113, 20);
            this.txtEmissao.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(157, 427);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(271, 13);
            this.label13.TabIndex = 67;
            this.label13.Text = "* CAMPO IMPORTANTE - NÃO PODE HAVER NULOS";
            // 
            // btnBaixar
            // 
            this.btnBaixar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBaixar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBaixar.Enabled = false;
            this.btnBaixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixar.ForeColor = System.Drawing.Color.White;
            this.btnBaixar.Location = new System.Drawing.Point(335, 368);
            this.btnBaixar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(85, 54);
            this.btnBaixar.TabIndex = 12;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = false;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(10, 296);
            this.txtHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(411, 59);
            this.txtHistorico.TabIndex = 9;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.YellowGreen;
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(102, 368);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 54);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Teal;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(11, 368);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 54);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(7, 275);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 64;
            this.label15.Text = "Histórico *";
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCliente.Location = new System.Drawing.Point(191, 86);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(237, 20);
            this.lblCliente.TabIndex = 63;
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCentroVendas
            // 
            this.lblCentroVendas.BackColor = System.Drawing.SystemColors.Info;
            this.lblCentroVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCentroVendas.Location = new System.Drawing.Point(85, 244);
            this.lblCentroVendas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCentroVendas.Name = "lblCentroVendas";
            this.lblCentroVendas.Size = new System.Drawing.Size(335, 21);
            this.lblCentroVendas.TabIndex = 62;
            this.lblCentroVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 228);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "F2 - Lista Centro de Vendas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(324, 172);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Valor Documento *";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(226, 191);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(82, 20);
            this.txtDesconto.TabIndex = 7;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(223, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Desconto";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(127, 191);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(2);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(80, 20);
            this.txtJuros.TabIndex = 6;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
            this.txtJuros.Leave += new System.EventHandler(this.txtJuros_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(125, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Juros";
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.Location = new System.Drawing.Point(9, 191);
            this.txtValorBruto.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.Size = new System.Drawing.Size(87, 20);
            this.txtValorBruto.TabIndex = 5;
            this.txtValorBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorBruto_KeyPress);
            this.txtValorBruto.Leave += new System.EventHandler(this.txtValorBruto_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Valor Bruto *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(324, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Data Pagamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(160, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Data Vencimento *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Data Emissão *";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(127, 87);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(60, 20);
            this.txtCliente.TabIndex = 2;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Clientes (F2 - Lista Clientes)";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(9, 87);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(113, 20);
            this.txtDocumento.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Documento * (F2)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Data *";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(9, 33);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(72, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged_1);
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID (F2-Extrato)";
            // 
            // txtCentroVendas
            // 
            this.txtCentroVendas.Location = new System.Drawing.Point(9, 244);
            this.txtCentroVendas.Mask = "aaa,aaa";
            this.txtCentroVendas.Name = "txtCentroVendas";
            this.txtCentroVendas.Size = new System.Drawing.Size(70, 20);
            this.txtCentroVendas.TabIndex = 8;
            this.txtCentroVendas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCentroVendas_KeyDown);
            this.txtCentroVendas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCentroVendas_KeyPress);
            this.txtCentroVendas.Leave += new System.EventHandler(this.txtCentroVendas_Leave);
            // 
            // btnFechar
            // 
        //    this.btnFechar.BackgroundImage = global::SistemaPadrao.Properties.Resources.icone_close;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(400, -2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(28, 32);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 72;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // imgPago
            // 
          //  this.imgPago.BackgroundImage = global::SistemaPadrao.Properties.Resources.pago;
            this.imgPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPago.Location = new System.Drawing.Point(284, 17);
            this.imgPago.Name = "imgPago";
            this.imgPago.Size = new System.Drawing.Size(43, 39);
            this.imgPago.TabIndex = 71;
            this.imgPago.TabStop = false;
            this.imgPago.Visible = false;
            // 
            // fContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(431, 448);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.imgPago);
            this.Controls.Add(this.txtCentroVendas);
            this.Controls.Add(this.lblTotalDocumento);
            this.Controls.Add(this.lblDataPagamento);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.txtEmissao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCentroVendas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValorBruto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "fContasReceber";
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.fContasReceber_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fContasReceber_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fContasReceber_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalDocumento;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.DateTimePicker txtVencimento;
        private System.Windows.Forms.DateTimePicker txtEmissao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCentroVendas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorBruto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCentroVendas;
        private System.Windows.Forms.PictureBox imgPago;
        private System.Windows.Forms.PictureBox btnFechar;
    }
}