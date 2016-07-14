using System;

namespace TicTacToe
{
    class Spielbrett
    {
        private static string[] spalteA = { " ", " ", " " };
        private static string[] spalteB = { " ", " ", " " };
        private static string[] spalteC = { " ", " ", " " };

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
