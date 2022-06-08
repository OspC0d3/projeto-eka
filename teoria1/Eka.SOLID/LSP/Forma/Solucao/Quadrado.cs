namespace LSP.Forma.Solucao;
public class Quadrado : Forma
{
    public double Lado { get; }
    public Quadrado(double lado) => Lado = lado;
    public override double Area => Math.Pow(Lado, 2);
}

