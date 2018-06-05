// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace PeApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class USCPEApiWebApiAreasWebAdmitModelsCustomApplicationIdentifiers
    {
        /// <summary>
        /// Initializes a new instance of the
        /// USCPEApiWebApiAreasWebAdmitModelsCustomApplicationIdentifiers
        /// class.
        /// </summary>
        public USCPEApiWebApiAreasWebAdmitModelsCustomApplicationIdentifiers()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// USCPEApiWebApiAreasWebAdmitModelsCustomApplicationIdentifiers
        /// class.
        /// </summary>
        public USCPEApiWebApiAreasWebAdmitModelsCustomApplicationIdentifiers(string cycleName = default(string), string casId = default(string), string uscId = default(string), string pid = default(string))
        {
            CycleName = cycleName;
            CasId = casId;
            UscId = uscId;
            Pid = pid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cycleName")]
        public string CycleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "casId")]
        public string CasId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uscId")]
        public string UscId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public string Pid { get; set; }

    }
}
