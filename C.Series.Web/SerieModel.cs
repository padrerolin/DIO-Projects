namespace C.Series.Web
{
    public class SerieModel
    {
        public int Id { get;  set; }
        public Genero Genero { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public int Ano { get; set; }

        public bool Excluido { get; set; }

        public SerieModel() 
        { }

        public SerieModel(Series serie)
        {
            Id = serie.retornaId();
            Genero = serie.retornaGenero();
            Titulo = serie.retornaTitulo();
            Descricao = serie.retornaDescricao();
            Ano = serie.retornaAno();
            Excluido = serie.retornaExcluido();

        }
        public Series ToSerie()
        {
            return new Series(Id, Genero,Titulo, Descricao, Ano);

        }

    }
}
