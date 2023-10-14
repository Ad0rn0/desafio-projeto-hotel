using desafio_projeto_hotel.Models;

List<Pessoa> hospedes = [];

Suite solo = new("Solo", 1, 40M);
Suite casal = new("Casal", 2, 80M);
Suite familia = new("Familia", 5, 200M);

Reserva reserva = new();
reserva.CadastrarHospedes(hospedes);

int quantidadeHospedes = reserva.ObterQuantidadeHospedes();

/* foreach(Pessoa hospede in hospedes)
{
    Console.WriteLine(hospede.Nome + hospede.Sobrenome);
}
 */


// Pessoa p1 = new(nome, sobrenome);

// p1.Exibir();
