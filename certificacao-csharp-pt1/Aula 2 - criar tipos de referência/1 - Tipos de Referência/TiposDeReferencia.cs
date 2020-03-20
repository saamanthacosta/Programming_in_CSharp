using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            int idade = 42;
            int copiaIdade = idade;

            Console.WriteLine("int idade = 42;");
            Console.WriteLine("int copiaIdade = idade;");
            Console.WriteLine($"idade: { idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            Cliente1 cliente1 = new Cliente1("Maria", 20);
            Cliente1 cliente1Copia = cliente1;
            Cliente2 cliente2 = new Cliente2("José", 20);
            Cliente2 cliente2Copia = cliente2;
            Console.WriteLine($"Cliente1:      {cliente1}");
            Console.WriteLine($"Cliente1Copia: {cliente1Copia}");
            Console.WriteLine($"Cliente2:      {cliente2}");
            Console.WriteLine($"Cliente2Copia: {cliente2Copia}");

            cliente1.nome = "Lucas";
            cliente2.nome = "Paula";
            Console.WriteLine();
            Console.WriteLine("Troca de nome do Cliente1 e Cliente2.......");
            Console.WriteLine($"Cliente1:      {cliente1}");
            Console.WriteLine($"Cliente1Copia: {cliente1Copia}");
            Console.WriteLine($"Cliente2:      {cliente2}");
            Console.WriteLine($"Cliente2Copia: {cliente2Copia}");
        }

        struct Cliente1
        {
            public string nome;
            public int idade;
            public Cliente1(string nome, int idade)
            {
                this.nome = nome;
                this.idade = idade;
            }

            public override string ToString()
            {
                return $"Nome: {nome}, Idade: {idade}";
            }
        }
        class Cliente2
        {
            public string nome;
            public int idade;
            public Cliente2(string nome, int idade)
            {
                this.nome = nome;
                this.idade = idade;
            }

            public override string ToString()
            {
                return $"Nome: {nome}, Idade: {idade}";
            }
        }

    }
}
