using System;

namespace ConsoleAgeCalculatorApp
{
    // Struct obrigatória
    struct Pessoa
    {
        public string Nome;
        public DateTime DataNascimento;

        public int CalcularIdade()
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - DataNascimento.Year;

            if (DataNascimento.Date > hoje.AddYears(-idade))
                idade--;

            return idade;
        }

        public bool PodeTirarCnh()
        {
            return CalcularIdade() >= 18;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite seu nome completo:");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua data de nascimento (dd/mm/aaaa):");
            DateTime dataNascimento;
            while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
            {
                Console.WriteLine("Data inválida, tente novamente (dd/mm/aaaa):");
            }
            pessoa.DataNascimento = dataNascimento;

            int idade = pessoa.CalcularIdade();

            Console.WriteLine($"\nOlá {pessoa.Nome}!");
            Console.WriteLine($"Você tem {idade} anos.");

            if (pessoa.PodeTirarCnh())
                Console.WriteLine("Você é maior de idade e pode tirar a carteira de habilitação.");
            else
                Console.WriteLine("Você ainda é menor de idade e não pode tirar a carteira de habilitação.");
        }
    }
}