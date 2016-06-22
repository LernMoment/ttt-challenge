# Projektstart Workshop

In diesem Dokument findest du alle wichtigen Informationen, die wir im "Projektstart-Workshop" der Challenge besprochen haben.

## Ziel definieren

Ziel der Challenge ist es die [Application Kata - Tic Tac Toe](https://app.box.com/s/0474qkr7huwjo2mf607c) umzusetzen. Dafür werden wir eine C#-Konsolenanwendung schreiben mit der 2 Spieler Tic Tac Toe (oder kurz TTT) spielen können. Weitere Katas findest du übrigens bei der [Clean Code Developer School](http://ccd-school.de/coding-dojo/).

Im Fokus steht

 - Erstellen eines objektorientierten und evolvierbaren Designs
 - Iteratives vorgehen beim Erstellen von Design und Quellcode
 - Umsetzung in C#
 - Verwendung von GitHub
 
Nicht berücksichtigt werden

 - Üben / Lernen wie Anforderungen definiert werden
 - Die Anwendung intensiv testen
 - Release - Die Anwendung zum Kunden bekommen
 - Dokumentation

## Projektumfeld analysieren

Wenn du dein eigenes Projekt startest oder an einem bestehenden mitarbeiten willst, ist es wichtig, dass du das Projektumfeld kennst und insbesondere die Beziehungen zwischen den Projektbeteiligten verstanden hast. Arbeitest du für dich ganz alleine an einem Projekt ist das relativ einfach. Möchtest du jedoch etwas Unterstützung haben, oder willst du dich gar an einem großen Projekt beteiligen, ist das schon etwas kompilizierter.

Für diese Challenge wollen wir einzeln entwickeln, aber die Möglichkeit haben Fragen zu unserem aktuellen Quellcode zu stellen und bei Bedarf auch Änderungen von anderen Entwicklern zu integrieren.

## Infrastruktur aufsetzen

Basierend auf den beiden vorherigen Aktivitäten (Ziel definieren und Projektumfeld analysieren) können wir nun entscheiden welche Werkzeuge wir einsetzen wollen und können diese einrichten, so dass wir mit der Entwicklung starten können.

### GitHub - Versionierung & Kollaboration

Wie du weißt bin ich ein großer Freund von Versionierung. Dieses ist für mich einer der wichtigsten Praktiken von professioneller Softwareentwicklung überhaupt. Zum Start eines Projekts kannst du untern Umständen zwischen verschiedenen Werkzeugen für die Versionierung auswählen. Einige der gängisten sind:

 - tbd

Wie wir im Abschnitt "Projektumfeld analysieren" ermittelt haben geht es allerdings nicht nur darum, dass wir unseren Quellcode versionieren können, sondern auch, dass wir unseren Quellcode gegenseitig sehen können und auch kommentieren können. Daher habe ich dieses GitHub-Projekt erstellt.

Folgende Punkte solltest du umsetzen um einen leichten Start in die Challenge zu haben:

 - Ein eigenes Projekt auf GitHub für die Challenge starten
 - Dich kurz in [diesem Issue](https://github.com/LernMoment/ttt-challenge/issues/1) vorstellen und den Link zu deinem GitHub-Projekt einfügen. Damit habe ich und alle anderen Teilnehmer einen Überblick wer alles mitmacht und können helfen und kommentieren.

### Visual Studio

Ich werde in Visual Studio in der Community Edition entwickeln. Das ist somit auch was du in den Videos sehen wirst, wenn ich dir zeige wie ich konkrete Aufgaben gelöst habe. Du bist bei der Wahl deiner Entwicklungsumgebung komplett frei. Allerdings kann ich dir nur bei Fragen rund um Visual Studio helfen.

Der erste Schritt ist das Anlegen eines Konsolenprojekts und das synchronisieren mit dem GitHub-Porjekt. Damit habe wir eine solide Ausgangsbasis für den ersten Quellcode.

Wichtig ist mir an dieser Stelle noch, dass wir möglichst immer eine lauffähige Version unserer Anwendung haben. Selbst, wenn wie jetzt zu Anfang, noch nichts passiert, aber wir können die Anwendung ohne Fehler kompilieren und ausführen. Das sollte auch immer das Ziel einer jeden Änderung sein.

## Grobdesign erstellen

- Strukturelemente
 - Spielbrett (Anzahl: 1)
  - Koordinaten (Anzahl: von A0 bis C2)
   - Zeile (0 - 2)
   - Spalte (A - C)
   - Diagonale
  - Spielstein (Anzahl: zwischen 3 und 5 je Spieler)
 - Spieler (Anzahl: 2)
  - Spielsteine mit bestimmten Symbolen
  - Nur ein Spieler kann Gewinner sein
- Interaktionen
 - Spiel starten
 - Spiel neu starten
 - Spiel beenden
 - Spieler macht einen Zug
 - Spielzug überprüfen
 - Spielfeld anzeigen (inkl. Koordinaten und den Spielsteinen der beiden Spieler)
 - Hinweis anzeigen ob der Spielzug gültig war
 - Hinweis anzeigen welcher Spieler gewonnen hat
 - Hinweis anzeigen welche Kommandos es gibt
 - Spielregeln anzeigen?

