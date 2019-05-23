using System;
using System.Collections.Generic;
using System.Text;
using DinoJump.Model;

namespace DinoJump.Service
{
    public static class Jogo
    {
        public static void Jogar()
        {
            Entities._pontuacao = 0;
            Entities._dinoHeight = 1;
            Entities._jogoPerdido = false;
            Entities._movimento = 0;
            Entities._objetos = new List<int>();
            Moves._chegouAoTopo = false;
            Moves._movimentavel = true;

            Console.Clear();
            Emjogo();
        }

        public static void Emjogo()
        {
            while (!Entities._jogoPerdido)
            {
                Entities._tela = Screen.MontarTela(Entities._dinoHeight, Entities._objetos);
                Render.CriarRender(Entities._tela, Entities._pontuacao, Entities._corTela);
                GameOver.ValidarGameOver();
                Moves.Movimentar();
            }

            GameOver.MensagemGameOver();
            Console.ReadKey();
            Jogar();
        }

    }
}
