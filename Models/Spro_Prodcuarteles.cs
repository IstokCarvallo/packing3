using System;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packing3.Models
{
    [Table("spro_prodcuarteles", Schema = "dbo")]
    public class Spro_Prodcuarteles
    {
        [Key]
        [SqlColumn("prod_codigo")]
        public decimal Prod_Codigo { get; set; }

        [Key]
        [SqlColumn("prpr_codigo")]
        public decimal Prpr_Codigo { get; set; }

        [Key]
        [SqlColumn("prcc_codigo")]
        public decimal Prcc_Codigo { get; set; }

        [SqlColumn("prcc_nombre")]
        public string? Prcc_Nombre { get; set; }

        [SqlColumn("prcc_cuapro")]
        public decimal? Prcc_Cuapro { get; set; }

        [SqlColumn("prcc_nompro")]
        public string? Prcc_Nompro { get; set; }

        [SqlColumn("espe_codigo")]
        public decimal Espe_Codigo { get; set; }

        [SqlColumn("vari_codigo")]
        public decimal? Vari_Codigo { get; set; }

        [Key]
        [SqlColumn("siri_codigo")]
        public decimal? Siri_Codigo { get; set; }

        [Key]
        [SqlColumn("sico_codigo")]
        public decimal? Sico_Codigo { get; set; }

        [SqlColumn("prcc_superf")]
        public decimal? Prcc_Superf { get; set; }

        [SqlColumn("prcc_porinj")]
        public string? Prcc_Porinj { get; set; }

        [SqlColumn("prcc_anoinj")]
        public decimal? Prcc_Anoinj { get; set; }

        [SqlColumn("prcc_ptasob")]
        public decimal? Prcc_Ptasob { get; set; }

        [SqlColumn("prcc_ptaent")]
        public decimal? Prcc_Ptaent { get; set; }

        [SqlColumn("prcc_nropta")]
        public decimal? Prcc_Nropta { get; set; }

        [SqlColumn("prcc_anopla")]
        public decimal? Prcc_Anopla { get; set; }

        [SqlColumn("prcc_disgot")]
        public decimal? Prcc_Disgot { get; set; }

        [SqlColumn("prcc_caugot")]
        public decimal? Prcc_Caugot { get; set; }

        [SqlColumn("prcc_gothec")]
        public decimal? Prcc_Gothec { get; set; }

        [SqlColumn("prcc_gashec")]
        public decimal? Prcc_Gashec { get; set; }

        [SqlColumn("prcc_cjtem1")]
        public decimal? Prcc_Cjtem1 { get; set; }

        [SqlColumn("prcc_cjtem2")]
        public decimal? Prcc_Cjtem2 { get; set; }

        [SqlColumn("prcc_cjtem3")]
        public decimal? Prcc_Cjtem3 { get; set; }

        [SqlColumn("prcc_cjtem4")]
        public decimal? Prcc_Cjtem4 { get; set; }

        [SqlColumn("prcc_cjtem5")]
        public decimal? Prcc_Cjtem5 { get; set; }

        [SqlColumn("prcc_densid")]
        public decimal? Prcc_Densid { get; set; }

        [SqlColumn("prcc_plabue")]
        public decimal? Prcc_Plabue { get; set; }

        [SqlColumn("prcc_plareg")]
        public decimal? Prcc_Plareg { get; set; }

        [SqlColumn("prcc_plamal")]
        public decimal? Prcc_Plamal { get; set; }

        [SqlColumn("prcc_frubue")]
        public decimal? Prcc_Frubue { get; set; }

        [SqlColumn("prcc_frureg")]
        public decimal? Prcc_Frureg { get; set; }

        [SqlColumn("prcc_frumal")]
        public decimal? Prcc_Frumal { get; set; }

        [SqlColumn("prcc_encarg")]
        public string? Prcc_Encarg { get; set; }

        [SqlColumn("patr_codigo")]
        public decimal? Patr_Codigo { get; set; }

        [SqlColumn("tipl_codigo")]
        public decimal? Tipl_Codigo { get; set; }

        [SqlColumn("prcc_fecact")]
        public DateTime? Prcc_Fecact { get; set; }

        [SqlColumn("prcc_observ")]
        public string? Prcc_Observ { get; set; }

        [SqlColumn("prcc_obscli")]
        public string? Prcc_Obscli { get; set; }

        [SqlColumn("prcc_obsral")]
        public string? Prcc_Obsral { get; set; }

        [SqlColumn("prcc_obsman")]
        public string? Prcc_Obsman { get; set; }

        [SqlColumn("prcc_porpro")]
        public decimal? Prcc_Porpro { get; set; }

        [SqlColumn("prcc_pprose")]
        public decimal? Prcc_Pprose { get; set; }

        [SqlColumn("prcc_poremb")]
        public decimal? Prcc_Poremb { get; set; }

        [SqlColumn("prcc_pembse")]
        public decimal? Prcc_Pembse { get; set; }

        [SqlColumn("prcc_cmedse")]
        public decimal? Prcc_Cmedse { get; set; }

        [SqlColumn("prcc_calmed")]
        public decimal? Prcc_Calmed { get; set; }

        [SqlColumn("prcc_estado")]
        public decimal? Prcc_Estado { get; set; }

        [SqlColumn("prcc_cajhec")]
        public decimal? Prcc_Cajhec { get; set; }

        [SqlColumn("prcc_cajcuar")]
        public decimal? Prcc_Cajcuar { get; set; }

        [SqlColumn("prcc_codhom")]
        public decimal? Prcc_Codhom { get; set; }

        [SqlColumn("prcc_nomhom")]
        public string? Prcc_Nomhom { get; set; }

        [SqlColumn("prcc_cuahom")]
        public decimal? Prcc_Cuahom { get; set; }

        [SqlColumn("prcc_kunif")]
        public decimal? Prcc_Kunif { get; set; }

        [SqlColumn("prcc_pesrac")]
        public decimal? Prcc_Pesrac { get; set; }

        [SqlColumn("prcc_pesnor")]
        public decimal? Prcc_Pesnor { get; set; }

        [SqlColumn("prcc_semini")]
        public decimal? Prcc_Semini { get; set; }

        [SqlColumn("prcc_fecini")]
        public DateTime? Prcc_Fecini { get; set; }

        [SqlColumn("prcc_sector")]
        public string? Prcc_Sector { get; set; }

        [SqlColumn("prcc_system")]
        public decimal? Prcc_System { get; set; }

        [SqlColumn("prcc_codope")]
        public string? Prcc_Codope { get; set; }

    }
}
