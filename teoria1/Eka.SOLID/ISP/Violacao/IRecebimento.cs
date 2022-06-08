namespace ISP.Violacao;
public interface IRecebimento
{
    string DescarregarMercadoria();
    string ConferrirMercadoria();
    string AprovarDivergencia();
}
// Esta interface tem como contrato 3 metodos
// que sao possiveis na acao de recebimento
// mas sse verificarmos as classes que a implementa
// veremos que elas nao implemente todos os metodos
// ferindo assim o principio ISP
