using System.ComponentModel.DataAnnotations;

namespace UselessAPI.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public virtual Note Note { get; set; }
    }
}