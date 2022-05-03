using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    public class Pacco : Spedizione
    {
        private readonly double Altezza;
        private readonly double Larghezza;
        private readonly double Profondità;

        public Pacco (string mittente,string destinatario,string descrizione,decimal valore,double altezza, double larghezza, double profondità)
            :base (mittente,destinatario,valore)
        {
            Altezza = altezza;
            Larghezza = larghezza;
            Profondità = profondità;
    
        }
 
        public override double printIngombro() => Altezza * Larghezza * Profondità;
    }
}

