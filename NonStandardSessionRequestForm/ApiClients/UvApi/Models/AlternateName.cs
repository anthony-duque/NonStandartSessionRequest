// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UvApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AlternateName
    {
        /// <summary>
        /// Initializes a new instance of the AlternateName class.
        /// </summary>
        public AlternateName()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlternateName class.
        /// </summary>
        public AlternateName(string prefix = default(string), string firstName = default(string), string middleName = default(string), string lastName = default(string), string suffix = default(string))
        {
            Prefix = prefix;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Suffix = suffix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "suffix")]
        public string Suffix { get; set; }

    }
}