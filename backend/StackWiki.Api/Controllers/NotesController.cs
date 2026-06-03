using Microsoft.AspNetCore.Mvc;
using StackWiki.Api.Models;
using StackWiki.Api.Interfaces;
namespace StackWiki.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotesController : ControllerBase
{
    private readonly INoteService _noteService;

    public NotesController(INoteService noteService)
    {
        _noteService = noteService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Note>> Get()
    {
        var notes = _noteService.GetAllNotes();
        return Ok(notes);
    }
}
