using NotesManagement.Model.Notes.Entities;
using NotesManagement.Model.Users.Entities;

namespace NotesManagement.DAL.Notes;

public interface INoteRepository
{
    IEnumerable<Note> GetAllUserNotes(int? userId);
    Note GetById(int id);
    void AddNote(Note note);
    void UpdateNote(Note note);
    void DeleteNote(int id);
}
