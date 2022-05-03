using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    public class Corriere 
    {
        private readonly List<Spedizione> Carico;
        private string Nome;

        public Corriere(string nome)
        {
            Nome= nome;
            Carico = new List<Spedizione>();
        }
        public void AddSpedizione(Spedizione spedizione) => Carico.Add(spedizione);
       
        public double IngombroTot()
        {
            double tot = 0;
            foreach (var ing in Carico)
                tot += ing.printIngombro();
            return tot;
        }
    
        public string ListSpedizioni()
        {
            string result = $"Spedizioni in carico ad: {Nome}{Environment.NewLine}";
            foreach (var item in Carico)
                result = string.Concat(result, item.ListSpedizioni(), Environment.NewLine);
            return result;
        }
    }
}