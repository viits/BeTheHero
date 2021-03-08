using System.Collections.Generic;
using System.Threading.Tasks;
using Projeto.Models;

namespace Projeto.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        bool Save();
        Ongs[] GetAllOngs();

        Ongs GetById(int id);

        Incident[] GetAllIncidents();
        
        Incident GetByIdIncident(int id);
        

    }
}