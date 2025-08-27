using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTrackingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie();
            movie1.Id = 1;
            movie1.Name = "Prens";
            movie1.Type = "Komedi";
            movie1.Duration = 40;
            movie1.ViewStatus = true;

            Movie movie2 = new Movie();
            movie2.Id = 2;
            movie2.Name = "Bir İstanbul Masalı";
            movie2.Type = "Dram";
            movie2.Duration = 75;
            movie2.ViewStatus = false;

            Movie movie3 = new Movie();
            movie3.Id = 3;
            movie3.Name = "1862";
            movie3.Type = "Aşk,Dram";
            movie3.Duration = 80;
            movie3.ViewStatus = false;

            var movies = new Movie[] { movie1, movie2, movie3 };
            foreach (var movie in movies)
            {
                movie.MovieInfo();
            }
            movie3.MarkAsWatched();
            movie2.UpdateDuration(60);
        }
    }
}
