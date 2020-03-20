using System;

namespace certificacao_csharp_roteiro
{
    class Classes : IAulaItem
    {
        public void Executar()
        {
            ClassePosicaoGPS posicao1 = new ClassePosicaoGPS(13.78, 29.51);

            PosicaoGPSComLeitura posicao2 = new PosicaoGPSComLeitura(40.23, 17.4, DateTime.Now);

            Console.WriteLine($"Posicao1: {posicao1}");
            Console.WriteLine($"Posicao3: {posicao2}");
        }

        interface IGPS
        {
            bool EhHerisferioNorte();
        }

        public class ClassePosicaoGPS : IGPS
        {
            public double latitude;
            public double longitude;

            public ClassePosicaoGPS(double latitude, double longitude)
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

        public class PosicaoGPSComLeitura : ClassePosicaoGPS
        {
            private readonly DateTime dataLeitura;

            public PosicaoGPSComLeitura(double latitude, double longitude, DateTime dataLeitura) : base(latitude, longitude)
            {
                this.dataLeitura = dataLeitura;
            }

            public override string ToString()
            {
                return $"Latitude: {latitude}, Longitude: {longitude}, Data Leitura: {dataLeitura}";
            }
        }
    }
}
