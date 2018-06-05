// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace PeApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONLOADDEN
    {
        /// <summary>
        /// Initializes a new instance of the
        /// USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONLOADDEN class.
        /// </summary>
        public USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONLOADDEN()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONLOADDEN class.
        /// </summary>
        public USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONLOADDEN(string caSID = default(string), string associatioNNAME = default(string), string cyclENAME = default(string), string posTCODE = default(string), string terMCODE = default(string), string usCID = default(string), System.DateTime? processeDBYSISTS = default(System.DateTime?))
        {
            CaSID = caSID;
            AssociatioNNAME = associatioNNAME;
            CyclENAME = cyclENAME;
            PosTCODE = posTCODE;
            TerMCODE = terMCODE;
            UsCID = usCID;
            ProcesseDBYSISTS = processeDBYSISTS;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "caS_ID")]
        public string CaSID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "associatioN_NAME")]
        public string AssociatioNNAME { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cyclE_NAME")]
        public string CyclENAME { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "posT_CODE")]
        public string PosTCODE { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "terM_CODE")]
        public string TerMCODE { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usC_ID")]
        public string UsCID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processeD_BY_SIS_TS")]
        public System.DateTime? ProcesseDBYSISTS { get; set; }

    }
}
