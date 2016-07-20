using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Spiel
    {
        private Spielbrett brett = new Spielbrett();

        public void EinenSpielzugAusfuehren()
        {
            brett.Anzeigen();
            brett.SpielsteinSetzen('X', 'C', 2);
            brett.Anzeigen();
        }

        public void AnderenSpielzugAusfuehren()
        {
            brett.Anzeigen();
            brett.SpielsteinSetzen('O', 'B', 1);
            brett.Anzeigen();
        }
    }
}
