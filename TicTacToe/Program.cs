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

            Spiel aktuellesSpiel = new Spiel();

            Console.WriteLine("Spieler {0} macht folgenden Zug:", aktuellesSpiel.AktuellerSpieler.ToString());
            aktuellesSpiel.SpielzugAusfuehren('A', 0);

            Console.WriteLine("Spieler {0} macht folgenden Zug:", aktuellesSpiel.AktuellerSpieler.ToString());
            aktuellesSpiel.SpielzugAusfuehren('B', 1);

            Console.WriteLine("Zum beenden RETURN (bzw. Enter) drücken.");
            Console.ReadLine();
        }
    }
}
