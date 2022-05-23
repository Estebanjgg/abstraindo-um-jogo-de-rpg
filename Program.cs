using System;
using abstraindo_um_jogo_de_rpg.src.Entities;

namespace abstraindo_um_jogo_de_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus", 23, "knight");
        

            Console.Write(hero.ToString());
        }
    }
}