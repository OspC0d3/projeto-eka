namespace LSP.Forma.Solucao;
public class Retangulo : Forma
{
    public double Altura { get; }
    public double Largura { get; }
    public Retangulo(double altura, double largura)
       => (Altura, Largura) = (altura, largura);
    public override double Area => Altura * Largura;
}

