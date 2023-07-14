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
    [DataWindow("dw_mues_correlfolio", DwStyle.Default)]
    [Table("spro_correlfolio", Schema = "dbo")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"dbo.spro_correlfolio\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"( dbo.spro_correlfolio.clie_codigo\"   OP =\"=\"    EXP2 =\":cliente )\" ) ) ARG(NAME = \"Cliente\" TYPE = number)")]
    #endregion
    [DwParameter("Cliente", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class Correlfolio
    {
        [Key]
        [DwColumn("dbo.spro_correlfolio", "clie_codigo")]
        public decimal Clie_Codigo { get; set; }

        [Key]
        [DwColumn("dbo.spro_correlfolio", "plde_codigo")]
        public decimal Plde_Codigo { get; set; }

        [Key]
        [DwColumn("dbo.spro_correlfolio", "spco_corini")]
        public decimal Spco_Corini { get; set; }

        [DwColumn("dbo.spro_correlfolio", "spco_corter")]
        public decimal? Spco_Corter { get; set; }

        [SqlCompute("isnull(dbo.spro_correlfolio.spco_estado,0) as spco_estado")]
        public decimal Spco_Estado { get; set; } = 0m;

        [DwColumn("dbo.spro_correlfolio", "spco_ultcor")]
        public decimal? Spco_Ultcor { get; set; }

        [Key]
        [DwColumn("dbo.spro_correlfolio", "paen_tipopa")]
        public decimal Paen_Tipopa { get; set; }

    }

}



