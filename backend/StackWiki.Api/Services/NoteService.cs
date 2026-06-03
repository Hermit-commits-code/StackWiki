using StackWiki.Api.Interfaces;
using StackWiki.Api.Models;

namespace StackWiki.Api.Services;

public class NoteService : INoteService
{
    public IEnumerable<Note> GetAllNotes()
    {
        return new List<Note>
        {
            new Note
            {
                Id = 1,
                Title = "Classes",
                Content = "Classes are blueprints for objects."
            },
            new Note
            {
                Id = 2,
                Title = "Variables",
                Content = "Variables store data."
            }
        };
    }
}
