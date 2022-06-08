namespace ISP.Violacao;
public class Ajudante : IRecebimento
{
    public string DescarregarMercadoria() => String.Empty;
    public string ConferrirMercadoria() => throw new NotImplementedException();
    public string AprovarDivergencia() => throw new NotImplementedException();
}

