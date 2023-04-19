using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp.Maui.Models
{
    [Table("NcuEvents")]
    public class Events : BaseEntity
    {
        
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        [MaxLength(50)]
        [Unique]
        public string Description { get; set; }
    }

}
