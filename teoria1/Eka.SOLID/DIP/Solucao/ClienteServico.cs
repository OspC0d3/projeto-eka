namespace DIP.Solucao;
public class ClienteServico
{
    private readonly EmailServico _emasrv;
    private readonly ClienteValidacao _clival;
    private readonly ClienteRepositorio _clirep;

    public ClienteServico(EmailServico emasrv,
           ClienteValidacao clival,
           ClienteRepositorio clirep)
        => (_emasrv, _clival, _clirep) = (emasrv, clival, clirep);
    public string AdicionarCliente(Cliente cliente)
    {
        if (!_emasrv.EhValido(cliente.Email))
            return "Dados inválidos";

        if (!_clival.EhValido(cliente.Documento, cliente.Pessoa))
            return "Dados inválidos";

        _clirep.AdicionarCliente(cliente);

        _emasrv.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns está Cadastrado");

        return "Cliente cadastrado com sucesso";
    }
}