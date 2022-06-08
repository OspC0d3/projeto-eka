namespace LSP.Recebimento.Solucao;
public class Conferente : Recebimento
{
    public override string ExecutarTarefa()
        => new Conferir().Execute();
}


