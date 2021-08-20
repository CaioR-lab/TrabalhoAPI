using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public abstract class BaseRepository<T> where T : Base
    {
        public static List<T> lista = new List<T>();

        public virtual void Create(T model)
        {
            lista.Add(model);
        }

        public virtual T Read (int id)
        {
            return lista.Find(lista => lista.Id == id);
        }

        public virtual List<T> Read()
        {
            return lista;
        }

        public virtual void Update(int Id, T model)
        {
            lista[lista.FindIndex(lista => lista.Id == Id)] = model;
        }

        public virtual void Delete(int Id)
        {
            lista.Remove(lista[lista.FindIndex(lista => lista.Id == Id)]);
        }
    }
}
