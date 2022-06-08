namespace ISP.Violacao;
public class Conferente : IRecebimento
{
    public string DescarregarMercadoria() => throw new NotImplementedException();
    public string ConferrirMercadoria() => String.Empty;
    public string AprovarDivergencia() => throw new NotImplementedException();
}

