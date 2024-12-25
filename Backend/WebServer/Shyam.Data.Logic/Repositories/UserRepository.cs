using Shyam.Data.Entities;
using Shyam.Data.Interfaces.Repositories;

namespace Shyam.Data.Logic.Repositories
{
    internal class UserRepository : IUserRepository
    {
        public List<User> AllUser()
        {
            throw new NotImplementedException();
        }

        public User GetByUserName(string userName, string password)
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    UserName = "Deepak",
                    Password = "123456"
                },
                new User()
                {
                    UserName = "Shyam",
                    Password = "123456"
                }
            };

            User user = users.FirstOrDefault(x => x.UserName == userName && x.Password == password)!;
            return user;
        }
                   
    }
}
