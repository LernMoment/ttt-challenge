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

            // Erstes Spiel wird gestartet
            Console.WriteLine();
            Console.WriteLine("ERSTES Spiel:");
            Spiel aktuellesSpiel = new Spiel();
            aktuellesSpiel.EinenSpielzugAusfuehren();

            // Neues Spiel wird gestartet
            Console.WriteLine();
            Console.WriteLine("ZWEITES Spiel:");
            aktuellesSpiel = new Spiel();
            aktuellesSpiel.AnderenSpielzugAusfuehren();

            Console.WriteLine("Zum beenden RETURN (bzw. Enter) drücken.");
            Console.ReadLine();
        }
    }
}
