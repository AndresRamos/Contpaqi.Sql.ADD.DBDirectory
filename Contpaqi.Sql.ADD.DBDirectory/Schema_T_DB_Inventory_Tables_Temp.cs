using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Schema_T_DB_Inventory_Tables_Temp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDataBase { get; set; }

        [StringLength(255)]
        public string TableName { get; set; }

        [StringLength(2)]
        public string IdObject { get; set; }

        public int? NumberOfRows { get; set; }
    }
}