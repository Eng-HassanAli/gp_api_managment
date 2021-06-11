using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace IntelligenceFarmer.tableDb
{
    [Table("farms")]
    public class Farms
    {

        [Key]
        public int Farm_Id { get; set; }
        public string Ssn_Id { get; set; }
        //  [ForeignKey("User_Id")]
        public int user_id { get; set; }
        //public Users users { get; set; }
        public string Type_Soil { get; set; }
        public Double Area { get; set; }
        public string Governorate { get; set; }
        public string Region { get; set; }
        public Byte[] Image_farm { get; set; }
        public Double Longitude { get; set; }
        public Double Latitude { get; set; }
    }
}
