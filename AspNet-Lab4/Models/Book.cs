using System.ComponentModel.DataAnnotations;

namespace AspNet_Lab4.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
