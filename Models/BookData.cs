namespace Lazar_Beatrice_Lab2.Models
{
    public class BookData
    {

        public IEnumerable<book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }

    }
}
