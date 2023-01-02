using Microsoft.EntityFrameworkCore;
using NotesManagement.Model.Notes.Entities;
using NotesManagement.Model.Users.Entities;

namespace NotesManagement.DAL.DbContexts;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
        new User
        {
            FirstName = "Ali",
            LastName = "Hoseyni",
            Email = "AliHoseyni@gmail.com",
            Age = 20,
            Website = ""
        }
        );
        modelBuilder.Entity<Note>().HasData(
            new Note { Content = " Salam ", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true },
            new Note { Content = "My Name is Kosar", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true }
        );

        modelBuilder.Entity<User>().HasData(
        new User
        {
            FirstName = "zahra",
            LastName = "Rahimi",
            Email = "zahraRahimi@gmail.com",
            Age = 34,
            Website = ""
        }
        );
        modelBuilder.Entity<Note>().HasData(
            new Note { Content = "Hiiiiiii", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true },
            new Note { Content = "My Name is Zahraaaaaaaa", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true }
        );

        modelBuilder.Entity<User>().HasData(
        new User
        {
            FirstName = "zahra",
            LastName = "Rahimi",
            Email = "zahraRahimi@gmail.com",
            Age = 34,
            Website = ""
        }
        );
        modelBuilder.Entity<Note>().HasData(
            new Note { Content = "Hiiiiiii", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true },
            new Note { Content = "My Name is Zahraaaaaaaa", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true }
        );
    }
}