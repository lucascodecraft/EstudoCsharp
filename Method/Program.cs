﻿using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            InformacaoConstrutor();
            Console.WriteLine();
            Andar();
            Console.WriteLine();
            Saltar();

            Console.ReadLine();
        }
         
        public static void InformacaoConstrutor()
        {
            var humano = new Humano("Gesiel");
            var cachorro = new Cachorro("scoob");

            Console.WriteLine("Nome: " + humano.Nome);
            Console.WriteLine("Tipo: " + humano.Tipo);

            Console.WriteLine("Nome: " + cachorro.Nome);
            Console.WriteLine("Tipo: " + cachorro.Tipo);
        }

        public static void Saltar()
        {
            var cachorro = new Cachorro("scoob");

            cachorro.Saltar();
            cachorro.Saltar();
            cachorro.Saltar();
            cachorro.Saltar();
            cachorro.Saltar();

            Console.WriteLine("O cachorro saltou " + cachorro.TotaldeSaltos + " vezes.");
        }

        public static void Andar()
        {
            var humano = new Humano("Gesiel");
            var cachorro = new Cachorro("scoob");

            humano.Andar();
            cachorro.Andar();

            Console.WriteLine("Humano: " + humano.MododeAndar);
            Console.WriteLine("Cachorro: " + cachorro.MododeAndar);
        }
    }
}
