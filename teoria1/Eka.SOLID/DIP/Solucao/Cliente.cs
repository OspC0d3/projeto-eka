namespace DIP.Solucao;
public class Cliente
{
    public int Id { get; set; }
    public string Pessoa { get; set; } = "J";
    public string Documento { get; set; }
    public string Fantasia { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Codigo { get; set; }
    public DateTime DtCadastro { get; set; } = DateTime.Now;
    public int Status { get; set; } = 1; // Ativo
}
