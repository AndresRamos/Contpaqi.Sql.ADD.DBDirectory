using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    [Table("TempSourceDBDetail")]
    public class TempSourceDBDetail
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string TblName { get; set; }

        [StringLength(255)]
        public string ColName { get; set; }

        public int? ColOrd { get; set; }

        [StringLength(255)]
        public string ColType { get; set; }

        public int? ColLen { get; set; }

        public int? ColPre { get; set; }

        public int? ColSca { get; set; }
    }
}