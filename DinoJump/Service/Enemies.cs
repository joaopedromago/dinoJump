using DinoJump.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinoJump.Service
{
    public static class Enemies
    {
        public static void RendenizarInimigos()
        {
            Entities._contadorCriacaoInimigos++;

            if (Entities._contadorCriacaoInimigos >= Entities._limiteCriacaoInimigos)
            {
                CriarInimigo();
            }

            MoverInimigos();
        }

        public static void MoverInimigos()
        {
            var novasPosicoes = new List<int>();

            foreach (var item in Entities._objetos)
            {
                if (item > 0)
                {
                    novasPosicoes.Add(item - 1);
                }
            }

            Entities._objetos = novasPosicoes;
        }

        public static void CriarInimigo()
        {
            Random rnd = new Random();

            if (rnd.Next(0, 10) == 1)
            {
                Entities._contadorCriacaoInimigos = 0;
                Entities._objetos.Add(Entities._columns);
            }
        }
    }
}
