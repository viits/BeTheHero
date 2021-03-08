using System.Linq;
using Microsoft.EntityFrameworkCore;
using Projeto.Models;

namespace Projeto.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public Incident[] GetAllIncidents()
        {
            IQueryable<Incident> query = _context.Incidents;
            return query.ToArray();
        }

        public Ongs[] GetAllOngs()
        {
            IQueryable<Ongs> query = _context.Ongs;
            return query.ToArray();
        }

        public Ongs GetById(int id)
        {
            IQueryable<Ongs> query = _context.Ongs;

            (query = query.AsNoTracking()
                .Where(ong => ong.Id == id))
                .FirstOrDefault();
            return query.FirstOrDefault();    
        }

        public Incident GetByIdIncident(int id)
        {
            IQueryable<Incident> query = _context.Incidents;
            (query = query.AsNoTracking()
                .Where(incident => incident.Id == id))
                .FirstOrDefault();
            return query.FirstOrDefault();
        }

        public bool Save()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}