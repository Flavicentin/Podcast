class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodio { get => episodios.Count; }


    public Podcast(string Nome, string Host)
    {
        this.Nome = Nome;
        this.Host = Host;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Lista de Episódios do poscast {Nome} do host {Host}");
        foreach (var episodio in episodios.OrderBy(e => e.NumeroEpisodio))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"O poscast {Nome} contém {TotalEpisodio} episódios");
    }

}