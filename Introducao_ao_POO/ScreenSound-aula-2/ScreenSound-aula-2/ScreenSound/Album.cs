class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica (Musica musica){
        musicas.Add(musica);
    }
    public void ExibirMusicas(){
        
        Console.WriteLine($"Lista de músicas do álbum {Nome}:");
        musicas.ForEach(musica => Console.WriteLine(musica.Nome));
        Console.WriteLine($"Para ouvir este album inteiro você precisa de {DuracaoTotal} segundos");
    }
}