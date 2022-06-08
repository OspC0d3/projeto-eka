namespace LSP.Forma.Violacao;
public class Circulo : Forma
{
    public Circulo(int altura, int largura)
        : base(altura, largura)
    {
        throw new ArgumentException("Circulo não tem lados!!!");
    }
}

