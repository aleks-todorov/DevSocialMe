﻿
using System.Collections.Generic;
namespace DevSocialMe.Models
{
    public class Vote
    {
        public int VoteId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<ApplicationUser> Voters { get; set; }

        public Vote()
        {
            this.Voters = new HashSet<ApplicationUser>();
        }
    }
}
