# Lern-Periode 4

Florian Ruby

20.2 bis 2.4.2024

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
     Seit der letzten LP haben wir noch keine neuen NOten bekommen, deswegen stehen diese immernoch genau gleich.
3. Was hatten Sie sich am Ende von LP2 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?
     Am Ende der LP2 habe ich mir vorgenommen strikter bei dem Projekt zu sein und nicht von meinem originallen Projekt abzuweichen.
5. **Neu**: Was möchten Sie Neues lernen?
     Wie man mit Winforms arbeitet und grosse Mengen an Bilder mit dazugehörigen Daten in Winforms benutzen kann
7. Was wäre ein geeignetes Projekt für diese LP4?
     Flaggen Tiktaktoe 
## 20.2.2024

✍️ Heute habe ich mich für ein neues Projekt entschieden, ein Tiktaktoe bei welchem man Flaggen auf dem 3x3 Feld sieht und nie Namen der jeweiligen Ländern auschreiben muss zu welchen die Flaggen gehören, es sollte auch verschiedene Schwierigkeitsstufen geben. Nachdem ich mir Gedanken über mein Projekt gemacht habe, habe ich an der LB des Moduls 164 weitergearbeitet und bin jetzt etwa zur hälfte fertig. 

Ich habe mir überlegt das ich zuerst ein normales Tiktaktoe programmiere und danach and dem Flaggen Tiktaktoe arbeite. 

## 27.2.2024

- [X] Mit Winforms experimentieren
- [X] Felder erstellen mit Klick funktion
- [X] Sieger bestimmungsfunktion

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1 | VS mit winforms geöffnet | Objekte einfügen | Objekte erscheinen | X |
| 2 | Felder  | Klick auf Feld  |  Änderung der Farbe des Feldes oder signalisierung zu welchem Spieler das Feld gehört | X |
| 3 | 3 Felder in einer Reihe/Linie | Automatisch | Fenster das signalisiert wer gewonnen hat | X |

✍️ Heute habe ich die Grundbasis für das TicTacToe, sprich ein normales TicTacToe ohne Flaggen erstellt, welches ich mithilfe eines Youtube Videos geschafft habe. Ich kann jetzt alle verschiedenen Felder anklicken, ich sehe welcher Spieler die jeweiligen Felder angeklickt hat oder wer an der Reihe ist, man sieht nun wer gewonnen/verloren hat oder falls es ein Unentschieden gab und man sieht auch wer wie oft schon gewonnen hat. 

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 05.03.2024

- [X] Entschieden welche Flaggen ich benutzen will (welche Länder, simplifizierte Versionen oder nicht etc.)
- [X] Alle Flaggen in gleicher Grösse und Qualität als Datei bekommen
- [X] Entscheiden zu welcher Schwierigkeit welche Flagge gehört (einfach, mittel, schwer)
- [X] Flaggen testweise in Winforms einfügen

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1 | Browser | Liste an Flaggen finden | Entscheidung für Flaggen (Liste) getroffen | Ja |
| 2 | Browser  | Suche nach Flaggen & falls nicht in richtiger Grösse = zuschneiden |  Flaggen Dateien in richtiger Grösse etc in einem Ordner | Ja |
| 3 | Flaggen Dateien | Einteilung | Flaggen Datei entweder in Ordner einfach, mittel oder schwer  | Ja |
| 4 | Flaggen Dateien | winforms code/Toolbox item | Flagge wird angezeigt |  |

✍️ Heute habe ich mich für alle Länder entschlossen, welche ich einbeziehen will. Ich habe mich für die 193 UN Mitgliedstaaten entschieden und habe darauf hin ein Dokument mit allen Ländern Alphabetisch sortiert erstellt. Ich habe ausserdem auch jede einezelne Flagge heruntergeladen und dann diese nach der Schwierigkeit in entweder Einfach, Mittel oder Schwierig einsortiert. Ich habe dazu für jede einzelne Schwierigkeitsstufe ein Dokument erstellt mit den Namen der einzelnen Länder. Heute habe ich es allerdings nicht geschafft diese Flaggen bereits in Winforms einzufügen. 

## 12.03.2024

- [X] Flaggen testweise in Winforms einfügen
- [X] Flaggen und Flaggennamen als Array speichern und Zufallsgenerator für diese
- [X] Alle Flaggen in gleicher Grösse und Qualität in Winforms einfügen
- [X] Alle Flaggen in gleicher Grösse und Qualität in Winforms einfügen 

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1 | Alle Flaggen als einzelne Datei | Flagge in Winforms einfügen | Flagge erscheint | Ja |
| 2 | Flaggen und Länder als Liste + Zufallsgenerator  | Programm startet | Länder Name wird angezeigt | Nein |
| 3 | Flaggen und Länder als Liste + Zufallsgenerator | Programm startet | Länder Name **& Flagge** wird angezeigt  | Nein |
| 4 | Flaggen und Länder als Liste + Zufallsgenerator | Programm startet | Länder Name **& Flagge** wird angezeigt  | Nein |

