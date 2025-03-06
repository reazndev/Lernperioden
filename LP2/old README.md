# Lernperiode2

## Grob-Planung
Florian Ruby
20.10.2023 bis 22.12.2023 (🎄 Weihnachtsferien)

### Leit-Satz
In meinem zweiten Projekt möchte ich einen Währungsrechner programmieren, welcher zur Verwaltung eines Fremdwährungsportfolios genutzt werden kann. Er soll sich in der Basisversion Wechselkurse und in einer Erweiterung auch Marktentwicklungen selbständig über das Internet beziehen. Das technische Augenmerk liegt hier auf dem programmatischen Bezug von Informationen aus dem Internet und der Umrechnung der Währung. Um dises Projekt umsetzen zu können brauche ich eine API mit welcher ich Zugriff auf aktuelle Währungskurse habe, danach muss ich diese Daten automatisch in eine Datenbank eintragen um diese dann analysieren zu können und Gewinne, Verluste oder sonstiges wie prozentuale Veränderungen errechnen zu können. (99)

### Arbeitspakete für 24.10.2023
- [x] C# Projekt aufsetzen & weitere Vorgehensweise plannen.
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Projekt aufsetzen | `Code` | `Output`      |

- [x] Datenbank in welcher ich Währungen eintragen kann und wie viel ich von dieser habe.

| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datenbank | `Währungsname & Menge` | `Währung & Menge ist aufrufbar`|

