using System;
using System.Collections.Generic;

#nullable disable

namespace DocumentService.Models
{
    public partial class User
    {
        public User()
        {
            Documents = new HashSet<Document>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string EmaiId { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
