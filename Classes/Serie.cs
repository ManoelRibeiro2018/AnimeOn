using Serie.Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie.Classes
{
    class Serie : EntidadeBase
    {
        private GeneroEnum Genero { get; set; }
        private int Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Serie(int id, GeneroEnum genero, int titulo, string descricao, int ano)
        {
            this.Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