Heute habe ich alles geschafft was ich mir vorgenommen hatte. 
Ich konnte das Projekt schnell aufsetzen und konnte mir auch schon einmal überlegen wie ich es angehen will. 
Danach habe ich zwei leere arrays erstellt, einen für den Währungsnamen und einen für die Menge. Darauf hin habe ich den Code geschrieben, welcher nach dem Währungsname & der Menge fragt. Danach habe ich eine formatiere Ausgabe mithilfe von [Microsoft](https://learn.microsoft.com/de-de/dotnet/api/system.console.writeline?view=net-7.0) erstellt, ich habe auch ChatGPT benutzt da ich nicht mit der Formatierung zufrieden war, da die Menge sich je nach grösse zu weit nach Links verschoben hat. Jetzt kann sich die Menge nur noch nach Rechts verschieben und es sieht nun so aus: 

![image](https://github.com/FlorianRuby/Lernperiode2/assets/142885331/59d9ac3d-d631-4df8-ab70-8483e232a295)


### Arbeitspakete für 31.10.2023
- [X] richtige API finden & herausfinden wie man diese API benutzt
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| API recherche | `nichts (sollte automatisch gehen sobald das Program offen ist)` | `Wechselkurse`      |

- [X] richtige API finden & herausfinden wie man diese API benutzt
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| API recherche | `nichts (sollte automatisch gehen sobald das Program offen ist)` | `Wechselkurse`      |

- [ ] Währungsmenge in CHF rechnen

| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `Währung & Menge` | `Menge umgerrechnet in CHF`|

- [ ] Währungsmenge wird in CHF angegeben mit Kursveränderung in der letzten Woche
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei & API | `n bei "Wollen sie noch weitere Währungen eintragen?"` | `Kursveränderungen in der letzten Woche in Prozent`      |

Ich konnte heute nicht alles schaffen, ich habe jetzt zwar die API und kann Wechselkurse aufrufen, aber ich kann diese noch nicht automatisch in Visual Studio abrufen, ich muss zuerst diese selbst herüberkopieren. Deswegen bin ich auch nach der API Aufgabe stecken geblieben und habe den Rest nicht geschaft. Sobald ich diese Hürde überwältigt habe sollte es aber schnell gehen da diese Aufgaben nicht lange dauern.

### Arbeitspakete für 07.11.2023

- [ ] Währungsmenge in CHF rechnen

| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `Währung & Menge` | `Menge umgerrechnet in CHF`|

- [ ] Währungsmenge wird in CHF angegeben mit Kursveränderung in der letzten Woche
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei & API | `n bei "Wollen sie noch weitere Währungen eintragen?"` | `Kursveränderungen in der letzten Woche in Prozent`      |

- [ ] Währungsmenge etc in einer Datei speichern und dann diese wieder auslesen
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `nichts, sollte automatisch am Anfang und am Ende passieren` | `derzeitiger Wert des Portfolios`      |

Heute habe ich nicht an meinem Projekt weiter gearbeitet sondern an dem Mahara Portfolio des Modules 319 gearbeitet, da wir dieses am Donnerstag abgeben müssen. 
Ich habe Beiträge zu den Themen Konventionen, Programmierfehler, Funktionen und zu dem Compiler gemacht. Ich bin jetzt eigentlich fast fertig mit dem Portfoliobeitrag und muss den Rest noch in meiner Freizeit machen, was aber nicht viel ist. Ich werde die Arbeitsmodule von dieser Woche einfach auf dei nächste verlegen.

### Arbeitspakete für 14.11.2023

- [ ] Währungsmenge in CHF rechnen

| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `Währung & Menge` | `Menge umgerrechnet in CHF`|

- [ ] Währungsmenge wird in CHF angegeben mit Kursveränderung in der letzten Woche
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei & API | `n bei "Wollen sie noch weitere Währungen eintragen?"` | `Kursveränderungen in der letzten Woche in Prozent`|

- [ ] Währungsmenge etc in einer Datei speichern und dann diese wieder auslesen
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `nichts, sollte automatisch am Anfang und am Ende passieren` | `derzeitiger Wert des Portfolios`|

Heute habe ich leider nicht viel geschaft da ich die ganze Sache mit der API noch einmal neu machen musste, da mein Login nicht mehr funktionierte und ich so meinen Account bei dem Exchange API Anbieter und bei Postman verloren habe. Danach habe ich probiert die API in Visual Studio zu bekommen was allerdings schwer war da alle Youtube Tutourials nur für VS Code waren und nicht für VS, deswegen habe ich es mit chatGPT probiert aber der dieser einen Wissensstand von 2021 hat wusste er nicht das manche Plugins abgeändert wurden. Nach zwei Stunden habe ich es dann geschaft den API Wert durch das Programm selbst zu bekommen aber dann trat ein neuer Fehler auf: System.ArgumentNullException: 'Value cannot be null. (Parameter 'key')'. Deswegen habe ich mich dazu entschieden dieses Programm in meiner Freizeit fertig zu schreiben oder zumindestens versuchen zu verstehen wie APIs funktionieren. Nächste Woche werde ich also mit Herr Paucar und Herr Muic zusammen an unserem Kanti Programmierprojekt arbeiten?

### Arbeitspakete für 21.11.2023

- [x] Tabelle mit Teilkostenrechnung erstellen
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `Zahlen für die Rechnung` | `Tabelle`|

- [x] Tabelle mit Teilkostenrechnung erstellen
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `Zahlen für die Rechnung` | `Tabelle`|

- [x] Tabelle mit Teilkostenrechnung erstellen
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `Zahlen für die Rechnung` | `Tabelle`|

- [x] Tabelle mit Teilkostenrechnung erstellen
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `Zahlen für die Rechnung` | `Tabelle`|

*Wir haben gerade erst angefangen deswegen wissen wir noch nicht richtig was wir alles machen müssen, deswegen sind die Arbeitspakete auch so spärrlich.
Heute haben wir an dem Programmierprojekt der Kanti Lehrpersonen weitergearbeitet, wir haben heute an der Plannung gearbeitet, einen PAP erstellt etc. Wir haben auch mit dem Code angefangen und die Anfrage nach den verschiedenen Daten, die wir später brauchen erstellt. Hier ist ein Code Beispiel: 
![image](https://github.com/FlorianRuby/Lernperiode2/assets/142885331/a5f24252-bf1f-42c6-a0ef-8e2b081dc187)

### Arbeitspakete für 28.11.2023

- [x] Code schreiben der eine Tabelle erstellt

| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Code | `Zahlen wie Nettoerlös` | `Tabelle`|

- [x] Code schreiben der eine Tabelle erstellt
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Code | `Zahlen wie Nettoerlös` | `Tabelle`|

- [x] Code schreiben der eine Tabelle erstellt
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Code | `Zahlen wie Nettoerlös` | `Tabelle`|



*Wir haben am Projekt weiter am Projekt gearbeitet und sind sehr gut weit vorangekommen, wir haben an der Ausgabe der Tabelle mithilfe von der Console gearbeitet und sind da schon fast fertig. Das einzige was wir noch machen müssen ist das wir die Ausgabe jetzt noch formatieren müssen, da sie gerade sehr komisch aussieht.*

### Arbeitspakete für 05.12.2023

- [X] Ausgabe formatieren
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Formatierungscode code | `Werte` | `Formatierte Tabelle`      |

- [X] Ausgabe formatieren
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Formatierungscode code | `Werte` | `Formatierte Tabelle`      |

- [X] Dokumentation nachführen
      
Da wir schon am Freitag mit dem Code für das Projekt fertig wurden habe ich heute an meinem Modul 162 Portfolio gearbeitet welches wir am Donnerstag abgeben müssen. Wir müssen in dem Portfolio-Auftrag über Statistiken schreiben, diese anpassen und redundante Werte löschen und schlussendlich diese dann mithilfe von mehreren Diagrammen besser ersichtlich machen.


### Arbeitspakete für 12.12.2023

- [X] Dokumentation schreiben

Heute haben wir die Dokumentation für unser Programmierprojekt angefangen und sind dabei sehr weit gekommen, wir sind zwar nicht fertig aber das können wir noch heute Nachmittag oder morgen machen, da wir es am Mittwoch Abend abgeben müssen.

### Arbeitspakete für 19.12.2023

- [X] Präsentation für die Vorstellung des Programmierprojekts vorbereiten

## Reflexion

1. Ich habe das Währungsrechner Projekt angefangen.
      -> Ich habe alles vorbereitet *(Abfrage inputs)* sodass ich mit der API Recherche anfangen kann.
2. Ich habe eine API für das Projekt gesucht.
      -> Da ich nun eine API gefunden habe konnte ich der implementierung anfangen.
3. Ich habe an der Implementierung der API gearbeitet.
      -> Dies ging länger als ich dachte und habe habe ausserdem all meinen Fortschritt in Postman verloren.
4. Ich habe an der Implementierung der API gearbeitet.
      -> Ich habe wieder die API implementiert aber kam nicht weiter.
5. Ich habe zusammen mit Herr Paucar und Herr Muic das Kanti Teilkostenrechnugns Programmierprojekt angefangen.
      -> Da jetzt das Kanti Projekt angefangen hat haben wir an diesem gearbeitet und dieses geplannt sodass wir in der nächsten Woche mit dem Programmieren anfangen konnten.
6. Ich habe zusammen mit Herr Paucar und Herr Muic an dem Kanti Teilkostenrechnugns Programmierprojekt weitergearbeitet. *(programmieren)*
      -> Da jetzt alles fertig geplannt war haben wir angefangen zu programmieren und haben die Input abfrage programmiert.
7. Ich habe zusammen mit Herr Paucar und Herr Muic an dem Kanti Teilkostenrechnugns Programmierprojekt weitergearbeitet. _(programmieren)_
      -> Da wir jetzt die Inputs hatten konnten wir mit dem erstellen und errechnen der Tabellenwerte anfangen. Das haben wir auch geschaft, deswegen konnten wir am gleichen Tag auch noch mit der Formatiertung der Tabelle anfangen und haben dies auch geschaft.
8. Ich habe das Portfolio für das Modul 162 geschrieben
      -> Da wir mit dem Code fertig waren konnte ich anstatt am Projekt zu arbeiten an dem Portfolio Auftrag des Modules 162 arbeiten, welches wir am Donnerstag in der gleichen Woch abgeben sollten. 
9. Ich habe zusammen mit Herr Paucar und Herr Muic an dem Kanti Teilkostenrechnugns Programmierprojekt weitergearbeitet. _(Präsentation)_
      -> Da wir mit dem Programmierteil des Projektes fertig waren mussten wir nur noch die Vorstellung an der Kanti vorbereiten.

### Wichtigsten Erfolge, Ereignisse & Meilensteine
#### Erfolge
1. gute API gefunden
2. Herausgefunden wir man eine Tabelle in der Console richtig formatieren kann (mit mixxed array)

#### Ereignisse 
1. Projekt wechsel zu Kanti Projekt
2. kurzer Projekt welchsel zu dem M162 Portfolio

#### Meilensteine
1. API implementierung in VS
2. Formatierte Tabelle
3. Portfolio abgeschlossen
4. Dokumentation & Präsentation abgeschlossen

### Reflexion Text
In den letzten neun Wochen habe ich an drei verschiedenen Projekten gearbeitet. Zunächst habe ich einen Währungsrechner begonnen, dann einen Teilkostenrechner für eine Kantine in einer Gruppenarbeit programmiert und dokumentiert. Abschließend habe ich ein Portfolio für ein Modul erstellt. Ursprünglich plante ich, das Währungsrechner-Projekt in meiner Freizeit fertigzustellen. Aufgrund der Vielzahl von Prüfungen und anderen Verpflichtungen in letzter Zeit habe ich dies jedoch nicht geschafft. Um ehrlich zu sein, habe ich sogar komplett vergessen, dass ich es überhaupt begonnen hatte. Hätte ich es nicht vergessen, hätte ich wahrscheinlich in der achten Woche an meinem ursprünglichen Programmierprojekt gearbeitet, anstatt am Portfolio.

### Verbesserungsvorschläge
Für die kommende Lernperiode nehme ich mir vor, mich strikt an meinen ursprünglichen Plan zu halten und die Zeit im Lernatelier dafür zu verwenden, um mich auf meine Projekte zu konzentrieren. Also werde ich diese Zeit nicht mehr für andere Projekte nutzen, die eigentlich nichts mit dem Lernatelier zu tun haben.
