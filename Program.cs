using System;
using abstraindo_um_jogo_de_rpg.src.Entities;

namespace abstraindo_um_jogo_de_rpg
{
    class Program
    {   
        static void Main(string[] args)
        {
            knight arus = new knight("Arus", 23, "knight");
            Wizard wizard = new Wizard("Jennica", 23,"white wizard");
            Ninja wedge = new Ninja(" Webge ", 42, "Ninja");
            Black_Wizard black_Wizard = new Black_Wizard  ("Topapa", 42,"Black_Wizard");
        
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(arus .Attack());
            Console.WriteLine(wedge.Attack(1));
            Console.WriteLine(wedge.Attack(7));
            Console.WriteLine(black_Wizard .Attack());
            

        }
    }
}