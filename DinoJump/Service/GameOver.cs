﻿using DinoJump.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinoJump.Service
{
    public static class GameOver
    {
        public static void ValidarGameOver()
        {
            if (Entities._objetos.Any())
            {
                if (Entities._objetos.Min() < 8 && Entities._dinoHeight < 6)
                {
                    Entities._jogoPerdido = true;
                }
            }
        }

        public static void MensagemGameOver()
        {
            var mensagemDerrota =
   @"
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░█▌░░█▌░░░█▌█▌░░░░░█▌█▌░█▌█▌█▌░░░░░░░░░░░░
░░░░░░░░░░░░░░░█▌░░█▌░█▌░░░░█▌░█▌░░░░░█▌░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░█▌░░█▌░█▌░░░░█▌░█▌░░░░░█▌█▌█▌░░░░░░░░░░░░
░░░░░░░░░░░░░░░█▌░░█▌░█▌░░░░█▌░█▌░░░░░█▌░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░█▌░░░░░█▌█▌░░░░░█▌█▌░█▌█▌█▌░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░█▌░░█▌░░░░░█▌█▌░░░░░█▌█▌░░░░░░█▌█▌░░░█▌█▌█▌░█▌░░░░█▌░
░█▌░░█▌░░█▌░█▌░░░░█▌░█▌░░░░█▌░░█▌░░░░█▌░█▌░░░░░█▌░░░░█▌░
░█▌░░█▌░░█▌░█▌░░░░█▌░█▌█▌█▌░░░░█▌█▌█▌░░░█▌█▌█▌░█▌░░░░█▌░
░█▌░░█▌░░█▌░█▌░░░░█▌░█▌░░█▌░░░░█▌░░█▌░░░█▌░░░░░█▌░░░░█▌░
░█▌░░░░░░█▌░░░█▌█▌░░░█▌░░░░█▌░░█▌░░░░█▌░█▌█▌█▌░░░█▌█▌░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░███████████████████████████░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░████▀░░░░░░░░░░░░░░░░░▀████░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░███│░░░░░░░░░░░░░░░░░░░│███░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░██▌│░░░░░░░░░░░░░░░░░░░│▐██░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░██░└┐░░░░░░░░░░░░░░░░░┌┘░██░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░██░░└┐░░░░░░░░░░░░░░░┌┘░░██░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░██▌░│██████▌░░░▐██████│░▐██░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░███░│▐███▀▀░░▄░░▀▀███▌│░███░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░████▄─┘██▌░░░░░░░▐██└─▄████░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░███████▄░░░░░░░░░░░▄███████░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░███████████████████████████░░░░░░░░░░░░░░";

            Console.Clear();
            Console.WriteLine(mensagemDerrota);
        }
    }
}