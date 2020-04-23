using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Schema_T_DB_Types
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XtypeCode { get; set; }

        [StringLength(255)]
        public string Xtype { get; set; }

        [StringLength(1)]
        public string IdSpec { get; set; }
    }
}