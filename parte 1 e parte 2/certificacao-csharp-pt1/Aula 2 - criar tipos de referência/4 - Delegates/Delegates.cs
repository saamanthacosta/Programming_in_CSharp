using System;

namespace certificacao_csharp_roteiro
{
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }

        delegate double MetodoMultiplicacao(double input);

        class Calculadora
        {
            static double Duplicar(double input)
            {
                return input * 2;
            }

            static double Triplicar(double input)
            {
                return input * 3;
            }

            public static void Executar()
            {
                Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");
                Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

                Console.WriteLine();
                MetodoMultiplicacao metodoMultiplicacao = Duplicar;
                Console.WriteLine($"Duplicar(7.5): {metodoMultiplicacao(7.5)}");
                metodoMultiplicacao = Triplicar;
                Console.WriteLine($"Triplicar(7.5): {metodoMultiplicacao(7.5)}");

                MetodoMultiplicacao metodoQuadrado = delegate (double input)
                {
                    return input * input;
                };
                MetodoMultiplicacao metodoCubo = input => input * input * input;

                double quadrado = metodoQuadrado(5);
                double cubo = metodoCubo(4.75);

                Console.WriteLine("quadrado: {0}", quadrado);
                Console.WriteLine("cubo: {0}", cubo);
            }
        }
    }
}
