using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.WebAPI.Models.Entities
{
    [Table("session")]
    public class Session
    {
        [Column("id_session")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("location")]
        public string Location { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("time_start")]
        public DateTime TimeStart { get; set; }
        [Column("time_end")]
        public DateTime TimeEnd { get; set; }
    }
}
