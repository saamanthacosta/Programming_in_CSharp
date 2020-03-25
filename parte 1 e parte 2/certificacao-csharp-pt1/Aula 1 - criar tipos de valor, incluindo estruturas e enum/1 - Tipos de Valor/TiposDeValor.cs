using System;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade = 12;

            System.Int32 copiaIdade = idade;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            idade = 30;
            Console.WriteLine("\n Alterações:");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            System.Nullable<int> idade2 = null;
            // permite que a gente diga que a idade3 é um int q aceita receber nulos
            int? idade3 = null;

            Console.WriteLine("\n Idades nulas: ");
            Console.WriteLine($"idade2: {idade2}");
            Console.WriteLine($"idade3: {idade3}");

            idade2 = 10;
            idade3 = 20;
            Console.WriteLine("\n Idades não nulas: ");
            Console.WriteLine($"idade2: {idade2}");
            Console.WriteLine($"idade3: {idade3}");
        }
    }
}
