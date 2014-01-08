using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace StudentSystemDomainClasses
{
    public class Mark
    {
        [Key]
        public int MarkId { get; set; }

//        [Required]
//        [DataMember(IsRequired = true)] 
        public string Subject { get; set; }
//
//        [Required]
//        [DataMember(IsRequired = true)] 
        public int Value { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

    }
}