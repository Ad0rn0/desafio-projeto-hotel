using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_projeto_hotel.Models
{
    public class Reserva
    {

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;

            Console.WriteLine("===== Bem-vindo ao Hottel 5 Stars =====\nQuantas pessoas farão o check-in?");
            int quantidadeHospedes = int.Parse(Console.ReadLine());

            if (quantidadeHospedes > Suite.Capacidade)
            {
                throw new Exception($"A suíte escolhida não suporta {quantidadeHospedes} pessoas. No máximo {Suite.Capacidade} pessoa(s) pode(m) fazer checkin na suíte {Suite.TipoSuite}");
            }
            else
            {
            for(int i = 0; i < quantidadeHospedes; i++){
                Console.WriteLine($"Digite o nome da {i+1}ª pessoa:");
                string nome = Console.ReadLine();

                Console.WriteLine($"Digite o sobrenome da {i+1}ª pessoa:");
                string sobrenome = Console.ReadLine();

                Pessoa pessoa = new(nome, sobrenome);
                hospedes.Add(pessoa);
            }
            }   

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            Console.WriteLine("Quantos dias você irá ficar na suíte?");
            int diasHospedado = int.Parse(Console.ReadLine());

            decimal valorTotal = Convert.ToDecimal(diasHospedado) * Suite.ValorDiaria;

            if (diasHospedado > 10)
            {
                decimal desconto = valorTotal * 0.10M;
                valorTotal -= desconto;
            }
            return valorTotal;
        }
    }
}