using System.ComponentModel.DataAnnotations;

namespace Web.Data.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
