using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities {
    class Address {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
