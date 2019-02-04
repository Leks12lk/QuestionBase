using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuestionBase.Application.Interfaces.DAL
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T item);
        Task<T> Update(T item);
        void Delete(int id);
    }
}
