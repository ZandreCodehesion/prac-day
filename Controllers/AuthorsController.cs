using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;






namespace prac_day.Controllers
{
    //using prac_day; MOET NIE HIER STUFF VAN NAMESPACE SKRYF NIE, ALTYD INSIDE OF NAMESPACE AKA line 31 na namespace prac_day.Controllers (reg bo)
    //using var db = new AuthorContext();

    [Route("[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        [HttpPost] //authors
        public IActionResult Post([FromBody] Author newAuthor) //from body vat dadelik van die body af , not case sensitive :)
        {
            using var db = new AuthorContext();
            {
                Console.WriteLine("Creating new entry");
                db.Authors.Add(newAuthor);
                db.SaveChangesAsync(); //better than normal savechanges want dit allow multiple users to interact at the same time without violation
            }
            return Ok(); //test
        }

        
        [HttpGet]
        [Route("[controller]/{requestedID}")]
        public IActionResult Get(Guid requestedID)
        {
            using var db = new AuthorContext();
            
                Console.WriteLine("Creating new entry");
                var filter = db.Authors.Where(author => author.AuthorId == requestedID); //lamba function
                return Ok(filter.First()); //moet first insit want dan maak dit die query wat in 'lys' formaat is , 'n single row.
        }
    }
}




public class Author
{
    public Author()
    {
        AuthorId = Guid.NewGuid();
        CreatedBy = AuthorId;
    }
    [Key] public Guid AuthorId { get; private set; }
    public string? AuthorName { get; set; }
    public DateTime ActiveFrom { get; set; }
    public DateTime ActiveTo { get; set; }
    private Guid CreatedBy;

   


}
