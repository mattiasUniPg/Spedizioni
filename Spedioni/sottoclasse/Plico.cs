using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{

    public class Plico : Spedizione
    {
        private readonly double Altezza;
        private readonly double Lunghezza;

        public Plico(string mittente, string destinatario,string descrizione, decimal valore, double altezza, double lunghezza)
                : base(mittente, destinatario, valore)
        {
            Altezza = altezza;
            Lunghezza = lunghezza;
        }
        public override double printIngombro() => Altezza * Lunghezza;
    }
}

