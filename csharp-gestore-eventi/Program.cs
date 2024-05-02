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
                Console.WriteLine("Inserisci un numero valido di eventi da aggiungere:");
            }

            for (int i = 0; i < numeroEventiDaAggiungere; i++)
            {
                try
                {
                    Console.Write("Inserisci il nome dell'evento: ");
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

                    // Milestone 1 e 2 //// Prenotazione di posti
                    // Milestone 1 e 2 //Console.Write("Quanti posti desideri prenotare? ");
                    // Milestone 1 e 2 //string risposta = Console.ReadLine();
                    // Milestone 1 e 2 
                    // Milestone 1 e 2 //int postiDaPrenotare;
                    // Milestone 1 e 2 //while (!int.TryParse(risposta, out postiDaPrenotare) || postiDaPrenotare <= 0)
                    // Milestone 1 e 2 //{
                    // Milestone 1 e 2 //    Console.WriteLine("Inserisci un numero valido di posti da prenotare:");
                    // Milestone 1 e 2 //}
                    // Milestone 1 e 2 
                    // Milestone 1 e 2 //try
                    // Milestone 1 e 2 //{
                    // Milestone 1 e 2 //    nuovoEvento.PrenotaPosti(postiDaPrenotare);
                    // Milestone 1 e 2 //    Console.WriteLine($"\nNumero di posti prenotati: {nuovoEvento.PostiPrenotati}");
                    // Milestone 1 e 2 //    Console.WriteLine($"Numero di posti disponibili: {nuovoEvento.CapienzaMassima - nuovoEvento.PostiPrenotati}");
                    // Milestone 1 e 2 //}
                    // Milestone 1 e 2 //catch (Exception ex)
                    // Milestone 1 e 2 //{
                    // Milestone 1 e 2 //    Console.WriteLine($"Errore: {ex.Message}");
                    // Milestone 1 e 2 //}
                    // Milestone 1 e 2 
                    // Milestone 1 e 2 //// Disdetta di posti
                    // Milestone 1 e 2 //Console.Write("\nVuoi disdire dei posti (si/no)? ");
                    // Milestone 1 e 2 //risposta = Console.ReadLine();
                    // Milestone 1 e 2 //while (risposta == "si")
                    // Milestone 1 e 2 //{
                    // Milestone 1 e 2 //    Console.Write("Indica il numero di posti da disdire: ");
                    // Milestone 1 e 2 //    int postiDaDisdire;
                    // Milestone 1 e 2 //    while (!int.TryParse(Console.ReadLine(), out postiDaDisdire) || postiDaDisdire <= 0)
                    // Milestone 1 e 2 //    {
                    // Milestone 1 e 2 //        Console.WriteLine("Inserisci un numero valido di posti da disdire:");
                    // Milestone 1 e 2 //    }
                    // Milestone 1 e 2 
                    // Milestone 1 e 2 //    try
                    // Milestone 1 e 2 //    {
                    // Milestone 1 e 2 //        nuovoEvento.DisdiciPosti(postiDaDisdire);
                    // Milestone 1 e 2 //        Console.WriteLine($"\nNumero di posti prenotati: {nuovoEvento.PostiPrenotati}");
                    // Milestone 1 e 2 //        Console.WriteLine($"Numero di posti disponibili: {nuovoEvento.CapienzaMassima - nuovoEvento.PostiPrenotati}");
                    // Milestone 1 e 2 //    }
                    // Milestone 1 e 2 //    catch (Exception ex)
                    // Milestone 1 e 2 //    {
                    // Milestone 1 e 2 //        Console.WriteLine($"Errore: {ex.Message}");
                    // Milestone 1 e 2 //    }
                    // Milestone 1 e 2 //    Console.Write("\nVuoi disdire dei posti (si/no)? ");
                    // Milestone 1 e 2 //    risposta = Console.ReadLine();
                    // Milestone 1 e 2 
                    // Milestone 1 e 2 //    Console.WriteLine("OK va bene!");
                    // Milestone 1 e 2 //    Console.WriteLine($"\nNumero di posti prenotati: {nuovoEvento.PostiPrenotati}");
                    // Milestone 1 e 2 //    Console.WriteLine($"Numero di posti disponibili: {nuovoEvento.CapienzaMassima - nuovoEvento.PostiPrenotati}");
                    // Milestone 1 e 2 //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante la creazione dell'evento: {ex.Message}");
                }
            }
        }
    }
}