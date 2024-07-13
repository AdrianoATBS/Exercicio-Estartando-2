/*
Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida,
crie um método para acelerar o carro (aumentando a velocidade em 10) e outro para frear
o carro (diminuindo a velocidade em 10, mas nunca deixando a velocidade negativa).

*/


using System;
using System.Collections.Generic;

namespace AutoMovel
{
    class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public double Velocidade { get; set; }

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0;
        }
        public void Acelerar()
        {
            Velocidade = Velocidade + 10;
            Console.WriteLine($"\nAcelerando: {Modelo} agora está a {Velocidade} km/h");
        }
        public void Frear()
        {
            Velocidade = Velocidade - 10;
            if(Velocidade < 0)
            {
                Velocidade = 0;
            }
            Console.WriteLine($"\nFreando: {Modelo} agora está a {Velocidade} km/h");
        }

    }
}