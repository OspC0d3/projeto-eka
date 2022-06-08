namespace OCP.Solucao;
public class PedidoMovel : Pedido
{
    public override bool ValidarQuantidade(List<PedidoItem> itens) => true;
    public bool ValidarOrigem() => true;
}