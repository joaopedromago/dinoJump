using DinoJump.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoJump.Service
{
    public static class Render
    {
        public static void CriarRender(char[,] tela, int pontuacaoValue, ConsoleColor corTela)
        {
            Enemies.RendenizarInimigos();
            var stringTela = Rendenizar(tela);
            ExibirTela(stringTela, pontuacaoValue, corTela);

            var teste = Entities._objetos;
        }
        private static string Rendenizar(char[,] tela)
        {
            var display = "";
            for (var l = 0; l < tela.GetLength(0); l++)
            {
                for (var c = 0; c < tela.GetLength(1); c++)
                {
                    display += $"{tela[l, c]} ";
                }
                display += "\n";
            }
            return display;
        }
        private static void ExibirTela(string tela, int pontuacaoValue, ConsoleColor corTela)
        {
            var titulo = "Dino Jump ~";
            var pontuacao = $"Pontuação Atual: {pontuacaoValue}";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(titulo);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(pontuacao);

            Console.ForegroundColor = corTela;
            Console.WriteLine(tela);
            Console.ForegroundColor = ConsoleColor.White;

            //Console.Clear();

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, 0);
        }
    }
}
