using System;
using System.Collections.Generic;

#nullable disable

namespace DocumentService.Models
{
    public partial class Document
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public byte[] Document1 { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
