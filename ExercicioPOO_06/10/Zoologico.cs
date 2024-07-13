/*
Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade.
Crie também um método chamado EmitirSom, que imprime na tela o som do animal.
*/

using System;
using System.Collections.Generic;
using NAudio.Wave;

namespace Zoologico
{
    class Animal
    {
        public string Nome{ get; private set; }
        public string Especie { get; private set; }

        public int Idade { get; private set; }

        public string Som { get; private set; }

        public Animal(string nome, string especie, int idade, string som)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
            Som = som;
        }
        public void EmitirSom()
        {
            Console.WriteLine($"Nome: {Nome}, faz: {Som}");

        

//             string path = @"C:\Users\Pichau\Desktop\Exercício_Estartando\Exercicio-Estartando-2\ExercicioPOO\Leopard.mp3";
// ;
//             if (!System.IO.File.Exists(path))
//             {
//                 Console.WriteLine("Arquivo não encontrado!");
//                 return;
//             }

//             using (var audioFile = new AudioFileReader(@"C:\Users\Pichau\Desktop\Exercício_Estartando\Exercicio-Estartando-2\ExercicioPOO\10\Leopard.mp3"))
//             using (var outputDevice = new WaveOutEvent())
//             {
                
//                 outputDevice.Init(audioFile);
//                 outputDevice.Play();

//                 while (outputDevice.PlaybackState == PlaybackState.Playing)
//                 {
//                     System.Threading.Thread.Sleep(100);
//                 }
//             }
        }

        
        public void informacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Espécie: {Especie}, Idade: {Idade} anos");
        }
    }
}