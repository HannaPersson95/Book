using Eksamen_Emne8.Models.DTO;
using Eksamen_Emne8.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eksamen_Emne8.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    //[HttpGet("health")]
    //public string Health()
    //{
    //    return "API OK";
    //}




    [HttpGet(Name = "GetBooks")]
    public async Task<ActionResult<IEnumerable<BookDTO>>> GetBooksAsync()
    {
        return Ok(await _bookService.GetBooksAsync());

    }

    [HttpGet("{id}", Name = "GetBookId")]
    public async Task<ActionResult<BookDTO>> GetBookByIdAsync(int id)
    {
        var res = await _bookService.GetBookByIdAsync(id);
        return res != null ? Ok(res) : NotFound("Could not find Book with that ID");

    }






}
