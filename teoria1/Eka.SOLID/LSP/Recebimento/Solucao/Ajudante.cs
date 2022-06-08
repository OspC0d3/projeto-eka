namespace LSP.Recebimento.Solucao;
public class Ajudante : Recebimento
{
    public override string ExecutarTarefa()
        => new Descarregar().Execute();
}


