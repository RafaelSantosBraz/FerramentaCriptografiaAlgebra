using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    class Controle
    {
        private int[,] matrizCodificadora;
        private char[,] matrizMensagem;
        private int[,] matrizResultado;

        public Controle()
        {
            MatrizCodificadora = new int[1, 1];
            matrizMensagem = new char[1, 1];
            MatrizResultado = new int[1, 1];
        }

        public int[,] MatrizCodificadora { get => matrizCodificadora; set => matrizCodificadora = value; }
        public char[,] MatrizMensagem { get => matrizMensagem; set => matrizMensagem = value; }
        public int[,] MatrizResultado { get => matrizResultado; set => matrizResultado = value; }

        public void gerarMatrizAleatoria(int limite)
        {
            Random x = new Random();
            int aux = x.Next(2, 11);
            MatrizCodificadora = new int[aux, aux];

            for (int c = 0; c < aux; c++)
            {
                for (int i = 0; i < aux; i++)
                {
                    MatrizCodificadora[c, i] = x.Next(1, limite);
                }
            }
        }

        public bool verificarMatriz(int[,] mat)
        {
            if (determinante(mat) == 0)
            {
                return false;
            }
            return true;
        }

        public int determinante(int[,] mat)
        {
            if (mat.GetLength(0) == 1)
            {
                return mat[0, 0];
            }
            if (mat.GetLength(0) == 2)
            {
                return (mat[0, 0] * mat[1, 1]) - (mat[1, 0] * mat[0, 1]);
            }
            if (mat.GetLength(0) == 3)
            {
                int[,] novaMat = new int[mat.GetLength(0), mat.GetLength(1) + 2];
                for (int c = 0; c < mat.GetLength(0); c++)
                {
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        novaMat[c, i] = mat[c, i];
                    }
                }
                for (int c = 0; c < mat.GetLength(0); c++)
                {
                    for (int i = mat.GetLength(0); i < novaMat.GetLength(1); i++)
                    {
                        novaMat[c, i] = mat[c, i - 3];
                    }
                }
                int detPositivo = (novaMat[0, 0] * novaMat[1, 1] * novaMat[2, 2]) + (novaMat[0, 1] * novaMat[1, 2] * novaMat[2, 3])
                    + (novaMat[0, 2] * novaMat[1, 3] * novaMat[2, 4]);
                int detNegativo = (novaMat[2, 0] * novaMat[1, 1] * novaMat[0, 2]) + (novaMat[2, 1] * novaMat[1, 2] * novaMat[0, 3])
                    + (novaMat[2, 2] * novaMat[1, 3] * novaMat[0, 4]);
                return detPositivo - detNegativo;
            }
            int[,,] matrizTripla = new int[mat.GetLength(1), mat.GetLength(0) - 1, mat.GetLength(1) - 1];
            for (int colunaExclu = 0; colunaExclu < mat.GetLength(1); colunaExclu++)
            {
                int linha = -1;
                int coluna = -1;
                for (int c = 1; c < mat.GetLength(0); c++)
                {
                    linha++;
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        if (i != colunaExclu)
                        {
                            coluna++;
                            matrizTripla[colunaExclu, linha, coluna] = mat[c, i];
                        }
                    }
                    coluna = -1;
                }
            }
            int det = 0;
            for (int c = 0; c < matrizTripla.GetLength(0); c++)
            {
                int[,] nova = new int[matrizTripla.GetLength(1), matrizTripla.GetLength(1)];
                for (int j = 0; j < matrizTripla.GetLength(1); j++)
                {
                    for (int i = 0; i < matrizTripla.GetLength(1); i++)
                    {
                        nova[j, i] = matrizTripla[c, j, i];
                    }
                }
                if (c % 2 == 0)
                {
                    det += mat[0, c] * determinante(nova);
                }
                else
                {
                    det -= mat[0, c] * determinante(nova);
                }
            }
            return det;
        }

        public void inserirMatrizMensagem(String texto)
        {
            if (texto.Length / matrizCodificadora.GetLength(1) == 0)
            {
                matrizMensagem = new char[matrizCodificadora.GetLength(1), 1];
            }
            else if (texto.Length % matrizCodificadora.GetLength(1) != 0)
            {
                matrizMensagem = new char[matrizCodificadora.GetLength(1), texto.Length / matrizCodificadora.GetLength(1) + 1];            
            }
            else
            {
                matrizMensagem = new char[matrizCodificadora.GetLength(1), texto.Length / matrizCodificadora.GetLength(1)];
            }
            int pos = 0;
            for (int c = 0; c < matrizMensagem.GetLength(0); c++)
            {
                for (int i = 0; i < matrizMensagem.GetLength(1); i++)
                {
                    if (pos < texto.Length)
                    {
                        matrizMensagem[c, i] = texto[pos];
                        pos++;
                    }
                    else
                    {
                        matrizMensagem[c, i] = ' ';
                    }
                }
            }
        }

        public bool inserirMatrizCodificadora(String texto, int linhas)
        {
            String[] elementos = texto.Split((' ' + Environment.NewLine).ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (elementos.Length != linhas * linhas)
            {
                return false;
            }
            for (int i = 0; i < elementos.Length; i++)
            {
                try
                {
                    Convert.ToInt32(elementos[i]);
                }
                catch
                {
                    return false;
                }

            }
            matrizCodificadora = new int[linhas, linhas];
            int cont = 0;
            for (int c = 0; c < linhas; c++)
            {
                for (int i = 0; i < linhas; i++)
                {
                    MatrizCodificadora[c, i] = Convert.ToInt32(elementos[cont]);
                    cont++;
                }
            }
            return true;
        }

        public void codificarMensagem()
        {
            matrizResultado = new int[matrizMensagem.GetLength(0), matrizMensagem.GetLength(1)];
            for (int c = 0; c < MatrizResultado.GetLength(0); c++)
            {
                for (int i = 0; i < MatrizResultado.GetLength(1); i++)
                {
                    int resultado = 0;
                    for (int j = 0; j < matrizCodificadora.GetLength(1); j++)
                    {
                        resultado += matrizCodificadora[c, j] * (int)matrizMensagem[j, i];
                    }
                    matrizResultado[c, i] = resultado;
                }
            }
        }
    }
}
