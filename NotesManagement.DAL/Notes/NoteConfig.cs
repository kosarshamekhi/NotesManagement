using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotesManagement.Model.Notes.Entities;

namespace NotesManagement.DAL.Notes;

public class NoteConfig : IEntityTypeConfiguration<Note>
{
    public void Configure(EntityTypeBuilder<Note> builder)
    {
        builder.Property(c => c.Id).IsRequired();
        builder.Property(c => c.Content).IsRequired();
        builder.Property(c => c.DateCreated).IsRequired();
        builder.Property(c => c.DateModified).IsRequired();
        builder.Property(c => c.Views).IsRequired();
        builder.Property(c => c.Published).IsRequired();
    }
}
