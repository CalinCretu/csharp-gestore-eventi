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

        // Metodo per restituire la data e ora formattata
        public string GetDataOraFormattata()
        {
            return Data.ToString("dd/MM/yyyy");
        }

        // Metodo per restituire il prezzo formattato
        public string GetPrezzoFormattato()
        {
            return Prezzo.ToString("0.00") + " euro";
        }

        // Override del metodo ToString()
        public override string ToString()
        {
            return $"       {GetDataOraFormattata()} - {Titolo} - {Relatore} - {GetPrezzoFormattato()}";
        }
    }
}
