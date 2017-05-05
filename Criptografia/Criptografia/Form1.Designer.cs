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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criptografiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptografiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.campoMatrizCodificadora = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botaoMatrizAleatoria = new System.Windows.Forms.Button();
            this.campoMensagem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.botaoCodificar = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.botaoSair = new System.Windows.Forms.Button();
            this.menuAbas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1482, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Descriptografia";
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
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // açõesToolStripMenuItem
            // 
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criptografiaToolStripMenuItem,
            this.descriptografiaToolStripMenuItem});
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            this.açõesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.açõesToolStripMenuItem.Text = "Funções";
            // 
            // criptografiaToolStripMenuItem
            // 
            this.criptografiaToolStripMenuItem.Name = "criptografiaToolStripMenuItem";
            this.criptografiaToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.criptografiaToolStripMenuItem.Text = "Criptografia";
            // 
            // descriptografiaToolStripMenuItem
            // 
            this.descriptografiaToolStripMenuItem.Name = "descriptografiaToolStripMenuItem";
            this.descriptografiaToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.descriptografiaToolStripMenuItem.Text = "Descriptografia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoMatrizAleatoria);
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
            this.campoMatrizCodificadora.Location = new System.Drawing.Point(6, 54);
            this.campoMatrizCodificadora.Multiline = true;
            this.campoMatrizCodificadora.Name = "campoMatrizCodificadora";
            this.campoMatrizCodificadora.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.campoMatrizCodificadora.Size = new System.Drawing.Size(472, 295);
            this.campoMatrizCodificadora.TabIndex = 0;
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
            // botaoMatrizAleatoria
            // 
            this.botaoMatrizAleatoria.Location = new System.Drawing.Point(6, 25);
            this.botaoMatrizAleatoria.Name = "botaoMatrizAleatoria";
            this.botaoMatrizAleatoria.Size = new System.Drawing.Size(472, 23);
            this.botaoMatrizAleatoria.TabIndex = 1;
            this.botaoMatrizAleatoria.Text = "Gerar Matriz Codificadora Aleatória";
            this.botaoMatrizAleatoria.UseVisualStyleBackColor = true;
            this.botaoMatrizAleatoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // campoMensagem
            // 
            this.campoMensagem.Location = new System.Drawing.Point(6, 25);
            this.campoMensagem.Multiline = true;
            this.campoMensagem.Name = "campoMensagem";
            this.campoMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.campoMensagem.Size = new System.Drawing.Size(472, 324);
            this.campoMensagem.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(986, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 355);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(472, 324);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.botaoSair);
            this.groupBox4.Controls.Add(this.botaoLimpar);
            this.groupBox4.Controls.Add(this.botaoCodificar);
            this.groupBox4.Location = new System.Drawing.Point(496, 367);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(484, 74);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ações:";
            // 
            // botaoCodificar
            // 
            this.botaoCodificar.Location = new System.Drawing.Point(6, 32);
            this.botaoCodificar.Name = "botaoCodificar";
            this.botaoCodificar.Size = new System.Drawing.Size(150, 23);
            this.botaoCodificar.TabIndex = 0;
            this.botaoCodificar.Text = "Codificar Mensagem";
            this.botaoCodificar.UseVisualStyleBackColor = true;
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(162, 32);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(160, 23);
            this.botaoLimpar.TabIndex = 1;
            this.botaoLimpar.Text = "Limpar Campos";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            // 
            // botaoSair
            // 
            this.botaoSair.Location = new System.Drawing.Point(328, 32);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(150, 23);
            this.botaoSair.TabIndex = 2;
            this.botaoSair.Text = "Fechar Ferramenta";
            this.botaoSair.UseVisualStyleBackColor = true;
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
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Button botaoMatrizAleatoria;
        private System.Windows.Forms.TextBox campoMensagem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Button botaoCodificar;
    }
}