﻿using System;

namespace certificacao_csharp_roteiro
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            IEletrodomestico eletro1 = new Televisao();
            eletro1.Ligar();
            eletro1 = new Abajur();
            eletro1.Desligar();

            IIluminacao iluminacao1 = new Lanterna();
            double potenciaDaLanterna = iluminacao1.PotenciaDaLampada;
            iluminacao1 = new Abajur();

            Abajur abajur1 = new Abajur();
            abajur1.Ligar();
            double potenciaDoAbajur = abajur1.PotenciaDaLampada;
        }
    }
    interface IEletrodomestico
    {
        void Ligar();
        void Desligar();
    }

    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }
    }

    class Televisao : IEletrodomestico
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
    class Abajur : IEletrodomestico, IIluminacao
    {

        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
}