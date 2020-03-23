using System;

namespace certificacao_csharp_roteiro
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;

            object caixa = numero;

            Console.WriteLine(string.Concat("Resposta", numero, true));
        }
    }
}
