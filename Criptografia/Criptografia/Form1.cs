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
            nucleo.gerarMatrizAleatoria(50);
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
            if(campoMatrizCodificadora.Text[campoMatrizCodificadora.Text.Length - 1] == '\n')
            {
                campoMatrizCodificadora.Text = campoMatrizCodificadora.Text.Remove(campoMatrizCodificadora.Text.Length - 2);
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
            nucleo.inserirMatrizMensagem(campoMensagem.Text);
            nucleo.codificarMensagem();
            String aux = "";
            for (int c = 0; c < nucleo.MatrizResultado.GetLength(0); c++)
            {
                for (int i = 0; i < nucleo.MatrizResultado.GetLength(1); i++)
                {
                    aux += Convert.ToString(nucleo.MatrizResultado[c, i]) + ' ';
                }
                aux += Environment.NewLine;
            }
            campoMensagemCodificada.Text = aux;
            MessageBox.Show("Mensagem Codificada!", "AVISO");
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botaoSair_Click(sender, e);
        }

        private void botaoLimparCamposDes_Click(object sender, EventArgs e)
        {
            campoMensagemCodificadaDes.Text = "";
            campoMatrizCodificadoraDes.Text = "";
            campoMatrizDecodificadora.Text = "";
            campoResultadoDes.Text = "";
        }

        private void botaoDecodificarMensagem_Click(object sender, EventArgs e)
        {
            if ((campoMensagemCodificadaDes.Text == "") || (campoMatrizCodificadoraDes.Text == ""))
            {
                MessageBox.Show("Os campos Mensagem Codificada e Matriz Codificadora não podem ser nulos!", "AVISO");
                return;
            }
            if (campoMatrizCodificadoraDes.Text[campoMatrizCodificadoraDes.Text.Length - 1] == '\n')
            {
                campoMatrizCodificadoraDes.Text = campoMatrizCodificadoraDes.Text.Remove(campoMatrizCodificadoraDes.Text.Length - 2);
            }
            if (!nucleo.inserirMatrizCodificadora(campoMatrizCodificadoraDes.Text, campoMatrizCodificadoraDes.Lines.Length))
            {
                MessageBox.Show("Matriz Codificadora Inválida!", "AVISO");
                return;
            }
            if (!nucleo.verificarMatriz(nucleo.MatrizCodificadora))
            {
                MessageBox.Show("Matriz Codificadora Inválida!", "AVISO");
                return;
            }
            if (campoMensagemCodificadaDes.Text[campoMensagemCodificadaDes.Text.Length - 1] == '\n')
            {
                campoMensagemCodificadaDes.Text = campoMensagemCodificadaDes.Text.Remove(campoMensagemCodificadaDes.Text.Length - 2);
            }
            if (!nucleo.inserirMatrizMensagemCodificada(campoMensagemCodificadaDes.Text, campoMensagemCodificadaDes.Lines.Length))
            {
                MessageBox.Show("Mensagem Codificada Inválida!", "AVISO");
                return;
            }
            nucleo.gerarMatrizInversa();
            campoMatrizDecodificadora.Text = "";
            for (int c = 0; c < nucleo.MatrizInversa.GetLength(0); c++)
            {
                for (int i = 0; i < nucleo.MatrizInversa.GetLength(1); i++)
                {
                    campoMatrizDecodificadora.Text += Convert.ToString(nucleo.MatrizInversa[c, i]) + ' ';
                }
                campoMatrizDecodificadora.Text += Environment.NewLine;
            }
            if (!nucleo.verificarMatrizMensagemCodificada())
            {
                MessageBox.Show("Mensagem Codificada e Matriz Decodificadora incompatíveis!", "AVISO");
                return;
            }
            nucleo.DecodificarMensagem();
            String aux = "";
            for (int c = 0; c < nucleo.MatrizResultado.GetLength(0); c++)
            {
                for (int i = 0; i < nucleo.MatrizResultado.GetLength(1); i++)
                {
                    aux += (char) nucleo.MatrizResultado[c, i];
                }
            }
            campoResultadoDes.Text = aux;
            MessageBox.Show("Mensagem Decodificada!", "AVISO");
        }

        private void criptografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuAbas.SelectTab(0);
        }

        private void descriptografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuAbas.SelectTab(1);
        }
    }
}
