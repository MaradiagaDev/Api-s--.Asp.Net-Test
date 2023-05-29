using ASP.Net_Test.Models;
using ASP.Net_Test.Objects;

namespace ASP.Net_Test.Services
{
    public interface IUserService
    {
        void ChangeState(int id);
        void CreateUser(UserModel user);
        void Delete(int id);
        IEnumerable<User> GetAll();
        User GetbyId(int id);
        IEnumerable<User> SearchUserByName(string UserName);
        void UpdateUser(UserModel user, int id);
    }
}