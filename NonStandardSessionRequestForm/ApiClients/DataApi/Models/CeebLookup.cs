// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DataApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CeebLookup
    {
        /// <summary>
        /// Initializes a new instance of the CeebLookup class.
        /// </summary>
        public CeebLookup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CeebLookup class.
        /// </summary>
        public CeebLookup(string liaisonCeeb = default(string), string uscCeeb = default(string))
        {
            LiaisonCeeb = liaisonCeeb;
            UscCeeb = uscCeeb;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "liaisonCeeb")]
        public string LiaisonCeeb { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uscCeeb")]
        public string UscCeeb { get; set; }

    }
}
