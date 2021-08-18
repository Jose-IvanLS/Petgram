using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities {
    class Pet {
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender{ get; set; }
        public string Breed { get; set; }
        public Address Address { get; set; }
        public Profile Profile { get; set; }

    }
}
