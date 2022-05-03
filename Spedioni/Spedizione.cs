namespace Spedizioni
{
    public abstract class Spedizione
    {
        protected string Mittente { get; set; }
        protected string Destinatario { get; set; }
        protected decimal Valore { get; set; }

        protected Spedizione(string mittente, string destinatario, decimal valore)
        {
            Mittente = mittente;
            Destinatario = destinatario;
            Valore = valore;
        }
        public abstract double printIngombro();
        public bool Equals(Spedizione obj)
        {
            return
                obj.Mittente.Equals(Mittente) &&
                obj.Valore.Equals(Valore) &&
                obj.Destinatario.Equals(Destinatario) &&
                obj.printIngombro().Equals(printIngombro());
        }
        public string ListSpedizioni()
        {
            return $"Mittente: {Mittente} ------- Destinatario: {Destinatario} ------- Valore: {Valore} ------- Valore Ingombro {printIngombro()}";
        }
    }
}