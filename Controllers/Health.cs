using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eksamen_Emne8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Health : ControllerBase
{


    [HttpGet("Health")]
    public string GetHealth()
    {
        return "API OK";
    }





}
