using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie.Interface
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornadoPorId(int id);
        void Inserir(T entidade);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
