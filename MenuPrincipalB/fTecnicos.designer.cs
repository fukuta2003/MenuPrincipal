namespace Sistema
{
    partial class fTecnicos
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
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpoCadastro = new System.Windows.Forms.GroupBox();
            this.txtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.chkWhatsapp = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.imgNo = new System.Windows.Forms.PictureBox();
            this.imgOK = new System.Windows.Forms.PictureBox();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.gpoCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackColor = System.Drawing.Color.Red;
            this.cmdNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNovo.ForeColor = System.Drawing.Color.White;
        //    this.cmdNovo.Image = global::SistemaPadrao.Properties.Resources.add;
            this.cmdNovo.Location = new System.Drawing.Point(12, 1);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(87, 51);
            this.cmdNovo.TabIndex = 12;
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdNovo.UseVisualStyleBackColor = false;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "CPF",
            "Cidade"});
            this.cmbPesquisa.Location = new System.Drawing.Point(197, 17);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(129, 21);
            this.cmbPesquisa.TabIndex = 11;
            this.cmbPesquisa.Text = "Nome";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPesquisa.Location = new System.Drawing.Point(331, 18);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(450, 20);
            this.txtPesquisa.TabIndex = 10;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pesquisa";
            // 
            // gpoCadastro
            // 
            this.gpoCadastro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gpoCadastro.Controls.Add(this.txtNascimento);
            this.gpoCadastro.Controls.Add(this.txtComissao);
            this.gpoCadastro.Controls.Add(this.label6);
            this.gpoCadastro.Controls.Add(this.imgNo);
            this.gpoCadastro.Controls.Add(this.imgOK);
            this.gpoCadastro.Controls.Add(this.txtRG);
            this.gpoCadastro.Controls.Add(this.label4);
            this.gpoCadastro.Controls.Add(this.txtCPF);
            this.gpoCadastro.Controls.Add(this.label3);
            this.gpoCadastro.Controls.Add(this.txtEmail);
            this.gpoCadastro.Controls.Add(this.txtCelular);
            this.gpoCadastro.Controls.Add(this.txtTelefone);
            this.gpoCadastro.Controls.Add(this.txtCep);
            this.gpoCadastro.Controls.Add(this.txtEstado);
            this.gpoCadastro.Controls.Add(this.txtCidade);
            this.gpoCadastro.Controls.Add(this.txtBairro);
            this.gpoCadastro.Controls.Add(this.txtEndereco);
            this.gpoCadastro.Controls.Add(this.txtNome);
            this.gpoCadastro.Controls.Add(this.cmdExcluir);
            this.gpoCadastro.Controls.Add(this.cmdSalvar);
            this.gpoCadastro.Controls.Add(this.label22);
            this.gpoCadastro.Controls.Add(this.label20);
            this.gpoCadastro.Controls.Add(this.chkWhatsapp);
            this.gpoCadastro.Controls.Add(this.label19);
            this.gpoCadastro.Controls.Add(this.label17);
            this.gpoCadastro.Controls.Add(this.label15);
            this.gpoCadastro.Controls.Add(this.label13);
            this.gpoCadastro.Controls.Add(this.label11);
            this.gpoCadastro.Controls.Add(this.label9);
            this.gpoCadastro.Controls.Add(this.label7);
            this.gpoCadastro.Controls.Add(this.label5);
            this.gpoCadastro.Controls.Add(this.lblID);
            this.gpoCadastro.Controls.Add(this.label2);
            this.gpoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpoCadastro.Location = new System.Drawing.Point(2, 176);
            this.gpoCadastro.Name = "gpoCadastro";
            this.gpoCadastro.Size = new System.Drawing.Size(780, 268);
            this.gpoCadastro.TabIndex = 8;
            this.gpoCadastro.TabStop = false;
            this.gpoCadastro.Text = "Cadastro";
            this.gpoCadastro.Visible = false;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNascimento.Location = new System.Drawing.Point(664, 135);
            this.txtNascimento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(104, 20);
            this.txtNascimento.TabIndex = 44;
            this.txtNascimento.Value = new System.DateTime(2020, 1, 31, 0, 0, 0, 0);
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(721, 99);
            this.txtComissao.MaxLength = 2;
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtComissao.Size = new System.Drawing.Size(47, 20);
            this.txtComissao.TabIndex = 32;
            this.txtComissao.TextChanged += new System.EventHandler(this.txtComissao_TextChanged);
            this.txtComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComissao_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Comissão %";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRG
            // 
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(664, 171);
            this.txtRG.MaxLength = 20;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(104, 20);
            this.txtRG.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "RG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(459, 172);
            this.txtCPF.MaxLength = 14;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(114, 20);
            this.txtCPF.TabIndex = 37;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "CPF";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(72, 172);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 20);
            this.txtEmail.TabIndex = 36;
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(252, 138);
            this.txtCelular.MaxLength = 14;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(129, 20);
            this.txtCelular.TabIndex = 34;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(72, 137);
            this.txtTelefone.MaxLength = 13;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(122, 20);
            this.txtTelefone.TabIndex = 33;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(542, 103);
            this.txtCep.MaxLength = 9;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(71, 20);
            this.txtCep.TabIndex = 31;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(459, 103);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(35, 20);
            this.txtEstado.TabIndex = 30;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(72, 103);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(309, 20);
            this.txtCidade.TabIndex = 29;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(459, 64);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(309, 20);
            this.txtBairro.TabIndex = 28;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(72, 64);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(309, 20);
            this.txtEndereco.TabIndex = 27;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(207, 31);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(561, 21);
            this.txtNome.TabIndex = 26;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 175);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "E-Mail";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(595, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Nascimento";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkWhatsapp
            // 
            this.chkWhatsapp.AutoSize = true;
            this.chkWhatsapp.Enabled = false;
            this.chkWhatsapp.Location = new System.Drawing.Point(406, 140);
            this.chkWhatsapp.Name = "chkWhatsapp";
            this.chkWhatsapp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkWhatsapp.Size = new System.Drawing.Size(75, 17);
            this.chkWhatsapp.TabIndex = 35;
            this.chkWhatsapp.Text = "Whatsapp";
            this.chkWhatsapp.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(204, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Celular";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Telefone";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(510, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Cep";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(408, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Estado";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cidade";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Bairro";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Endereço";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Enabled = false;
            this.lblID.Location = new System.Drawing.Point(72, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 22);
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
            this.Grid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid1.Location = new System.Drawing.Point(1, 53);
            this.Grid1.MultiSelect = false;
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            this.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid1.Size = new System.Drawing.Size(781, 391);
            this.Grid1.TabIndex = 7;
            this.Grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellContentClick);
            this.Grid1.DoubleClick += new System.EventHandler(this.Grid1_DoubleClick);
            this.Grid1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Grid1_KeyPress);
            // 
            // imgNo
            // 
          //  this.imgNo.Image = global::SistemaPadrao.Properties.Resources.no;
            this.imgNo.Location = new System.Drawing.Point(575, 172);
            this.imgNo.Name = "imgNo";
            this.imgNo.Size = new System.Drawing.Size(18, 15);
            this.imgNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNo.TabIndex = 42;
            this.imgNo.TabStop = false;
            this.imgNo.Visible = false;
            // 
            // imgOK
            // 
            //this.imgOK.Image = global::SistemaPadrao.Properties.Resources.yes;
            this.imgOK.Location = new System.Drawing.Point(575, 171);
            this.imgOK.Name = "imgOK";
            this.imgOK.Size = new System.Drawing.Size(18, 15);
            this.imgOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOK.TabIndex = 41;
            this.imgOK.TabStop = false;
            this.imgOK.Visible = false;
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackColor = System.Drawing.Color.Blue;
            this.cmdExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcluir.ForeColor = System.Drawing.Color.White;
            //this.cmdExcluir.Image = global::SistemaPadrao.Properties.Resources.delete;
            this.cmdExcluir.Location = new System.Drawing.Point(124, 209);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(94, 53);
            this.cmdExcluir.TabIndex = 40;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdExcluir.UseVisualStyleBackColor = false;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdSalvar.Enabled = false;
            this.cmdSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalvar.ForeColor = System.Drawing.Color.White;
            //this.cmdSalvar.Image = global::SistemaPadrao.Properties.Resources.save;
            this.cmdSalvar.Location = new System.Drawing.Point(10, 209);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(94, 53);
            this.cmdSalvar.TabIndex = 39;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSalvar.UseVisualStyleBackColor = false;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // fTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 447);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmbPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpoCadastro);
            this.Controls.Add(this.Grid1);
            this.KeyPreview = true;
            this.Name = "fTecnicos";
            this.Text = "Técnicos";
            this.Load += new System.EventHandler(this.fTecnicos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fTecnicos_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fTecnicos_KeyPress);
            this.gpoCadastro.ResumeLayout(false);
            this.gpoCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNovo;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpoCadastro;
        private System.Windows.Forms.PictureBox imgNo;
        private System.Windows.Forms.PictureBox imgOK;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkWhatsapp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.DateTimePicker txtNascimento;
    }
}