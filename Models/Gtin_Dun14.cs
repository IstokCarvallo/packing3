using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using SnapObjects.Data;
using DWNet.Data;
using Newtonsoft.Json;
using System.Collections;

namespace Packing3.Models 
{
    [DataWindow("dw_mant_mues_gtin_dun14", DwStyle.Default)]
    [Table("gtin_dun14", Schema = "dbo")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"dbo.gtin_dun14\" )  TABLE(NAME=\"dbo.especies\" )  TABLE(NAME=\"dbo.variedades\" )  TABLE(NAME=\"dbo.embalajesprod\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"dbo.gtin_dun14.espe_codigo\"    OP =\"=\"RIGHT=\"dbo.especies.espe_codigo\" )    JOIN (LEFT=\"dbo.gtin_dun14.espe_codigo\"    OP =\"=\"RIGHT=\"dbo.variedades.espe_codigo\" )    JOIN (LEFT=\"dbo.gtin_dun14.vari_codigo\"    OP =\"=\"RIGHT=\"dbo.variedades.vari_codigo\" )    JOIN (LEFT=\"dbo.gtin_dun14.emba_codigo\"    OP =\"=\"RIGHT=\"dbo.embalajesprod.emba_codigo\" )    JOIN (LEFT=\"dbo.gtin_dun14.clie_codigo\"    OP =\"=\"RIGHT=\"dbo.embalajesprod.clie_codigo\" )WHERE(    EXP1 =\"( ( dbo.gtin_dun14.clie_codigo\"   OP =\"=\"    EXP2 =\":cliente )\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"( :embalaje\"   OP =\"in\"    EXP2 =\"(dbo.gtin_dun14.emba_codigo, 'Todos') ) )\" ) ) ARG(NAME = \"cliente\" TYPE = number)  ARG(NAME = \"embalaje\" TYPE = string)")]
    #endregion
    [DwParameter("cliente", typeof(double?))]
    [DwParameter("embalaje", typeof(string))]
    [DwSort("gtin_numero A espe_codigo A vari_codigo A emba_nombre A")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class Gtin_Dun14
    {
        [Key]
        [DwColumn("dbo.gtin_dun14", "clie_codigo")]
        public decimal Clie_Codigo { get; set; }

        [DwColumn("dbo.gtin_dun14", "gtin_numero")]
        public decimal Gtin_Numero { get; set; }

        [Key]
        [DwColumn("dbo.gtin_dun14", "espe_codigo")]
        public decimal Espe_Codigo { get; set; }

        [Key]
        [DwColumn("dbo.gtin_dun14", "vari_codigo")]
        public decimal Vari_Codigo { get; set; }

        [Key]
        [DwColumn("dbo.gtin_dun14", "emba_codigo")]
        public string Emba_Codigo { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("dbo.especies", "espe_nombre")]
        public string Espe_Nombre { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("dbo.variedades", "vari_nombre")]
        public string Vari_Nombre { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("dbo.embalajesprod", "emba_nombre")]
        public string Emba_Nombre { get; set; }

        [Key]
        [StringLength(3)]
        [DwColumn("dbo.gtin_dun14", "gtin_calibr")]
        public string Gtin_Calibr { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlCompute("convert(decimal(1), Case When gtin_calibr = '-1 ' then 1 else 0 end) as todocal")]
        public decimal? Todocal { get; set; }

        [DwColumn("dbo.gtin_dun14", "gtin_codplu")]
        public string Gtin_Codplu { get; set; }

        [DwColumn("dbo.gtin_dun14", "gtin_codupc")]
        public string Gtin_Codupc { get; set; }

    }

}