✍️ Heute habe ich mich um die Implementierung des Zufallsgenerator und der Flaggen gekümmert, ich habe den ganzen Code geschrieben und er sollte in der Theorie eigentlich auch funktionieren aber meine PictureBox's zeigen bisher noch keine Flagen an. Ich werde mich beim nächsten mal darum kümmern diesen Fehler zu beheben.

## 19.03.2024

- [X] Flaggen werden angezeigt
- [X] Flaggen werden angezeigt
- [ ] Box in welcher man Namen der Flagge eingeben kann
- [ ] Check ob der Name richtig oder Falsch ist 

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1 | Flaggen und Länder als Liste + Zufallsgenerator | Programm startet | Flagge erscheint automatisch | Ja |
| 2 | Flaggen und Länder als Liste + Zufallsgenerator | Programm startet | Flagge erscheint automatisch | Ja |
| 3 | Flaggen werden angezeigt | neues Box fenster | Ländernamen sind eingebbar  |  |
| 4 | Flaggen werden angezeigt | Name eingeben | Richtiger/Falscher Name wird erkannt  |  |

✍️ Heute konnte ich nicht viel machen da ich einen Bug in VS hatte und der der Designer nicht geladen hat. Ich habe probiert den Bug zu beheben aber ich habe im Internet nicht viel gefunden, was auch funktioniert hat. Eine möglichkeit ist es ganz Windows neu zu installieren und VS danach auch neu zu installieren aber ich wollte dies noch nicht versuchen, vor allem weil es bei mir zu Hause ging. Ich konnte allerdings den Zufallsgenerator der Flaggen fertiggstellen und man sieht jetzt auf jedem Feld eine zufällige Flagge. Bei manchen Flaggen Dateien muss ich allerdings noch den Namen anpassen, was ich bisher noch nicht machen konnte, da ich dazu auf den Designer zugreifen muss. 

## 26.03.2024

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1 | Flaggen werden angezeigt | neues Box fenster | Ländernamen sind eingebbar  |  |
| 1 | Wer Flagge richtig erraten hat wird angezeigt | Name eingeben | Richtiger/Falscher Name wird erkannt  |  |
| 3 | Wer Flagge richtig erraten hat wird angezeigt | Name eingeben | Richtiger/Falscher Name wird erkannt  |  |
| 4 | Neues Spiel Fenster | Spiel fertig | Neues Spiel, JA/NEIN  |  |

✍️ Heute konnte ich leider nicht so viel machen. Ich habe nach Ihrem Rat ein neues Projekt erstellt, dieses mal .net und habe probiert den abgeänderten code stückweise herein zu kopieren, allerdings habe ich bei .net einen Debugg Fehler direkt am Anfang bekommen, da ein Debug Profil nicht existierte oder eine andere wichtige Datei in dem gleichen Ordner fehlte. Ich habe danach probiert alles in ein normales Winforms Projekt herein zu kopieren und bin gerade daran dies zu tun. 

## 02.04.2024

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1 | Flaggen werden angezeigt | neues Box fenster | Ländernamen sind eingebbar  |  |
| 1 | Wer Flagge richtig erraten hat wird angezeigt | Name eingeben | Richtiger/Falscher Name wird erkannt  |  |
| 3 | Wer Flagge richtig erraten hat wird angezeigt | Name eingeben | Richtiger/Falscher Name wird erkannt  |  |

✍️ Heute habe ich weiter daran gearbeitet den Code neu zu schreiben, ich hatte allerdings wieder das gleiche Problem sodass ich den Designer nicht öffnen konnte und nur den code neu geschrieben habe ohne die Felder (zb image oder Texbox) zu erstellen. 

## Reflexion
In dieser Lernperiode habe ich probiert ein Tictactoe, bei welchem man Flaggennamen eingeben muss um die Felder zu bekommen zu programmieren. Ich habe am Anfang mithilfe eines Youtube tutorials ein normales Tictactoe programmiert um herauszufinden wie dies eigentlich funktioniert. Danach habe ich probiert das auf jedem Feld zufällige Flaggen angezeigt werden, was ich auch geschafft habe, danach musste ich nur noch die Funktion einfügen das man den Namen der Flagge eingeben kann und das man dann auch dieses Feld bekommt, allerdings hatte ich an diesem Punkt das Problem das ich den Winforms Designer nicht mehr öffnen konnte und somit konnte ich leider auch kein Textfeld einfügen, mit welchem man die Namen eingibt. Ich habe fast zwei Wochen lang probiert dieses Problem zu beheben, jedoch habe ich es allerdings nicht geschaft und habe danach probiert den ganzen Code effizienter neu zu schreiben. Bei diesem Prozess hatte ich allerdings auch wieder das gleiche Problem und somit konnte ich zwar den Code neu schreiben aber ich konnte keine Textfelder PictureBoxes etc einfügen und somit funktioniert das ganze Programm zwar  in der Theorie aber nicht in Wirklichkeit. 

