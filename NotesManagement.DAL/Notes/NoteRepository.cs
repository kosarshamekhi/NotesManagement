using NotesManagement.DAL.DbContexts;
using NotesManagement.Model.Notes.Entities;
using NotesManagement.Model.Users.Entities;
using System.Collections.Generic;

namespace NotesManagement.DAL.Notes;

public class NoteRepository : INoteRepository
{
    private readonly NoteDbContext _noteDbContext;

    public NoteRepository(NoteDbContext noteDbContext)
    {
        _noteDbContext = noteDbContext;
    }

    public IEnumerable<Note> GetAllUserNotes(int? userId)
    {
        //var listOfNotes = _noteDbContext.Notes.Select(r => _noteDbContext.Notes);
        //var notes = _noteDbContext.Notes.Where(r => listOfNotes.Contains(_noteDbContext.Notes));

        //var notes = _noteDbContext.Notes.Where(r => note.Notes.Any(ur => ur.NoteId == r.Id));

        //var listOfNotes = userId.Notes.Select(r => r.RoleId);
        //var notes = _noteDbContext.Notes.Where(r => listOfNotes.Contains(r.Id));

        //var notes = _noteDbContext.Notes.Where(r => userId.Notes.Contains(r.Id));

        //var notes = _noteDbContext.Notes.Where(x => x.Id == userId).Select(x => x.Note);

        var notes = _noteDbContext.Notes.Where(x => x.UserId == userId).Select(x => x.Content).ToList();
        return (IEnumerable<Note>)notes;

    }

    public Note GetById(int id)
    {
        Note note = _noteDbContext.Notes.FirstOrDefault(u => u.Id == id);
        return note;
    }

    public void AddNote(Note note)
    {
        _noteDbContext.AddAsync(note);
        _noteDbContext.SaveChangesAsync();
    }

    public void DeleteNote(int id)
    {
        _noteDbContext.Remove(id);
        _noteDbContext.SaveChangesAsync();
    }

    public void UpdateNote(Note note)
    {
        _noteDbContext.Update(note);
        _noteDbContext.SaveChangesAsync();
    }
}
