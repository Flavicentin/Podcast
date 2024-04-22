Podcast p1 = new Podcast("Raibundos", "Flavio");

Episodio ep1 = new Episodio(1, "Piloto", 1240);
ep1.AdicionarConvidados("Monark");
p1.AdicionarEpisodio(ep1);


Episodio ep2 = new Episodio(3, "Bate Papo", 123);
ep2.AdicionarConvidados("Monark");
ep2.AdicionarConvidados("Gordox");
ep2.AdicionarConvidados("Alexandre de Moraes");
p1.AdicionarEpisodio(ep2);

Episodio ep3 = new Episodio(2, "Casal Ama", 432);
ep3.AdicionarConvidados("Tata");
ep3.AdicionarConvidados("Cocielo");
ep3.AdicionarConvidados("Roberto Justos");
p1.AdicionarEpisodio(ep3);

p1.ExibirDetalhes();