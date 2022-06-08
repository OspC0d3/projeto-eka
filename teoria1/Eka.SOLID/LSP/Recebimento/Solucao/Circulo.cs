namespace LSP.Recebimento.Solucao;
public class Supervisor : Recebimento
{
    public override string ExecutarTarefa()
        => new Aprovar().Execute();
}


