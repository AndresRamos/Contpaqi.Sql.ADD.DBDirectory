using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Owners
    {
        [Key]
        [Column(Order = 0)]
        public Guid GuidOwner { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid GuidCompany { get; set; }

        [StringLength(100)]
        public string ApplicationType { get; set; }

        [StringLength(12)]
        public string MemberType { get; set; }

        public byte? Read { get; set; }

        public byte? Write { get; set; }

        public virtual DatabaseDirectory DatabaseDirectory { get; set; }
    }
}