using compents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace compents.Resporities
    {
    public interface INews
        {
        IEnumerable<News> Getallnews();
        News GetnewsId(int id);
        void createnews(News employee);
        void Updatecomponentnews(News employee);
        void Deletecomponentnews(int id);
        void Save();
    }
}



