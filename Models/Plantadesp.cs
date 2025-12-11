using SnapObjects.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packing3.Models
{
    [Table("plantadesp", Schema = "dbo")]
    public class Plantadesp
    {
        [Key]
        [SqlColumn("plde_codigo")]
        public decimal Plde_Codigo { get; set; }

        [SqlColumn("cone_codigo")]
        public decimal? Cone_Codigo { get; set; }

        [SqlColumn("plde_nombre")]
        public string? Plde_Nombre { get; set; }

        [SqlColumn("plde_insfda")]
        public decimal? Plde_Insfda { get; set; }

        [SqlColumn("zona_codigo")]
        public decimal? Zona_Codigo { get; set; }

        [SqlColumn("plde_tipopl")]
        public decimal? Plde_Tipopl { get; set; }

        [SqlColumn("plde_razsoc")]
        public string? Plde_Razsoc { get; set; }

        [SqlColumn("plde_direcc")]
        public string? Plde_Direcc { get; set; }

        [SqlColumn("plde_ciudad")]
        public string? Plde_Ciudad { get; set; }

        [SqlColumn("plde_nrotel")]
        public string? Plde_Nrotel { get; set; }

        [SqlColumn("plde_nrorut")]
        public string? Plde_Nrorut { get; set; }

        [SqlColumn("plde_repres")]
        public string? Plde_Repres { get; set; }

        [SqlColumn("plde_codsag")]
        public decimal? Plde_Codsag { get; set; }

        [SqlColumn("plde_region")]
        public decimal? Plde_Region { get; set; }

        [SqlColumn("plde_provin")]
        public decimal? Plde_Provin { get; set; }

        [SqlColumn("plde_comuna")]
        public decimal? Plde_Comuna { get; set; }

        [SqlColumn("plde_admini")]
        public decimal? Plde_Admini { get; set; }

        [SqlColumn("plde_atenc1")]
        public string? Plde_Atenc1 { get; set; }

        [SqlColumn("plde_atenc2")]
        public string? Plde_Atenc2 { get; set; }

        [SqlColumn("plde_atenc3")]
        public string? Plde_Atenc3 { get; set; }

        [SqlColumn("plde_atenc4")]
        public string? Plde_Atenc4 { get; set; }

        [SqlColumn("comu_codigo")]
        public decimal? Comu_Codigo { get; set; }

        [SqlColumn("plde_insfda2")]
        public string? Plde_Insfda2 { get; set; }

        [SqlColumn("plde_codpla")]
        public decimal? Plde_Codpla { get; set; }

        [SqlColumn("plde_correo")]
        public string? Plde_Correo { get; set; }

        [SqlColumn("plde_nomfda")]
        public string? Plde_Nomfda { get; set; }

        [SqlColumn("ciud_codigo")]
        public decimal? Ciud_Codigo { get; set; }

        [SqlColumn("plde_prvsag")]
        public decimal? Plde_Prvsag { get; set; }

        [SqlColumn("plde_comsag")]
        public decimal? Plde_Comsag { get; set; }

        [SqlColumn("plde_codmul")]
        public decimal? Plde_Codmul { get; set; }

        [SqlColumn("plde_pacvir")]
        public decimal? Plde_Pacvir { get; set; }

        [SqlColumn("plde_gencaj")]
        public decimal? Plde_Gencaj { get; set; }

        [SqlColumn("plde_propie")]
        public decimal? Plde_Propie { get; set; }

        [SqlColumn("plde_conpro")]
        public decimal? Plde_Conpro { get; set; }

        [SqlColumn("plde_paccom")]
        public decimal? Plde_Paccom { get; set; }

        [SqlColumn("plde_cajbul")]
        public decimal? Plde_Cajbul { get; set; }

        [SqlColumn("plde_glncod")]
        public string? Plde_Glncod { get; set; }

        [SqlColumn("plde_cuaren")]
        public decimal? Plde_Cuaren { get; set; }

        [SqlColumn("plde_idpclb")]
        public string? Plde_Idpclb { get; set; }

        [SqlColumn("plde_chasag")]
        public string? Plde_Chasag { get; set; }

        [SqlColumn("plde_blkwal")]
        public decimal? Plde_Blkwal { get; set; }

        [SqlColumn("plde_corplt")]
        public string? Plde_Corplt { get; set; }

        [SqlColumn("plde_corsam")]
        public string? Plde_Corsam { get; set; }

        [SqlColumn("plde_renenv")]
        public decimal? Plde_Renenv { get; set; }

        [SqlColumn("plde_abrevi")]
        public string? Plde_Abrevi { get; set; }

        [SqlColumn("plde_corrjp")]
        public string? Plde_Corrjp { get; set; }

        [SqlColumn("plde_perten")]
        public decimal? Plde_Perten { get; set; }

        [SqlColumn("plde_fecres")]
        public DateTime? Plde_Fecres { get; set; }

        [SqlColumn("plde_nomres")]
        public string? Plde_Nomres { get; set; }

        [SqlColumn("plde_corter")]
        public string? Plde_Corter { get; set; }

        [SqlColumn("plde_cormat")]
        public string? Plde_Cormat { get; set; }

        [SqlColumn("plde_interp")]
        public decimal? Plde_Interp { get; set; }

        [SqlColumn("plde_comfds")]
        public string? Plde_Comfds { get; set; }

        [SqlColumn("plde_tiempo")]
        public decimal? Plde_Tiempo { get; set; }

        [SqlColumn("plde_capemb")]
        public decimal? Plde_Capemb { get; set; }

        [SqlColumn("plde_diapro")]
        public decimal? Plde_Diapro { get; set; }

        [SqlColumn("plde_oficen")]
        public decimal? Plde_Oficen { get; set; }

        [SqlColumn("plde_giroem")]
        public string? Plde_Giroem { get; set; }

        [SqlColumn("plde_ciuori")]
        public string? Plde_Ciuori { get; set; }

        [SqlColumn("plde_comori")]
        public string? Plde_Comori { get; set; }

        [SqlColumn("plde_dirori")]
        public string? Plde_Dirori { get; set; }

        [SqlColumn("plde_cargopr")]
        public decimal? Plde_Cargopr { get; set; }

        [SqlColumn("plde_tippac")]
        public decimal? Plde_Tippac { get; set; }

        [SqlColumn("plde_corpro")]
        public string? Plde_Corpro { get; set; }

        [SqlColumn("plde_codope")]
        public string? Plde_Codope { get; set; }

    }
}
