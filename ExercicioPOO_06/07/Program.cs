using System;
using System.Collections.Generic;

namespace Playlist
{
    class Progaman
    {
        public static void Main(string[] args)
        {
            Playlist minhaPlaylist = new Playlist("Adriano");

            Musica musica1 = new Musica("Necio ", "Romeo Santos", "Não sei");
            Musica musica2 = new Musica("You Are My High", "DJ Snake", "Vou ficar devendo");
            Musica musica3 = new Musica("We Ain't Feeling Time", "FKJ ", "Outra que vou ficar devendo");
            Musica musica4 = new Musica("Better Give U Up", "FKJ ", "Mesmo álbum da outra");

            minhaPlaylist.AdicionarMusica(musica1);
            minhaPlaylist.AdicionarMusica(musica2);
            minhaPlaylist.AdicionarMusica(musica3);
            minhaPlaylist.AdicionarMusica(musica4);

            Console.WriteLine("\nReproduzindo uma música ");
            minhaPlaylist.TocarMusicaRandom();
        }
    }
}