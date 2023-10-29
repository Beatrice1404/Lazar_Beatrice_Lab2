namespace Lazar_Beatrice_Lab2.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public ICollection<book>? Books { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
