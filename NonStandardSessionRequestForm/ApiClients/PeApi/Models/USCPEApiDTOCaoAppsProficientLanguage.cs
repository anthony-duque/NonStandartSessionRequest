// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace PeApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class USCPEApiDTOCaoAppsProficientLanguage
    {
        /// <summary>
        /// Initializes a new instance of the
        /// USCPEApiDTOCaoAppsProficientLanguage class.
        /// </summary>
        public USCPEApiDTOCaoAppsProficientLanguage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// USCPEApiDTOCaoAppsProficientLanguage class.
        /// </summary>
        public USCPEApiDTOCaoAppsProficientLanguage(int? proficientLanguageId = default(int?), string language = default(string), string languageLevel = default(string))
        {
            ProficientLanguageId = proficientLanguageId;
            Language = language;
            LanguageLevel = languageLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "proficientLanguageId")]
        public int? ProficientLanguageId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languageLevel")]
        public string LanguageLevel { get; set; }

    }
}
