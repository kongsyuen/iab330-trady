using System;
using SQLite;

namespace Trady.Models
{
    public class Item
    {
        public string Information { get; set; }
        public string Photo { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
        [PrimaryKey]
        public int ID { get; set; }
    }
}
