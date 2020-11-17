namespace Sistema
{
    partial class fContasReceber_Show
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDocumento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClienteNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBaixa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCcusto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValorDocumento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.optEmissao = new System.Windows.Forms.RadioButton();
            this.optVencimento = new System.Windows.Forms.RadioButton();
            this.optPagamento = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMesInteiro = new System.Windows.Forms.CheckBox();
            this.txtAte = new System.Windows.Forms.DateTimePicker();
            this.txtDe = new System.Windows.Forms.DateTimePicker();
            this.lblTotalDocumentos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCentroCustos = new System.Windows.Forms.MaskedTextBox();
            this.lblCentroCusto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalAberto = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colDocumento,
            this.colCliente,
            this.colClienteNome,
            this.colEmissao,
            this.colVencimento,
            this.colBaixa,
            this.colCcusto,
            this.colValorDocumento,
            this.colPG});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 89);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1019, 250);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colDocumento
            // 
            this.colDocumento.Text = "Documento";
            this.colDocumento.Width = 100;
            // 
            // colCliente
            // 
            this.colCliente.Text = "Cliente";
            this.colCliente.Width = 70;
            // 
            // colClienteNome
            // 
            this.colClienteNome.Text = "Nome do Cliente";
            this.colClienteNome.Width = 300;
            // 
            // colEmissao
            // 
            this.colEmissao.Text = "Emissão";
            this.colEmissao.Width = 80;
            // 
            // colVencimento
            // 
            this.colVencimento.Text = "Vencimento";
            this.colVencimento.Width = 80;
            // 
            // colBaixa
            // 
            this.colBaixa.Text = "Baixa";
            this.colBaixa.Width = 80;
            // 
            // colCcusto
            // 
            this.colCcusto.Text = "C.Custo";
            this.colCcusto.Width = 70;
            // 
            // colValorDocumento
            // 
            this.colValorDocumento.Text = "Valor Documento";
            this.colValorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colValorDocumento.Width = 100;
            // 
            // colPG
            // 
            this.colPG.Text = "Pago";
            this.colPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // optEmissao
            // 
            this.optEmissao.AutoSize = true;
            this.optEmissao.Location = new System.Drawing.Point(12, 12);
            this.optEmissao.Name = "optEmissao";
            this.optEmissao.Size = new System.Drawing.Size(64, 17);
            this.optEmissao.TabIndex = 1;
            this.optEmissao.Text = "Emissão";
            this.optEmissao.UseVisualStyleBackColor = true;
            // 
            // optVencimento
            // 
            this.optVencimento.AutoSize = true;
            this.optVencimento.Checked = true;
            this.optVencimento.Location = new System.Drawing.Point(12, 35);
            this.optVencimento.Name = "optVencimento";
            this.optVencimento.Size = new System.Drawing.Size(81, 17);
            this.optVencimento.TabIndex = 2;
            this.optVencimento.TabStop = true;
            this.optVencimento.Text = "Vencimento";
            this.optVencimento.UseVisualStyleBackColor = true;
            // 
            // optPagamento
            // 
            this.optPagamento.AutoSize = true;
            this.optPagamento.Location = new System.Drawing.Point(12, 58);
            this.optPagamento.Name = "optPagamento";
            this.optPagamento.Size = new System.Drawing.Size(79, 17);
            this.optPagamento.TabIndex = 3;
            this.optPagamento.Text = "Pagamento";
            this.optPagamento.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMesInteiro);
            this.groupBox1.Controls.Add(this.txtAte);
            this.groupBox1.Controls.Add(this.txtDe);
            this.groupBox1.Location = new System.Drawing.Point(99, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Intervalo";
            // 
            // chkMesInteiro
            // 
            this.chkMesInteiro.AutoSize = true;
            this.chkMesInteiro.Location = new System.Drawing.Point(6, 49);
            this.chkMesInteiro.Name = "chkMesInteiro";
            this.chkMesInteiro.Size = new System.Drawing.Size(78, 17);
            this.chkMesInteiro.TabIndex = 2;
            this.chkMesInteiro.Text = "Mês Inteiro";
            this.chkMesInteiro.UseVisualStyleBackColor = true;
            this.chkMesInteiro.CheckedChanged += new System.EventHandler(this.chkMesInteiro_CheckedChanged);
            this.chkMesInteiro.Click += new System.EventHandler(this.chkMesInteiro_Click);
            // 
            // txtAte
            // 
            this.txtAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtAte.Location = new System.Drawing.Point(131, 23);
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(107, 22);
            this.txtAte.TabIndex = 1;
            // 
            // txtDe
            // 
            this.txtDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDe.Location = new System.Drawing.Point(6, 23);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(107, 22);
            this.txtDe.TabIndex = 0;
            // 
            // lblTotalDocumentos
            // 
            this.lblTotalDocumentos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotalDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDocumentos.Location = new System.Drawing.Point(857, 342);
            this.lblTotalDocumentos.Name = "lblTotalDocumentos";
            this.lblTotalDocumentos.Size = new System.Drawing.Size(97, 26);
            this.lblTotalDocumentos.TabIndex = 5;
            this.lblTotalDocumentos.Text = "0,00";
            this.lblTotalDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(737, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total dos Documentos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCentroCustos);
            this.groupBox2.Controls.Add(this.lblCentroCusto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblCliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Location = new System.Drawing.Point(358, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 71);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outros Filtros";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtCentroCustos
            // 
            this.txtCentroCustos.Location = new System.Drawing.Point(90, 48);
            this.txtCentroCustos.Mask = "aaa,aaa";
            this.txtCentroCustos.Name = "txtCentroCustos";
            this.txtCentroCustos.Size = new System.Drawing.Size(54, 20);
            this.txtCentroCustos.TabIndex = 11;
            this.txtCentroCustos.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCentroCustos_MaskInputRejected);
            this.txtCentroCustos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCentroCustos_KeyDown);
            this.txtCentroCustos.Leave += new System.EventHandler(this.txtCentroCustos_Leave);
            // 
            // lblCentroCusto
            // 
            this.lblCentroCusto.BackColor = System.Drawing.Color.Gold;
            this.lblCentroCusto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCentroCusto.Location = new System.Drawing.Point(150, 48);
            this.lblCentroCusto.Name = "lblCentroCusto";
            this.lblCentroCusto.Size = new System.Drawing.Size(344, 21);
            this.lblCentroCusto.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Centro Vendas";
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Gold;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCliente.Location = new System.Drawing.Point(150, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(344, 21);
            this.lblCliente.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(90, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(54, 20);
            this.txtCliente.TabIndex = 9;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(35, 345);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(58, 20);
            this.txtID.TabIndex = 9;
            this.txtID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(787, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Pagos";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPago.ForeColor = System.Drawing.Color.White;
            this.lblTotalPago.Location = new System.Drawing.Point(857, 368);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(97, 26);
            this.lblTotalPago.TabIndex = 11;
            this.lblTotalPago.Text = "0,00";
            this.lblTotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(776, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Devedor";
            // 
            // lblTotalAberto
            // 
            this.lblTotalAberto.BackColor = System.Drawing.Color.DarkRed;
            this.lblTotalAberto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAberto.ForeColor = System.Drawing.Color.White;
            this.lblTotalAberto.Location = new System.Drawing.Point(857, 391);
            this.lblTotalAberto.Name = "lblTotalAberto";
            this.lblTotalAberto.Size = new System.Drawing.Size(97, 26);
            this.lblTotalAberto.TabIndex = 13;
            this.lblTotalAberto.Text = "0,00";
            this.lblTotalAberto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
           // this.btnPesquisar.BackgroundImage = global::Properties.Resources.searchrosa;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(933, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 71);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // fContasReceber_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 421);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalAberto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalDocumentos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.optPagamento);
            this.Controls.Add(this.optVencimento);
            this.Controls.Add(this.optEmissao);
            this.Controls.Add(this.listView1);
            this.Name = "fContasReceber_Show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber - Extrato";
            this.Load += new System.EventHandler(this.fContasReceber_Show_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colCliente;
        private System.Windows.Forms.ColumnHeader colClienteNome;
        private System.Windows.Forms.ColumnHeader colEmissao;
        private System.Windows.Forms.ColumnHeader colVencimento;
        private System.Windows.Forms.ColumnHeader colBaixa;
        private System.Windows.Forms.ColumnHeader colCcusto;
        private System.Windows.Forms.ColumnHeader colValorDocumento;
        private System.Windows.Forms.ColumnHeader colPG;
        private System.Windows.Forms.ColumnHeader colDocumento;
        private System.Windows.Forms.RadioButton optEmissao;
        private System.Windows.Forms.RadioButton optVencimento;
        private System.Windows.Forms.RadioButton optPagamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtAte;
        private System.Windows.Forms.DateTimePicker txtDe;
        private System.Windows.Forms.Label lblTotalDocumentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblCentroCusto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.MaskedTextBox txtCentroCustos;
        private System.Windows.Forms.CheckBox chkMesInteiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalAberto;
    }
}