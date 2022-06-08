namespace LSP.Forma.Solucao;
public abstract class Forma
{
    public abstract double Area { get; }
    public static double ExibeArea(Forma forma) => forma.Area;
}

