using System;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            char resposta = 'S';// System.Char

            byte niveldeAzul = 0xF; // = 255 em decimal 
            //nivelDeAzul = -3
            sbyte niveldeBrilho = -127; // System.SByte

            short passageirosVoo = -230; // System.Int16
            ushort passageirosNavio = 230; // System.UInt16 
            // passageirosNavio = -230;

            int populacao = -1500; // SystemInt.32
            uint estoque = 1500; // System.UInt32
            // estoque = -1500;

            long populacaoDoBrasil = -207_660_929; // +/- 207 milhões - System.Int64
            ulong populacaoDoMundo = 7_000_000_000; //7 bilhões = System.UInt64
            //  populacaoDoMundo = -7_000_000_000;

            Console.WriteLine("\n Tipos Inteiros: ");
            Console.WriteLine($"SS char   resposta: {resposta}");
            Console.WriteLine($"SS byte   nivelDeAzul: {niveldeAzul}");
            Console.WriteLine($"AS sbyte  niveldeBrilho: {niveldeBrilho}");
            Console.WriteLine($"AS short  passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"SS ushort passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"AS int    populacao: {populacao}");
            Console.WriteLine($"SS uint   estoque: {estoque}");
            Console.WriteLine($"AS long   populacaoDoBrasil: {populacaoDoBrasil}");
            Console.WriteLine($"SS ulong  populacaoDoMundo: {populacaoDoMundo}");
        }
    }
}
