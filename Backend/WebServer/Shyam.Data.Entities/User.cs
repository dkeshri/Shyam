using Shyam.Data.Entities.Base;

namespace Shyam.Data.Entities
{
    public class User : EntityBase
    {
        public string UserName {  get; set; }
        public string Password { get; set; }
    }
}
