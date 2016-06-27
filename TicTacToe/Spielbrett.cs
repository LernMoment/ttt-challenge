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
                throw new ArgumentOutOfRangeException("symbol", "Nur X und O sind zulässige Symbole!");
            }

            if ((zeile < 0) || (zeile > 2))
            {
                throw new ArgumentOutOfRangeException("zeile", "Nur Zeile zwischen 0 und 2 sind zulässig!");
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
                    throw new ArgumentOutOfRangeException("spalte", "Nur die Spalten A, B und C sind zulässig!");
                    break;
            }
        }

        public static void Anzeigen()
        {
            Console.WriteLine("  A   B   C ");
            Console.WriteLine($"0 {spalteA[0]} | {spalteB[0]} | {spalteC[0]} ");
            Console.WriteLine(" ---+---+---");
            Console.WriteLine($"1 {spalteA[1]} | {spalteB[1]} | {spalteC[1]} ");
            Console.WriteLine(" ---+---+---");
            Console.WriteLine($"2 {spalteA[2]} | {spalteB[2]} | {spalteC[2]} ");
        }
    }
}
