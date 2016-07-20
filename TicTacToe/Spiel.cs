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
        private bool istSpielerEinsAmZug = true;

        public char AktuellerSpieler
        {
            get
            {
                if (istSpielerEinsAmZug == true)
                {
                    return 'X';
                }

                return 'O';
            }
        }

        public void SpielzugAusfuehren(char spalte, int zeile)
        {
            brett.SpielsteinSetzen(AktuellerSpieler, spalte, zeile);
            brett.Anzeigen();
            SpielerWechseln();
        }

        private void SpielerWechseln()
        {
            if (istSpielerEinsAmZug == true)
            {
                istSpielerEinsAmZug = false;
            }
            else
            {
                istSpielerEinsAmZug = true;
            }
        }
    }
}
