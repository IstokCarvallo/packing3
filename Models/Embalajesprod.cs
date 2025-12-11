using SnapObjects.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packing3
{
    [Table("embalajesprod", Schema = "dbo")]
    public class Embalajesprod
    {
        [Key]
        [SqlColumn("emba_codigo")]
        public string? Emba_Codigo { get; set; }

        [Key]
        [SqlColumn("clie_codigo")]
        public decimal Clie_Codigo { get; set; }

        [SqlColumn("envo_codigo")]
        public decimal? Envo_Codigo { get; set; }

        [SqlColumn("enva_tipoen")]
        public decimal Enva_Tipoen { get; set; }

        [SqlColumn("enva_codigo")]
        public decimal Enva_Codigo { get; set; }

        [SqlColumn("emba_nombre")]
        public string? Emba_Nombre { get; set; }

        [SqlColumn("emba_abrevi")]
        public string? Emba_Abrevi { get; set; }

        [SqlColumn("emba_cajpal")]
        public decimal? Emba_Cajpal { get; set; }

        [SqlColumn("emba_nomlar")]
        public string? Emba_Nomlar { get; set; }

        [SqlColumn("emes_codigo")]
        public decimal? Emes_Codigo { get; set; }

        [SqlColumn("emba_tiprpc")]
        public string? Emba_Tiprpc { get; set; }

        [SqlColumn("emba_dimens")]
        public string? Emba_Dimens { get; set; }

        [SqlColumn("espe_codigo")]
        public decimal? Espe_Codigo { get; set; }

        [SqlColumn("emba_codcli")]
        public string? Emba_Codcli { get; set; }

        [SqlColumn("etiq_codigo")]
        public decimal? Etiq_Codigo { get; set; }

        [SqlColumn("emba_pesmin")]
        public decimal? Emba_Pesmin { get; set; }

        [SqlColumn("emba_pesmax")]
        public decimal? Emba_Pesmax { get; set; }

        [SqlColumn("emba_pesnet")]
        public decimal? Emba_Pesnet { get; set; }

        [SqlColumn("emba_altura")]
        public decimal? Emba_Altura { get; set; }

        [SqlColumn("emba_columna")]
        public decimal? Emba_Columna { get; set; }

        [SqlColumn("emba_nrogs1")]
        public string? Emba_Nrogs1 { get; set; }

        [SqlColumn("emba_nroint")]
        public string? Emba_Nroint { get; set; }

        [SqlColumn("emba_usapes")]
        public decimal? Emba_Usapes { get; set; }

        [SqlColumn("emba_tipbol")]
        public decimal? Emba_Tipbol { get; set; }

        [SqlColumn("emba_tipvid")]
        public decimal? Emba_Tipvid { get; set; }

        [SqlColumn("emba_codant")]
        public string? Emba_Codant { get; set; }

        [SqlColumn("emba_perten")]
        public decimal? Emba_Perten { get; set; }

        [SqlColumn("emba_flgexp")]
        public decimal? Emba_Flgexp { get; set; }

        [SqlColumn("emba_vigent")]
        public decimal? Emba_Vigent { get; set; }

        [SqlColumn("emba_tipofr")]
        public decimal? Emba_Tipofr { get; set; }

        [SqlColumn("emba_premium")]
        public decimal? Emba_Premium { get; set; }

        [SqlColumn("emba_flggra")]
        public decimal? Emba_Flggra { get; set; }

        [SqlColumn("emba_flgvar")]
        public decimal? Emba_Flgvar { get; set; }

        [SqlColumn("emba_flgpsn")]
        public decimal? Emba_Flgpsn { get; set; }

        [SqlColumn("copa_codigo")]
        public decimal? Copa_Codigo { get; set; }

        [SqlColumn("emba_flgusn")]
        public decimal? Emba_Flgusn { get; set; }

        [SqlColumn("emba_atmosf")]
        public decimal? Emba_Atmosf { get; set; }

        [SqlColumn("emba_descri")]
        public string? Emba_Descri { get; set; }

    }
}
