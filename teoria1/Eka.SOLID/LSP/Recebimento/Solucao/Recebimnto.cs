namespace LSP.Recebimento.Solucao;
public abstract class Recebimento
{
    public int Id { get; }
    public DateTime Data { get; }
    public String NotaFiscal { get; }
    public int IdFuncionario { get; }
    public virtual string ExecutarTarefa() => String.Empty;
}

