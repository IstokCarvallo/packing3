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
    [DataWindow("dw_mues_calibresenvase", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"dbo.calibresenvase\" )  TABLE(NAME=\"dbo.envases\" )  TABLE(NAME=\"dbo.tiposenvases\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"dbo.envases.enva_tipoen\"    OP =\"=\"RIGHT=\"dbo.calibresenvase.enva_tipoen\" )    JOIN (LEFT=\"dbo.envases.enva_codigo\"    OP =\"=\"RIGHT=\"dbo.calibresenvase.enva_codigo\" )    JOIN (LEFT=\"dbo.calibresenvase.enva_tipoen\"    OP =\"=\"RIGHT=\"dbo.tiposenvases.enva_tipoen\" )WHERE(    EXP1 =\"( ( :especie\"   OP =\"in\"    EXP2 =\"( 0, dbo.calibresenvase.espe_codigo ) )\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"( :tipo\"   OP =\"in\"    EXP2 =\"( 0, dbo.calibresenvase.enva_tipoen ) )\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"( :codigo\"   OP =\"in\"    EXP2 =\"( 0, dbo.calibresenvase.enva_codigo ) ) )\" ) ) ARG(NAME = \"especie\" TYPE = number)  ARG(NAME = \"tipo\" TYPE = number)  ARG(NAME = \"codigo\" TYPE = number)")]
    #endregion
    [DwParameter("especie", typeof(double?))]
    [DwParameter("tipo", typeof(double?))]
    [DwParameter("codigo", typeof(double?))]
    public class CalibresEnvase
    {
        [DwColumn("dbo.calibresenvase", "espe_codigo")]
        public decimal Espe_Codigo { get; set; }

        [DwColumn("dbo.calibresenvase", "enva_tipoen")]
        public decimal Enva_Tipoen { get; set; }

        [DwColumn("dbo.calibresenvase", "enva_codigo")]
        public decimal Enva_Codigo { get; set; }

        [DwColumn("dbo.calibresenvase", "caen_calibr")]
        public string Caen_Calibr { get; set; }

        [DwColumn("dbo.calibresenvase", "caen_grupoc")]
        public string Caen_Grupoc { get; set; }

        [DwColumn("dbo.calibresenvase", "caen_calest")]
        public string Caen_Calest { get; set; }

        [DwColumn("dbo.calibresenvase", "caen_column")]
        public decimal? Caen_Column { get; set; }

        [DwColumn("dbo.calibresenvase", "caen_ordena")]
        public decimal? Caen_Ordena { get; set; }

        [DwColumn("dbo.envases", "enva_nombre")]
        public string Enva_Nombre { get; set; }

        [DwColumn("dbo.calibresenvase", "caen_cales2")]
        public string Caen_Cales2 { get; set; }

        [DwColumn("dbo.calibresenvase", "caen_pordis")]
        public decimal? Caen_Pordis { get; set; }

        [DwColumn("dbo.calibresenvase", "caen_pordi2")]
        public decimal? Caen_Pordi2 { get; set; }

        [DwColumn("dbo.tiposenvases", "tien_nombre")]
        public string Tien_Nombre { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("RowCount()")]
        public object Compute_1 { get; set; }

    }

}



