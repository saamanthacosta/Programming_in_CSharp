using System;

namespace certificacao_csharp_roteiro
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            double inteiro = 2_234_234;
            //long inteiroLongo = inteiro;
            long inteiroLongo = (long)inteiro;
            Console.WriteLine(inteiroLongo);


            Animal animal = new Gato();
            Gato gato = (Gato)animal;
            Console.WriteLine(gato.GetType());
        }

    }

}