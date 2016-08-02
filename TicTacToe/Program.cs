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

        /// <summary>
        /// Überprüft ob es sich bei dem angegebenen Kommando um einen Spielzug handelt.
        /// Das ist der Fall, wenn das Kommando aus einem Buchstaben (an erster Stelle)
        /// und einer Zahl (an zweiter Stelle) besteht.
        /// </summary>
        /// <param name="kommando">Entweder ein Spielzug, oder eines der anderen gültigen
        /// Kommandos</param>
        /// <returns>true, wenn es sich um einen Spielzug (egal ob gültig oder nicht) handelt;
        /// false, wenn es sich um ein anderes (oder nicht unterstütztes) Kommando handelt.</returns>
        static bool IstSpielzug(string kommando)
        {
            // 1) Prüfen ob das Kommando länger als 2 Zeichen ist.
            // Ein Spielzug besteht immer aus exakt 2 Zeichen. Wenn das Kommando mehr Zeichen
            // enthält, dann kann es kein Spielzug sein.
            if (kommando.Length != 2)
            {
                return false;
            }

            if (!IstErstesZeichenBuchstabe(kommando))
            {
                return false;
            }

            // 3) Prüfen ob das Kommando an zweiter Stelle eine Ziffer enthält.
            // Ist das Kommando ein Spielzug, dann ist das zweite Zeichen eine Ziffer und 
            // identifiziert die Zeile der Koordinate. Ist das zweite Zeichen keine Ziffer,
            // kann das Kommando NICHT ein Spielzug sein.
            if (!Char.IsDigit(kommando[1]))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Prüft ob das Kommando als erstes einen Buchstaben enthält.
        /// Ist das Kommando ein Spielzug, dann ist das erste Zeichen ein Buchstaben und 
        /// identifiziert die Spalte der Koordinate. Ist das erste Zeichen kein Buchstabe,
        /// kann das Kommando NICHT ein Spielzug sein.
        /// </summary>
        private static bool IstErstesZeichenBuchstabe(string kommando)
        {
            if (!Char.IsLetter(kommando[0]))
            {
                return false;
            }

            return true;
        }
    }
}
