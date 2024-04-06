using InstrumentationAccountingSystem2.Dto;
using InstrumentationAccountingSystem2.Models;

namespace InstrumentationAccountingSystem2.BusinessLogic.Interfaces
{
    public interface IUserService
    {
        void Create(UserCreateDto userCreateDto);

        List<User> GetAll();

        User Get(UserLogInDto userLogInDto);

        User GetUserById(int id);

        void DeleteUserById(int id);

        void Edit(User user);
    }
}
