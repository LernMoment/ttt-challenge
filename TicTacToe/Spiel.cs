using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Spiel
    {
        private bool istSpieler1AmZug = true;
        private Spielbrett brett = new Spielbrett();

        public char AktuellerSpieler
        {
            get
            {
                if (istSpieler1AmZug == true)
                {
                    return 'X';
                }

                return 'O';
            }
        }

        public void Starten()
        {
            brett.Anzeigen();
        }

        public void SpielzugAusfuehren(char spalte, int zeile)
        {
            brett.SpielsteinSetzen(AktuellerSpieler, spalte, zeile);
            brett.Anzeigen();
            SpielerWechseln();
        }

        public bool IstBeendet()
        {
            // TODO: Gewinner ermitteln
            // TODO: Unentschieden ermitteln
            return false;
        }

        private void SpielerWechseln()
        {
            if (istSpieler1AmZug == true)
            {
                istSpieler1AmZug = false;
            }
            else
            {
                istSpieler1AmZug = true;
            }
        }
    }
}
