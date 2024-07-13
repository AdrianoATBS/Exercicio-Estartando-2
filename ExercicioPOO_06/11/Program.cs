using System;
using System.Collections.Generic;

namespace AutoMovel
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("BMW Série 1", 2019);
            carro.Acelerar();
            carro.Acelerar();
            carro.Acelerar();
            carro.Frear();
            carro.Frear();
        }
    }
}