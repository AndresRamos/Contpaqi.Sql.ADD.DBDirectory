using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class Certificates
    {
        [Key]
        public Guid GuidDocument { get; set; }

        [Column(TypeName = "text")]
        public string LlavePublica { get; set; }

        [StringLength(40)]
        public string NumeroSerie { get; set; }

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaFinal { get; set; }

        [Column(TypeName = "text")]
        public string SubjectName { get; set; }

        [Column(TypeName = "text")]
        public string IssuerName { get; set; }

        public bool? IsTesting { get; set; }
    }
}