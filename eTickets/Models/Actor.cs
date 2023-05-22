using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public int ProfilePictureURL { get; set; }

        public int FullName { get; set; }
        public int Bio { get; set; }

        //Relationship

        public List<Actor_Movie> Actors_movies { get; set; }


    }
}
