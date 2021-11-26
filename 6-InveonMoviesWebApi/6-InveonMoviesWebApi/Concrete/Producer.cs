using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6_InveonMoviesWebApi.Concrete
{
    public class Producer : IBaseEntity
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public IList<Movie> Movies { get; set; }
    }
}
