namespace SRP.Solucao;
public static class ClienteValidacao
{
    public static bool EhValido(string pessoa, string doc)
    {

        var valido = false;

        if (pessoa == "F" && doc.Length != 11)
            valido = true;
        else if (pessoa == "J" && doc.Length != 14)
            valido = true;
        return valido;
    }
}
