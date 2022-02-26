using System;
using POO_jogo.src.Entities;

namespace POO__jogo_
{
    class Program
    {
        static void Main(string[] args)
        {
             Hero arus = new Hero("Arus", 23, "Knight");

                Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            

             Console.WriteLine(wizard.Attack(1));
             Console.WriteLine(arus.Attack());
             
        }
    }
}
