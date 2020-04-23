using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Tunning_ErroLog
    {
        [Key]
        [Column(Order = 0)]
        public Guid GuidProcess { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid GuidCompany { get; set; }

        public string DescriptionError { get; set; }
    }
}