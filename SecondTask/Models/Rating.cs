using System;
using System.Collections.Generic;

namespace SecondTask.Models
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public decimal Score { get; set; }

        public virtual Book Book { get; set; } = null!;
    }
}
