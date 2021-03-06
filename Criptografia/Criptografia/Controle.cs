﻿using System;
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
        private decimal[,] matrizInversa;
        private int[,] matrizMensagemCodificada;
        private bool estadoAlteracao;

        public Controle()
        {
            MatrizCodificadora = new int[1, 1];
            matrizMensagem = new char[1, 1];
            MatrizResultado = new int[1, 1];
            MatrizInversa = new decimal[1, 1];
            MatrizMensagemCodificada = new int[1, 1];
            estadoAlteracao = false;
        }

        public int[,] MatrizCodificadora { get => matrizCodificadora; set => matrizCodificadora = value; }
        public char[,] MatrizMensagem { get => matrizMensagem; set => matrizMensagem = value; }
        public int[,] MatrizResultado { get => matrizResultado; set => matrizResultado = value; }
        public decimal[,] MatrizInversa { get => matrizInversa; set => matrizInversa = value; }
        public int[,] MatrizMensagemCodificada { get => matrizMensagemCodificada; set => matrizMensagemCodificada = value; }
        public bool EstadoAlteracao { get => estadoAlteracao; set => estadoAlteracao = value; }

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

        public void gerarMatrizInversa()
        {
            if (matrizCodificadora.GetLength(0) == 1)
            {
                MatrizInversa = new decimal[1, 1];
                matrizInversa[0, 0] = (decimal) 1.0 / matrizCodificadora[0, 0];
            }
            else
            {
                MatrizInversa = new decimal[MatrizCodificadora.GetLength(0), MatrizCodificadora.GetLength(1)];
                for (int c = 0; c < matrizInversa.GetLength(0); c++)
                {
                    for (int i = 0; i < matrizInversa.GetLength(1); i++)
                    {
                        if (c == i)
                        {
                            matrizInversa[c, i] = (decimal) 1.0;
                        }
                        else
                        {
                            matrizInversa[c, i] = (decimal) 0.0;
                        }
                    }
                }
                decimal[,] matrizOriginal = new decimal[matrizCodificadora.GetLength(0), matrizCodificadora.GetLength(1)];
                for (int c = 0; c < matrizCodificadora.GetLength(0); c++)
                {
                    for (int i = 0; i < matrizCodificadora.GetLength(1); i++)
                    {
                        matrizOriginal[c, i] = (decimal) matrizCodificadora[c, i];
                    }
                }
                for (int c = 0; c < matrizOriginal.GetLength(0); c++)
                {
                    if (matrizOriginal[c, c] != (decimal) 1.0)
                    {
                        decimal fator = (decimal) 1.0 / matrizOriginal[c, c];
                        for (int i = 0; i < matrizOriginal.GetLength(1); i++)
                        {
                            matrizOriginal[c, i] *= fator;
                            matrizInversa[c, i] *= fator;
                        }
                    }
                    for (int i = 0; i < matrizOriginal.GetLength(0); i++)
                    {
                        if (c != i)
                        {
                            if (matrizOriginal[i, c] != (decimal) 0.0)
                            {
                                decimal fator = (decimal) (-1.0) * matrizOriginal[i, c];
                                for (int j = 0; j < matrizOriginal.GetLength(1); j++)
                                {
                                    matrizOriginal[i, j] = (matrizOriginal[c, j] * fator) + matrizOriginal[i, j];
                                    matrizInversa[i, j] = (matrizInversa[c, j] * fator) + matrizInversa[i, j];
                                }
                            }
                        }
                    }
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

        public bool inserirMatrizMensagemCodificada(String texto, int linhas)
        {
            String[] elementos = texto.Split((' ' + Environment.NewLine).ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
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
            if (elementos.Length % linhas != 0)
            {
                return false;
            }
            matrizMensagemCodificada = new int[linhas, elementos.Length / linhas];
            int cont = 0;
            for (int c = 0; c < linhas; c++)
            {
                for (int i = 0; i < elementos.Length / linhas; i++)
                {
                    matrizMensagemCodificada[c, i] = Convert.ToInt32(elementos[cont]);
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

        public void DecodificarMensagem()
        {
            matrizResultado = new int[matrizMensagemCodificada.GetLength(0), matrizMensagemCodificada.GetLength(1)];
            for (int c = 0; c < MatrizResultado.GetLength(0); c++)
            {
                for (int i = 0; i < MatrizResultado.GetLength(1); i++)
                {
                    decimal resultado = (decimal) 0.0;
                    for (int j = 0; j < matrizInversa.GetLength(1); j++)
                    {
                        resultado += (matrizInversa[c, j] * (decimal) matrizMensagemCodificada[j, i]);
                    }
                    matrizResultado[c, i] = (int) Convert.ToInt64(resultado);
                }
            }
        }

        public bool verificarMatrizMensagemCodificada()
        {
            if (matrizMensagemCodificada.GetLength(0) == matrizInversa.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
