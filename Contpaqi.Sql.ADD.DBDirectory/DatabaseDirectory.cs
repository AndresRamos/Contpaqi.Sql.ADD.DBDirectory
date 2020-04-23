using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    [Table("DatabaseDirectory")]
    public class DatabaseDirectory
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatabaseDirectory()
        {
            Owners = new HashSet<Owners>();
        }

        public long idDataBase { get; set; }

        [Key]
        public Guid GuidCompany { get; set; }

        [StringLength(7)]
        public string Version { get; set; }

        [StringLength(255)]
        public string NombreEmpresa { get; set; }

        [StringLength(255)]
        public string DB_DocumentsMetadata { get; set; }

        public decimal? Ver_DocumentsMetadata { get; set; }

        [StringLength(255)]
        public string DB_DocumentsContent { get; set; }

        public decimal? Ver_DocumentsContent { get; set; }

        [StringLength(255)]
        public string DB_OthersMetadata { get; set; }

        public decimal? Ver_OthersMetadata { get; set; }

        [StringLength(255)]
        public string DB_OthersContent { get; set; }

        public decimal? Ver_OthersContent { get; set; }

        public DateTime? Syncronized { get; set; }

        [StringLength(20)]
        public string Accesibility { get; set; }

        public DateTime? TimeStamp { get; set; }

        [StringLength(255)]
        public string Alias { get; set; }

        [StringLength(15)]
        public string RFC { get; set; }

        [StringLength(255)]
        public string CompanyPath { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Owners> Owners { get; set; }
    }
}