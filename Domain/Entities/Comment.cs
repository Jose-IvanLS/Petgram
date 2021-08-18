using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities {
    class Comment {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Like { get; set; }
        public Profile Profile { get; set; }
    }
}
