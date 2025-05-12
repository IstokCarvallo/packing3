using System;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packing3.Models
{
    [Table("TimbreSAG", Schema = "dbo")]
    public class TimbreSAG
    {
        [Key]
        [SqlColumn("tisa_codigo")]
        public decimal Tisa_Codigo { get; set; }

        [SqlColumn("tisa_nombre")]
        public string? Tisa_Nombre { get; set; }

    }
}
