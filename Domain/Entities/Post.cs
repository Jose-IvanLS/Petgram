using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities {
    class Post {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Like { get; set; }
        public DateTime Date { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Photo> Photos { get; set; }

    }
}
