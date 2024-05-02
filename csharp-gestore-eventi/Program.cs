namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
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

                Console.Write("Inserisci la capienza massima dell'evento: ");
                int capienzaMassima;
                while (!int.TryParse(Console.ReadLine(), out capienzaMassima) || capienzaMassima <= 0)
                {
                    Console.WriteLine("Inserisci un numero valido per la capienza massima (deve essere un numero positivo): ");
                }

                Evento nuovoEvento = new Evento(titolo, data, capienzaMassima);

                // Prenotazione di posti
                Console.Write("Quanti posti desideri prenotare? ");
                string risposta = Console.ReadLine();

                int postiDaPrenotare;
                while (!int.TryParse(risposta, out postiDaPrenotare) || postiDaPrenotare <= 0)
                {
                    Console.WriteLine("Inserisci un numero valido di posti da prenotare:");
                }

                try
                {
                    nuovoEvento.PrenotaPosti(postiDaPrenotare);
                    Console.WriteLine($"\nNumero di posti prenotati: {nuovoEvento.PostiPrenotati}");
                    Console.WriteLine($"Numero di posti disponibili: {nuovoEvento.CapienzaMassima - nuovoEvento.PostiPrenotati}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore: {ex.Message}");
                }

                // Disdetta di posti
                Console.Write("\nVuoi disdire dei posti (si/no)? ");
                risposta = Console.ReadLine();
                while (risposta == "si")
                {
                    Console.Write("Indica il numero di posti da disdire: ");
                    int postiDaDisdire;
                    while (!int.TryParse(Console.ReadLine(), out postiDaDisdire) || postiDaDisdire <= 0)
                    {
                        Console.WriteLine("Inserisci un numero valido di posti da disdire:");
                    }

                    try
                    {
                        nuovoEvento.DisdiciPosti(postiDaDisdire);
                        Console.WriteLine($"\nNumero di posti prenotati: {nuovoEvento.PostiPrenotati}");
                        Console.WriteLine($"Numero di posti disponibili: {nuovoEvento.CapienzaMassima - nuovoEvento.PostiPrenotati}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore: {ex.Message}");
                    }
                    Console.Write("\nVuoi disdire dei posti (si/no)? ");
                    risposta = Console.ReadLine();

                    Console.WriteLine("OK va bene!");
                    Console.WriteLine($"\nNumero di posti prenotati: {nuovoEvento.PostiPrenotati}");
                    Console.WriteLine($"Numero di posti disponibili: {nuovoEvento.CapienzaMassima - nuovoEvento.PostiPrenotati}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante la creazione dell'evento: {ex.Message}");
            }
        }
    }
}