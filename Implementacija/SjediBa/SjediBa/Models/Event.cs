using System;

namespace SjediBa.Models
{
    public class EventModel
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

        public string Lokacija { get; set; }

        public DateTime Datum { get; set; }

        public string Vrsta { get; set; }

        public string Organizacija { get; set; }

        public EventModel(int id, string naziv, string lokacija, DateTime datum, string vrsta, string organizacija) {
            this.Id = id;
            this.Naziv = naziv;
            this.Lokacija = lokacija;
            this.Datum = datum;
            this.Vrsta = vrsta;
            this.Organizacija = organizacija;
        }
    }
}