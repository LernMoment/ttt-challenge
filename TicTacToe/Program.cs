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

            while (!IstAbbruchKommando(kommando))
            {
                Console.Write("Starte ein neues Spiel mit 'neu' und beende das Programm mit 'ende': ");
                kommando = Console.ReadLine();

                if (IstNeustartKommando(kommando))
                {
                    Spiel aktuellesSpiel = new Spiel();

                    while (!aktuellesSpiel.IstBeendet())
                    {
                        Console.WriteLine("Spieler {0} - Wo willst du deinen Spielstein setzen? ", aktuellesSpiel.AktuellerSpieler);
                        kommando = Console.ReadLine();
                        if (IstSpielzug(kommando))
                        {
                            aktuellesSpiel.SpielzugAusfuehren(ExtrahiereSpalte(kommando), ExtrahiereZeile(kommando));
                        }
                        else if (IstAbbruchKommando(kommando))
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }

        static bool IstNeustartKommando(string kommando)
        {
            return (kommando.ToLower() == "neu");
        }

        static bool IstAbbruchKommando(string kommando)
        {
            return (kommando.ToLower() == "ende");
        }

        /// <summary>
        /// Überprüft ob es sich bei dem angegebenen Kommando um einen Spielzug handelt.
        /// Das ist der Fall, wenn das Kommando aus einem Buchstaben (an erster Stelle)
        /// und einer Zahl (an zweiter Stelle) besteht.
        /// </summary>
        /// <param name="kommando"></param>
        /// <returns></returns>
        static bool IstSpielzug(string kommando)
        {
            if (kommando.Length != 2)
            {
                return false;
            }

            char spalte = ExtrahiereSpalte(kommando);
            if (!Char.IsLetter(spalte))
            {
                return false;
            }

            // wenn die Zeile keine Zahl ist, wird die Konvertierung nicht klappen!
            int zeile = ExtrahiereZeile(kommando);

            return true;
        }

        static int ExtrahiereZeile(string koordinate)
        {
            string zeile = koordinate.Substring(1, 1);

            return int.Parse(zeile);
        }

        static char ExtrahiereSpalte(string koordinate)
        {
            string spalte = koordinate.Substring(0, 1);

            return char.Parse(spalte);
        }
    }
}
