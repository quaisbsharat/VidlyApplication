using System.Collections.Generic;
using VidlyThirdTime.Models;

namespace VidlyThirdTime.ViewModel
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}