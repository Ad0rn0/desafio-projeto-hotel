using desafio_projeto_hotel.Models;

List<Pessoa> hospedes = [];

Suite solo = new("solo", 1, 40M);
Suite casal = new("casal", 2, 80M);
Suite familia = new("familia", 5, 200M);

Reserva reserva = new();

Console.WriteLine($"Qual de nossas suítes você vai querer?");
Console.WriteLine($"- {solo.TipoSuite.ToUpper()}\n- {casal.TipoSuite.ToUpper()}\n- {familia.TipoSuite.ToUpper()}");
string suiteEscolhida = Console.ReadLine().ToLower();
if (!suiteEscolhida.Contains("solo#casal#familia"))
{
    throw new Exception(suiteEscolhida + " é uma informação inválida.");
} 

switch (suiteEscolhida)
{
    case "solo":
        reserva.CadastrarSuite(solo);
        break;
    case "casal":
        reserva.CadastrarSuite(casal);
        break;
    case "familia":
        reserva.CadastrarSuite(familia);
        break;
}

reserva.CadastrarHospedes(hospedes);
int quantidadeHospedes = reserva.ObterQuantidadeHospedes();

decimal valorFinal = reserva.CalcularValorDiaria();

Console.WriteLine($"O valor a pagar é: {valorFinal.ToString("C")}");





