namespace Sistema
{
    partial class fServicos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.gpoCadastro = new System.Windows.Forms.GroupBox();
            this.txtValorPrazo = new System.Windows.Forms.TextBox();
            this.txtValorVista = new System.Windows.Forms.TextBox();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.gpoCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pesquisa";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(295, 31);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(473, 21);
            this.txtDescricao.TabIndex = 26;
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackColor = System.Drawing.Color.Red;
            this.cmdNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNovo.ForeColor = System.Drawing.Color.White;
            this.cmdNovo.Location = new System.Drawing.Point(12, 10);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(87, 44);
            this.cmdNovo.TabIndex = 12;
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.UseVisualStyleBackColor = false;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click_1);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPesquisa.Location = new System.Drawing.Point(342, 27);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(450, 20);
            this.txtPesquisa.TabIndex = 10;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackColor = System.Drawing.Color.Blue;
            this.cmdExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcluir.ForeColor = System.Drawing.Color.White;
            this.cmdExcluir.Location = new System.Drawing.Point(674, 73);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(94, 53);
            this.cmdExcluir.TabIndex = 30;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = false;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Id",
            "Descrição"});
            this.cmbPesquisa.Location = new System.Drawing.Point(208, 26);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(129, 21);
            this.cmbPesquisa.TabIndex = 11;
            this.cmbPesquisa.Text = "Descrição";
            // 
            // gpoCadastro
            // 
            this.gpoCadastro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gpoCadastro.Controls.Add(this.txtValorPrazo);
            this.gpoCadastro.Controls.Add(this.txtValorVista);
            this.gpoCadastro.Controls.Add(this.txtDescricao);
            this.gpoCadastro.Controls.Add(this.cmdExcluir);
            this.gpoCadastro.Controls.Add(this.cmdSalvar);
            this.gpoCadastro.Controls.Add(this.label9);
            this.gpoCadastro.Controls.Add(this.label7);
            this.gpoCadastro.Controls.Add(this.label5);
            this.gpoCadastro.Controls.Add(this.lblID);
            this.gpoCadastro.Controls.Add(this.label2);
            this.gpoCadastro.Location = new System.Drawing.Point(12, 428);
            this.gpoCadastro.Name = "gpoCadastro";
            this.gpoCadastro.Size = new System.Drawing.Size(780, 149);
            this.gpoCadastro.TabIndex = 8;
            this.gpoCadastro.TabStop = false;
            this.gpoCadastro.Text = "Cadastro";
            this.gpoCadastro.Visible = false;
            // 
            // txtValorPrazo
            // 
            this.txtValorPrazo.Location = new System.Drawing.Point(99, 106);
            this.txtValorPrazo.Name = "txtValorPrazo";
            this.txtValorPrazo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValorPrazo.Size = new System.Drawing.Size(85, 20);
            this.txtValorPrazo.TabIndex = 28;
            // 
            // txtValorVista
            // 
            this.txtValorVista.Location = new System.Drawing.Point(99, 70);
            this.txtValorVista.Name = "txtValorVista";
            this.txtValorVista.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValorVista.Size = new System.Drawing.Size(85, 20);
            this.txtValorVista.TabIndex = 27;
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdSalvar.Enabled = false;
            this.cmdSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalvar.ForeColor = System.Drawing.Color.White;
            this.cmdSalvar.Location = new System.Drawing.Point(560, 73);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(94, 53);
            this.cmdSalvar.TabIndex = 29;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = false;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Valor a Vista";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Valor a Prazo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descrição";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Enabled = false;
            this.lblID.Location = new System.Drawing.Point(99, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(85, 22);
            this.lblID.TabIndex = 1;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AllowUserToDeleteRows = false;
            this.Grid1.BackgroundColor = System.Drawing.Color.White;
            this.Grid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Grid1.Location = new System.Drawing.Point(12, 62);
            this.Grid1.MultiSelect = false;
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            this.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid1.Size = new System.Drawing.Size(781, 515);
            this.Grid1.TabIndex = 7;
            this.Grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellContentClick);
            this.Grid1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Grid1_CellFormatting);
            this.Grid1.DoubleClick += new System.EventHandler(this.Grid1_DoubleClick);
            this.Grid1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Grid1_KeyPress);
            // 
            // fServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cmbPesquisa);
            this.Controls.Add(this.gpoCadastro);
            this.Controls.Add(this.Grid1);
            this.Name = "fServicos";
            this.Text = "fServicos";
            this.Load += new System.EventHandler(this.fServicos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fServicos_KeyDown);
            this.gpoCadastro.ResumeLayout(false);
            this.gpoCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button cmdNovo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.GroupBox gpoCadastro;
        private System.Windows.Forms.TextBox txtValorPrazo;
        private System.Windows.Forms.TextBox txtValorVista;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grid1;
    }
}