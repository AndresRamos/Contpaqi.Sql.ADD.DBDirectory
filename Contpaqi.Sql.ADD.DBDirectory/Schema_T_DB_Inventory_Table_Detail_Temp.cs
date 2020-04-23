using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Schema_T_DB_Inventory_Table_Detail_Temp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDataBase { get; set; }

        [StringLength(255)]
        public string TableName { get; set; }

        [StringLength(255)]
        public string ColumnName { get; set; }

        public int? XtypeCode { get; set; }

        [StringLength(25)]
        public string Xtype { get; set; }

        public int? Lenght { get; set; }

        public int? Prec { get; set; }

        public int? Scale { get; set; }

        public int? ColOrder { get; set; }
    }
}