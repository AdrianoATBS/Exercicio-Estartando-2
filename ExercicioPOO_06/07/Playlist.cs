/*
7 - Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora.
Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e uma
string para armazenar o dono da playlist. Implemente um método para adicionar músicas
na lista, para "tocar a música" (só mostrar uma mensagem na tela com o titulo da
música). Tente fazer uma reprodução aleatória, ou seja, em vez de percor
*/
using System;
using System.Collections.Generic;

namespace Playlist
{
    class Musica
    {
        public string Nome { get; set; }
        public string Autor { get; set; }

        public string Gravadora { get; set; }

        public Musica(string nome, string autor, string gravadora)
        {
            Nome = nome;
            Autor = autor;
            Gravadora = gravadora;
        }

        public void Tocar()
        {
            Console.WriteLine($"Tocando Música{Nome} - {Autor}({Gravadora})");
        }
    }
    class Playlist
    {
        private List<Musica> musicaList;
        public string Dono { get; set; }

        public Playlist(string dono)
        {
            Dono = dono;
            musicaList = new List<Musica>();
        }

        public void AdicionarMusica(Musica musica)
        {
            musicaList.Add(musica);
            Console.WriteLine($"\nMúsica {musica.Nome} Adicionada na Playlist de {Dono}");
        }

        public void TocarMusicaRandom()
        {
            Random rand = new Random();
            int index = rand.Next(musicaList.Count);
            musicaList[index].Tocar();
        }
    }
}