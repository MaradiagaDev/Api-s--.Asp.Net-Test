using ASP.Net_Test.Data;
using ASP.Net_Test.Models;
using ASP.Net_Test.Objects;

namespace ASP.Net_Test.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext dataContext;

        public UserService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        //CRUD

        public void CreateUser(UserModel user)
        {
            User User_ = new User
            {
                UserName = user.UserName,
                Password = user.Password,
                State = "Active"
            };
            dataContext.Add(User_);
            dataContext.SaveChanges();

        }

        public void UpdateUser(UserModel user, int id)
        {
            User User_Data = dataContext.Users.Where(user => user.Id == id).FirstOrDefault();
            User_Data.UserName = user.UserName;
            User_Data.Password = user.Password;
            dataContext.SaveChanges();
        }

        public User GetbyId(int id)
        {
            return this.dataContext.Users.Find(id);
        }

        public void ChangeState(int id)
        {
            User user = this.dataContext.Users.Where(user => user.Id == id).FirstOrDefault();

            if (user.State == "" || user.State == "Inactive")
            {
                user.State = "Active";
            }
            else
            {
                user.State = "Inactive";
            }

            this.dataContext.Update(user);
            this.dataContext.SaveChanges();
        }
        public void Delete(int id)
        {
            this.dataContext.Users.Remove(GetbyId(id));
            this.dataContext.SaveChanges();      
        }

        public IEnumerable<User> SearchUserByName(string UserName)
        {
            List<User> users = this.dataContext.Users.Where(user => user.UserName.Contains(UserName)).ToList();

            return users;
        }
        public IEnumerable<User> GetAll()
        {
            List<User> users = this.dataContext.Users.ToList();
            return users;
        }
    }
}
