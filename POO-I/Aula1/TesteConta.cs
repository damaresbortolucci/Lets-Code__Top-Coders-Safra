﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class TesteConta
    {
        public static void Main(string[] args)
        {
            Conta c1 = new Conta();
            c1.numero = 1234;
            c1.saldo = 1000;
            c1.limite = 500;


            Conta c2 = new Conta();
            c2.numero = 1235;
            c2.saldo = 12000;
            c2.limite = 2000;

            Console.WriteLine("Dados da primeira conta");
            Console.WriteLine($"Número: {c1.numero}");
            Console.WriteLine($"Saldo: {c1.saldo}");
            Console.WriteLine($"Limite: {c1.limite}");

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Dados da segunda conta");
            Console.WriteLine($"Número: {c2.numero}");
            Console.WriteLine($"Saldo: {c2.saldo}");
            Console.WriteLine($"Limite: {c2.limite}");
        }
    }
}