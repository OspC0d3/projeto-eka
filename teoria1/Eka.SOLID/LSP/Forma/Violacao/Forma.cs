
namespace LSP.Forma.Violacao;
public abstract class Forma
{
    public double Altura { get; private set; }
    public double Largura { get; private set; }

    protected Forma(int altura, int largura)
        => (Altura, Largura) = (altura, largura);
    public double CalculaArea() => Altura * Largura;
}
