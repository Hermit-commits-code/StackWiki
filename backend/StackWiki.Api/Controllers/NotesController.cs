using Microsoft.AspNetCore.Mvc;
using StackWiki.Api.Models;

namespace StackWiki.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Note>> Get()
    {
        var notes = new List<Note>
        {
            new Note { Id = 1, Title = "First Note", Content = "This is the content of the first note." },
            new Note { Id = 2, Title = "Second Note", Content = "This is the content of the second note." }
        };

        return Ok(notes);
    }
}
