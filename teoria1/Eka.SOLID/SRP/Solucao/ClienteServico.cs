namespace SRP.Solucao;
public class ClienteServico
{
    public string AdicionarCliente(Cliente cliente)
    {
        if (!cliente.EhValido())
            return "Dados inválidos";

        var repo = new ClienteRepositorio();
        repo.AdicionarCliente(cliente);
        
        EmailServico.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns está Cadastrado");

        return "Cliente cadastrado com sucesso";
    }
}