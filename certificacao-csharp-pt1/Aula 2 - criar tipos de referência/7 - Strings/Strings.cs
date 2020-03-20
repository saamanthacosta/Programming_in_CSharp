using System;

namespace certificacao_csharp_roteiro
{
    class Strings : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine("OBJECT COM VALOR PRIMITIVO");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"meuObjeto: {meuObjeto}");
            Console.WriteLine($"meuObjeto.GetType(): {meuObjeto.GetType()}");

            meuObjeto = new Jogador();
            Jogador classRef = (Jogador)meuObjeto; //conversão explícita, ou "cast"
            Console.WriteLine();
            Console.WriteLine("OBJECT COM REFERÊNCIA DE OBJETO");
            Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");
        }

        internal class Jogador
        {
            public int Pontuacao { get; set; }
        }
    }
}
