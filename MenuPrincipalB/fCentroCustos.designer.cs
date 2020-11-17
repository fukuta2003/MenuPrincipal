namespace Sistema
{
    partial class fCentroCustos
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.gpoDados = new System.Windows.Forms.GroupBox();
            this.txtDezembro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNovembro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOutubro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSetembro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAgosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJulho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJunho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAbril = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFevereiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.txtJaneiro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpoDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblOperacao
            // 
            this.lblOperacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(454, 27);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(155, 32);
            this.lblOperacao.TabIndex = 30;
            this.lblOperacao.Text = "< Operação >";
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(6, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(92, 16);
            this.lblCodigo.TabIndex = 27;
            this.lblCodigo.Text = "ID (F2-Lista)";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(9, 34);
            this.txtCodigo.Mask = "aaa,aaa";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(55, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCodigo_MaskInputRejected);
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown_1);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave_1);
            // 
            // gpoDados
            // 
            this.gpoDados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpoDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpoDados.Controls.Add(this.txtDezembro);
            this.gpoDados.Controls.Add(this.label10);
            this.gpoDados.Controls.Add(this.txtNovembro);
            this.gpoDados.Controls.Add(this.label11);
            this.gpoDados.Controls.Add(this.txtOutubro);
            this.gpoDados.Controls.Add(this.label12);
            this.gpoDados.Controls.Add(this.txtSetembro);
            this.gpoDados.Controls.Add(this.label13);
            this.gpoDados.Controls.Add(this.txtAgosto);
            this.gpoDados.Controls.Add(this.label6);
            this.gpoDados.Controls.Add(this.txtJulho);
            this.gpoDados.Controls.Add(this.label7);
            this.gpoDados.Controls.Add(this.txtJunho);
            this.gpoDados.Controls.Add(this.label8);
            this.gpoDados.Controls.Add(this.txtMaio);
            this.gpoDados.Controls.Add(this.label9);
            this.gpoDados.Controls.Add(this.txtAbril);
            this.gpoDados.Controls.Add(this.label5);
            this.gpoDados.Controls.Add(this.txtMarco);
            this.gpoDados.Controls.Add(this.label4);
            this.gpoDados.Controls.Add(this.txtFevereiro);
            this.gpoDados.Controls.Add(this.label1);
            this.gpoDados.Controls.Add(this.cmdExcluir);
            this.gpoDados.Controls.Add(this.cmdSalvar);
            this.gpoDados.Controls.Add(this.txtJaneiro);
            this.gpoDados.Controls.Add(this.label3);
            this.gpoDados.Controls.Add(this.txtDescricao);
            this.gpoDados.Controls.Add(this.label2);
            this.gpoDados.Enabled = false;
            this.gpoDados.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gpoDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoDados.ForeColor = System.Drawing.Color.Black;
            this.gpoDados.Location = new System.Drawing.Point(9, 73);
            this.gpoDados.Name = "gpoDados";
            this.gpoDados.Size = new System.Drawing.Size(602, 326);
            this.gpoDados.TabIndex = 2;
            this.gpoDados.TabStop = false;
            this.gpoDados.Text = "Dados";
            // 
            // txtDezembro
            // 
            this.txtDezembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDezembro.ForeColor = System.Drawing.Color.Black;
            this.txtDezembro.Location = new System.Drawing.Point(469, 216);
            this.txtDezembro.Name = "txtDezembro";
            this.txtDezembro.Size = new System.Drawing.Size(114, 22);
            this.txtDezembro.TabIndex = 15;
            this.txtDezembro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDezembro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDezembro_KeyPress);
            this.txtDezembro.Leave += new System.EventHandler(this.txtDezembro_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(466, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "Dezembro";
            // 
            // txtNovembro
            // 
            this.txtNovembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovembro.ForeColor = System.Drawing.Color.Black;
            this.txtNovembro.Location = new System.Drawing.Point(311, 216);
            this.txtNovembro.Name = "txtNovembro";
            this.txtNovembro.Size = new System.Drawing.Size(114, 22);
            this.txtNovembro.TabIndex = 14;
            this.txtNovembro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNovembro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovembro_KeyPress);
            this.txtNovembro.Leave += new System.EventHandler(this.txtNovembro_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(308, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Novembro";
            // 
            // txtOutubro
            // 
            this.txtOutubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutubro.ForeColor = System.Drawing.Color.Black;
            this.txtOutubro.Location = new System.Drawing.Point(155, 216);
            this.txtOutubro.Name = "txtOutubro";
            this.txtOutubro.Size = new System.Drawing.Size(114, 22);
            this.txtOutubro.TabIndex = 13;
            this.txtOutubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutubro_KeyPress);
            this.txtOutubro.Leave += new System.EventHandler(this.txtOutubro_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(152, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "Outubro";
            // 
            // txtSetembro
            // 
            this.txtSetembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetembro.ForeColor = System.Drawing.Color.Black;
            this.txtSetembro.Location = new System.Drawing.Point(9, 216);
            this.txtSetembro.Name = "txtSetembro";
            this.txtSetembro.Size = new System.Drawing.Size(114, 22);
            this.txtSetembro.TabIndex = 12;
            this.txtSetembro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSetembro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSetembro_KeyPress);
            this.txtSetembro.Leave += new System.EventHandler(this.txtSetembro_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Setembro";
            // 
            // txtAgosto
            // 
            this.txtAgosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgosto.ForeColor = System.Drawing.Color.Black;
            this.txtAgosto.Location = new System.Drawing.Point(469, 161);
            this.txtAgosto.Name = "txtAgosto";
            this.txtAgosto.Size = new System.Drawing.Size(114, 22);
            this.txtAgosto.TabIndex = 11;
            this.txtAgosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAgosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgosto_KeyPress);
            this.txtAgosto.Leave += new System.EventHandler(this.txtAgosto_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(466, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Agosto";
            // 
            // txtJulho
            // 
            this.txtJulho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJulho.ForeColor = System.Drawing.Color.Black;
            this.txtJulho.Location = new System.Drawing.Point(311, 161);
            this.txtJulho.Name = "txtJulho";
            this.txtJulho.Size = new System.Drawing.Size(114, 22);
            this.txtJulho.TabIndex = 10;
            this.txtJulho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJulho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJulho_KeyPress);
            this.txtJulho.Leave += new System.EventHandler(this.txtJulho_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(308, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Julho";
            // 
            // txtJunho
            // 
            this.txtJunho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJunho.ForeColor = System.Drawing.Color.Black;
            this.txtJunho.Location = new System.Drawing.Point(155, 161);
            this.txtJunho.Name = "txtJunho";
            this.txtJunho.Size = new System.Drawing.Size(114, 22);
            this.txtJunho.TabIndex = 9;
            this.txtJunho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJunho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJunho_KeyPress);
            this.txtJunho.Leave += new System.EventHandler(this.txtJunho_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(152, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Junho";
            // 
            // txtMaio
            // 
            this.txtMaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaio.ForeColor = System.Drawing.Color.Black;
            this.txtMaio.Location = new System.Drawing.Point(9, 161);
            this.txtMaio.Name = "txtMaio";
            this.txtMaio.Size = new System.Drawing.Size(114, 22);
            this.txtMaio.TabIndex = 8;
            this.txtMaio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaio_KeyPress);
            this.txtMaio.Leave += new System.EventHandler(this.txtMaio_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Maio";
            // 
            // txtAbril
            // 
            this.txtAbril.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbril.ForeColor = System.Drawing.Color.Black;
            this.txtAbril.Location = new System.Drawing.Point(469, 106);
            this.txtAbril.Name = "txtAbril";
            this.txtAbril.Size = new System.Drawing.Size(114, 22);
            this.txtAbril.TabIndex = 7;
            this.txtAbril.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAbril.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbril_KeyPress);
            this.txtAbril.Leave += new System.EventHandler(this.txtAbril_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(466, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Abril";
            // 
            // txtMarco
            // 
            this.txtMarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarco.ForeColor = System.Drawing.Color.Black;
            this.txtMarco.Location = new System.Drawing.Point(311, 106);
            this.txtMarco.Name = "txtMarco";
            this.txtMarco.Size = new System.Drawing.Size(114, 22);
            this.txtMarco.TabIndex = 6;
            this.txtMarco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMarco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarco_KeyPress);
            this.txtMarco.Leave += new System.EventHandler(this.txtMarco_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(308, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Março";
            // 
            // txtFevereiro
            // 
            this.txtFevereiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFevereiro.ForeColor = System.Drawing.Color.Black;
            this.txtFevereiro.Location = new System.Drawing.Point(155, 106);
            this.txtFevereiro.Name = "txtFevereiro";
            this.txtFevereiro.Size = new System.Drawing.Size(114, 22);
            this.txtFevereiro.TabIndex = 5;
            this.txtFevereiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFevereiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFevereiro_KeyPress);
            this.txtFevereiro.Leave += new System.EventHandler(this.txtFevereiro_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(152, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fevereiro";
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Location = new System.Drawing.Point(108, 273);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(93, 37);
            this.cmdExcluir.TabIndex = 17;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(9, 273);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(93, 37);
            this.cmdSalvar.TabIndex = 16;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = true;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // txtJaneiro
            // 
            this.txtJaneiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJaneiro.ForeColor = System.Drawing.Color.Black;
            this.txtJaneiro.Location = new System.Drawing.Point(9, 106);
            this.txtJaneiro.Name = "txtJaneiro";
            this.txtJaneiro.Size = new System.Drawing.Size(114, 22);
            this.txtJaneiro.TabIndex = 4;
            this.txtJaneiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJaneiro.TextChanged += new System.EventHandler(this.txtJaneiro_TextChanged);
            this.txtJaneiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJaneiro_KeyPress);
            this.txtJaneiro.Leave += new System.EventHandler(this.txtJaneiro_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Janeiro";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Location = new System.Drawing.Point(9, 47);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(574, 22);
            this.txtDescricao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição da Conta do Centro de Custos";
            // 
            // fCentroCustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.gpoDados);
            this.Controls.Add(this.lblCodigo);
            this.KeyPreview = true;
            this.Name = "fCentroCustos";
            this.Text = "fCentroCustos";
            this.Load += new System.EventHandler(this.fCentroCustos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fCentroCustos_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fCentroCustos_KeyPress);
            this.gpoDados.ResumeLayout(false);
            this.gpoDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.GroupBox gpoDados;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.TextBox txtJaneiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDezembro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNovembro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOutubro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSetembro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAgosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJulho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJunho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAbril;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFevereiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
    }
}