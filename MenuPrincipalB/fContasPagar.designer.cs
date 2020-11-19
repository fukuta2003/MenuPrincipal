namespace Sistema
{
    partial class fContasPagar
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorBruto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCentrodeCustos = new System.Windows.Forms.TextBox();
            this.lblCentrodeCustos = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmbFornecedores = new System.Windows.Forms.ComboBox();
            this.cmbCentroCustos = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.lblTotalDocumento = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imgPago = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPago)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID (F2-Extrato)";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(14, 31);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(64, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento * (F2)";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(14, 85);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(113, 20);
            this.txtDocumento.TabIndex = 3;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocumento_KeyDown);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            this.txtDocumento.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fornecedor * (F2-Combo)";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(132, 85);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(60, 20);
            this.txtFornecedor.TabIndex = 4;
            this.txtFornecedor.Click += new System.EventHandler(this.txtFornecedor_Click);
            this.txtFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFornecedor_KeyDown);
            this.txtFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFornecedor_KeyPress);
            this.txtFornecedor.Leave += new System.EventHandler(this.txtFornecedor_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data Emissão *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data Vencimento *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data Pagamento";
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.Location = new System.Drawing.Point(14, 189);
            this.txtValorBruto.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.Size = new System.Drawing.Size(87, 20);
            this.txtValorBruto.TabIndex = 8;
            this.txtValorBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorBruto.TextChanged += new System.EventHandler(this.txtValorBruto_TextChanged);
            this.txtValorBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorBruto_KeyPress);
            this.txtValorBruto.Leave += new System.EventHandler(this.txtValorBruto_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Valor Bruto *";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(132, 189);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(2);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(80, 20);
            this.txtJuros.TabIndex = 9;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJuros.TextChanged += new System.EventHandler(this.txtJuros_TextChanged);
            this.txtJuros.Leave += new System.EventHandler(this.txtJuros_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Juros";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(231, 189);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(82, 20);
            this.txtDesconto.TabIndex = 10;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Desconto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 170);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Valor Documento *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 226);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Centro de Custos * (F2-Combo)";
            // 
            // txtCentrodeCustos
            // 
            this.txtCentrodeCustos.Location = new System.Drawing.Point(14, 242);
            this.txtCentrodeCustos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCentrodeCustos.Name = "txtCentrodeCustos";
            this.txtCentrodeCustos.Size = new System.Drawing.Size(72, 20);
            this.txtCentrodeCustos.TabIndex = 11;
            this.txtCentrodeCustos.Click += new System.EventHandler(this.txtCentrodeCustos_Click);
            this.txtCentrodeCustos.TextChanged += new System.EventHandler(this.txtCentrodeCustos_TextChanged);
            this.txtCentrodeCustos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCentrodeCustos_KeyDown);
            this.txtCentrodeCustos.Leave += new System.EventHandler(this.txtCentrodeCustos_Leave);
            // 
            // lblCentrodeCustos
            // 
            this.lblCentrodeCustos.BackColor = System.Drawing.SystemColors.Info;
            this.lblCentrodeCustos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCentrodeCustos.Location = new System.Drawing.Point(133, 242);
            this.lblCentrodeCustos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCentrodeCustos.Name = "lblCentrodeCustos";
            this.lblCentrodeCustos.Size = new System.Drawing.Size(292, 21);
            this.lblCentrodeCustos.TabIndex = 24;
            this.lblCentrodeCustos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFornecedor.Location = new System.Drawing.Point(239, 84);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(194, 20);
            this.lblFornecedor.TabIndex = 25;
            this.lblFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 273);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Histórico *";
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(16, 366);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 35);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(107, 366);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 35);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(15, 294);
            this.txtHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(411, 59);
            this.txtHistorico.TabIndex = 13;
            this.txtHistorico.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // btnBaixar
            // 
            this.btnBaixar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBaixar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBaixar.Enabled = false;
            this.btnBaixar.Location = new System.Drawing.Point(340, 366);
            this.btnBaixar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(85, 35);
            this.btnBaixar.TabIndex = 16;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = false;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // cmbFornecedores
            // 
            this.cmbFornecedores.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.cmbFornecedores.ForeColor = System.Drawing.Color.White;
            this.cmbFornecedores.FormattingEnabled = true;
            this.cmbFornecedores.Location = new System.Drawing.Point(239, 85);
            this.cmbFornecedores.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFornecedores.Name = "cmbFornecedores";
            this.cmbFornecedores.Size = new System.Drawing.Size(195, 21);
            this.cmbFornecedores.TabIndex = 28;
            this.cmbFornecedores.Visible = false;
            this.cmbFornecedores.SelectedIndexChanged += new System.EventHandler(this.cmbFornecedores_SelectedIndexChanged);
            this.cmbFornecedores.TextChanged += new System.EventHandler(this.cmbFornecedores_TextChanged);
            // 
            // cmbCentroCustos
            // 
            this.cmbCentroCustos.BackColor = System.Drawing.Color.Khaki;
            this.cmbCentroCustos.FormattingEnabled = true;
            this.cmbCentroCustos.Location = new System.Drawing.Point(133, 241);
            this.cmbCentroCustos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCentroCustos.Name = "cmbCentroCustos";
            this.cmbCentroCustos.Size = new System.Drawing.Size(295, 21);
            this.cmbCentroCustos.TabIndex = 12;
            this.cmbCentroCustos.Visible = false;
            this.cmbCentroCustos.SelectedIndexChanged += new System.EventHandler(this.cmbCentroCustos_SelectedIndexChanged);
            this.cmbCentroCustos.TextChanged += new System.EventHandler(this.cmbCentroCustos_TextChanged);
            this.cmbCentroCustos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCentroCustos_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 425);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(271, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "* CAMPO IMPORTANTE - NÃO PODE HAVER NULOS";
            // 
            // txtEmissao
            // 
            this.txtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEmissao.Location = new System.Drawing.Point(14, 136);
            this.txtEmissao.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmissao.MaxDate = new System.DateTime(2020, 6, 30, 0, 0, 0, 0);
            this.txtEmissao.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtEmissao.Name = "txtEmissao";
            this.txtEmissao.Size = new System.Drawing.Size(113, 20);
            this.txtEmissao.TabIndex = 6;
            // 
            // txtVencimento
            // 
            this.txtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVencimento.Location = new System.Drawing.Point(168, 136);
            this.txtVencimento.Margin = new System.Windows.Forms.Padding(2);
            this.txtVencimento.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(119, 20);
            this.txtVencimento.TabIndex = 7;
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(312, 29);
            this.txtData.Margin = new System.Windows.Forms.Padding(2);
            this.txtData.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(116, 20);
            this.txtData.TabIndex = 31;
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.BackColor = System.Drawing.Color.Bisque;
            this.lblDataPagamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataPagamento.Location = new System.Drawing.Point(332, 136);
            this.lblDataPagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(100, 20);
            this.lblDataPagamento.TabIndex = 32;
            // 
            // lblTotalDocumento
            // 
            this.lblTotalDocumento.BackColor = System.Drawing.Color.Bisque;
            this.lblTotalDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDocumento.Location = new System.Drawing.Point(332, 188);
            this.lblTotalDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDocumento.Name = "lblTotalDocumento";
            this.lblTotalDocumento.Size = new System.Drawing.Size(100, 20);
            this.lblTotalDocumento.TabIndex = 33;
            this.lblTotalDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(197, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 22);
            this.button2.TabIndex = 34;
            this.button2.Text = "...";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(90, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 22);
            this.button3.TabIndex = 35;
            this.button3.Text = "...";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imgPago
            // 
           // this.imgPago.BackgroundImage = global::SistemaPadrao.Properties.Resources.pago;
            this.imgPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPago.Location = new System.Drawing.Point(182, 12);
            this.imgPago.Name = "imgPago";
            this.imgPago.Size = new System.Drawing.Size(43, 39);
            this.imgPago.TabIndex = 72;
            this.imgPago.TabStop = false;
            this.imgPago.Visible = false;
            // 
            // fContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 447);
            this.Controls.Add(this.imgPago);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTotalDocumento);
            this.Controls.Add(this.lblDataPagamento);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.txtEmissao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbCentroCustos);
            this.Controls.Add(this.cmbFornecedores);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblCentrodeCustos);
            this.Controls.Add(this.txtCentrodeCustos);
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
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar";
            this.Activated += new System.EventHandler(this.fContasPagar_Activated);
            this.Load += new System.EventHandler(this.fContasPagar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fContasPagar_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fContasPagar_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.imgPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorBruto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCentrodeCustos;
        private System.Windows.Forms.Label lblCentrodeCustos;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox cmbFornecedores;
        private System.Windows.Forms.ComboBox cmbCentroCustos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker txtEmissao;
        private System.Windows.Forms.DateTimePicker txtVencimento;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.Label lblTotalDocumento;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox imgPago;
    }
}