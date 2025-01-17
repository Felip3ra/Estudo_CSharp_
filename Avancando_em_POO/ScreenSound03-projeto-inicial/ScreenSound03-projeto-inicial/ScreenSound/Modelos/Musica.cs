﻿namespace Screensound.Modelos;
internal class Musica: IAvaliavel
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    private List<Avaliacao> notas = new List<Avaliacao>();
    public double Media{
        get{
            if (notas.Count == 0)
            {
                return 0;
            }
            else
            {
                return notas.Average(a => a.Nota);
            }
        }
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}