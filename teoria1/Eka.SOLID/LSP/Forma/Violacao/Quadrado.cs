namespace LSP.Forma.Violacao;
public class Quadrado : Forma
{
    public Quadrado(int altura, int largura)
        : base(altura, largura)
    {
        if (largura != altura)
            throw new ArgumentException("Quadrado com lados diferentes!!!");
    }
}

