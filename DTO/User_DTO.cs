using System;

namespace App.Core.Dto {
    
        public class User_DTO {

        public long ID { get; set; }

#nullable enable
        virtual public Role_DTO? Role { get; set; }
#nullable disable
    }

}

