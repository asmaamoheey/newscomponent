using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using compents.Models;
using System.ComponentModel.DataAnnotations.Schema;
    namespace compents.Models
    {
        public class News
        {
            public News()
            {
                categories = new List<Category>();
            }
            public int id { get; set; }
            public string title { get; set; }
            public string content { get; set; }
            public string photo { get; set; }
            public DateTime publichdate { get; set; }
            public virtual List<Category> categories { get; set; }
            [ForeignKey("sourses")]
           public int sourseid { get; set; }
            public virtual Source sources { get; set; }



        }
    }


