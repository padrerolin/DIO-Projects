namespace C.Series
{
    public class Series : EntidadeBase
    {
        private Genero Genero {get; set;}

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        public int Ano { get; set; }

        private bool Excluido {get; set;}

        public Series(int id, Genero genero, string titulo, string descricao, int ano){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString(){
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo+ Environment.NewLine;
            retorno += "Descrição: " + this.Descricao+ Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano+ Environment.NewLine;
             retorno += "Excluido: " + this.Excluido;
            return retorno;    
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
          public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public Genero retornaGenero()
        {
            return this.Genero;
        }
        public string retornaDescricao()
        {
            return Descricao;
        }
        public int retornaAno()
        {
            return Ano;
        }

        public void Excluir () {
            this.Excluido = true;
        }
    }
}