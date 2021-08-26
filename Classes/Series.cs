using Serie.Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie.Classes
{
    class Series : EntidadeBase
    {
        public GeneroEnum Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Series(int id, GeneroEnum genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public int RetornaID()
        {
            return Id;
        }
        public string RetornaTitulo()
        {
            return Titulo;
        }
        public bool RetornaExluido()
        {
            return Excluido;
        }
        public void Excluir()
        {
            Excluido = true;
        }
        public override string ToString()
        {
            return "Gênero: " + this.Genero + Environment.NewLine
                + "Título: " + this.Titulo + Environment.NewLine
                + "Descrição: " + this.Descricao + Environment.NewLine
                + "Ano de início: " + this.Ano + Environment.NewLine
                + "Excluido: " + this.Excluido + Environment.NewLine;
        }
    }
}
