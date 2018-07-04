using System;
using System.ComponentModel.DataAnnotations;

namespace UselessAPI.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}