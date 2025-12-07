using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoEscolar
{
    public partial class Form1 : Form
    {
        Ficha[] formandos = new Ficha[20];
        int[,] notas = new int[20, 10];
        public Form1()
        {
            InitializeComponent();
            dtvPauta.CellEndEdit += dtvPauta_CellEndEdit;
        }

        //Botão de criar a grid
        private void criarDataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtvPauta.Visible = true;
        }

        //Botão de criar as Colunas dos Dados Pessoais dos Formandos        
        private void criarColunasDadosFormandosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NossaGrid ns = new NossaGrid();
            ns.CriarColunasDadosFormandos(dtvPauta);

        }

        //Botão de Preencher os Dados Pessoais dos Formandos
        private void preencherDadosDosFormandosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipa eq = new Equipa();
            eq.InicializarArrayDeEquipa(ref formandos);
            NossaGrid ns = new NossaGrid();
            ns.ColonizarDados(dtvPauta, formandos);
        }

        //Botão de criar as Colunas Das Notas Dos Formandos
        private void criarColunasDasNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NossaGrid ns = new NossaGrid();
            ns.CriarColunasDasNotas(dtvPauta);
        }

        //Botão de Preencher as Notas Dos Formandos
        private void preencherNotasDosFormandosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipa equipa = new Equipa();
            NossaGrid ns = new NossaGrid();
            notas = equipa.InitMatriz();
            ns.ColonizarNotas(dtvPauta, notas);
            ns.colorirNegativas(dtvPauta);
        }

        //Botão De Crias as Colunas da Média,Negativas e do Estado
        private void criarColunasDaMédiaNegativasEEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NossaGrid ns = new NossaGrid();
            ns.CriarColunasMediaNegativasEstado(dtvPauta);
        }

        //Botão de Preencher a Média
        private void preencherMédiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipa eq = new Equipa();
            NossaGrid ns = new NossaGrid();
            ns.Calcular_Media(dtvPauta);
        }

        //Botão de Preencher Quantas Negativas teve cada Formando
        private void quantidadeDeNegativasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipa eq = new Equipa();
            NossaGrid ns = new NossaGrid();
            ns.Calcular_Negativas(dtvPauta);
        }

        //Botão de Preencher o Estado dos Formandos
        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipa eq = new Equipa();
            NossaGrid ns = new NossaGrid();
            ns.Calcular_Estado(dtvPauta);
            ns.colorirVerdeAprovadoAmareloAprovadoVermelhoReprovou(dtvPauta);

        }

        //Botão de Contar quantos rapazes e quantas raparigas reprovaram e mostrar numa message box
        private void Resultado_Click(object sender, EventArgs e)
        {
            int contadorM = 0;
            int contadorF = 0;

            for (int i = 0; i < 20; i++)
            {
                if (Convert.ToString(dtvPauta.Rows[i].Cells[4].Value) == "M" && Convert.ToString(dtvPauta.Rows[i].Cells[17].Value) == "Reprovado")
                {
                    contadorM = contadorM + 1;
                }
                if (Convert.ToString(dtvPauta.Rows[i].Cells[4].Value) == "F" && Convert.ToString(dtvPauta.Rows[i].Cells[17].Value) == "Reprovado")
                {
                    contadorF = contadorF + 1;
                }
            }
            MessageBox.Show("Reprovaram " + contadorM + " Rapazes e " + contadorF + " Raparigas");
        }

        //Botão de Escrever os nomes, media e negativas dos reprovados Message box
        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            string nome;
            string nNegativas;
            string nMedia;
            string s = "";

            for (int i = 0; i < formandos.Length; i++)
            {
                if (Convert.ToString(dtvPauta.Rows[i].Cells[17].Value) == "Reprovado")
                {
                    nome = Convert.ToString(dtvPauta.Rows[i].Cells[1].Value);
                    nNegativas = Convert.ToString(dtvPauta.Rows[i].Cells[16].Value);
                    nMedia = Convert.ToString(dtvPauta.Rows[i].Cells[15].Value);
                    s = s + nome + " (Negativas:" + nNegativas + ", Média: " + nMedia + ")" + "\n";
                }
            }
            MessageBox.Show(s);
        }

        //Botão de Listar os formandos em uma message box, primeiro o apelido e depois onome seguido da freguesia e media
        private void btnexercicio3_Click(object sender, EventArgs e)
        {
            NossaGrid ns = new NossaGrid();
            string s = "";
            string nome;
            string nomeCorrigido;
            string freguesia;
            string media;

            for (int i = 0; i < formandos.Length; i++)
            {
                nome = Convert.ToString(dtvPauta.Rows[i].Cells[1].Value);
                nomeCorrigido = ns.FormatarApelidoPrimeiro(nome);
                freguesia = Convert.ToString(dtvPauta.Rows[i].Cells[2].Value);
                media = Convert.ToString(dtvPauta.Rows[i].Cells[15].Value);
                s = s + nomeCorrigido + " (Freguesia: " + freguesia + ", Media: " + media + ")\n\n";
            }
            MessageBox.Show(s);
        }

        //Botão de Redimensionar as colunas
        private void redimensionarColunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtvPauta.Columns["colN"].Width = 40;
            dtvPauta.Columns["colNome"].Width = 150;
            dtvPauta.Columns["colFreguesia"].Width = 100;
            dtvPauta.Columns["colAno"].Width = 50;
            dtvPauta.Columns["colSexo"].Width = 40;
            dtvPauta.Columns["colPortugues"].Width = 40;
            dtvPauta.Columns["colIngles"].Width = 40;
            dtvPauta.Columns["colFilosofia"].Width = 40;
            dtvPauta.Columns["colMatematica"].Width = 40;
            dtvPauta.Columns["colFisica"].Width = 40;
            dtvPauta.Columns["colQuimica"].Width = 40;
            dtvPauta.Columns["colGeografia"].Width = 40;
            dtvPauta.Columns["colHistoria"].Width = 40;
            dtvPauta.Columns["colEducaoFisica"].Width = 40;
            dtvPauta.Columns["colMoral"].Width = 40;
            dtvPauta.Columns["colMedia"].Width = 40;
            dtvPauta.Columns["colNegativas"].Width = 60;
            dtvPauta.Columns["colEstado"].Width = 100;

        }

        //Método para inserir aluno manualmente e calcular a media e as negativas automaticamente
        private void dtvPauta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Supondo que suas colunas de notas são "Disciplina1", "Disciplina2", "Disciplina3"
                // e que "Media" e "Negativas" são as colunas onde queremos colocar o resultado
                int rowIndex = e.RowIndex;

                if (rowIndex < 0) return; // Nenhuma linha válida

                DataGridViewRow row = dtvPauta.Rows[rowIndex];

                try
                {
                    // Pega as notas (verifique se as células não estão vazias)
                    double nota1 = Convert.ToDouble(row.Cells["ColPortugues"].Value ?? 0);
                    double nota2 = Convert.ToDouble(row.Cells["colIngles"].Value ?? 0);
                    double nota3 = Convert.ToDouble(row.Cells["colFilosofia"].Value ?? 0);
                    double nota4 = Convert.ToDouble(row.Cells["colMatematica"].Value ?? 0);
                    double nota5 = Convert.ToDouble(row.Cells["colFisica"].Value ?? 0);
                    double nota6 = Convert.ToDouble(row.Cells["colQuimica"].Value ?? 0);
                    double nota7 = Convert.ToDouble(row.Cells["colGeografia"].Value ?? 0);
                    double nota8 = Convert.ToDouble(row.Cells["colHistoria"].Value ?? 0);
                    double nota9 = Convert.ToDouble(row.Cells["colEducaoFisica"].Value ?? 0);
                    double nota10 = Convert.ToDouble(row.Cells["colMoral"].Value ?? 0);
                    
                   

                    // Calcula média
                    double media = (nota1 + nota2 + nota3+nota4+nota5+nota6+nota7+nota8+nota9+nota10) / 10;

                    // Conta negativas (nota < 10 é negativa)
                    int negativas = 0;
                    if (nota1 < 10)
                    {
                        negativas=negativas+1;
                    }
                    if (nota2 < 10)
                    {
                        negativas = negativas + 1;
                    }
                    if (nota3 < 10)
                    {
                        negativas = negativas + 1;
                    }
                    if (nota4 < 10)
                    {
                        negativas = negativas + 1;
                    } 
                    if (nota5 < 10)
                    {
                        negativas = negativas + 1;
                    } 
                    if (nota6 < 10)
                    {
                        negativas = negativas + 1;
                    } 
                    if (nota7 < 10)
                    {
                        negativas = negativas + 1;
                    }
                    if (nota8 < 10)
                    {
                        negativas = negativas + 1;
                    }
                    if (nota9 < 10)
                    {
                        negativas = negativas + 1;
                    }
                    if (nota10 < 10)
                    {
                        negativas = negativas + 1;
                    }

                    //Verificar Estado do estado do formando
                    if (negativas>=3)
                    {
                        row.Cells[17].Value = "Reprovado";
                    }
                   else
                    {
                        row.Cells[17].Value = "Aprovado";
                    }

                    // Preenche as células de média e negativas
                    row.Cells[15].Value = media;
                    row.Cells[16].Value = negativas;
                }
                catch
                {
                    // Caso o valor digitado não seja número, coloca 0
                    row.Cells[15].Value = 0;
                    row.Cells[16].Value = 0;
                }
            }
        }





    }
}

