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

            if (IstSpielzug("B1"))
            {
                Console.WriteLine("ERFOLG: Der Algorithmus erkennt eine Koordinate als Spielzug.");
            }
            else
            {
                Console.WriteLine("FEHLER: Der Algorithmus erkennt eine Koordinate NICHT als Spielzug!");
            }

            if (IstSpielzug("ende"))
            {
                Console.WriteLine("FEHLER: Der Algorithmus sieht das ENDE-Kommando als Spielzug an.");
            }
            else
            {
                Console.WriteLine("ERFOLG: Der Algorithmus sieht das ENDE-Kommando NICHT als Spielzug an.");
            }

            Console.WriteLine("Zum beenden RETURN (bzw. Enter) drücken.");
            Console.ReadLine();
        }

        static bool IstSpielzug(string kommando)
        {
            return false;
        }
    }
}
