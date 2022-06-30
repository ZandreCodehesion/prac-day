using System;
/****Task1****/


using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace prac_day.Controllers
{
    [Route("[controller]")] //route accounts
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpPost("Register")] //accounts/register
        public IActionResult Post([FromBody]Accounts newAccountInfo) //from body vat dadelik van die body af , not case sensitive :)
        {
            //register new user already done in above

            //return Ok(newAccountInfo.getUserId()); //test
            //return Ok(newAccountInfo.userName); //test
            return NoContent(); //return 204 code;
        }
    }
}


//namespace prac_day;

public class Accounts
{

    private Guid UserId;
    public string userName { get; set; }
    public string password { get; set; }


    public void setUserId()
    {
        UserId =  Guid.NewGuid();
        return;
    }

    public Guid getUserId()
    {
        return UserId;
    }




}
