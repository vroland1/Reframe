using ReframeEntities.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReframeEntities.Entities
{
    public class User : IEntityBase
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
