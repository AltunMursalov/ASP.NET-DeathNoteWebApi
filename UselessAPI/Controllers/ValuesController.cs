using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UselessAPI.Models;

namespace UselessAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ValuesController : Controller
    {
        private readonly DeathNoteContext context;

        public ValuesController(DeathNoteContext context)
        {
            this.context = context; 
        }


        // GET api/values
        [HttpGet("/api/[controller]/getdata")]
        public IEnumerable<DeathNote> Get()
        {
            var notes = context.Notes.Include(n => n.Person).ToList();
            List<DeathNote> deathNotes = new List<DeathNote>();
            foreach (var note in notes) {
                deathNotes.Add(new DeathNote {
                    Date = note.Date,
                    Description = note.Description,
                    Name = note.Person.Name,
                    Surname = note.Person.Surname,
                    Image = note.Person.Image,
                    IdNote = note.Id,
                    IdPerson = note.PersonId
                });
            }
            return deathNotes;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost("/api/[controller]/create")]
        public void Post([FromBody]DeathNote value)
        {
            context.Notes.Add(new Note {
                Date = value.Date,
                Description = value.Description,
                Person = new Person {
                    Name = value.Name,
                    Image = value.Image,
                    Surname = value.Surname,
                }
            });
            context.SaveChanges();
        }

        // PUT (UPDATE) api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]DeathNote value)
        {
            context.Notes.Update(new Note {
                Id = value.IdNote,
                Date = value.Date,
                Description = value.Description,
                PersonId = value.IdPerson
            });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
