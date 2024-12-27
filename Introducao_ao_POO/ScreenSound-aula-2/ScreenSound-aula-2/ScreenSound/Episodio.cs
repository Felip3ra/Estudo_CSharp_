class Episodio
{
    public Episodio(int ordem,string titulo,int duracao)
    {
        Duracao = duracao;
        Titulo = titulo;
        Ordem = ordem;
    }
    public int Duracao { get;  }
    public int Ordem { get;  }
    public string Resumo => $"Ordem: {Ordem} - Título: {Titulo} - Duracao: {Duracao} - Convidados: {string.Join(",",convidados)}";
    public string Titulo { get;  }
    private List<string> convidados = new List<string>();

    public void AdicionarConvidados(string convidado){
        convidados.Add(convidado);
    }
}