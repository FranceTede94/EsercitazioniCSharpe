namespace PRIMOESERCIZIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Nome = "Francesco";
            String Cognome = "Tedesco";
            int Età = 30;
            String Indirizzo = "Via Milano 54";

            Console.WriteLine($"Mi chiamo {Nome} {Cognome} e ho {Età} anni e vivo a Roma in via {Indirizzo}");

            Console.WriteLine();
            int numero1 = 500;
            int numero2 = 200;

            Console.WriteLine(numero1 + numero2);
            Console.WriteLine(numero1 - numero2);
            Console.WriteLine(numero1 * numero2);
            Console.WriteLine(numero1 / numero2);

            Console.WriteLine();

            int a = 10, b = 20, c = 30;
            Console.WriteLine(a + b + c);

            Console.WriteLine();

            double Primonumero = 35;
            double Secondonumero = 50;

            Console.WriteLine(((Primonumero + Secondonumero) / 355) + 60);

            Console.WriteLine();

            ESERCIZIO esercizio = new ESERCIZIO("Alessio", "Beccardo", 25);

            Console.WriteLine(esercizio.Nome);
            Console.WriteLine(esercizio.Cognome);
            Console.WriteLine(esercizio.Età);

            Console.WriteLine();

            int numero = 10;

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Buongiorno" + " sono il numero " + i);
            }

            Console.WriteLine();

            string nome = "Francesco ha 30 anni e via a Roma in Via Trento 3";
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
                Console.WriteLine(nome.Count());
            }


            String[] Frutta = ["Ananas", "Arancia", "Mela", "Pera", "Banana"];

            for (int i = 0; i < Frutta.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("La frutta migliore è " + Frutta[i]);
                    Console.WriteLine("Fai bene l'ananas");
                }
                else if (i == 1)
                {
                    Console.WriteLine("La frutta migliore è " + Frutta[i]);
                    Console.WriteLine("Fai bene l'arancia");
                }
                else if (i == 2)
                {
                    Console.WriteLine("La frutta migliore è " + Frutta[i]);
                    Console.WriteLine("Fai bene la mela");
                }
                else if (i == 3)
                {
                    Console.WriteLine("La frutta migliore è " + Frutta[i]);
                    Console.WriteLine("Fai bene la pera");
                }
                else
                {
                    Console.WriteLine("La frutta migliore è " + Frutta[i]);
                    Console.WriteLine("Fai bene la banana");
                }


                bool Lampadina = true;
                Lampadina = false;

                if (Lampadina)
                {
                    Console.WriteLine("La lampadina è accesa");
                }
                else
                {
                    Console.WriteLine("La lampadina è non accesa");
                }

                string Parola = "Francesco";

                for (i = 0; i < Parola.Length; i++)
                {
                    char carattere = Parola[i]; // Ottiene il carattere alla posizione i
                    Console.WriteLine("Carattere alla posizione " + i + ": " + carattere);
                }

                string Testo = "ciao";

                char carattere1 = Testo[0]; // ti da  come risultato "i"
                int indice = Testo.IndexOf(";"); //ti da come risultato la posizione della prima i
                                                 //che trova nella stringa in questo caso 1

                string Animale = "Gatto";
                string NomeAnimale1 = "Billi";

                Console.WriteLine($"Ciao sono un {Animale} e il mio nome è {NomeAnimale1}");

                int N1 = 200;
                if (N1 % 50 == 0)
                {
                    Console.WriteLine("La divisione ha resto resto");
                }
                else
                {
                    Console.WriteLine("La divisione non da ha resto resto e quindi è con la virgola");
                }

                string filePath = @"C:\Users\f.tedesco\Desktop\TestImport.csv";

                Console.WriteLine(File.ReadAllText(filePath));
                Console.WriteLine("File CSV letto con successo nel terminale");
                Console.WriteLine();


                string percorso = @"C:\Users\f.tedesco\Desktop\NuovoFile.csv";

                // Creazione del file CSV con intestazioni
                using (StreamWriter writer = new StreamWriter(percorso))
                {
                    writer.WriteLine("Nome;Cognome;Indirizzo;Eta;Provenienza");  // Scrive le intestazioni nel file
                }

                Console.WriteLine("File CSV creato con successo sul Desktop!");

                using (StreamWriter writer = new StreamWriter(percorso, append: true)) // `append: true` per aggiungere dati senza sovrascrivere
                {
                    writer.WriteLine("Mario;Rossi;Via Roma, 123;30;Italia");  // Scrive una riga di dati
                    writer.WriteLine("Luigi;Bianchi;Piazza Venezia, 45;25;Italia"); // Scrive una riga di dati
                    writer.WriteLine("Francesco;Verdi;Via Milano, 101;40;Italia");  // Scrive una riga di dati
                    writer.WriteLine("Sara;Neri;Corso Garibaldi, 78;28;Italia"); // Scrive una riga di dati
                    writer.WriteLine("Giulia;Bianchi;Via Firenze, 56;32;Italia");  // Scrive una riga di dati
                    writer.WriteLine("Marco;Gialli;Viale Trento, 9;45;Italia"); // Scrive una riga di dati
                    writer.WriteLine("Anna;Blu;Piazza del Popolo, 3;27;Italia");  // Scrive una riga di dati
                    writer.WriteLine("Luca;Verdi;Via San Giovanni, 14;35;Italia"); // Scrive una riga di dati
                }

                Console.WriteLine();
                Console.WriteLine("Dati aggiunti al file CSV con successo!");

                int cronometro = 0;

                while (cronometro < 3)  // Continua finché cronometro è minore di 10
                {
                    Console.WriteLine(cronometro);  // Stampa il valore corrente di cronometro
                    cronometro++;  // Incrementa cronometro di 1 ad ogni iterazione
                }

                Console.WriteLine();

                int Numero = 0;

                do
                {
                    Console.WriteLine(Numero);  // Stampa il valore corrente di cronometro
                    Numero++;  // Incrementa cronometro di 1 ad ogni iterazione
                } while (Numero < 3);  // Continua finché cronometro è minore di 10

                Console.WriteLine();


                string[] Animali = ["Cavallo", "Giraffa", "Leone", "Tigre", "Elefante"];

                for (i = 0; i < Animali.Length; i++)
                {
                    Console.WriteLine(Animali[i]);
                }

                Console.WriteLine();


                // Creazione di un oggetto anonimo
                var frutta = new
                {
                    NomeFrutto = "Mela",
                    ProvenienzaFrutto = "Italia",
                    NumeroTotaleMele = 30,
                    MarcaMela = "Golden"

                };

                // Stampa i dettagli dell'oggetto anonimo
                Console.WriteLine($"Nome: {frutta.NomeFrutto}");
                Console.WriteLine($"Provenienza: {frutta.ProvenienzaFrutto}");
                Console.WriteLine($"Numero totale: {frutta.NumeroTotaleMele} mele");
                Console.WriteLine($"Marca del prodotto: {frutta.MarcaMela}");

                Console.WriteLine();

                // Creazione della lista di animali
                List<string> TipiAnimali = new List<string> { "Cavallo", "Giraffa", "Leone", "Tigre", "Elefante" };


                for (int y = 0; y < TipiAnimali.Count; y++)
                {
                    Console.WriteLine(TipiAnimali[y]);
                }

                // Aggiungiamo un nuovo animale alla lista
                TipiAnimali.Add("Zebra");

                // Rimuoviamo un animale dalla lista
                TipiAnimali.Remove("Cavallo");

                // Modifichiamo un animale nella lista
                TipiAnimali[2] = "Rinoceronte";

                Console.WriteLine();

                for (int y = 0; y < TipiAnimali.Count; y++)
                {
                    Console.WriteLine(TipiAnimali[y]);
                }

                Console.WriteLine();

                List<int> numeri = new List<int>();

                // Aggiungere numeri alla lista
                numeri.Add(5);
                numeri.Add(10);
                numeri.Add(3);
                numeri.Add(7);
                numeri.Add(1);


                for (var z = 0; a < numeri.Count(); a++)
                {
                    Console.WriteLine(numeri[z]);
                }


                Console.WriteLine();
                numeri.Remove(5);
                numeri.Remove(1);

                for (var y = 0; y < numeri.Count(); y++)
                {
                    Console.WriteLine(numeri[y]);
                }


                Console.WriteLine();
                numeri.Sort(); // Ordina la lista in ordine crescente

                for (var y = 0; y < numeri.Count(); y++)
                {
                    Console.WriteLine(numeri[y]);
                }


                Console.WriteLine();

                int NomeAnimale = 3;
                switch (NomeAnimale)
                {
                    case 1:
                        Console.WriteLine("Giraffa");
                        break;
                    case 2:
                        Console.WriteLine("Cavallo");
                        break;
                    case 3:
                        Console.WriteLine("Zebra");
                        continue;
                    case 4:
                        Console.WriteLine("Maiale");
                        break;
                    case 5:
                        Console.WriteLine("Mucca");
                        break;
                    case 6:
                        Console.WriteLine("Pecora");
                        break;
                    case 7:
                        Console.WriteLine("Coiote");
                        break;
                }

                Console.WriteLine(NomeAnimale);

            }
        }
    }
}
