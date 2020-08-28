using ReframeModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReframeData.Repository
{
    public interface IUserRepository : IEntityBaseRepository<User>
    {
        bool IsUsernameUniq(string username);
        bool IsEmailUniq(string email);
    }
}
