using System.ComponentModel.DataAnnotations;

namespace Lazar_Beatrice_Lab2.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string AuthorName
        {
            get { return FirstName + " " + LastName; }
        }

      
        public ICollection<book>? Books { get; set; }
    }
}
