using Shyam.Data.Entities;

namespace Shyam.Data.Interfaces.Repositories
{
    public interface IUserRepository
    {
        public List<User> AllUser();
    }
}
