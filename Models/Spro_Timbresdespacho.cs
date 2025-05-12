using System;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packing3.Models
{
    [Table("spro_timbresdespacho", Schema = "dbo")]
    public class Spro_Timbresdespacho
    {
        [Key]
        [SqlColumn("tide_codigo")]
        public decimal Tide_Codigo { get; set; }

        [SqlColumn("tide_descri")]
        public string? Tide_Descri { get; set; }

    }
}
