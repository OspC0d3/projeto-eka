namespace OCP.Solucao;
public class PedidoFixa : Pedido
{
    public override bool ValidarQuantidade(List<PedidoItem> itens) => true;
    public bool EncaminhaPedidoEngenharia()=> true;
}