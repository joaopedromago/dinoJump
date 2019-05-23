using DinoJump.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoJump.Service
{
    public static class Positions
    {
        public static string[] ObterPosicoesDino(int dinoHeight)
        {
            /*
             * ░ ░ ░ ▄ ▄ ░ ░ ░ ░ ░ 21 e 22
             * ░ ░ ░ ░ ▄ ▄ ░ ░ ░ ░ 19 e 20
             * ░ ░ ░ ░ ▄ ▄ ▄ ▄ ░ ░ 15 a 18
             * ░ ░ ░ ░ ▄ ▄ ▄ ▄ ░ ░ 11 a 14
             * ░ ░ ░ ░ ▄ ░ ░ ░ ░ ░ 10
             * ░ ░ ░ ▄ ▄ ░ ░ ░ ░ ░ 8 e 9
             * ░ ▄ ▄ ▄ ▄ ▄ ░ ░ ░ ░ 3 a 7
             * ░ ░ ░ ▄ ░ ▄ ▄ ░ ░ ░ 0 a 2
             *       0   1 2
             */
            var retorno = new string[23];
            retorno[0] = ((Entities._lines-1) - (dinoHeight + 1)) + "," + 4;
            retorno[1] = ((Entities._lines-1) - (dinoHeight + 1)) + "," + 6;
            retorno[2] = ((Entities._lines-1) - (dinoHeight + 1)) + "," + 7;

            retorno[3] = ((Entities._lines-1) - (dinoHeight + 2)) + "," + 1;
            retorno[4] = ((Entities._lines-1) - (dinoHeight + 2)) + "," + 2;
            retorno[5] = ((Entities._lines-1) - (dinoHeight + 2)) + "," + 3;
            retorno[6] = ((Entities._lines-1) - (dinoHeight + 2)) + "," + 4;
            retorno[7] = ((Entities._lines-1) - (dinoHeight + 2)) + "," + 5;

            retorno[8] = ((Entities._lines-1) - (dinoHeight + 3)) + "," + 3;
            retorno[9] = ((Entities._lines-1) - (dinoHeight + 3)) + "," + 4;

            retorno[10] = ((Entities._lines-1) - (dinoHeight + 4)) + "," + 4;

            retorno[11] = ((Entities._lines-1) - (dinoHeight + 5)) + "," + 4;
            retorno[12] = ((Entities._lines-1) - (dinoHeight + 5)) + "," + 5;
            retorno[13] = ((Entities._lines-1) - (dinoHeight + 5)) + "," + 6;
            retorno[14] = ((Entities._lines-1) - (dinoHeight + 5)) + "," + 7;

            retorno[15] = ((Entities._lines-1) - (dinoHeight + 6)) + "," + 4;
            retorno[16] = ((Entities._lines-1) - (dinoHeight + 6)) + "," + 5;
            retorno[17] = ((Entities._lines-1) - (dinoHeight + 6)) + "," + 6;
            retorno[18] = ((Entities._lines-1) - (dinoHeight + 6)) + "," + 7;

            retorno[19] = ((Entities._lines-1) - (dinoHeight + 7)) + "," + 4;
            retorno[20] = ((Entities._lines-1) - (dinoHeight + 7)) + "," + 5;

            retorno[21] = ((Entities._lines-1) - (dinoHeight + 8)) + "," + 3;
            retorno[22] = ((Entities._lines-1) - (dinoHeight + 8)) + "," + 4;

            return retorno;
        }

        public static string[] ObterPosicoesObjeto(int posicaoObjeto)
        {
            /*
               ░ ░ ░ ░ ░ ░ ░ ░ ░ ░
               ░ ░ ░ ░ ╬ ╬ ░ ░ ░ ░
               ░ ░ ░ ╬ ░ ░ ╬ ░ ░ ░
               ░ ░ ░ ░ ╬ ╬ ░ ░ ░ ░
               ░ ░ ░ ╬ ╬ ╬ ╬ ░ ░ ░
               ░ ░ ╬ ╬ ░ ░ ╬ ╬ ░ ░
               ░ ░ ░ ░ ░ ░ ░ ░ ░ ░
               ░ ░ ░ ░ ░ ░ ░ ░ ░ ░
             */
            var retorno = new string[14];
            retorno[0] = (Entities._lines - 3) + "," + posicaoObjeto;
            retorno[1] = (Entities._lines - 3) + "," + (posicaoObjeto + 1);
            retorno[2] = (Entities._lines - 3) + "," + (posicaoObjeto + 4);
            retorno[3] = (Entities._lines - 3) + "," + (posicaoObjeto + 5);

            retorno[4] = (Entities._lines - 4) + "," + (posicaoObjeto + 1);
            retorno[5] = (Entities._lines - 4) + "," + (posicaoObjeto + 2);
            retorno[6] = (Entities._lines - 4) + "," + (posicaoObjeto + 3);
            retorno[7] = (Entities._lines - 4) + "," + (posicaoObjeto + 4);

            retorno[8] = (Entities._lines - 5) + "," + (posicaoObjeto + 2);
            retorno[9] = (Entities._lines - 5) + "," + (posicaoObjeto + 3);

            retorno[10] = (Entities._lines - 6) + "," + (posicaoObjeto + 1);
            retorno[11] = (Entities._lines - 6) + "," + (posicaoObjeto + 4);

            retorno[12] = (Entities._lines - 7) + "," + (posicaoObjeto + 2);
            retorno[13] = (Entities._lines - 7) + "," + (posicaoObjeto + 3);

            return retorno;
        }
    }
}
