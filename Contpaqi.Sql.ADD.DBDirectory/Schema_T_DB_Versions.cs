using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Schema_T_DB_Versions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDataBase { get; set; }

        [StringLength(255)]
        public string DataBaseName { get; set; }

        [StringLength(10)]
        public string Version { get; set; }

        [StringLength(200)]
        public string ErrorDescription { get; set; }
    }
}