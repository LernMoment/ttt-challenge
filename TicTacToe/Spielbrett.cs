using System;

namespace TicTacToe
{
    class Spielbrett
    {
        private static string[] spalteA = { " ", " ", " " };
        private static string[] spalteB = { " ", " ", " " };
        private static string[] spalteC = { " ", " ", " " };

        public static void SpielsteinSetzen(char symbol, char spalte, int zeile)
        {
            if (symbol != 'X' && symbol != 'O')
            {
                // hier die Verwendung von Exceptions
                throw new ArgumentOutOfRangeException("symbol", "Nur X und O sind zulässige Symbole!");
                // Alternativ kannst du auch einfach die Methode verlassen:
                // return;
            }

            if ((zeile < 0) || (zeile > 2))
            {
                // hier die Verwendung von Exceptions
                throw new ArgumentOutOfRangeException("zeile", "Nur Zeile zwischen 0 und 2 sind zulässig!");
                // Alternativ kannst du auch einfach die Methode verlassen:
                // return;
            }

            switch (spalte)
            {
                case 'A':
                    spalteA[zeile] = symbol.ToString();
                    break;
                case 'B':
                    spalteB[zeile] = symbol.ToString();
                    break;
                case 'C':
                    spalteC[zeile] = symbol.ToString();
                    break;
                default:
                    // hier die Verwendung von Exceptions
                    throw new ArgumentOutOfRangeException("spalte", "Nur die Spalten A, B und C sind zulässig!");
                    // Alternativ kannst du auch einfach die Methode verlassen:
                    // return;
                    break;
            }
        }

        public static void Anzeigen()
        {
            string zeileNull = "0 " + spalteA[0] + " | " + spalteB[0] + " | " + spalteC[0] + " ";
            string zeileEins = "0 " + spalteA[1] + " | " + spalteB[1] + " | " + spalteC[1] + " ";
            string zeileZwei = "0 " + spalteA[2] + " | " + spalteB[2] + " | " + spalteC[2] + " ";

            Console.WriteLine("  A   B   C ");
            Console.WriteLine(zeileNull);
            Console.WriteLine(" ---+---+---");
            Console.WriteLine(zeileEins);
            Console.WriteLine(" ---+---+---");
            Console.WriteLine(zeileZwei);
        }
    }
}
