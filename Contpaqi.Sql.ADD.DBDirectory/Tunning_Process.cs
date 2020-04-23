using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Tunning_Process
    {
        [Key]
        [Column(Order = 0)]
        public Guid GuidProcess { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid GuidCompany { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? TruncatedLogs { get; set; }

        public int? ReorganicedIdx { get; set; }

        public int? RebuildedIdx { get; set; }

        public byte? UpdStatix { get; set; }
    }
}