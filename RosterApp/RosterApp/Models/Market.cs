using System;
using SQLite;

namespace RosterApp.Models
{
    [Table("Market")]
    public class Market
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
    }
}