using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Principal : Form
    {
        Controle nucleo;

        public Principal()
        {
            InitializeComponent();
            nucleo = new Controle();
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nucleo.gerarMatrizAleatoria(10);
            campoMensagemCodificada.Text = Convert.ToString(nucleo.MatrizCodificadora.Rank);
            campoMatrizCodificadora.Text = "";
            for (int c = 0; c < nucleo.MatrizCodificadora.GetLength(0); c++)
            {
                for (int i = 0; i < nucleo.MatrizCodificadora.GetLength(1); i++)
                {
                    campoMatrizCodificadora.Text += Convert.ToString(nucleo.MatrizCodificadora[c, i]) + ' ';
                }
                campoMatrizCodificadora.Text += Environment.NewLine;
            }
        }

        private void botaoCodificar_Click(object sender, EventArgs e)
        {
            if ((campoMensagem.Text == "") || (campoMatrizCodificadora.Text == ""))
            {
                MessageBox.Show("Os campos Mensagem e Matriz Codificadora não podem ser nulos!", "AVISO");
                return;
            }
            if (!nucleo.inserirMatrizCodificadora(campoMatrizCodificadora.Text, campoMatrizCodificadora.Lines.Length))
            {
                MessageBox.Show("Matriz Codificadora Inválida!", "AVISO");
                return;
            }
            if (!nucleo.verificarMatriz(nucleo.MatrizCodificadora))
            {
                MessageBox.Show("Matriz Codificadora Inválida!", "AVISO");
                return;
            }

        }


        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            campoMatrizCodificadora.Text = "";
            campoMensagem.Text = "";
            campoMensagemCodificada.Text = "";
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
