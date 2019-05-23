using System;
using System.Collections.Generic;
using System.Text;

namespace DinoJump.Model
{
    public static class Entities
    {
        public static int _lines { get; set; } = 40;
        public static int _columns { get; set; } = 70;
        public static int _dinoMaxHeight { get; set; } = 17;
        public static int _limiteCriacaoInimigos { get; set; } = _lines / 2;
        public static int _contadorCriacaoInimigos { get; set; } = _limiteCriacaoInimigos;

        public static int _pontuacao { get; set; } = 0;
        public static int _dinoHeight { get; set; } = 1;
        public static short _movimento { get; set; } = 0; //> 0 subindo, < 0 = descendo
        public static List<int> _objetos { get; set; } = new List<int>();
        public static ConsoleColor _corTela { get; set; } = ConsoleColor.White;
        public static char[,] _tela { get; set; } = new char[_lines, _columns];
        public static bool _jogoPerdido { get; set; } = false;
        public static int _speed { get; set; } = 10;
    }
}
