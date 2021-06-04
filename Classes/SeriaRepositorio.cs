using Serie.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie.Classes
{
    class SeriaRepositorio : IRepositorio<Serie>
    {
        public List<Serie> ListaSerie = new List<Serie>();
       

        public void Inserir(Serie entidade)
        {
            ListaSerie.Add(entidade);
        }
        public void Atualiza(int id, Serie entidade)
        {
            ListaSerie[id] = entidade;
        }

        public void Excluir(int id)
        {
            ListaSerie[id].Excluir();
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornadoPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}
