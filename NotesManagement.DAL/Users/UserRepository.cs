using NotesManagement.DAL.DbContexts;
using NotesManagement.Model.Users.Entities;
using System.Xml.Linq;

namespace NotesManagement.DAL.Users;

public class UserRepository : IUserRepository
{
    private readonly NoteDbContext _noteDbContext;

    public UserRepository(NoteDbContext noteDbContext)
    {
        _noteDbContext = noteDbContext;
    }

    public IEnumerable<User> GetAllUsers()
    {
        IQueryable<User> users = _noteDbContext.Users;
        return users.ToList();
    }

    public User GetById(int id)
    {
        User user = _noteDbContext.Users.FirstOrDefault(u => u.Id == id);
        return user;
    }

    public void AddUser(User user)
    {
        _noteDbContext.AddAsync(user);
        _noteDbContext.SaveChangesAsync();
    }

    public void UpdateUser(User user)
    {
        _noteDbContext.Update(user);
        _noteDbContext.SaveChangesAsync();
    }   

    public void DeleteUser(int id)
    {
        _noteDbContext.Remove(id);
        _noteDbContext.SaveChangesAsync();
    }
}
