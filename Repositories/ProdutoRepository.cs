using ProjetoAula05.Contexts;
using ProjetoAula05.Entities;
using ProjetoAula05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Repositories
{
    public class ProdutoRepository : IGenericRepository<Produto, Guid>
    {
        public void Add(Produto obj)
        {
            using(var dataContext = new DataContext())
            {
                dataContext.Add(obj);
                dataContext.SaveChanges();

           }
        }

        public void Update(Produto obj)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Update(obj);
                dataContext.SaveChanges();

            }
        }

        public void Delete(Produto obj)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(obj);
                dataContext.SaveChanges();

            }
        }

        public List<Produto> GetAll()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<Produto>().OrderBy(p => p.Nome).ToList();
                
            }
        }

        public Produto GetById(Guid id)
        {
            using (var dataContext = new DataContext())
            {
                //retornar 1 produto baseado pelo ID
                return dataContext.Set<Produto>().Find(id);
            }
        }
    }
}
