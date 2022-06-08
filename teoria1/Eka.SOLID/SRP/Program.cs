
// Solucao da violacao do SRP

var cliV = new SRP.Violacao.Cliente();
cliV.Codigo = "VSP008";
cliV.Documento = "58441770000150";
cliV.DtCadastro = DateTime.Now;
cliV.Email = "joaoalberto@vivo.com";
cliV.Fantasia = "VivoSP";
cliV.Nome = "Vivo Sao Paulo";
cliV.Pessoa = "J";
cliV.Status = 1;

var resultV = cliV.AdicionarCliente();

Console.WriteLine(resultV);

/// <summary>
/// 
/// Falta de coesão — uma classe não deve assumir responsabilidades que não são suas;
/// Alto acoplamento — Mais responsabilidades geram um maior nível de dependências, deixando 
///                    o sistema engessado e frágil para alterações;
/// Dificuldades na implementação de testes automatizados — É difícil de “mockar” esse tipo de classe;
/// Dificuldades para reaproveitar o código;
/// 
/// </summary>


// Solucao do SRP da forma correta 

var cliI = new SRP.Solucao.Cliente();
cliI.Codigo = "VSP008";
cliI.Documento = "58441770000150";
cliI.DtCadastro = DateTime.Now;
cliI.Email = "joaoalberto@vivo.com";
cliI.Fantasia = "VivoSP";
cliI.Nome = "Vivo Sao Paulo";
cliI.Pessoa = "J";
cliI.Status = 1;

var resultI = new SRP.Solucao.ClienteServico().AdicionarCliente(cliI);

Console.WriteLine(resultI);
