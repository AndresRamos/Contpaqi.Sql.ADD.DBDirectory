using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Schema_T_Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDataBase { get; set; }

        [StringLength(255)]
        public string DataBaseName { get; set; }

        [StringLength(255)]
        public string ComponentName { get; set; }

        [StringLength(2)]
        public string IdObject { get; set; }

        [StringLength(255)]
        public string Action { get; set; }
    }
}