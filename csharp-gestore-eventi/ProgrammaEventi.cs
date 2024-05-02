using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class ProgrammaEventi
    {
        public string Titolo { get; private set; }
        private List<Evento> eventi;

        public ProgrammaEventi(string titolo)       // costruttore
        {
            Titolo = titolo;
            eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento nuovoEvento)      // metodo per aggiungere un nuovo evento
        {
            eventi.Add(nuovoEvento);
        }
    }
}
