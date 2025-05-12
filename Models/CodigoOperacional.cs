using System;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packing3.Models
{
    [Table("CodigoOperacional", Schema = "dbo")]
    public class CodigoOperacional
    {
        [Key]
        [SqlColumn("coop_codigo")]
        public string Coop_Codigo { get; set; }

        [Key]
        [SqlColumn("espe_codigo")]
        public decimal Espe_Codigo { get; set; }

        [SqlColumn("coop_nombre")]
        public string? Coop_Nombre { get; set; }

    }
}
