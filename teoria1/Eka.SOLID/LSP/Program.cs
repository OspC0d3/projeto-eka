// See https://aka.ms/new-console-template for more information
using LSP.Forma.Solucao;
using LSP.Recebimento.Solucao;

var quadrado = new Quadrado(5);
var retangulo = new Retangulo(10, 12);
var circulo = new Circulo(3);

Console.WriteLine($" Quadrado: {Forma.ExibeArea(quadrado)}");
Console.WriteLine($" Retangulo: {Forma.ExibeArea(retangulo)}");
Console.WriteLine($" Circulo: {Forma.ExibeArea(circulo)}");

Forma quadradop = new Quadrado(5);
Forma retangulop = new Retangulo(10, 12);
Forma circulop = new Circulo(3);

Console.WriteLine($" Quadrado Pai: {Forma.ExibeArea(quadradop)}");
Console.WriteLine($" Retangulo Pai: {Forma.ExibeArea(retangulop)}");
Console.WriteLine($" Circulo Pai: {Forma.ExibeArea(circulop)}");

Console.ReadKey();

var ajudante = new Ajudante().ExecutarTarefa();
var conferente = new Conferente().ExecutarTarefa();
var supervisor = new Supervisor().ExecutarTarefa();
Console.WriteLine($" Ajudante: {ajudante}");
Console.WriteLine($" Conferista: {conferente}");
Console.WriteLine($" Supervisor: {supervisor}");

Recebimento ajudantep = new Ajudante();
Recebimento conferentep = new Conferente();
Recebimento supervisorp = new Supervisor();

Console.WriteLine($" Ajudante Pai: {ajudantep.ExecutarTarefa()}");
Console.WriteLine($" Conferista Pai: {conferentep.ExecutarTarefa()}");
Console.WriteLine($" Supervisor Pai: {supervisorp.ExecutarTarefa()}");

Console.ReadKey();


