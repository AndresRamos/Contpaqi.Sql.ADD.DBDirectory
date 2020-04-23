using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    [Table("ProcessControl")]
    public class ProcessControl
    {
        [Key]
        public Guid GuidControl { get; set; }

        public Guid? GuidCompany { get; set; }

        public int? Id_Process { get; set; }

        [StringLength(255)]
        public string ProcessDescription { get; set; }

        public int? Percentage { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? TotalExtracted { get; set; }

        public int? TotalProcessed { get; set; }

        [StringLength(255)]
        public string LogName { get; set; }

        [StringLength(50)]
        public string StatusProcess { get; set; }

        [StringLength(255)]
        public string JSONName { get; set; }

        public virtual Cat_Process Cat_Process { get; set; }
    }
}