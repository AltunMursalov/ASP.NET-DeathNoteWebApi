using System;

namespace UselessAPI.Models
{
    public class DeathNote
    {
        public int IdNote { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int IdPerson { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
    }
}