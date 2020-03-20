using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");

            PosicaoGPS posicao1;
            posicao1.latitude = Latitude1;
            posicao1.longitude = Longitude1;

            PosicaoGPS posicao2 = new PosicaoGPS() { latitude = Latitude2, longitude = Longitude2 };
            PosicaoGPS posicao3 = new PosicaoGPS(20, 30);

            Console.WriteLine($"Posicao1: {posicao1}");
            Console.WriteLine($"Posicao2: {posicao2}");
            Console.WriteLine($"Posicao3: {posicao3}");
            Console.WriteLine($"Posição1 é do hemisfério norte: {posicao1.EhHerisferioNorte()}");
        }

        interface IGPS
        {
            bool EhHerisferioNorte();
        }

        struct PosicaoGPS : IGPS
        {
            public double latitude;
            public double longitude;

            // não podemos ter construtor com parâmetros vazios em Struct
            //public PosicaoGPS()
            //{

            //}

            public PosicaoGPS(double latitude, double longitude)
            {
                this.latitude = latitude;
                this.longitude = longitude;
            }

            public bool EhHerisferioNorte()
            {
                return latitude > 0;
            }

            public override string ToString()
            {
                return $"Latitude: {latitude}, Longitude: {longitude}";
            }
        }
    }
}
