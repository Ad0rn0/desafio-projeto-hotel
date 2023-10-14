using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_projeto_hotel.Models
{
    public class Reserva
    {
/*         public Reserva()
        {
            
        } */
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;

            Console.WriteLine("===== Bem-vindo ao Hottel 5 Stars =====\nQuantas pessoas farão o check-in?");
            int quantidadeHospedes = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantidadeHospedes; i++){
                Console.WriteLine($"Digite o nome da {i+1}ª pessoa:");
                string nome = Console.ReadLine();

                Console.WriteLine($"Digite o sobrenome da {i+1}ª pessoa:");
                string sobrenome = Console.ReadLine();

                Pessoa pessoa = new(nome, sobrenome);
                hospedes.Add(pessoa);
            }   

        }

        public void CadastrarSuite(Suite suite)
        {

        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            return 0M;
        }
    }
}