using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6_InveonMoviesWebApi.Concrete
{
    public class Movie :IBaseEntity
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Details { get; set; }
        public IList<Actor> Actors { get; set; }
        public IList<Genre> Genres { get; set; }
        public Producer Producer { get; set; }
        public int ProducerId { get; set; }
    }
}
