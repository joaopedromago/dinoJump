using DinoJump.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoJump.Service
{
    public class Moves
    {
        public static bool _chegouAoTopo = false;
        public static bool _movimentavel = true;
        public static void Movimentar()
        {

            Moves.LerMovimento(Entities._speed);
                    
            if (Entities._movimento != 0)
            {
                Entities._dinoHeight += Entities._movimento;

                if (Entities._dinoHeight >= Entities._dinoMaxHeight && 
                    Entities._movimento > 0 && 
                    !_chegouAoTopo)
                {
                    _chegouAoTopo = true;
                    Entities._movimento *= -1;
                }

                if(Entities._dinoHeight <= 1 && Entities._movimento < 0)
                {
                    Entities._dinoHeight = 1;
                    Entities._movimento = 0;
                    _movimentavel = true;
                    _chegouAoTopo = false;
                }
            }
        }
        public static void LerMovimento(int speed)
        {
            var beginWait = DateTime.Now;
            bool movimentoApertado = false;

            while (DateTime.Now.Subtract(beginWait).TotalMilliseconds < speed)
            {
                if (!movimentoApertado)
                {
                    if (Console.KeyAvailable)
                    {
                        var ch = Console.ReadKey(true).Key;

                        switch (ch)
                        {
                            case ConsoleKey.UpArrow:
                                MoverParaCima(2);
                                break;
                            case ConsoleKey.Spacebar:
                                MoverParaCima(3);
                                break;
                            case ConsoleKey.DownArrow:
                                    MoverParaBaixo(-3);
                                break;
                        }
                    }
                }
            }
        }

        public static void RestarMovimentos()
        {
            _movimentavel = false;
            _chegouAoTopo = false;
        }

        public static void MoverParaCima(short quant)
        {
            if (_chegouAoTopo && _movimentavel)
            {
                RestarMovimentos();
                Entities._movimento = quant;
            }
            else if(!_chegouAoTopo)
            {
                Entities._movimento = quant;
            }
        }
        public static void MoverParaBaixo(short quant)
        {
            if (!_chegouAoTopo)
            {
                Entities._movimento = quant;
            }
        }
    }
}
