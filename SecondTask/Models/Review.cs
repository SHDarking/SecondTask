using System;
using System.Collections.Generic;

namespace SecondTask.Models
{
    public partial class Review
    {
        public int Id { get; set; }
        public string Message { get; set; } = null!;
        public int BookId { get; set; }
        public string Reviewer { get; set; } = null!;

        public virtual Book Book { get; set; } = null!;
    }
}
