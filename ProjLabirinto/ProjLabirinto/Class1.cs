using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Labirinto
{
    class Program
    {
        private static string[,] inicio = new string[8, 20] //matriz com a forma do título do jogo
        {
            {"               ", "   ", "   ", "   ", "   ", "   ", "     ", "   ", "   ", "   ", "     ", "   ", "   ", "   ", "   ", "     ", "   ", "   ", "   ", "   "},
            {"               ", " # ", " # ", " # ", " # ", " # ", "     ", " # ", " # ", " # ", "     ", " # ", " # ", " # ", " # ", "     ", " # ", " # ", " # ", "   "},
            {"               ", " # ", "   ", " # ", "   ", " # ", "     ", " # ", "   ", " # ", "     ", "   ", "   ", "   ", " # ", "     ", " # ", "   ", "   ", "   "},
            {"               ", " # ", "   ", " # ", "   ", " # ", "     ", " # ", "   ", " # ", "     ", "   ", "   ", " # ", "   ", "     ", " # ", " # ", " # ", "   "},
            {"               ", " # ", "   ", " # ", "   ", " # ", "     ", " # ", " # ", " # ", "     ", "   ", " # ", "   ", "   ", "     ", " # ", "   ", "   ", "   "},
            {"               ", " # ", "   ", "   ", "   ", " # ", "     ", " # ", "   ", " # ", "     ", " # ", "   ", "   ", "   ", "     ", " # ", "   ", "   ", "   "},
            {"               ", " # ", "   ", "   ", "   ", " # ", "     ", " # ", "   ", " # ", "     ", " # ", " # ", " # ", " # ", "     ", " # ", " # ", " # ", "   "},
            {"               ", "   ", "   ", "   ", "   ", "   ", "     ", "   ", "   ", "   ", "     ", "   ", "   ", "   ", "   ", "     ", "   ", "   ", "   ", "   "},
        };

        private static string[,] labirinto = new string[8, 11] //matriz com a forma do labirinto nível 1
        {
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", " - ", " - ", " - ", "|+|", " - ", " - ", " - "},
            {"                        ", "|+|", "|+|", "|+|", " - ", "|+|", " - ", "|+|", " - ", "|+|", "|+|"},
            {"                        ", "|+|", " - ", " - ", " - ", "|+|", " - ", "|+|", " - ", "|+|", "|+|"},
            {"                        ", "|+|", " - ", "|+|", "|+|", "|+|", " - ", "|+|", " - ", "|+|", "|+|"},
            {"                        ", "|+|", " - ", "|+|", "|+|", "|+|", " - ", "|+|", " - ", "|+|", "|+|"},
            {"                        ", "|+|", " - ", "|+|", "|+|", "|+|", " - ", " - ", " - ", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
        };

        private static string[,] labirinto2 = new string[10, 13] //matriz com a forma do labirinto nível 2
        {
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", " - ", " - ", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|"},
            {"                        ", "|+|", " - ", "|+|", "|+|", "|+|", " - ", "|+|", " - ", " - ", "|+|", " - ", "|+|"},
            {"                        ", "|+|", " - ", "|+|", " # ", "|+|", " - ", "|+|", "|+|", " - ", "|+|", " - ", "|+|"},
            {"                        ", "|+|", " - ", "|+|", " - ", "|+|", " - ", "|+|", "|+|", " - ", "|+|", " - ", "|+|"},
            {"                        ", "|+|", " - ", " - ", " - ", "|+|", " - ", "|+|", "|+|", " - ", "|+|", " - ", "|+|"},
            {"                        ", "|+|", "|+|", " - ", "|+|", "|+|", " - ", "|+|", " - ", " - ", " - ", " - ", "|+|"},
            {"                        ", "|+|", "|+|", " - ", "|+|", "|+|", " - ", "|+|", " - ", "|+|", "|+|", " - ", " - "},
            {"                        ", "|+|", "|+|", " - ", " - ", " - ", " - ", "|+|", " - ", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
        };

        private static string[,] labirinto3 = new string[15, 15] //matriz com a forma do labirinto nível 3
        {
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " # ", "|+|", "|+|", " # ", " - ", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", " - ", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", " - ", " - ", " - ", " - ", " - ", " - ", " - ", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", " # ", "|+|", " - ", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", " - ", "|+|", " - ", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", " - ", "|+|", " - ", "|+|", " - ", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", " - ", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", " - ", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", " - ", " - ", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", " - ", " - ", "|+|"},
            {"                        ", "|+|", "|+|", " # ", " - ", ">:(", " - ", " - ", " - ", " - ", " - ", "|+|", " - ", " # ", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
        };

        private static string[,] labirinto4 = new string[20, 20] //vetor com a forma do labirinto nível 4
        {
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", " # ", " - ", " - ", " - ", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", " # ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", " # ", " - ", " - ", "|+|", " - ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", ">:(", " - ", " - ", " - ", " - ", " # ", "|+|", "|+|", "|+|", "|+|", "|+|"},
            {"                        ", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|", "|+|"},
        };

        static string jogador = labirinto[6, 2] = "-@-"; //setando a posição de cada posLinha e posColuna para setar o jogador
        static int posLinha = 6;
        static int posColuna = 2;

        static string jogador2 = labirinto2[1, 2] = "-@-"; //setando a posição de cada posLinha e posColuna para setar o jogador
        static int posLinha2 = 1;
        static int posColuna2 = 2;

        static string jogador3 = labirinto3[1, 13] = "-@-"; //setando a posição de cada posLinha e posColuna para setar o jogador
        static string inimigo1 = labirinto3[13, 5] = ">:("; //setando a posição do inimigo
        static int vidas = 3;
        static int posLinha3 = 1;
        static int posColuna3 = 13;

        static string jogador4 = labirinto4[1, 9] = "-@-"; //setando a posição de cada posLinha e posColuna para setar o jogador
        static string inimigo4 = labirinto4[18, 9] = ">:("; //setando a posição do inimigo
        static int posLinha4 = 1;
        static int posColuna4 = 9;

        private static Random _random = new Random(); //variável random para a cor aleatória no menu
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor)); //cor aleatória no menu do jogo
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }

        static void Main(string[] args)
        {
        bool iniciar = false;
            while (!iniciar){ //condição no menu do jogo, enquanto for falso, continuar executando
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.BackgroundColor = GetRandomConsoleColor();
                Console.Clear();
                Console.WriteLine("\n\n\n\n                Boas-vindas ao String");
                for (int linha = 0; linha < 8; linha++)
                {
                    for (int coluna = 0; coluna < 20; coluna++)
                    {
                        Console.Write(inicio[linha, coluna]);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("\n\n\n\nPressione Enter para começar!");
                //Console.Beep();
                ConsoleKeyInfo key2;
                key2 = Console.ReadKey(true);
                if (key2.Key == ConsoleKey.Enter) //quando pressionar enter, a condição iniciar será verdadeira, quebrando o laço.
                {
                    iniciar = true;
                }

            }

            Console.BackgroundColor = ConsoleColor.White; //setando a cor de fundo do console como branca
            Console.ForegroundColor = ConsoleColor.Black; //setando a cor da letra do console como preta
            Console.Clear();

            bool fimdejogo = false;
            labirinto[6, 2] = jogador; //setando posição do jogador no labirinto 1

            while (!fimdejogo)
            {
                Console.Clear();

                Console.Write("\n                  Nível 1\n\n");
                for (int linha = 0; linha < 8; linha++) //for para fazer o labirinto um, montando coluna e linha
                {
                    for (int coluna = 0; coluna < 10; coluna++)
                    {
                        Console.Write(labirinto[linha, coluna]);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("\n                  Para onde deseja ir?\n");
                Console.WriteLine("                  > Use as setas do teclado para cada direção\n");

                ConsoleKeyInfo key;
                key = Console.ReadKey(true); //console readkey para ler uma tecla do teclado.
                if (key.Key == ConsoleKey.UpArrow) //se a tecla for setinha para cima,
                {
                    if (labirinto[posLinha - 1, posColuna] != "|+|") // o jogador irá se mover 1 linha anterior, se o quadrado não for igual a "|+|"(parede)
                    {
                        labirinto[posLinha, posColuna] = " - ";
                        posLinha--; //diminui uma linha no poslinha, para não perder a contagem
                    }
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (labirinto[posLinha, posColuna - 1] != "|+|")
                    {
                        labirinto[posLinha, posColuna] = " - ";
                        posColuna--;
                    }
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    if (labirinto[posLinha, posColuna + 1] != "|+|")
                    {
                        labirinto[posLinha, posColuna] = " - ";
                        posColuna++;
                    }
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    fimdejogo = true;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (labirinto[posLinha + 1, posColuna] != "|+|")
                    {
                        labirinto[posLinha, posColuna] = " - ";
                        posLinha++;
                    }
                }
                labirinto[posLinha, posColuna] = jogador;

                if (labirinto[1, 9] == jogador) //condição, se o jogador estiver na posição linha 1, coluna 9, fim de jogo = true.
                {
                    fimdejogo = true;
                    Console.Beep();    //som do console quando o jogador passar o nível 1.
                    Console.WriteLine("                  Parabéns! você concluiu o nível 1!");
                    System.Threading.Thread.Sleep(2000); //espera de 2 segundos depois que o jogador chegar no ponto final do labirinto 1
                }
            }

            bool fimdejogo2 = false;
            labirinto2[1, 2] = jogador2;

            while (!fimdejogo2)
            {
                Console.BackgroundColor = ConsoleColor.Cyan; //cor de fundo do console
                Console.ForegroundColor = ConsoleColor.Black; //cor das letras do console
                Console.Clear();

                Console.WriteLine("\n                  Nível 2, pegue a chave '#' para completar a fase!\n");

                for (int linha = 0; linha < 10; linha++)
                {
                    for (int coluna = 0; coluna < 13; coluna++)
                    {
                        Console.Write(labirinto2[linha, coluna]);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("\n           Para onde deseja ir?\n");
                Console.WriteLine("           > Use as setas do teclado para cada direção\n");

                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (labirinto2[posLinha2 - 1, posColuna2] != "|+|")
                    {
                        labirinto2[posLinha2, posColuna2] = " - ";
                        posLinha2--;
                    }
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (labirinto2[posLinha2, posColuna2 - 1] != "|+|")
                    {
                        labirinto2[posLinha2, posColuna2] = " - ";
                        posColuna2--;
                    }
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    fimdejogo2 = true;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    if (labirinto2[posLinha2, posColuna2 + 1] != "|+|")
                    {
                        labirinto2[posLinha2, posColuna2] = " - ";
                        posColuna2++;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (labirinto2[posLinha2 + 1, posColuna2] != "|+|")
                    {
                        labirinto2[posLinha2, posColuna2] = " - ";
                        posLinha2++;
                    }
                }
                labirinto2[posLinha2, posColuna2] = jogador2;
                if (labirinto2[3, 4] == jogador2) //se o jogador estiver na linha 3, coluna 4, a posição da linha atual + 5 e posição da coluna atual + 3
                    //será " - " abrindo espaço para o jogador passar e completar o nível
                {
                    labirinto2[posLinha2 + 5, posColuna2 + 3] = " - "; //posição que será aberta no nível 1.
                }

                if (labirinto2[7, 12] == jogador2)
                {
                    fimdejogo2 = true;
                    Console.Beep();
                    Console.WriteLine("                  Parabéns! você concluiu o nível 2!");
                    System.Threading.Thread.Sleep(2000);
                }
            }

            Console.BackgroundColor = ConsoleColor.Black; //seta a cor de fundo do console como preta
            Console.ForegroundColor = ConsoleColor.White; //seta a cor das letras do console como branca
            Console.Clear();

            bool fimdejogo3 = false;
            labirinto3[1, 13] = jogador3; //posição do jogador 3 no labirinto
            labirinto3[13, 5] = inimigo1; //posição do inimigo no labirinto

            while (!fimdejogo3)
            {
                Console.Clear();

                Console.Write("\n                  Nível 3, colete todas as chaves para completar o nível!\n\n");
                Console.Write("                  Você possui: " + Convert.ToInt32(vidas) + " vidas\n\n\n"); //mostra a quantia atual de vidas
                for (int linha = 0; linha < 15; linha++)
                {
                    for (int coluna = 0; coluna < 15; coluna++)
                    {
                        Console.Write(labirinto3[linha, coluna]);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("\n\n                  Para onde deseja ir?\n");
                Console.WriteLine("                  > Use as setas do teclado para cada direção\n");

                if (labirinto3[13, 5] == jogador3) //se encostar no inimigo, perderá 1 de vida
                {
                    vidas --; //diminui 1 nas vidas
                    labirinto3[13, 5] = ">:("; //refaz o local do inimigo após o jogador encostar nele
                    posLinha3 = posLinha3 - 12; //seta a posição linha do jogador, fazendo-o voltar 12 linhas atrás
                    posColuna3 = posColuna3 + 8;//seta a posição coluna do jogador, fazendo-o avanças 8 colunas, voltando ao ponto inicial
                    if (vidas <= 0) //se as vidas forem menores que 0, fimdejogo 3 será verdadeira, juntamente com fimdejogo4.
                    {
                        fimdejogo3 = true;
                        Console.WriteLine("                   Você não completou sua missão >:(");
                    }
                }
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (labirinto3[posLinha3 - 1, posColuna3] != "|+|")
                    {
                        labirinto3[posLinha3, posColuna3] = " - ";
                        posLinha3--;
                    }
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (labirinto3[posLinha3, posColuna3 - 1] != "|+|")
                    {
                        labirinto3[posLinha3, posColuna3] = " - ";
                        posColuna3--;
                    }
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    if (labirinto3[posLinha3, posColuna3 + 1] != "|+|")
                    {
                        labirinto3[posLinha3, posColuna3] = " - ";
                        posColuna3++;
                    }
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    fimdejogo3 = true;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (labirinto3[posLinha3 + 1, posColuna3] != "|+|")
                    {
                        labirinto3[posLinha3, posColuna3] = " - ";
                        posLinha3++;
                    }
                }
                labirinto3[posLinha3, posColuna3] = jogador3;
                if (labirinto3[1, 12] == jogador3) // se o jogador estiver nesta posição, uma passagem será aberta no poslinha atual +6
                {//e no poscoluna + 3, abrindo uma passagem para continuar o nível
                    labirinto3[posLinha3 + 6, posColuna3] = " - ";
                }
                if (labirinto3[13, 13] == jogador3)
                {
                    labirinto3[posLinha3, posColuna3 - 2] = " - ";
                }
                if (labirinto3[13, 3] == jogador3)
                {
                    labirinto3[posLinha3 - 6, posColuna3 + 6] = " - ";
                }
                if (labirinto3[5, 10] == jogador3) // se o jogador estiver nesta posição, uma passagem será aberta nas posições abaixo
                {
                    labirinto3[10, 9] = " - "; //forma simplificada de liberar o caminho, sem fazer + ou - a posição atual
                    labirinto3[10, 8] = " - ";
                    labirinto3[10, 7] = " - ";
                    labirinto3[10, 6] = " - ";
                    labirinto3[10, 5] = " - ";
                    labirinto3[10, 4] = " - ";
                    labirinto3[10, 3] = " - ";
                    labirinto3[11, 3] = " - ";
                    labirinto3[12, 3] = " - ";
                }

                if (labirinto3[13, 3] == jogador3)
                {
                    labirinto3[9, 3] = " - ";
                    labirinto3[8, 3] = " - ";
                    labirinto3[7, 3] = " - ";
                    labirinto3[6, 3] = " - ";
                    labirinto3[5, 3] = " - ";
                    labirinto3[4, 3] = " - ";
                    labirinto3[3, 3] = " - ";
                    labirinto3[2, 3] = " - ";
                    labirinto3[1, 3] = " - ";
                    labirinto3[1, 4] = " - ";
                    labirinto3[1, 5] = " - ";
                    labirinto3[1, 6] = " - ";
                    labirinto3[1, 7] = " - ";
                    labirinto3[1, 8] = " - ";
                }

                if (labirinto3[1, 9] == jogador3)
                {
                    fimdejogo3 = true;
                    Console.Beep();
                    Console.WriteLine("                  Parabéns! você concluiu o nível 3!");
                    System.Threading.Thread.Sleep(4000);
                }
            }

            bool fimdejogo4 = false;
            labirinto4[1, 9] = jogador3;

            while (!fimdejogo4)
            {
                Console.BackgroundColor = ConsoleColor.Magenta; //seta a cor do console como magenta
                Console.ForegroundColor = ConsoleColor.Black; //seta a cor da fonte do console como preta
                Console.Clear();

                Console.Write("\n                  Você possui: " + Convert.ToInt32(vidas) + " vidas\n\n"); //mostra a vida atual do jogador

                for (int linha = 0; linha < 20; linha++)
                {
                    for (int coluna = 0; coluna < 20; coluna++)
                    {
                        Console.Write(labirinto4[linha, coluna]);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("\n           Para onde deseja ir?\n");
                Console.WriteLine("           > Use as setas do teclado para cada direção\n");

                if (vidas <= 0)
                {
                    fimdejogo4 = true;
                    Console.WriteLine("Você fracassou em sua missão! agora todos estão perdidos no labirinto :(");
                }

                if (labirinto4[18, 9] == jogador4) //se o jogador encostar nessa posição, perde vida e retorna ao ponto inicial
                {
                    vidas--;
                    labirinto4[18, 9] = ">:("; //refaz o inimigo após o jogador encostar nele
                    posLinha4 = 1; //forma simplificada de voltar com o jogador para o ponto inicial
                    posColuna4 = 9;
                }
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (labirinto4[posLinha4 - 1, posColuna4] != "|+|")
                    {
                        labirinto4[posLinha4, posColuna4] = " - ";
                        posLinha4--;
                    }
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (labirinto4[posLinha4, posColuna4 - 1] != "|+|")
                    {
                        labirinto4[posLinha4, posColuna4] = " - ";
                        posColuna4--;
                    }
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    fimdejogo4 = true;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    if (labirinto4[posLinha4, posColuna4 + 1] != "|+|")
                    {
                        labirinto4[posLinha4, posColuna4] = " - ";
                        posColuna4++;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (labirinto4[posLinha4 + 1, posColuna4] != "|+|")
                    {
                        labirinto4[posLinha4, posColuna4] = " - ";
                        posLinha4++;
                    }
                }
                labirinto4[posLinha4, posColuna4] = jogador4;
                if (labirinto4[3, 9] == jogador4)
                {
                    labirinto4[2, 10] = " - ";
                    labirinto4[2, 8] = " - ";
                    labirinto4[2, 7] = " - ";
                    labirinto4[2, 11] = " - ";
                }
                if (labirinto4[4, 9] == jogador4)//se o jogador estiver nesta posição, as paredes ao lado da posição inicial serão abertas.
                {
                    labirinto4[3, 10] = " - ";
                    labirinto4[3, 8] = " - ";
                    labirinto4[3, 7] = " - ";
                    labirinto4[3, 11] = " - ";
                    labirinto4[3, 12] = " - ";
                    labirinto4[3, 6] = " - ";
                }

                if (labirinto4[3, 9] == jogador4) //se o jogador estiver nesta posição, as paredes ao redor irão fechar
                {
                    labirinto4[3, 10] = "|+|";
                    labirinto4[3, 8] = "|+|";
                    labirinto4[3, 7] = "|+|";
                    labirinto4[3, 11] = "|+|";
                    labirinto4[3, 12] = "|+|";
                    labirinto4[3, 6] = "|+|";
                }

                if (labirinto4[2, 9] == jogador4)
                {
                    labirinto4[2, 10] = "|+|";
                    labirinto4[2, 8] = "|+|";
                    labirinto4[2, 7] = "|+|";
                    labirinto4[2, 11] = "|+|";
                }

                if (labirinto4[17, 9] == jogador4)//se o jogador estiver nesta posição(chave) as paredes nas coordenadas abaixo serão abertas.
                {
                    labirinto4[17, 8] = " - ";
                    labirinto4[17, 7] = " - ";
                    labirinto4[17, 6] = " - ";
                }

                if(labirinto4[17, 5] == jogador4)
                {
                    labirinto4[16, 5] = " - "; //caminho que será aberto se o jogador estiver nessa posição
                    labirinto4[15, 5] = " - ";
                    labirinto4[14, 5] = " - ";
                    labirinto4[13, 5] = " - ";
                    labirinto4[12, 5] = " - ";
                    labirinto4[11, 5] = " - ";
                    labirinto4[10, 5] = " - ";
                    labirinto4[9, 5] = " - ";
                    labirinto4[8, 5] = " - ";
                    labirinto4[7, 5] = " - ";
                    labirinto4[6, 5] = " - ";
                    labirinto4[5, 5] = " - ";
                    labirinto4[4, 5] = " - ";
                }

                if (labirinto4[3, 2] == jogador4)
                {
                    labirinto4[17, 10] = " - ";
                }

                if (labirinto4[18, 14] == jogador4 && vidas > 0) //verifica se o jogador está na posição final, se estiver e vidas for maior que 0, jogo concluido!
                {
                    fimdejogo4 = true;
                    Console.WriteLine("         Parabéns! você conluiu o String Maze! :D");
                    Console.Beep();
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }
    }
}
