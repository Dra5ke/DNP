using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Dotnetimals
{
    public class DbRepository
    {
        private readonly CatContext _context;

        public DbRepository(CatContext context)
        {
            _context = context;
            DbInitializer.Initialize(_context);
        }

        public IEnumerable<Cat> GetAllCats()
        {
            return _context.Cats.OrderBy(c => c.Id).ToList();
        }

        public IEnumerable<Cat> GetCatsByMaxPrice(decimal price)
        {
            return _context.Cats.Where(c => c.Price <= price).ToList();
        }

        public IQueryable<Cat> GetCatById(int Id)
        {
            return _context.Cats.Where(c => c.Id == Id);
        }

        public void AddCat(Cat cat)
        {
            _context.Cats.Add(cat);
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
