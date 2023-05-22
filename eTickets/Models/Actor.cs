using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int MyProperty { get; set; }
        public int ProfilePictureURL { get; set; }

        public int FullName { get; set; }
        public int Bio { get; set; }


    }
}
