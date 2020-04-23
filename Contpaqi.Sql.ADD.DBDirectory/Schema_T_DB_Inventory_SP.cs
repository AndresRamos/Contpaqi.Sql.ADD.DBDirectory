using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Schema_T_DB_Inventory_SP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDataBase { get; set; }

        [StringLength(255)]
        public string SPName { get; set; }

        public int? CodeSize { get; set; }

        [StringLength(2)]
        public string IdObject { get; set; }
    }
}