using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // doubles
            double fixKosten;
            double variableKosten;
            double nettoErlos;
            int mengenBereich;
            double[] schritte = new double[75];
            double gewinnZiel;

            // fix/variable/nettoerlos
            Console.Write("Geben Sie ihre Fixkosten ein: ");
            while (!double.TryParse(Console.ReadLine(), out fixKosten))
            {
                Console.WriteLine("Fehlerhafte Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                Console.Write("Geben Sie ihre Fixkosten ein: ");
            }

            Console.Write("Geben Sie ihre Variablenkosten ein: ");
            while (!double.TryParse(Console.ReadLine(), out variableKosten))
            {
                Console.WriteLine("Fehlerhafte Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                Console.Write("Geben Sie ihre Variablenkosten ein: ");
            }

            Console.Write("Geben Sie ihren Nettoerlös pro Produkt ein: ");
            while (!double.TryParse(Console.ReadLine(), out nettoErlos))
            {
                Console.WriteLine("Fehlerhafte Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                Console.Write("Geben Sie ihren Nettoerlös pro Produkt ein: ");
            }

            // mengenbereich/schritte
            Console.Write("Geben Sie ihren gewünschten Mengenbereich ein (bei 0 wird ein Standardbereich generiert): ");
            while (!int.TryParse(Console.ReadLine(), out mengenBereich))
            {
                Console.WriteLine("Fehlerhafte Eingabe. Bitte geben Sie eine gültige ganze Zahl ein.");
                Console.Write("Geben Sie ihren gewünschten Mengenbereich ein: ");
            }

            // Überprüfen, ob keine Mengenbereiche eingegeben wurden
            if (mengenBereich == 0)
            {
                // Generiere Standardmengenbereiche
                int schritteVorher = 3;
                int schritteNachher = 2;
                int generierteSchritte = schritteVorher + schritteNachher + 1; // Gerade Zahl

                schritte = new double[generierteSchritte];

                for (int i = -schritteVorher; i <= schritteNachher; i++)
                {
                    schritte[schritteVorher + i] = 1.0 * (1.0 - i / 3.0); // Annahme: 1.0 ist die mengenmassige Nutzschwelle
                }

                mengenBereich = generierteSchritte;
            }
            else
            {
                int test2 = 0;
                while (test2 < mengenBereich)
                {
                    int anzeigeZahl = test2 + 1;
                    Console.Write("Geben Sie Schritt Nummer " + anzeigeZahl + " ein: ");
                    schritte[test2] = Convert.ToDouble(Console.ReadLine());
                    test2++;
                }
            }


            // Rest des Codes bleibt unverändert

            // Gewinnziel
            Console.Write("Geben Sie ihr gewünschtes Gewinnziel ein: ");
            while (!double.TryParse(Console.ReadLine(), out gewinnZiel))
            {
                Console.WriteLine("Fehlerhafte Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                Console.Write("Geben Sie ihr gewünschtes Gewinnziel ein: ");
            }

            // 2D Array definieren (width und height glaube ich)
            object[,] mixedArray = new object[6, mengenBereich + 1];

            // Manuell einzelne Werte einfüllen
            mixedArray[0, 0] = "Anzahl";
            mixedArray[1, 0] = "Nettoerlös";
            mixedArray[2, 0] = "Variable Kosten";
            mixedArray[3, 0] = "Deckungsbeitrag";
            mixedArray[4, 0] = "Fixe Kosten";
            mixedArray[5, 0] = "Gewinn/Verlust";

            for (int i = 0; i < mengenBereich; i++)
            {
                mixedArray[0, i + 1] = schritte[i];
                mixedArray[1, i + 1] = nettoErlos * schritte[i];
                mixedArray[2, i + 1] = variableKosten * schritte[i];
                mixedArray[3, i + 1] = nettoErlos * schritte[i] - (variableKosten * schritte[i]);
                mixedArray[4, i + 1] = fixKosten;
                mixedArray[5, i + 1] = ((nettoErlos * schritte[i]) - (variableKosten * schritte[i])) - fixKosten;
            }

            // Ausgabe Tabelle
            for (int zeile = 0; zeile < mixedArray.GetLength(0); zeile++)
            {
                for (int spalte = 0; spalte < mixedArray.GetLength(1); spalte++)
                {
                    string cellValue = mixedArray[zeile, spalte]?.ToString() ?? "NULL";
                    if (double.TryParse(cellValue, out double cellDoubleValue))
                    {
                        // Round the double values to the nearest whole number
                        cellValue = Math.Round(cellDoubleValue).ToString();
                    }
                    Console.Write($"{cellValue,15} |"); // Right-align by using positive width value
                }
                Console.WriteLine();

                // Trennlinie
                for (int i = 0; i < mixedArray.GetLength(1); i++)
                {
                    Console.Write(new string('-', 16) + "+");
                }
                Console.WriteLine();
            }

            double deckungsBeitrag = nettoErlos - variableKosten;
            double mengenmässigeNutzschwelle = fixKosten / deckungsBeitrag;
            double wertmässigeNutzschwelle = mengenmässigeNutzschwelle * nettoErlos;
            double notwendigeMengeDefinierterGewinn = (gewinnZiel + fixKosten) / nettoErlos;

            // Ausgabe der berechneten Werte
            Console.WriteLine("Mengenmässige Nutzschwelle: " + Math.Round(mengenmässigeNutzschwelle));
            Console.WriteLine("Wertmässige Nutzschwelle: " + Math.Round(wertmässigeNutzschwelle));
            Console.WriteLine("Notwendige Menge für definierten Gewinn: " + Math.Round(notwendigeMengeDefinierterGewinn));
        }
    }
}

