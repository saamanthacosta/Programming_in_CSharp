using System;

namespace certificacao_csharp_roteiro
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2_234_234;
            long inteiroLongo = inteiro;
            Console.WriteLine(inteiroLongo);

            // erro de compilação: não podemos adicionar um recipiente enorme a um recipiente menor :(
            //int inteiroNovo = inteiroLongo;

            Gato gato = new Gato();
            Animal animal = gato;
            Console.WriteLine(animal.GetType());

            // erro de compilação: só podemos fazer a conversão implicita se utilizarmos como destino uma variavel do tipo base da classe
            // sendo recebida ou uma interface implementada pela classe ou por uma classe base da classe
            //Gato gatinho = animal;

        }

    }

}