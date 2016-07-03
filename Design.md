# Designdokument - TicTacToe

## Ziel

In diesem Dokument werden grundsätzliche Überlegungen zum Design für die Umsetzung der TicTacToe C# Challenge beschrieben.

## Klassen und Verantwortlichkeiten

Im Rahmen der Domänenanalyse wurden folgende Klassen und Verantwortlichkeiten identifiziert:

 - **Spielbrett -** modelliert das physische Spielbrett. Dabei weiß es welche Spielfelder besetzt sind. Hat nichts mit weiteren Regeln und der Darstellung des Spiels zutun!
  - Existiert so lange das Spiel andauert
  - Enthält 9 Spielfelder die über Spalten und Zeilen identifiziert werden können
  - Im Rahmen eines Spielzugs markiert es ein Spielfeld als besetzt für den angegebenen Spieler
  - Kann feststellen ob das im Spielzug angegebene Spielfeld existiert
  - Kann feststellen ob das im Spielzug angegebene Spielfeld besetzt ist
 - **Spiel -** modelliert die Interaktion der beiden Spieler während des Spielablaufs. Ist eher als Fassade zu sehen und hast nichts mit der Darstellung zutun!
  - Zeigt an welcher Spieler den nächsten Spielzug machen darf
  - Führt einen Spielzug (unter Angabe der vom Spieler genannten Koordinate) für den aktuellen Spieler aus
  - Wechselt den Spieler nach einem erfolgreichen Spielzug
  - Zeigt den aktuellen Status an: Warten auf Spieler, Ungültiger Spielzug, Spielende
  - Zeigt den aktuellen Spielstand an: Unbekannt, Unentschieden, Spieler 1 hat gewonnen, Spieler 2 hat gewonnen
 - **Spielzug -** modelliert den Ablauf von der Eingabe einer Koordinate bis hin zum erfolgreichen Setzen eines Spielsteins auf ein Spielfeld oder der Feststellung, dass der Spielzug ungültig war.
  - Weiß welcher Spieler seinen Spielstein auf welches Spielfeld setzen will
  - Zeigt an ob ein Spielzug erfolgreich oder ungültig ist
  - Zeigt an warum ein Spielzug ungültig ist: ungültige Koordinate, Koordinate nicht auf Spielbrett, Spielfeld bereits besetzt

## Abläufe - Domänenebene

### Spiel starten

 1. Jeder der 2 Spieler sucht sich einen Spielstein aus
 2. Das Spielfeld wird aufgemalt
 3. Die Spieler stimmen ab, wer den ersten Zug macht

### Spielen

 1. Die Spieler führen abwechselnd einen Spielzug aus

### Spielzug ausführen

 1. Der Spieler der dran ist, malt seinen Spielstein in ein leeres Feld auf dem Spielbrett
 2. Die Spieler überprüfen ob das Spiel weiter geht, oder beendet ist (Unentschieden bzw. Gewonnen)

## Abläufe - Designebene

### UC1 - Spielstarten

 1. Benutzer startet die Anwendung
 2. Das System zeigt ein leeres Spielfeld und die zur Verfügung stehenden Kommandos an.
 3. System fordert ersten Spieler auf seine Eingabe zu machen.

### UC2 - Spiel beenden

 1. Benutzer gibt das Kommando "ende" ein
 2. Das aktuelle Spiel wird abgebrochen
 3. Die Anwendung wird beendet

### UC3 - Spiel neu starten

 1. Benutzer gibt das Kommando "neustart" ein
 2. Das aktuelle Spiel wird abgebrochen
 3. Ein leeres Spielbrett wird angezeigt
 4. System fordert ersten SPieler auf seine Eingabe zu machen

### UC4 - Spielzug ausführen

 1. Spieler der dran ist macht seine Eingabe (zwischen A0 und C2)
 2. System stellt fest, dass das eingegebene Feld auf dem Spielbrett noch nicht besetzt ist
 3. System belegt Feld auf dem Spielbrett mit dem Symbol des Spielers
 4. System zeigt Spielbrett erneut an
 5. System überprüft, dass das Spiel noch nicht beendet ist
 6. System fordert den anderen Spieler auf seine Eingabe zu machen

Alternativen zu Schritt **1**:

 a. Eingabe ist kein gültiges Feld auf dem Spielbrett
  1. Spielbrett wird nochmals ohne Änderungen angezeigt
  2. Spieler wird aufgefordert eine gültige Eingabe
  3. Ablauf startet erneut bei Schritt 1

Alternativen zu Schritt **2**:

 a. System stellt fest, dass das ausgewählte Feld auf dem Spielbrett bereits besetzt ist
  1. Spielbrett wird nochmals ohne Änderungen angezeigt
  2. Spieler wird aufgefordert eine gültige Eingabe
  3. Ablauf startet erneut bei Schritt 1

Alternativen zu Schritt **5**:

 a. System stellt fest, dass der aktuelle Spieler 3 Felder in einer Spalte, Zeile oder Diagonalen belegt hat
  1. System zeigt an, dass der aktuelle Spieler gewonnen hat
  2. System fordert Spieler auf ein neues Spiel zu starten oder die Anwendung zu beenden
 b. System stellt fest, dass kein weiterer Spielzug möglich ist
  1. System zeigt an, dass das Spiel unentschieden ist
  2. System fordert Spieler auf ein neues Spiel zu starten oder die Anwendung zu beenden

## Abläufe - Implementierungsebene

### Benutzereingabe verarbeiten

 1. Überprüfen ob die Eingabe ein Kommando ("neu" oder "ende") ist. Wenn ja entsprechend ausführen.
 2. Eingabe wird in Koordinate umgewandelt, wenn das möglich ist. Wenn nicht, handelt es sich um einen ungültigen Spielzug der wiederholt werden muss.
 3. Es wird kontrolliert ob die Koordinate auf dem Spielbrett liegt. Wenn nicht, handelt es sich um einen ungültigen Spielzug der wiederholt werden muss.
 4. Es wird festgestellt ob das Spielfeld mit der entsprechenden Koordinate bereits besetzt ist. Wenn ja, handelt es sich um einen ungültigen Spielzug der wiederholt werden muss.
 5. Das Spielfeld mit der entsprechenden Koordinate wird als besetzt markiert vom angegebenen Spieler
 6. Der Spielzug ist beendet
 7. Nach jedem Spielzug wird kontrolliert ob das Spiel beendet ist
