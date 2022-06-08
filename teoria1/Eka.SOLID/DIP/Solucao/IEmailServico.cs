namespace DIP.Solucao;
public interface IEmailServico
{
    bool EhValido(string email);
    void Enviar(string de, string para, string assunto, string mensagem);
}
