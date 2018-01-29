using System;
using System.Collections.Generic;

namespace Vidly.Models.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }   
}
