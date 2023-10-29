namespace Lazar_Beatrice_Lab2.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public book Book { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
