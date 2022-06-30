using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace prac_day.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpPost("Register")]
        public IActionResult Post([FromBody]Accounts newAccountInfo) //from body vat dadelik van die body af , not case sensitive :)
        {
            //register new user already done in above

            //return Ok(null); // ok response without a body or text returned - nope
            //return StatusCode(System.Net.HttpStatusCode.NoContent) - nope

            //StatusCodeResult code = new StatusCodeResult(204); // nope
            //return code;
            //Response.StatusCode = 204;
            return NoContent();
        }
    }
}


//namespace prac_day;

public class Accounts
{

    private Guid UserId;
    private string userName;
    private string password;
    

    public Guid GenerateGuidId()
    {
        return Guid.NewGuid();
    }

    public string Username { get; set; }
    public string Password { get; set; }
    public Guid Userid { get; set; }



}
