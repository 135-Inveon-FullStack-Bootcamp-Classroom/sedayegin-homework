using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6_InveonMoviesWebApi.Concrete
{
    public class Genre :IBaseEntity
    {
        public string GenreName { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
