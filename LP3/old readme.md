# Lern-Periode 3

Max Muster

9.1.2024 bis 30.1.2024 (☃️ Sportferien)

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?

   *Zurzeit habe ich in Informatik einen 5.67 Schnitt, wobei ich bisher nur 6er und einen 5er in dem Modul M162 hatte.*
   

3. Was hatten Sie sich am Ende von LP2 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?

   *Im der letzten LP habe ich mir vorgenommen im nächsten LP strikter zu arbeiten, also meine vorgenommenen Projekte tatsächlich auch fertig zustellen anstatt an anderen Projekten zu arbeiten, welche eigentlich nichts mit dem Lernatelier zu tun haben*
   

5. Was wäre ein geeignetes Projekt würd diese LP3?

   *Den Währungsrechner mit der API fertig zu stellen*

## 9.1.2024

✍️Heute habe ich mich dazu entschieden mein Währungsrechner Projekt weiter zu schreiben und es fertig zu stellen. Ich habe mir zuerst angeschaut wir weit ich bin und habe mich mit dem Programm vertraut gemacht. Mein derzeitiger Standpunkt ist, dass ich Währungen eintragen kann und am Ende alle auflisten kann aber ich kann noch nicht auf die API zugreifen und mit den Währungen rechnen. 

## 16.1 und 23.1.2024

- [X] auf API in VS zugreifen
- [X] json Datei auslesen & auf Json Datei zugreifen
- [X] mit API werten rechnen
- [ ] Portfolio Funktion

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| -------------- | -------------------- | -------------- | -------------- | -------- |
| 1              | Postman API key      | API Code       | Daten Ausgabe als Json | Ja |
| 2              | Json Datei           | CHF            | CHF - EUR Kurs | Ja |
| 3              | Zugriff auf API Werte | CHF & USD     | CHF - USD Kurs | Ja |
| 4              | Datei mit Portfolio Daten | CHF | Listet CHF bestand auf, ändert oder erstellt neuen Bestand falls noch nicht vorhanden |          |

*Bei 2 kann nur mit EUR umgerrechnet werden, da dies hier die Basiswährung ist. Es kann also nicht CHF - USD gerrechnet werden, bei 3 jedoch schon.

✍️ Heute am 16.1 habe ich weiter an dem Fremdwährungsrechner gearbeitet und habe die API implementiert. Ich kann nun mit allen verschiedenen Kursen rechnen also auch mit CHF - USD als Beispiel. Ich habe ausserdem die Portfolio Funktion, welche ich davor schon programmiert habe mit readfile kompatibel gemacht und ich sehe nun gespeierte Werte. (andere Datei)

☝️ Vergessen Sie nicht, bis zum 16.1 einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 23.1.2024

- [ ] Ganzes Portfolio in CHF anzeigen lassen
- [ ] Portfolio Ausgabe nach Menge sortieren (CHF Menge)
- [X] Am Anfang alle Funktionen und jeweilige Befehle listen 
- [ ] Projekt abschliessen & alles nochmal testen

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 5               | Portfolio Daten      | lp (list portfolio) | gesamtes Portfolio in CHF |          |
| 6               | Portfolio Ausgabe + Daten | lp (list portfolio) | gesamtes Portfolio in CHF, sortiert nach der Menge |          |
| 7               | Nichts               | Programm starten | Alle Funktionen und Befehle formatiert gelistet  | Ja |
| 8               | fertiger Code | jeweilige inputs für die Tests | gewollte Outputs  |          |

✍️ Heute am 23.1 habe ich probiert weiter an dem Code zu arbeiten aber schon als ich ihn das erste mal getestet hab ging er nicht und gab falsche Werte bei der Kursabfrage durch. Ich habe alles probiert aber ich bekam immer nur falsche Werte obwohl es genau der gleiche Code ist wie der vor einer Woche, bei welchem alles noch ging. Ich konnte aufgrund dessen nicht weiterarbeiten und habe heute den ganzen Tag lang probiert dieses Problem zu fixxen aber ich habe es nicht geschafft. 

☝️ Vergessen Sie nicht, bis zum 23.1 Ihren fixfertigen Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 30.1.2024

✍️ Heute am 23.1 habe ich an meinem Github Profil und an der Reflexion gearbeitet. Ich habe für mein Githubprofil ein Bild ausgewählt, habe eine paar Projekte gepinnt und habe diese jeweils in einigen kurzen Sätzen beschrieben. Ich habe ausserdem probiert eine Netzseite mithilfe von Github zu erstellen doch dies hat nicht ganz funktioniert, da ich bei der Pages Seite nicht weitergekommen bin.

## Reflexion

In dieser Lernperiode habe ich probiert einen Währungsrechner zu programmieren, ich habe so etwas ähnliches schon in der Lernperiode zuvor gemacht - einen Portfoliotracker, deswegen war es auch mein Ziel diese am Ende zu kombinieren. In der ersten Woche habe ich erstmal alles geplannt und habe mich mit dem alten Code vertraut gemacht. In der zweiten Woche habe ich eine API herausgesucht und habe diese implementiert. In dieser Woche ging der ganze Code noch und ich konnte mit Währungen wie USD/CHF, EUR/CHF oder JPY/EUR rechnen. In der letzten programmier Woche ging mein Code nicht mehr, die API hat falsche Werte ausgegeben oder manchmal gar keine. Ich verstehe bis heute nicht wie er auf diese Werte gekommen ist den ich verbrauchte keine API requests und ich habe zuvor auf keine Kurse eingetragen, an diesem Tag habe ich es nicht geschaft dieses Problem zu beheben, deswegen bin ich auch stehen geblieben und konnte nicht alle meine Zielfunktionen implementieren. Da der code nun gar nicht mehr funktioniert hat habe ich ihn am Samstag probiert neu zu schreiben und die API ging plötzlich wieder, allerdings habe ich realisiert das es viel zu viele API-requests braucht und ich nur 100 pro Monat zur Verfügung habe, deswegen habe ich mich dazu entschieden alle Kurse mithilfe von einem JSON Text zu speichern und nur mit diesen anstatt den akuellen zu rechnen. Am Ende ging das Währungsrechnen allerdings konnte ich da ich so viel Zeit verschwendet habe während der Code nicht ging nicht mehr alle Features programmieren. 

Ich fand die 9-Wöchige LP etwas zu lange, ich glaube ich hätte in ihr ein langes Projekt und ein kurzes Projekt fertig stellen können, die 3-Wöchige LP war allerdings etwas zu wenig vor allem da wir effektiv nur 2 Wochen Zeit hatten um zu programmieren. Ich denke allerdings auch das ich zu grosse Ziele mit dem Projekt in der LP3 hatte und ich das niemals in 2 Wochen hätte fertigkriegen können, selbst wenn alles funktioniert hätte. 
