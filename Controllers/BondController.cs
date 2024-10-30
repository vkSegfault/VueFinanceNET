using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VueFinanceNET.Models;

namespace VueFinanceNET.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BondController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Bond>>> GetAllBonds()
    {
        var bonds = new List<Bond>()
        {
            new Bond{ Name = "obligacja1", Description = "PIERWSZA"}
        };

        return Ok(bonds);
    }
}