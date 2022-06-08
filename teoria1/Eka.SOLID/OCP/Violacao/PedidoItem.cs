namespace OCP.Violacao;
public class PedidoItem
{
    public int Id { get; set; }
    public int IdPedido { get; set; }
    public int IdProduto { get; set; }
    public double Quantidade { get; set; }
    public int Status { get; set; } = 1;
}