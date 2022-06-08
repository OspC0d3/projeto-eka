namespace OCP.Violacao;
public class Pedido
{
    public int Id { get; set; }
    public DateTime DataHoraPedido { get; set; } = DateTime.Now;
    public int IdCliente { get; set; }
    public PedidoTipo Tipo { get; set; }
    public string Fornecimento { get; set; }
    public string NumPedido { get; set; }
    public List<PedidoItem> Itens { get; set; }
    public int Status { get; set; } = 1;
  
    public bool ValidarPedidoDeVenda()
    {
        var valido = false;

        //ValidaQtdeEstoque();

        if (Tipo == PedidoTipo.Movel)
            // ValidarOrigem();
            valido = true; 
        else if (Tipo == PedidoTipo.Fixa)
            // EncaminhaPedidoEngenharia();
            valido = true; 
        
        return valido;
    }
}