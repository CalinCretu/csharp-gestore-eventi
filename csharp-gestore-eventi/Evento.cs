using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        private string _titolo;
        private DateTime _data;
        private int _capienzaMassima;
        private int _postiPrenotati;

        public string Titolo
        {
            get { return _titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Il titolo non puo' essere vuoto!");
                _titolo = value;
            }
        }
        public DateTime Data
        {
            get { return _data; }
            set
            {
                if (value < DateTime.Today)
                    throw new ArgumentException("La data non puo' essere del passato");
                _data = value;
            }
        }
        public int CapienzaMassima
        {
            get { return _capienzaMassima; }
        }

        public int PostiPrenotati
        {
            get { return _postiPrenotati; }
        }

        // Costruttore
        public Evento(string titolo, DateTime data, int postiDisponibili)
        {
            Titolo = titolo;
            Data = data;
            if (postiDisponibili <= 0)
                throw new ArgumentException("La capienza massima deve essere un numero positivo");
            _capienzaMassima = postiDisponibili;
            _postiPrenotati = 0; // il numero di posti inizialmente prenotati
        }
    }
}
