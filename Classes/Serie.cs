using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo{ get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private string OndeAssistir {get; set; }
        private int Temporadas { get; set; }
        private bool Excluido {get; set; }
        // Métodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano, string ondeAssistir, int temporadas)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.OndeAssistir = ondeAssistir;
            this.Temporadas = temporadas;
            this.Excluido = false;
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Número de temporadas: " + this.Temporadas + Environment.NewLine;
            retorno += "Serviço de streaming: " + this.OndeAssistir + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}