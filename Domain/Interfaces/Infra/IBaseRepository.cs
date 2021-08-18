using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Infra {
    interface IBaseRepository <T> where T : class{
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Insert(T item);
        void Update(T item);
        void Delete(T item);
    }
}
