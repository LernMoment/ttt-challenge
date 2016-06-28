using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WILLKOMMEN zu LernMoment's TicTacToe!!!");
            Console.WriteLine();
            string kommando = "unbekannt";

            while (kommando.ToLower() != "ende")
            {
                Console.Write("Starte ein neues Spiel mit 'neu' und beende das Programm mit 'ende': ");
                kommando = Console.ReadLine();

                if (kommando.ToLower() == "neu")
                {
                    Spielbrett aktuellesSpiel = new Spielbrett();
                    aktuellesSpiel.Anzeigen();
                    aktuellesSpiel.SpielsteinSetzen('X', 'A', 1);
                    aktuellesSpiel.Anzeigen();
                }
            }
        }
    }
}
