// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace PeApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class USCPEApiWebApiAreasWebAdmitModelsCustomInstitutionSendToSisTimeStamp
    {
        /// <summary>
        /// Initializes a new instance of the
        /// USCPEApiWebApiAreasWebAdmitModelsCustomInstitutionSendToSisTimeStamp
        /// class.
        /// </summary>
        public USCPEApiWebApiAreasWebAdmitModelsCustomInstitutionSendToSisTimeStamp()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// USCPEApiWebApiAreasWebAdmitModelsCustomInstitutionSendToSisTimeStamp
        /// class.
        /// </summary>
        public USCPEApiWebApiAreasWebAdmitModelsCustomInstitutionSendToSisTimeStamp(string casId = default(string), string associationName = default(string), string cycleName = default(string), System.DateTime? startProcessingBySisTs = default(System.DateTime?))
        {
            CasId = casId;
            AssociationName = associationName;
            CycleName = cycleName;
            StartProcessingBySisTs = startProcessingBySisTs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "casId")]
        public string CasId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "associationName")]
        public string AssociationName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cycleName")]
        public string CycleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startProcessingBySisTs")]
        public System.DateTime? StartProcessingBySisTs { get; set; }

    }
}