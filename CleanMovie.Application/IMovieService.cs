using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    /// <summary>
    /// This is a use case
    /// </summary>
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
    }
}
