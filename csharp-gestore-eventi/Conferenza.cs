using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Conferenza : Evento
    {
        public string Relatore { get; set; }
        public double Prezzo { get; set; }

        public Conferenza(string titolo, DateTime data, int postiDisponibili, string relatore, double prezzo)
            : base(titolo, data, postiDisponibili)
        {
            Relatore = relatore;
            Prezzo = prezzo;
        }
    }
}
