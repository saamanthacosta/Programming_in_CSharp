using System;

namespace certificacao_csharp_roteiro
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            int idade = 57;
            object caixa = idade;

            try
            {
                int unboxed = (int)caixa;
                Console.WriteLine("Unboxed realizado com sucesso!");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("{0} Erro: unboxing incorreto.", e);

            }
        }
    }
}
