using System;
using System.Collections.Generic;

namespace certificacao_csharp_roteiro
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            // referente ao cubo
            int lado = 4;
            Console.WriteLine("Volume do Cubo: " + Volume(lado));

            // referente ao cilíndro
            double altura = 3.5;
            double raio = 2;
            Console.WriteLine("Volume do Cilíndro: " + Volume(altura, raio));

            // referente ao paralelepípedo
            altura = 3;
            double largura = 5.5;
            double profundidade = 4.2;
            Console.WriteLine("Volume do Paralelepípedo: " + Volume(altura, largura, profundidade));
        }
        
        public double Volume(int lado)
        {
            return Math.Pow(lado, 3);
        }

        public double Volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        public double Volume(double altura, double largura, double profundidade)
        {
            return altura * largura * profundidade;
        }
    }

}