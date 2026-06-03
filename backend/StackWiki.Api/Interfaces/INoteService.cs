using StackWiki.Api.Models;
namespace StackWiki.Api.Interfaces;

public interface INoteService
{
    IEnumerable<Note> GetAllNotes();
}
