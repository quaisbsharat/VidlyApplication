using System.Collections.Generic;
using VidlyThirdTime.Models;

namespace VidlyThirdTime.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}