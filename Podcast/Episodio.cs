class Episodio
{
    public Episodio(int numero, string titulo, int duracao)
    {
        this.NumeroEpisodio = numero;
        this.Titulo = titulo;   
        this.Duracao = duracao; 
    }

    private List<string> convidados = new List<string>();
    public int NumeroEpisodio { get; }
    public string Titulo { get; }
    public int Duracao { get; }

    public string Resumo => $"{NumeroEpisodio} - {Titulo} tem a duração de {Duracao} segundos com os convidados {string.Join(", ", convidados)}";

    public void AdicionarConvidados(string nomeConvidado)
    {
        convidados.Add(nomeConvidado);
    }
}