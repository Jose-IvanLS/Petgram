using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Application {
    interface IBaseService<T> where T : class {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Insert(T item);
        void Update(T item);
        void Delete(T item);
    }
}
