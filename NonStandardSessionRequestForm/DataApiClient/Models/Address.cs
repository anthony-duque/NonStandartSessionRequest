// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DataApiClient.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Address
    {
        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        public Address() { }

        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        public Address(string streetAddress1 = default(string), string streetAddress2 = default(string), string city = default(string), string stateCode = default(string), string zipCode = default(string), string countryIsoCode = default(string), string type = default(string), bool? isPreferred = default(bool?))
        {
            StreetAddress1 = streetAddress1;
            StreetAddress2 = streetAddress2;
            City = city;
            StateCode = stateCode;
            ZipCode = zipCode;
            CountryIsoCode = countryIsoCode;
            Type = type;
            IsPreferred = isPreferred;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "streetAddress1")]
        public string StreetAddress1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "streetAddress2")]
        public string StreetAddress2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stateCode")]
        public string StateCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "zipCode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "countryIsoCode")]
        public string CountryIsoCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isPreferred")]
        public bool? IsPreferred { get; set; }

    }
}
