using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Schema_T_DB_Inventory_Views
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDataBase { get; set; }

        [StringLength(255)]
        public string ViewName { get; set; }
    }
}