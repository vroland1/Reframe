using ReframeData.Context;
using ReframeModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReframeData.Repository
{
    public class UserRepository : ReframeRepository<User>, IUserRepository
    {
        public UserRepository(ReframeContext context) : base(context) { }

        public bool IsEmailUniq(string email)
        {
            var user = this.GetSingle(u => u.Email == email);
            return user == null;
        }

        public bool IsUsernameUniq(string username)
        {
            var user = this.GetSingle(u => u.Username == username);
            return user == null;
        }
    }
}
