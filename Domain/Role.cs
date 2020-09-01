using System;
using System.Collections.Generic;

namespace Domain.Core.Models {
    
        public class Role {

        public Role() {
            this.Users = new HashSet<User>();
        }

        public long ID { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public virtual ICollection<User> Users { get; private set; }
    }
    
}

