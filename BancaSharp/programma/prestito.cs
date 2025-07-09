using System;

namespace BancaSharp.programma
{
    public class Prestito
    {
        public string CodiceFiscaleIntestatario { get; set; }
        public decimal Ammontare { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
    }
}