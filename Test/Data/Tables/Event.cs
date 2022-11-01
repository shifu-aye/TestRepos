using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data.Tables
{
    [DataContract]
    [Table("Events")]
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int X { get; set; }
        [DataMember]
        public int Y { get; set; }
    }
}
