using NotesManagement.Model.Users.Entities;

namespace NotesManagement.DAL.Users;

public interface IUserRepository
{
    IEnumerable<User> GetAllUsers();
    User GetById(int id);
    void AddUser(User user);
    void UpdateUser(User user);
    void DeleteUser(int id);
}
