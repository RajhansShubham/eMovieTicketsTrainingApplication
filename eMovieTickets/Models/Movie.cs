using eMovieTickets.Utility;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMovieTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double Price { get; set; }

        public Cinemas CinemaName { get; set; }

        public IList<Actor> Actors { get; set; }

        public MovieCatagories MovieCataogory { get; set; }

        public string ImageURL { get; set; }


        //Relations

        public List<Actors_Movie> Actors_Movies { get; set; }


        //Cinema realtion
        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public Cinemas Cinema { get; set; }

        //Producer Relations
        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }       
}
