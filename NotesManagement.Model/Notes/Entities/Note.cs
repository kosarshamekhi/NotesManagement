using NotesManagement.Model.Users.Entities;

namespace NotesManagement.Model.Notes.Entities;

public class Note
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public int Views { get; set; }
    public bool Published { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
}
