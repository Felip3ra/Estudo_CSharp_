class Podcast
{
    public Podcast(string nome,string host)
    {
        Host = host;
        Nome = nome;
    }
    private List<Episodio> episodios = new List<Episodio>();
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count();

    public void AdicionarEpisodio(Episodio episodio){
        episodios.Add(episodio);
    }
    public void ExibirDetalhes(){
        Console.WriteLine($"O podcast {Nome} é apresentado pelo Host {Host}");
        Console.WriteLine($"Confira mais detalhes abaixo: ");
        episodios.OrderBy(e => e.Ordem).ToList().ForEach(episodio => Console.WriteLine(episodio.Resumo));
        Console.WriteLine($"Total de episodios: {TotalEpisodios}");
    }
}