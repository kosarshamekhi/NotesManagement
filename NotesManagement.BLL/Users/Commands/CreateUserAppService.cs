using MediatR;
using NotesManagement.DAL.Users;
using NotesManagement.Model.Framework;
using NotesManagement.Model.Users.Commands.CreateUsers;
using NotesManagement.Model.Users.Entities;

namespace NotesManagement.BLL.Users.Commands;

public class CreateUserAppService : IRequestHandler<CreateUserInput, ApplicationServiceResponse<CreateUserOutput>>
{
    private readonly UserRepository _userRepository;

    public CreateUserAppService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<ApplicationServiceResponse<CreateUserOutput>> Handle(CreateUserInput createUserInput, CancellationToken cancellationToken)
    {
        User newUser = new User
        {
            FirstName = createUserInput.NewFirstName,
            //LastName = createUserInput.NewLastName,
            Email = createUserInput.NewEmail,
            Age= createUserInput.NewAge,
            //Website = createUserInput.NewWebsite
        };

        _userRepository.AddUser(newUser);

        return new ApplicationServiceResponse<CreateUserOutput>
        {
            Result = new CreateUserOutput() { UserId = newUser.Id }
        };
    }
}
