using Shyam.Data.Entities;

namespace Shyam.Data.Interfaces.Repositories
{
    public interface IUserRepository
    {
        public List<User> AllUser();
        public User GetByUserName(string userName,string password);
    }
}
