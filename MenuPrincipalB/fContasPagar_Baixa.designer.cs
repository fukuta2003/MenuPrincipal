namespace Sistema
{
    partial class fContasPagar_Baixa
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCaixaID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdBaixa = new System.Windows.Forms.Button();
            this.txtPagamento = new System.Windows.Forms.DateTimePicker();
            this.txtValorDocumento = new System.Windows.Forms.TextBox();
            this.txtEmissao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorBruto = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCentroCustos = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(18, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(12, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // groupBox1
            // 
            //this.groupBox1.BackgroundImage = global::SistemaPadrao.Properties.Resources.backgroundmoney1;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtCaixaID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtValorPago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdBaixa);
            this.groupBox1.Controls.Add(this.txtPagamento);
            this.groupBox1.Controls.Add(this.txtValorDocumento);
            this.groupBox1.Controls.Add(this.txtEmissao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVencimento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtValorBruto);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtJuros);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCaixaID
            // 
            this.txtCaixaID.Enabled = false;
            this.txtCaixaID.Location = new System.Drawing.Point(108, 106);
            this.txtCaixaID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCaixaID.Name = "txtCaixaID";
            this.txtCaixaID.Size = new System.Drawing.Size(119, 20);
            this.txtCaixaID.TabIndex = 48;
            this.txtCaixaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(12, 109);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Caixa ID";
            // 
            // txtValorPago
            // 
            this.txtValorPago.BackColor = System.Drawing.Color.White;
            this.txtValorPago.ForeColor = System.Drawing.Color.Black;
            this.txtValorPago.Location = new System.Drawing.Point(250, 168);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(105, 20);
            this.txtValorPago.TabIndex = 3;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Valor Pago";
            // 
            // cmdBaixa
            // 
            //this.cmdBaixa.BackgroundImage = global::SistemaPadrao.Properties.Resources.pay21;
            this.cmdBaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBaixa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmdBaixa.Location = new System.Drawing.Point(374, 168);
            this.cmdBaixa.Name = "cmdBaixa";
            this.cmdBaixa.Size = new System.Drawing.Size(103, 79);
            this.cmdBaixa.TabIndex = 4;
            this.cmdBaixa.Text = "Baixar";
            this.cmdBaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdBaixa.UseVisualStyleBackColor = true;
            this.cmdBaixa.Click += new System.EventHandler(this.cmdBaixa_Click);
            // 
            // txtPagamento
            // 
            this.txtPagamento.Enabled = false;
            this.txtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtPagamento.Location = new System.Drawing.Point(108, 78);
            this.txtPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtPagamento.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(119, 20);
            this.txtPagamento.TabIndex = 5;
            // 
            // txtValorDocumento
            // 
            this.txtValorDocumento.Enabled = false;
            this.txtValorDocumento.Location = new System.Drawing.Point(390, 131);
            this.txtValorDocumento.Name = "txtValorDocumento";
            this.txtValorDocumento.Size = new System.Drawing.Size(87, 20);
            this.txtValorDocumento.TabIndex = 2;
            this.txtValorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEmissao
            // 
            this.txtEmissao.Enabled = false;
            this.txtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEmissao.Location = new System.Drawing.Point(108, 21);
            this.txtEmissao.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmissao.MaxDate = new System.DateTime(2020, 6, 30, 0, 0, 0, 0);
            this.txtEmissao.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtEmissao.Name = "txtEmissao";
            this.txtEmissao.Size = new System.Drawing.Size(119, 20);
            this.txtEmissao.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Data Emissão *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Data Vencimento *";
            // 
            // txtVencimento
            // 
            this.txtVencimento.Enabled = false;
            this.txtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVencimento.Location = new System.Drawing.Point(108, 50);
            this.txtVencimento.Margin = new System.Windows.Forms.Padding(2);
            this.txtVencimento.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(119, 20);
            this.txtVencimento.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Data Pagamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(319, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Valor Bruto *";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(289, 134);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Valor Documento *";
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.Enabled = false;
            this.txtValorBruto.Location = new System.Drawing.Point(390, 18);
            this.txtValorBruto.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.Size = new System.Drawing.Size(87, 20);
            this.txtValorBruto.TabIndex = 5;
            this.txtValorBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(390, 93);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(87, 20);
            this.txtDesconto.TabIndex = 1;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(353, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Juros";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(332, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Desconto";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(390, 54);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(2);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(87, 20);
            this.txtJuros.TabIndex = 0;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJuros.TextChanged += new System.EventHandler(this.txtJuros_TextChanged);
            this.txtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
            this.txtJuros.Leave += new System.EventHandler(this.txtJuros_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "C. Custos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 4;
            // 
            // lblCentroCustos
            // 
            this.lblCentroCustos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCentroCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroCustos.Location = new System.Drawing.Point(167, 35);
            this.lblCentroCustos.Name = "lblCentroCustos";
            this.lblCentroCustos.Size = new System.Drawing.Size(342, 18);
            this.lblCentroCustos.TabIndex = 5;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(167, 12);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(343, 18);
            this.lblFornecedor.TabIndex = 6;
            // 
            // fContasPagar_Baixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(518, 321);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblCentroCustos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Label1);
            this.KeyPreview = true;
            this.Name = "fContasPagar_Baixa";
            this.Text = "Baixa";
            this.Load += new System.EventHandler(this.fContasPagar_Baixa_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fContasPagar_Baixa_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker txtVencimento;
        private System.Windows.Forms.DateTimePicker txtEmissao;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBaixa;
        private System.Windows.Forms.DateTimePicker txtPagamento;
        private System.Windows.Forms.TextBox txtValorDocumento;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCentroCustos;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtCaixaID;
        private System.Windows.Forms.Label label13;
    }
}