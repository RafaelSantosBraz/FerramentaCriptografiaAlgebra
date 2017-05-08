namespace Criptografia
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuAbas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.botaoDescriptografar = new System.Windows.Forms.Button();
            this.botaoMatrizAleatoria = new System.Windows.Forms.Button();
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.botaoCodificar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.campoMensagemCodificada = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.campoMensagem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.campoMatrizCodificadora = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.campoMatrizDecodificadora = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.botaoFecharDes = new System.Windows.Forms.Button();
            this.botaoLimparCamposDes = new System.Windows.Forms.Button();
            this.botaoDecodificarMensagem = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.campoResultadoDes = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.campoMensagemCodificadaDes = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.campoMatrizCodificadoraDes = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criptografiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptografiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAbas
            // 
            this.menuAbas.Controls.Add(this.tabPage1);
            this.menuAbas.Controls.Add(this.tabPage2);
            this.menuAbas.Location = new System.Drawing.Point(12, 43);
            this.menuAbas.Name = "menuAbas";
            this.menuAbas.SelectedIndex = 0;
            this.menuAbas.Size = new System.Drawing.Size(1490, 484);
            this.menuAbas.TabIndex = 0;
            this.menuAbas.SelectedIndexChanged += new System.EventHandler(this.menuAbas_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1482, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Criptografia";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.botaoDescriptografar);
            this.groupBox4.Controls.Add(this.botaoMatrizAleatoria);
            this.groupBox4.Controls.Add(this.botaoSair);
            this.groupBox4.Controls.Add(this.botaoLimpar);
            this.groupBox4.Controls.Add(this.botaoCodificar);
            this.groupBox4.Location = new System.Drawing.Point(312, 367);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(943, 74);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ações:";
            // 
            // botaoDescriptografar
            // 
            this.botaoDescriptografar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoDescriptografar.Location = new System.Drawing.Point(582, 32);
            this.botaoDescriptografar.Name = "botaoDescriptografar";
            this.botaoDescriptografar.Size = new System.Drawing.Size(196, 29);
            this.botaoDescriptografar.TabIndex = 4;
            this.botaoDescriptografar.Text = "Descriptografar Mensagem";
            this.botaoDescriptografar.UseVisualStyleBackColor = true;
            this.botaoDescriptografar.Click += new System.EventHandler(this.botaoDescriptografar_Click);
            // 
            // botaoMatrizAleatoria
            // 
            this.botaoMatrizAleatoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoMatrizAleatoria.Location = new System.Drawing.Point(162, 32);
            this.botaoMatrizAleatoria.Name = "botaoMatrizAleatoria";
            this.botaoMatrizAleatoria.Size = new System.Drawing.Size(248, 29);
            this.botaoMatrizAleatoria.TabIndex = 3;
            this.botaoMatrizAleatoria.Text = "Gerar Matriz Codificadora Aleatória";
            this.botaoMatrizAleatoria.UseVisualStyleBackColor = true;
            this.botaoMatrizAleatoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoSair
            // 
            this.botaoSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSair.Location = new System.Drawing.Point(784, 32);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(150, 29);
            this.botaoSair.TabIndex = 2;
            this.botaoSair.Text = "Fechar Ferramenta";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoLimpar.Location = new System.Drawing.Point(416, 32);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(160, 29);
            this.botaoLimpar.TabIndex = 1;
            this.botaoLimpar.Text = "Limpar Campos";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // botaoCodificar
            // 
            this.botaoCodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCodificar.Location = new System.Drawing.Point(6, 32);
            this.botaoCodificar.Name = "botaoCodificar";
            this.botaoCodificar.Size = new System.Drawing.Size(150, 29);
            this.botaoCodificar.TabIndex = 0;
            this.botaoCodificar.Text = "Codificar Mensagem";
            this.botaoCodificar.UseVisualStyleBackColor = true;
            this.botaoCodificar.Click += new System.EventHandler(this.botaoCodificar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.campoMensagemCodificada);
            this.groupBox3.Location = new System.Drawing.Point(986, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 355);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado:";
            // 
            // campoMensagemCodificada
            // 
            this.campoMensagemCodificada.Location = new System.Drawing.Point(6, 25);
            this.campoMensagemCodificada.Multiline = true;
            this.campoMensagemCodificada.Name = "campoMensagemCodificada";
            this.campoMensagemCodificada.ReadOnly = true;
            this.campoMensagemCodificada.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.campoMensagemCodificada.Size = new System.Drawing.Size(472, 324);
            this.campoMensagemCodificada.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.campoMensagem);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 355);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mensagem:";
            // 
            // campoMensagem
            // 
            this.campoMensagem.Location = new System.Drawing.Point(6, 25);
            this.campoMensagem.Multiline = true;
            this.campoMensagem.Name = "campoMensagem";
            this.campoMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.campoMensagem.Size = new System.Drawing.Size(472, 324);
            this.campoMensagem.TabIndex = 1;
            this.campoMensagem.TextChanged += new System.EventHandler(this.campoMensagem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.campoMatrizCodificadora);
            this.groupBox1.Location = new System.Drawing.Point(496, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz Codificadora:";
            // 
            // campoMatrizCodificadora
            // 
            this.campoMatrizCodificadora.Location = new System.Drawing.Point(6, 25);
            this.campoMatrizCodificadora.Multiline = true;
            this.campoMatrizCodificadora.Name = "campoMatrizCodificadora";
            this.campoMatrizCodificadora.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.campoMatrizCodificadora.Size = new System.Drawing.Size(472, 324);
            this.campoMatrizCodificadora.TabIndex = 0;
            this.campoMatrizCodificadora.TextChanged += new System.EventHandler(this.campoMatrizCodificadora_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1482, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Descriptografia";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.campoMatrizDecodificadora);
            this.groupBox6.Location = new System.Drawing.Point(496, 224);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(484, 137);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Matriz Decodificadora:";
            // 
            // campoMatrizDecodificadora
            // 
            this.campoMatrizDecodificadora.Location = new System.Drawing.Point(6, 21);
            this.campoMatrizDecodificadora.Multiline = true;
            this.campoMatrizDecodificadora.Name = "campoMatrizDecodificadora";
            this.campoMatrizDecodificadora.ReadOnly = true;
            this.campoMatrizDecodificadora.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.campoMatrizDecodificadora.Size = new System.Drawing.Size(472, 110);
            this.campoMatrizDecodificadora.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.botaoFecharDes);
            this.groupBox7.Controls.Add(this.botaoLimparCamposDes);
            this.groupBox7.Controls.Add(this.botaoDecodificarMensagem);
            this.groupBox7.Location = new System.Drawing.Point(496, 367);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(484, 74);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ações:";
            // 
            // botaoFecharDes
            // 
            this.botaoFecharDes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFecharDes.Location = new System.Drawing.Point(328, 32);
            this.botaoFecharDes.Name = "botaoFecharDes";
            this.botaoFecharDes.Size = new System.Drawing.Size(150, 29);
            this.botaoFecharDes.TabIndex = 2;
            this.botaoFecharDes.Text = "Fechar Ferramenta";
            this.botaoFecharDes.UseVisualStyleBackColor = true;
            this.botaoFecharDes.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // botaoLimparCamposDes
            // 
            this.botaoLimparCamposDes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoLimparCamposDes.Location = new System.Drawing.Point(172, 32);
            this.botaoLimparCamposDes.Name = "botaoLimparCamposDes";
            this.botaoLimparCamposDes.Size = new System.Drawing.Size(150, 29);
            this.botaoLimparCamposDes.TabIndex = 1;
            this.botaoLimparCamposDes.Text = "Limpar Campos";
            this.botaoLimparCamposDes.UseVisualStyleBackColor = true;
            this.botaoLimparCamposDes.Click += new System.EventHandler(this.botaoLimparCamposDes_Click);
            // 
            // botaoDecodificarMensagem
            // 
            this.botaoDecodificarMensagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoDecodificarMensagem.Location = new System.Drawing.Point(6, 32);
            this.botaoDecodificarMensagem.Name = "botaoDecodificarMensagem";
            this.botaoDecodificarMensagem.Size = new System.Drawing.Size(160, 29);
            this.botaoDecodificarMensagem.TabIndex = 0;
            this.botaoDecodificarMensagem.Text = "Decodificar Mensagem";
            this.botaoDecodificarMensagem.UseVisualStyleBackColor = true;
            this.botaoDecodificarMensagem.Click += new System.EventHandler(this.botaoDecodificarMensagem_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.campoResultadoDes);
            this.groupBox8.Location = new System.Drawing.Point(986, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(484, 355);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Resultado:";
            // 
            // campoResultadoDes
            // 
            this.campoResultadoDes.Location = new System.Drawing.Point(6, 25);
            this.campoResultadoDes.Multiline = true;
            this.campoResultadoDes.Name = "campoResultadoDes";
            this.campoResultadoDes.ReadOnly = true;
            this.campoResultadoDes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.campoResultadoDes.Size = new System.Drawing.Size(472, 324);
            this.campoResultadoDes.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.campoMensagemCodificadaDes);
            this.groupBox9.Location = new System.Drawing.Point(6, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(484, 355);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Mensagem Codificada:";
            // 
            // campoMensagemCodificadaDes
            // 
            this.campoMensagemCodificadaDes.Location = new System.Drawing.Point(6, 25);
            this.campoMensagemCodificadaDes.Multiline = true;
            this.campoMensagemCodificadaDes.Name = "campoMensagemCodificadaDes";
            this.campoMensagemCodificadaDes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.campoMensagemCodificadaDes.Size = new System.Drawing.Size(472, 324);
            this.campoMensagemCodificadaDes.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.campoMatrizCodificadoraDes);
            this.groupBox10.Location = new System.Drawing.Point(496, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(484, 212);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Matriz Codificadora:";
            // 
            // campoMatrizCodificadoraDes
            // 
            this.campoMatrizCodificadoraDes.Location = new System.Drawing.Point(6, 25);
            this.campoMatrizCodificadoraDes.Multiline = true;
            this.campoMatrizCodificadoraDes.Name = "campoMatrizCodificadoraDes";
            this.campoMatrizCodificadoraDes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.campoMatrizCodificadoraDes.Size = new System.Drawing.Size(472, 178);
            this.campoMatrizCodificadoraDes.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.açõesToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1512, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opçõesToolStripMenuItem.Image")));
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // açõesToolStripMenuItem
            // 
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criptografiaToolStripMenuItem,
            this.descriptografiaToolStripMenuItem});
            this.açõesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("açõesToolStripMenuItem.Image")));
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            this.açõesToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.açõesToolStripMenuItem.Text = "Funções";
            // 
            // criptografiaToolStripMenuItem
            // 
            this.criptografiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("criptografiaToolStripMenuItem.Image")));
            this.criptografiaToolStripMenuItem.Name = "criptografiaToolStripMenuItem";
            this.criptografiaToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.criptografiaToolStripMenuItem.Text = "Criptografia";
            this.criptografiaToolStripMenuItem.Click += new System.EventHandler(this.criptografiaToolStripMenuItem_Click);
            // 
            // descriptografiaToolStripMenuItem
            // 
            this.descriptografiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("descriptografiaToolStripMenuItem.Image")));
            this.descriptografiaToolStripMenuItem.Name = "descriptografiaToolStripMenuItem";
            this.descriptografiaToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.descriptografiaToolStripMenuItem.Text = "Descriptografia";
            this.descriptografiaToolStripMenuItem.Click += new System.EventHandler(this.descriptografiaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1512, 546);
            this.Controls.Add(this.menuAbas);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriptoÁlgebra - Rafael Braz";
            this.menuAbas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl menuAbas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criptografiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descriptografiaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox campoMatrizCodificadora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox campoMensagem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox campoMensagemCodificada;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Button botaoCodificar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox campoMatrizDecodificadora;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button botaoFecharDes;
        private System.Windows.Forms.Button botaoLimparCamposDes;
        private System.Windows.Forms.Button botaoDecodificarMensagem;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox campoResultadoDes;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox campoMensagemCodificadaDes;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox campoMatrizCodificadoraDes;
        private System.Windows.Forms.Button botaoMatrizAleatoria;
        private System.Windows.Forms.Button botaoDescriptografar;
    }
}