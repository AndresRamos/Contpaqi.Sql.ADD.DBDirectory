using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class EFOS_Version
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Type { get; set; }

        [StringLength(10)]
        public string Version { get; set; }

        [StringLength(250)]
        public string URL { get; set; }

        public DateTime? Fecha { get; set; }
    }
}