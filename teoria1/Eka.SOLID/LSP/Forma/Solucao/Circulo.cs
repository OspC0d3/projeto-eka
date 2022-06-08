namespace LSP.Forma.Solucao;
public class Circulo : Forma
{
    public double Raio { get; }
    public Circulo(double raio) => Raio = raio;
    public override double Area => Math.Round(Math.PI * Math.Pow(Raio, 2), 2);
}

