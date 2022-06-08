namespace LSP.Recebimento.Violacao;
public abstract class Recebimento
{
    public int Id { get; }
    public DateTime Data { get; }
    public string NotaFiscal { get; }
    public int IdFuncionario { get; }

    public virtual string DescarregarMercadoria() => String.Empty;
    public virtual string ConferrirMercadoria() => String.Empty;
    public virtual string AprovarDivergencia() => String.Empty;
}

