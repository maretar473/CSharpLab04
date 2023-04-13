namespace Geometria
{
    abstract public class Bryla
    {
        public string Nazwa
        { get; set; }
        public double Gestosc
        { get; set; }
        public decimal CenaZaKg
        { get; set; }
        public double Objetosc
        { get; set; }
        public double Masa
        { get; set; }
        public void ObliczObjetosc() {
                
        }

        public void ObliczMase() {
            Masa = Objetosc * Gestosc;
        }

        public decimal ObliczCene() {
            return CenaZaKg*(decimal)Masa;
        }

        Bryla() { }
    }
}