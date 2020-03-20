using System;

namespace certificacao_csharp_roteiro
{
    class Metodos : IAulaItem
    {
        public void Executar()
        {
            Retangulo retangulo = new Retangulo(10, 12);
            var areaComOModificadorPublicOuInternal = retangulo.Area();
            Console.WriteLine($"area: {areaComOModificadorPublicOuInternal}");

            Retangulo retangulo2 = new Retangulo(5, 6);
            Console.WriteLine($"Semalhantes usando o retangulo: {retangulo.Semelhante(4, 2)}");
            Console.WriteLine($"Semalhantes sem usar o retangulo: {Retangulo.Semelhante(retangulo, retangulo2)}");
        }

        internal class Retangulo
        {
            public double largura;
            public double altura;
            public double area;
            public Retangulo(double largura, double altura)
            {
                this.largura = largura;
                this.altura = altura;
                area = GetArea();

            }
            private double GetArea()
            {
                return altura * largura;
            }

            internal double Area()
            {
                return altura * largura;
            }

            internal bool Semelhante(double outroRetanguloAltura, double outroRetanguloLargura)
            {
                return
                   ((largura / altura) == /*proporção deste retângulo*/
                   (outroRetanguloLargura / outroRetanguloAltura)) /*proporção do outro retângulo*/
                   ||
                   ((altura / largura) == /*compara a proporção inversa*/
                   (outroRetanguloLargura / outroRetanguloAltura));
            }

            internal static bool Semelhante(Retangulo retangulo, Retangulo outroRetangulo)
            {
                return ((outroRetangulo.largura / outroRetangulo.altura) == (retangulo.largura / retangulo.altura))
                    || ((outroRetangulo.altura / outroRetangulo.largura) == (retangulo.largura / retangulo.altura));
            }
        }

    }
}
