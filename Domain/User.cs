using System;

namespace Domain.Core.Models {
    

    public class User {

        public long ID { get; set; }

        public string Name {get;set;}

#nullable enable
        virtual public Role? Role { get; set; }
#nullable disable
    }

}

