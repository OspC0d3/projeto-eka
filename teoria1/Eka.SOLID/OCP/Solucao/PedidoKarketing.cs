namespace OCP.Solucao;
public class PedidoMarketing : Pedido
{
    public override bool ValidarQuantidade(List<PedidoItem> itens) => true;
    public bool VerificaCampanha() => true;
}