using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        public string Titolo { get; private set; }
        public List<Evento> eventi;

        public ProgrammaEventi(string titolo)       // costruttore
        {
            Titolo = titolo;
            eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento nuovoEvento)      // metodo per aggiungere un nuovo evento
        {
            eventi.Add(nuovoEvento);
        }

        public static string StampareEventi(List<Evento> listaEventi)       // metodo per stampare una lista eventi
        {
        if (listaEventi == null || listaEventi.Count == 0)
            {
                return "Nessun evento disponibile";
            }

            string result = "";

            foreach (var evento in listaEventi)
            {
                result += $"      {evento.ToString()}";
            }
            return result;
        }

        public int NumeroEventi()       // metodo per contare gli eventi nella lista
        {
            return eventi.Count;
        }

        public void SvuotaEventi()      // metodo per svuotare la lista degli eventi
        {
            eventi.Clear();
        }
    }
}
