using compents.Models;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace compents.Resporities
{
    public class newsrepositry : INews
    {
      //  baserepository<T> : Ibaserepository<T> where T : class
      //{
      //  protected dbcontext _context;
      //  public baserepository(dbcontext context)
      //  {
      //      _context = context;
      //  }

        private readonly newscontext _dbContext;

        //public newsrepositry()
        //{
        //    _dbContext = new newscontext();
        //}
        public newsrepositry(newscontext context)
        {
            _dbContext = context;
        }

        public IEnumerable<News> Getallnews()
        {
            return _dbContext.news.ToList();
        }

        public News GetnewsId(int id)
        {
            return _dbContext.news.Find(id);
        }

        public void createnews(News employee)
        {
            _dbContext.news.Add(employee);
            Save();
        }

        public void Updatecomponentnews(News employee)
        {
            _dbContext.Entry(employee).State = EntityState.Modified;
        }

        public void Deletecomponentnews(int id)
        {
            var employee = _dbContext.news.Find(id);
            if (employee != null) _dbContext.news.Remove(employee);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        
    }
}

