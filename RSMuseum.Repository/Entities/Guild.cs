﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSMuseum.Repository.Entities
{
    public class Guild
    {
        public int GuildId { get; set; }

        [Required]
        public string GuildName { get; set; }

        public virtual IList<Volunteer> Volunteers { get; set; }
    }
}