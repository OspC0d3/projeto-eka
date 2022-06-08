namespace SRP.Violacao;
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

    public string AdicionarCliente()
    {
        if (!Email.Contains("@"))
            return "Cliente com e-mail inválido";

        if (Pessoa == "F" && Documento.Length != 11)
            return "Cliente com CPF inválido";
        else if (Pessoa == "J" && Documento.Length != 14)
            return "Cliente com CNPJ inválido";


        using (var cn = new SqlConnection())
        {
            var cmd = new SqlCommand();

            cn.ConnectionString = "MinhaConnectionString";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CLIENTE (PESSOA, DOCUMENTO, FANTASIA, NOME, EMAIL, CODIGO, DTCADASTRO, STATUS) VALUES (@pessoa, @documento, @fantasia, @nome, @email, @codigo, @dtcadastro@status)";

            cmd.Parameters.AddWithValue("nome", Pessoa);
            cmd.Parameters.AddWithValue("nome", Documento);
            cmd.Parameters.AddWithValue("nome", Fantasia);
            cmd.Parameters.AddWithValue("nome", Nome);
            cmd.Parameters.AddWithValue("nome", Email);
            cmd.Parameters.AddWithValue("nome", Codigo);
            cmd.Parameters.AddWithValue("nome", DtCadastro);
            cmd.Parameters.AddWithValue("nome", Status);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        var mail = new MailMessage("empresa@empresa.com", Email);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = "Bem Vindo.";
        mail.Body = "Parabéns! Você está cadastrado.";
        client.Send(mail);

        return "Cliente cadastrado com sucesso!";
    }
}
