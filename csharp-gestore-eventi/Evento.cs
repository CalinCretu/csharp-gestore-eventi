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

        // Metodo per prenotare posti
        public void PrenotaPosti(int postiDaPrenotare)
        {
            if (DateTime.Today > Data)
                throw new InvalidOperationException("Impossibile prenotare posti per un evento passato.");

            if (postiDaPrenotare <= 0)
                throw new ArgumentException("Il numero di posti da prenotare deve essere positivo");

            if (_postiPrenotati + postiDaPrenotare > _capienzaMassima)
                throw new InvalidOperationException("Non ci sono abbastanza posti disponibili.");

            _postiPrenotati += postiDaPrenotare;
        }

        // Metodo per disdire posti
        public void DisdiciPosti(int postiDaDisdire)
        {
            if (DateTime.Today > Data)
                throw new InvalidOperationException("Impossibile disdire posti per un evento passato.");

            if (postiDaDisdire <= 0)
                throw new ArgumentException("Il numero di posti da disdire deve essere positivo");

            if (postiDaDisdire > _postiPrenotati)
                throw new InvalidOperationException("Impossibile disdire più posti di quelli prenotati.");

            _postiPrenotati -= postiDaDisdire;
        }

        // Override del metodo ToString()
        public override string ToString()
        {
            return $"       {Data.ToString("dd/MM/yyyy")} - {Titolo}\n";
        }
    }
}
