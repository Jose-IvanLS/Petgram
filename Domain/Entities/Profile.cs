using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities {
    class Profile {
        public Guid Id { get; set; }
        public string Bio { get; set; }
        public string Hobbies { get; set; }
        public string Photo { get; set; }
        public Pet Pet { get; set; }
        public List<Photo> Photos { get; set; }
        public List<Pet> Friends { get; set; }
    }
}
