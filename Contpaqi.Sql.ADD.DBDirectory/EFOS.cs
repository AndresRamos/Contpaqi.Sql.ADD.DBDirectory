using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.DBDirectory
{
    public class EFOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int No { get; set; }

        [StringLength(13)]
        public string RFC { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Situacion { get; set; }

        [StringLength(255)]
        public string NoPublica { get; set; }

        public DateTime? PubSATPresuntos { get; set; }

        [StringLength(250)]
        public string NumGlobPres { get; set; }

        public DateTime? PubDOFPresuntos { get; set; }

        public DateTime? PubSatDesvir { get; set; }

        [StringLength(250)]
        public string NumGlobContDesv { get; set; }

        [StringLength(250)]
        public string PubDofDesvir { get; set; }

        [StringLength(250)]
        public string NumGlobDef { get; set; }

        public DateTime? PubSATDef { get; set; }

        public DateTime? PubDofDef { get; set; }
    }
}