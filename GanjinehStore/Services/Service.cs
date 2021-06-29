using GanjinehStore.Data;
using GanjinehStore.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GanjinehStore.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<Service<T>> _logger;

        public Service(ApplicationDbContext context, ILogger<Service<T>> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();

        public T GetById(int id) => _context.Set<T>().Find(id);

        public T Add(T tEntity)
        {
            try
            {
                _context.Set<T>().Add(tEntity);
                _context.SaveChanges();

                return tEntity;
            }
            catch (Exception ex)
            {
                LogError(ex.StackTrace, ex.Message);

                return null;
            }
        }

        public T Remove(int id)
        {
            try
            {
                var tEntity = GetById(id);

                _context.Set<T>().Remove(tEntity);
                _context.SaveChanges();

                return tEntity;
            }
            catch (Exception ex)
            {
                LogError(ex.StackTrace, ex.Message);

                return null;
            }
        }

        public T Update(int id, T tEntity)
        {
            try
            {
                _context.Set<T>().Update(tEntity);
                _context.SaveChanges();

                return tEntity;
            }
            catch (Exception ex)
            {
                LogError(ex.StackTrace, ex.Message);

                return null;
            }
        }

        // helpers
        public void LogError(string stackTrace, string message) 
        {
            _logger.LogError($"{stackTrace} - {message}");
        }
    }
}
