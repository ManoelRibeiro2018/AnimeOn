using Serie.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie.Classes
{
    class AnimeRepositorio : IRepositorio<Series>
    {
        public List<Series> ListaSerie = new List<Series>();
        public void Inserir(Series entidade)
        {
            ListaSerie.Add(entidade);
        }
        public void Atualiza(int id, Series entidade)
        {
            ListaSerie[id] = entidade;
        }

        public void Excluir(int id)
        {
            ListaSerie[id].Excluir();
        }

        public List<Series> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Series RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
       
    }
}
