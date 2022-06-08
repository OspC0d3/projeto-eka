namespace OCP.Solucao;
public abstract class Pedido
{
    public int Id { get; set; }
    public DateTime DataHoraPedido { get; set; } = DateTime.Now;
    public int IdCliente { get; set; }
    public string Tipo { get; set; }
    public string Fornecimento { get; set; }
    public string NumPedido { get; set; }
    public List<PedidoItem> Itens { get; set; }
    public int Status { get; set; } = 1;
    // valida se existe quantidade disponivel no estoque dp CD
    public virtual bool ValidarQuantidade(List<PedidoItem> itens) => true;
}