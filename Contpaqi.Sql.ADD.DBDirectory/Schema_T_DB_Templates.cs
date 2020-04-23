using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Schema_T_DB_Templates
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDataBase { get; set; }

        [StringLength(255)]
        public string DataBaseName { get; set; }

        [StringLength(10)]
        public string CurrentVersion { get; set; }
    }
}