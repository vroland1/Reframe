using System;
using System.Collections.Generic;
using System.Text;

namespace ReframeEntities.Entities
{
    public class ThoughtLog
    {
        public int Id { get; set; }

        public int NegativeThoughtTypeId { get; set; }

        public virtual NegativeThoughtType NegativeThoughtType { get; set; }

        public int UserId { get; set; }

        //public virtual ApplicationUser {get; set;}

        public string NegativeThought { get; set; }

        public string Challenge { get; set; }

        public string NewThought { get; set; }

        public DateTime LogDate { get; set; }

    }
}
