using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Test.Data.Tables
{
    [DataContract]
    [Table("Users")]
    public class User
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public bool IsAdmin { get; set; }

    }
}
