using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoEscolar
{
    internal class Equipa
    {
        /// <summary>
        /// Inicializar um array em que cada elemento é do tipo Ficha, sendo Ficha uma classe que reperesenta um formando,
        /// designadamente, para transportar n.º, nome, freguesia, ano de nascimento e sexo.
        /// </summary>
        /// <param name="A"></param>

        //Método para inicilalizar o array com as informações dos formandos
        public void InicializarArrayDeEquipa(ref Ficha[] A)
        {
            for (int i = 0; i < 20; i++)
            {
                A[i] = new Ficha();
            }

            A[0].numero = 1; A[0].nome = "Ana Rita Cunha"; A[0].freguesia = "Gualtar"; A[0].ano = 1997; A[0].sexo = 'F';
            A[1].numero = 2; A[1].nome = "Bela Costa Silva"; A[1].freguesia = "Maximinos"; A[1].ano = 1999; A[1].sexo = 'F';
            A[2].numero = 3; A[2].nome = "Carlos Alberto Costa"; A[2].freguesia = "Aveleda"; A[2].ano = 2000; A[2].sexo = 'M';
            A[3].numero = 4; A[3].nome = "Carlos Daniel Ferreira"; A[3].freguesia = "Gualtar"; A[3].ano = 2000; A[3].sexo = 'M';
            A[4].numero = 5; A[4].nome = "Daniel Bastos Gomes"; A[4].freguesia = "Maximinos"; A[4].ano = 2001; A[4].sexo = 'M';
            A[5].numero = 6; A[5].nome = "Daniel Silva Ferraz"; A[5].freguesia = "Ferreiros"; A[5].ano = 1997; A[5].sexo = 'M';

            A[6].numero = 7; A[6].nome = "Elvira Gomes Pendes"; A[6].freguesia = "Maximinos"; A[6].ano = 2002; A[6].sexo = 'F';
            A[7].numero = 8; A[7].nome = "Fernanda Maria Silva"; A[7].freguesia = "Aveleda"; A[7].ano = 2001; A[7].sexo = 'F';
            A[8].numero = 9; A[8].nome = "Fernando Gomes Barros"; A[8].freguesia = "Gualtar"; A[8].ano = 1997; A[8].sexo = 'M';
            A[9].numero = 10; A[9].nome = "Guilherme Alexandre Barros"; A[9].freguesia = "Aveleda"; A[9].ano = 1997; A[9].sexo = 'M';
            A[10].numero = 11; A[10].nome = "Hilda Fonseca Silva"; A[10].freguesia = "Maximinos"; A[10].ano = 1997; A[10].sexo = 'F';

            A[11].numero = 12; A[11].nome = "José Manuel Carvalho"; A[11].freguesia = "Sé"; A[11].ano = 2001; A[11].sexo = 'M';
            A[12].numero = 13; A[12].nome = "José Alberto Gomes"; A[12].freguesia = "Maximinos"; A[12].ano = 2002; A[12].sexo = 'M';
            A[13].numero = 14; A[13].nome = "Maria Silvéria Bastos"; A[13].freguesia = "Lovios"; A[13].ano = 2001; A[13].sexo = 'F';
            A[14].numero = 15; A[14].nome = "Anabela Bastos Torres"; A[14].freguesia = "Ferreiros"; A[14].ano = 1997; A[14].sexo = 'F';
            A[15].numero = 16; A[15].nome = "Rui Vasco Santos"; A[15].freguesia = "Maximinos"; A[15].ano = 2001; A[15].sexo = 'M';

            A[16].numero = 17; A[16].nome = "Otávio Ferreira"; A[16].freguesia = "Gualtar"; A[16].ano = 2002; A[16].sexo = 'M';
            A[17].numero = 18; A[17].nome = "Silvério Silva Teixeira"; A[17].freguesia = "Ferreiros"; A[17].ano = 1997; A[17].sexo = 'M';
            A[18].numero = 19; A[18].nome = "Teodoro Armando Matos"; A[18].freguesia = "Maximinos"; A[18].ano = 2004; A[18].sexo = 'M';
            A[19].numero = 20; A[19].nome = "Zacarias Alexandre Sampaio"; A[19].freguesia = "Sequeira"; A[19].ano = 1995; A[19].sexo = 'M';

        }

        //Metódo para geral um valor aleatório
        private int GeraValor()
        {   //devolve valor entre 6 e 20
            int avaliacao;
            Random r = new Random();

            avaliacao = r.Next(6, 21);
            //reduzir, mas não impossibilitar, a ocorrência de negativas e de valores acima de 18:
            if (avaliacao < 10 || avaliacao > 18) { avaliacao = r.Next(6, 21); }
            return avaliacao;
        }

        //Método que preenche uma matriz com valores aleatórios
        public int[,] InitMatriz()
        {
            int[,] m = new int[20, 10];
            int fator = 10000000;//modificar este valor se a geração ficar lenta

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k < fator; k++)
                    {
                        //diversão ao processador, 
                        //para melhorar a geração de aleatórios
                    }
                    m[i, j] = GeraValor();
                }
            }
            return m;
        }
    }
}
