using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IntelligenceFarmer.tableDb
{
    [Table("hassan")]
    public class hassan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string names { get; set; }
       // public IList<hassan> Products { get; set; } = new List<hassan>();
    }
}
