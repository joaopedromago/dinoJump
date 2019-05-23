using DinoJump.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoJump.Service
{
    public class Screen
    {
        public static char _ground = '▓';
        public static char _sky = '░';
        public static char _dino = '▄';
        public static char _obstacle = '╬';

        public static int dinoHeight;
        public static List<int> objetos;

        public static char[,] MontarTela(int dinoHeightGet, List<int> objetosGet)
        {
            dinoHeight = dinoHeightGet;
            objetos = objetosGet;

            var retorno = new char[Entities._lines, Entities._columns];

            for (int l = 0; l < retorno.GetLength(0); l++)
            {
                for (int c = 0; c < retorno.GetLength(1); c++)
                {
                    retorno[l, c] = RetornarValorPosicao(l, c);
                }
            }

            return retorno;
        }

        private static char RetornarValorPosicao(int l, int c)
        {
            if (ValidarPosicaoDino(l, c))
            {
                return _dino;
            }

            if (ValidarPosicaoObjetos(l, c))
            {
                return _obstacle;
            }

            if (l >= (Entities._lines - 3))
            {
                return _ground;
            }

            return _sky;
        }

        private static bool ValidarPosicaoDino(int l, int c)
        {
            var posicoesDino = Positions.ObterPosicoesDino(dinoHeight);

            var stringL = l.ToString();
            var stringC = c.ToString();

            foreach (var posicao in posicoesDino)
            {
                var splitPosicao = posicao.Split(",");
                if (splitPosicao[0] == stringL && splitPosicao[1] == stringC)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ValidarPosicaoObjetos(int l, int c)
        {
            var stringL = l.ToString();
            var stringC = c.ToString();

            foreach (var objeto in objetos)
            {
                var posicoesObjeto = Positions.ObterPosicoesObjeto(objeto);

                foreach (var posicao in posicoesObjeto)
                {
                    var splitPosicao = posicao.Split(",");
                    if (splitPosicao[0] == stringL && splitPosicao[1] == stringC)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

    }
}
