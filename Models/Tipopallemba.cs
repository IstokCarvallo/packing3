using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using SnapObjects.Data;
using DWNet.Data;
using Newtonsoft.Json;

namespace Packing3.Models 
{
    [DataWindow("dw_mues_tipopallemba", DwStyle.Default)]
    [Table("tipopallemba", Schema = "dbo")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"dbo.tipopallemba\" )  TABLE(NAME=\"dbo.embalajesprod\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"dbo.tipopallemba.clie_codigo\"    OP =\"=\"RIGHT=\"dbo.embalajesprod.clie_codigo\" )    JOIN (LEFT=\"dbo.tipopallemba.emba_codigo\"    OP =\"=\"RIGHT=\"dbo.embalajesprod.emba_codigo\" )WHERE(    EXP1 =\"( ( dbo.tipopallemba.clie_codigo\"   OP =\"=\"    EXP2 =\":cliente )\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"( :embalaje\"   OP =\"in\"    EXP2 =\"( 'Z',dbo.tipopallemba.emba_codigo ) ) )\" ) ) ARG(NAME = \"cliente\" TYPE = number)  ARG(NAME = \"embalaje\" TYPE = string)")]
    #endregion
    [DwParameter("cliente", typeof(double?))]
    [DwParameter("embalaje", typeof(string))]
    [DwSort("clie_codigo A emba_codigo A tpem_cancaj A")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class Tipopallemba
    {
        [Key]
        [DwColumn("dbo.tipopallemba", "clie_codigo")]
        public decimal Clie_Codigo { get; set; }

        [Key]
        [DwColumn("dbo.tipopallemba", "emba_codigo")]
        public string Emba_Codigo { get; set; }

        [Key]
        [DwColumn("dbo.tipopallemba", "tpem_codigo")]
        public string Tpem_Codigo { get; set; }

        [DwColumn("dbo.tipopallemba", "tpem_cancaj")]
        public decimal? Tpem_Cancaj { get; set; }

        [DwColumn("dbo.tipopallemba", "tpem_altura")]
        public decimal Tpem_Altura { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("dbo.embalajesprod", "emba_nombre")]
        public string Emba_Nombre { get; set; }

        [DwColumn("dbo.tipopallemba", "emba_altura")]
        public decimal? Emba_Altura { get; set; }

        [DwColumn("dbo.tipopallemba", "emba_columna")]
        public decimal? Emba_Columna { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("RowCount()")]
        public object Compute_1 { get; set; }

    }

}



