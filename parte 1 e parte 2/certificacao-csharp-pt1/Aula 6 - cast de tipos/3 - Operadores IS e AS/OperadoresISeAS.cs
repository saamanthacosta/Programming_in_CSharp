using System;

namespace certificacao_csharp_roteiro
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Gato();
            Gato gato = new Gato();
            ClienteCinema cliente = new ClienteCinema("Samantha");

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);
        }

        public void Alimentar(object obj)
        {
            if (obj is Animal animal)
            {
                animal.Beber();
                animal.Comer();
                return;
            }

            Console.WriteLine("obj não é um animal");

            // outra maneira: 
            //Animal animal = obj as Animal;
            //if (animal == null)
            //{
            //    Console.Writeline("obj não é um animal");
            //    return;
            //}
            //animal.Beber();
            //animal.Comer();
        }
    }
}