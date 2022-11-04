using System;
using System.Collections.Generic;

namespace BookLib.DataAccess
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Publisher { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public double Price { get; set; }
    }
}
