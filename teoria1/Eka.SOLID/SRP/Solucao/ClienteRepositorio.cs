namespace SRP.Solucao;
public class ClienteRepositorio
{
    public void AdicionarCliente(Cliente cliente)
    {
        using (var cn = new SqlConnection())
        {
            var cmd = new SqlCommand();

            cn.ConnectionString = "MinhaConnectionString";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CLIENTE (PESSOA, DOCUMENTO, FANTASIA, NOME, EMAIL, CODIGO, DTCADASTRO, STATUS) VALUES (@pessoa, @documento, @fantasia, @nome, @email, @codigo, @dtcadastro@status)";

            cmd.Parameters.AddWithValue("pessoa", cliente.Pessoa);
            cmd.Parameters.AddWithValue("documento", cliente.Documento);
            cmd.Parameters.AddWithValue("fantasia", cliente.Fantasia);
            cmd.Parameters.AddWithValue("nome", cliente.Nome);
            cmd.Parameters.AddWithValue("email", cliente.Email);
            cmd.Parameters.AddWithValue("codigo", cliente.Codigo);
            cmd.Parameters.AddWithValue("dtcadastro", cliente.DtCadastro);
            cmd.Parameters.AddWithValue("status", cliente.Status);

            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}