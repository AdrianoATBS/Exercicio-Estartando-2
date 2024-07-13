using System;
using System.Collections.Generic;
using System.Media;

namespace Zoologico
{
    class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal("BigLion", "Leão-da-montanha", 5 ,"grrr, ronrom");
            animal.informacoes();
            animal.EmitirSom();
    
        }
    }
}