using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoEscolar
{
    internal class NossaGrid
    {
        /// <summary>
        /// Classe que representa todos os métodos que vão ser utlizados para criar e preencher a grid
        /// </summary>
        /// <param name="dtvPauta"></param>

        //Método para Criar colunas dos Dados do Formando
        public void CriarColunasDadosFormandos(DataGridView dgv)
        {
            dgv.Columns.Add("colN", "N");
            dgv.Columns.Add("colNome", "Nome");
            dgv.Columns.Add("colFreguesia", "Freguesia");
            dgv.Columns.Add("colAno", "Ano");
            dgv.Columns.Add("colSexo", "Sexo");

        }

        //Método para preencher a grid com o os nomes
        public void ColonizarDados(DataGridView dgv, Ficha[] A)
        {

            for (int i = 0; i < A.Length; i++)
            {
                dgv.Rows.Add(A[i].numero, A[i].nome, A[i].freguesia, A[i].ano, A[i].sexo);

            }
        }

        //Criar Colunas das Notas
        public void CriarColunasDasNotas(DataGridView dgv)
        {
            dgv.Columns.Add("colPortugues", "POR");
            dgv.Columns.Add("colIngles", "ING");
            dgv.Columns.Add("colFilosofia", "FIL");
            dgv.Columns.Add("colMatematica", "MAT");
            dgv.Columns.Add("colFisica", "FIS");
            dgv.Columns.Add("colQuimica", "QUI");
            dgv.Columns.Add("colGeografia", "GEO");
            dgv.Columns.Add("colHistoria", "HIS");
            dgv.Columns.Add("colEducaoFisica", "EF");
            dgv.Columns.Add("colMoral", "MOR");



        }

        //Método para preencher a grid com as notas
        public void ColonizarNotas(DataGridView dgv, int[,] A)
        {

            for (int i = 0; i < 20; i++)
            {
                int k = 0;
                for (int j = 5; j <= 14; j++)
                {
                    dgv.Rows[i].Cells[j].Value = A[i, k];
                    k++;
                }

            }

        }

        //Método para criar as colunas da média,negativas e estado
        public void CriarColunasMediaNegativasEstado(DataGridView dgv)
        {
            dgv.Columns.Add("colMedia", "Media");
            dgv.Columns.Add("colNegativas", "Negativas");
            dgv.Columns.Add("colEstado", "Estado");
        }

        //Método para Calcular a Média
        public void Calcular_Media(DataGridView dgv)
        {
            for (int i = 0; i < 20; i++)
            {
                int nota = 0;
                double media = 0;
                int soma = 0;
                for (int j = 5; j <= 14; j++)
                {
                    nota = (int)dgv.Rows[i].Cells[j].Value;
                    soma = soma + nota;

                }
                media = soma / 10;
                dgv.Rows[i].Cells[15].Value = media;
            }

        }

        //Método para Calcular quantas negativas teve cada Formando
        public void Calcular_Negativas(DataGridView dgv)
        {
            int nota = 0;
            for (int i = 0; i < 20; i++)
            {
                int contador = 0;

                for (int j = 5; j <= 14; j++)
                {
                    nota = (int)dgv.Rows[i].Cells[j].Value;
                    if (nota < 10)
                    {
                        contador++;
                    }
                    dgv.Rows[i].Cells[16].Value = contador;
                }
            }
        }

        //Método para Verificar se o formando foi aprovado ou reprovado
        public void Calcular_Estado(DataGridView dgv)
        {
            int nota = 0;
            for (int i = 0; i < 20; i++)
            {
                nota = (int)dgv.Rows[i].Cells[16].Value;
                if (nota >= 3)
                {
                    dgv.Rows[i].Cells[17].Value = "Reprovado";
                }
                else
                {
                    dgv.Rows[i].Cells[17].Value = "Aprovado";
                }
            }
        }

        //Formatar Colunas
        public string FormatarApelidoPrimeiro(string nomeCompleto)
        {
            nomeCompleto = nomeCompleto.Trim();
            int pos = nomeCompleto.LastIndexOf(' ');

            if (pos < 0)
                return nomeCompleto; // só nome

            string nome = nomeCompleto.Substring(0, pos);
            string apelido = nomeCompleto.Substring(pos + 1);

            return $"{apelido}, {nome}";
        }

        //Colorir a Vermelho as negativas de cada discilplina
        public void colorirNegativas(DataGridView dgv)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 5; j < 15; j++)
                {

                    if (Convert.ToUInt16(dgv.Rows[i].Cells[j].Value) < 10)
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.OrangeRed;
                    }
                }
            }
        }

        //Vai pintar a verde os formandos que passaram e não tiveram negativas
        public void colorirVerdeAprovadoAmareloAprovadoVermelhoReprovou(DataGridView dgv)
        {

            for (int i = 0; i < 20; i++)
            {
                if (Convert.ToInt16(dgv.Rows[i].Cells[16].Value)==0 && Convert.ToString(dgv.Rows[i].Cells[17].Value)=="Aprovado")
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                else if (Convert.ToInt16(dgv.Rows[i].Cells[16].Value) > 0  && Convert.ToString(dgv.Rows[i].Cells[17].Value) == "Aprovado")
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }




            //for (int i = 0; i < formandos.Length; i++)
            //{
            //    if (Convert.ToString(dgv.Rows[i].Cells[17].Value) == "Aprovado")
            //    {
            //        dgv.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
            //    }
            //    else
            //    {
            //        dgv.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
            //    }
            //}
        }
    }
}
