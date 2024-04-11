using ProjetoAula05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Interfaces
{
    /// <summary>
    /// Interface genérica para definir os métodos basicos de repositório.
    /// </summary>
    public interface IGenericRepository<T, ID>
        where T : class
    {
        #region Métodos abstratos

        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);

        List<T> GetAll();
        T GetById(ID id);

        #endregion
    }
}



