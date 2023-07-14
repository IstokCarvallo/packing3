using System;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packing3
{
    [Table("envases", Schema = "dbo")]
    public class Envases
    {
        [Key]
        [SqlColumn("enva_tipoen")]
        public decimal Enva_Tipoen { get; set; }

        [Key]
        [SqlColumn("enva_codigo")]
        public decimal Enva_Codigo { get; set; }

        [SqlColumn("enva_nombre")]
        public string? Enva_Nombre { get; set; }

        [SqlColumn("enva_pesone")]
        public decimal? Enva_Pesone { get; set; }

        [SqlColumn("enva_pesobr")]
        public decimal? Enva_Pesobr { get; set; }

        [SqlColumn("enva_dfaesp")]
        public string? Enva_Dfaesp { get; set; }

        [SqlColumn("enva_dfaing")]
        public string? Enva_Dfaing { get; set; }

        [SqlColumn("emes_codigo")]
        public decimal? Emes_Codigo { get; set; }

        [SqlColumn("enva_kilcua")]
        public decimal? Enva_Kilcua { get; set; }

        [SqlColumn("enva_noming")]
        public string? Enva_Noming { get; set; }

        [SqlColumn("enva_tipoma")]
        public decimal? Enva_Tipoma { get; set; }

        [SqlColumn("enva_unidad")]
        public decimal? Enva_Unidad { get; set; }

        [SqlColumn("enva_agrupa")]
        public string? Enva_Agrupa { get; set; }

        [SqlColumn("enva_peslib")]
        public string? Enva_Peslib { get; set; }

        [SqlColumn("cons_control")]
        public decimal? Cons_Control { get; set; }

        [SqlColumn("enva_pestra")]
        public decimal? Enva_Pestra { get; set; }

        [SqlColumn("enva_perten")]
        public decimal? Enva_Perten { get; set; }

        [SqlColumn("enva_caifco")]
        public decimal? Enva_Caifco { get; set; }

    }
}
