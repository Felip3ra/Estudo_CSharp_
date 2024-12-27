/*
Banda queen = new Banda("Queen");


Album albumQueen = new Album("A Night At the Opera");


Musica musica1 = new Musica(queen,"Love Of My Life")
{
    Duracao = 213,
    Disponivel = true,
};
//musica1.Duracao = 213;


Musica musica2 = new Musica(queen,"Bohemian Rhapsody"){
    Duracao = 354,
    Disponivel = false,
};
//musica2.Duracao = 354;

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);

albumQueen.ExibirMusicas();


queen.AdicionarAlbum(albumQueen);
queen.ExibirDiscografia();
*/
Episodio ep1 = new(2,"Técnicas de facilitacao",45);
ep1.AdicionarConvidados("Igão");
ep1.AdicionarConvidados("Mítico");
//Console.WriteLine(ep1.Resumo);


Episodio ep2 = new(1,"Técnicas de Aprendizado",67);
ep2.AdicionarConvidados("Igor3K");
ep2.AdicionarConvidados("Taty");

Podcast podcast = new("Podcast Delas","Taty");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
