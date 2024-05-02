namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Inserisci il nome del tuo programma Eventi: ");
            string titoloProgramma = Console.ReadLine();

            ProgrammaEventi programma = new ProgrammaEventi(titoloProgramma);

            Console.Write("Indica il numero di eventi da inserire: ");

            int numeroEventiDaAggiungere;
            while (!int.TryParse(Console.ReadLine(), out numeroEventiDaAggiungere) || numeroEventiDaAggiungere <= 0)
            {
                Console.WriteLine("Inserisci un numero valido di eventi da inserire:");
            }

            for (int i = 0; i < numeroEventiDaAggiungere; i++)
            {
                try
                {
                    Console.Write($"\nInserisci il nome del {i + 1}° evento: ");
                    string titolo = Console.ReadLine();

                    Console.Write("Inserisci la data dell'evento (dd/MM/yyyy): ");
                    DateTime data;
                    while (true)
                    {
                        if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
                        {
                            Console.WriteLine("Formato data non valido. Inserisci la data nel formato richiesto (dd/MM/yyyy): ");
                            continue;
                        }
                        break;
                    }

                    Console.Write("Inserisci il numero di posti totali: ");
                    int capienzaMassima;
                    while (!int.TryParse(Console.ReadLine(), out capienzaMassima) || capienzaMassima <= 0)
                    {
                        Console.WriteLine("Inserisci un numero valido per i posti totali (deve essere un numero positivo): ");
                    }

                    Evento nuovoEvento = new Evento(titolo, data, capienzaMassima);
                    programma.AggiungiEvento(nuovoEvento);
                    { // Milestone 2 //// Prenotazione di posti
                      // Milestone 2 //Console.Write("Quanti posti desideri prenotare? ");
                      // Milestone 2 //string risposta = Console.ReadLine();
                      // Milestone 2 
                      // Milestone 2 //int postiDaPrenotare;
                      // Milestone 2 //while (!int.TryParse(risposta, out postiDaPrenotare) || postiDaPrenotare <= 0)
                      // Milestone 2 //{
                      // Milestone 2 //    Console.WriteLine("Inserisci un numero valido di posti da prenotare:");
                      // Milestone 2 //}
                      // Milestone 2 
                      // Milestone 2 //try
                      // Milestone 2 //{
                      // Milestone 2 //    nuovoEvento.PrenotaPosti(postiDaPrenotare);
                      // Milestone 2 //    Console.WriteLine($"\nNumero di posti prenotati: {nuovoEvento.PostiPrenotati}");
                      // Milestone 2 //    Console.WriteLine($"Numero di posti disponibili: {nuovoEvento.CapienzaMassima - nuovoEvento.PostiPrenotati}");
                      // Milestone 2 //}
                      // Milestone 2 //catch (Exception ex)
                      // Milestone 2 //{
                      // Milestone 2 //    Console.WriteLine($"Errore: {ex.Message}");
                      // Milestone 2 //}
                      // Milestone 2 
                      // Milestone 2 //// Disdetta di posti
                      // Milestone 2 //Console.Write("\nVuoi disdire dei posti (si/no)? ");
                      // Milestone 2 //risposta = Console.ReadLine();
                      // Milestone 2 //while (risposta == "si")
                      // Milestone 2 //{
                      // Milestone 2 //    Console.Write("Indica il numero di posti da disdire: ");
                      // Milestone 2 //    int postiDaDisdire;
                      // Milestone 2 //    while (!int.TryParse(Console.ReadLine(), out postiDaDisdire) || postiDaDisdire <= 0)
                      // Milestone 2 //    {
                      // Milestone 2 //        Console.WriteLine("Inserisci un numero valido di posti da disdire:");
                      // Milestone 2 //    }
                      // Milestone 2 
                      // Milestone 2 //    try
                      // Milestone 2 //    {
                      // Milestone 2 //        nuovoEvento.DisdiciPosti(postiDaDisdire);
                      // Milestone 2 //        Console.WriteLine($"\nNumero di posti prenotati: {nuovoEvento.PostiPrenotati}");
                      // Milestone 2 //        Console.WriteLine($"Numero di posti disponibili: {nuovoEvento.CapienzaMassima - nuovoEvento.PostiPrenotati}");
                      // Milestone 2 //    }
                      // Milestone 2 //    catch (Exception ex)
                      // Milestone 2 //    {
                      // Milestone 2 //        Console.WriteLine($"Errore: {ex.Message}");
                      // Milestone 2 //    }
                      // Milestone 2 //    Console.Write("\nVuoi disdire dei posti (si/no)? ");
                      // Milestone 2 //    risposta = Console.ReadLine();
                      // Milestone 2 
                      // Milestone 2 //    Console.WriteLine("OK va bene!");
                      // Milestone 2 //    Console.WriteLine($"\nNumero di posti prenotati: {nuovoEvento.PostiPrenotati}");
                      // Milestone 2 //    Console.WriteLine($"Numero di posti disponibili: {nuovoEvento.CapienzaMassima - nuovoEvento.PostiPrenotati}");
                      // Milestone 2 //}
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante la creazione dell'evento: {ex.Message}");
                    i--;
                }
            }
            Console.WriteLine($"\nIl numero di eventi nel programma è: {programma.NumeroEventi()}");
            Console.WriteLine("Ecco il tuo programma eventi:");
            Console.WriteLine(titoloProgramma);
            Console.WriteLine(ProgrammaEventi.StampareEventi(programma.eventi));

            Console.Write("\nInserisci una data per per sapere che eventi ci saranno (dd/mm/yyyy): ");
            DateTime dataScelta;
            while (true)
            {
                if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataScelta))
                {
                    Console.WriteLine("Formato data non valido. Inserisci la data nel formato richiesto (dd/MM/yyyy): ");
                    continue;
                }
                break;
            }
            List<Evento> eventiInData = programma.EventiInData(dataScelta);

            Console.WriteLine($"\nGli eventi in data {dataScelta.ToString("dd/MM/yyyy")} sono:");
            Console.WriteLine(ProgrammaEventi.StampareEventi(programma.EventiInData(dataScelta)));

            //programma.SvuotaEventi();
            //Console.WriteLine("\nTutti gli eventi sono stati eliminati dal programma.");

            Console.WriteLine("---- BONUS ----");
            Console.WriteLine("Aggiungiamo anche una conferenza!");

            Console.Write("Inserisci il nome della conferenza: ");
            string titoloConferenza = Console.ReadLine();

            Console.Write("Inserisci la data della conferenza (gg/mm/yyyy): ");
            DateTime dataConferenza;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataConferenza))
            {
                Console.WriteLine("Formato data non valido. Inserisci la data nel formato richiesto (gg/mm/yyyy): ");
            }

            Console.Write("Inserisci il numero di posti per la conferenza: ");
            int postiConferenza;
            while (!int.TryParse(Console.ReadLine(), out postiConferenza) || postiConferenza <= 0)
            {
                Console.WriteLine("Inserisci un numero valido di posti per la conferenza:");
            }

            Console.Write("Inserisci il relatore della conferenza: ");
            string relatoreConferenza = Console.ReadLine();

            Console.Write("Inserisci il prezzo del biglietto della conferenza: ");
            double prezzoConferenza;
            while (!double.TryParse(Console.ReadLine(), out prezzoConferenza) || prezzoConferenza <= 0)
            {
                Console.WriteLine("Inserisci un prezzo valido per la conferenza:");
            }

            programma.AggiungiEvento(new Conferenza(titoloConferenza, dataConferenza, postiConferenza, relatoreConferenza, prezzoConferenza));

            Console.WriteLine("\nEcco il tuo programma eventi con anche le Conferenze:");
            Console.WriteLine(programma.Titolo);
            Console.WriteLine(ProgrammaEventi.StampareEventi(programma.eventi));
        }
    }
}