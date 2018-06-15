// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DataApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Certification
    {
        /// <summary>
        /// Initializes a new instance of the Certification class.
        /// </summary>
        public Certification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Certification class.
        /// </summary>
        public Certification(bool? intentToEnroll = default(bool?), string intentReasonCode = default(string), string intentCeebCode = default(string), string intentOtherReason = default(string), string intentSchool = default(string), System.DateTime? submitDate = default(System.DateTime?), System.DateTime? removeDate = default(System.DateTime?), bool? hasFeeWaiver = default(bool?), string housingCode = default(string), string orientationCode = default(string), Waiver waiver = default(Waiver))
        {
            IntentToEnroll = intentToEnroll;
            IntentReasonCode = intentReasonCode;
            IntentCeebCode = intentCeebCode;
            IntentOtherReason = intentOtherReason;
            IntentSchool = intentSchool;
            SubmitDate = submitDate;
            RemoveDate = removeDate;
            HasFeeWaiver = hasFeeWaiver;
            HousingCode = housingCode;
            OrientationCode = orientationCode;
            Waiver = waiver;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "intentToEnroll")]
        public bool? IntentToEnroll { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "intentReasonCode")]
        public string IntentReasonCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "intentCeebCode")]
        public string IntentCeebCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "intentOtherReason")]
        public string IntentOtherReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "intentSchool")]
        public string IntentSchool { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "submitDate")]
        public System.DateTime? SubmitDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "removeDate")]
        public System.DateTime? RemoveDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hasFeeWaiver")]
        public bool? HasFeeWaiver { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "housingCode")]
        public string HousingCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orientationCode")]
        public string OrientationCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "waiver")]
        public Waiver Waiver { get; set; }

    }
}