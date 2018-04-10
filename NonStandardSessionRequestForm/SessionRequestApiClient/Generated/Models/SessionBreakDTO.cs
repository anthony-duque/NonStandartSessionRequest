// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SessionRequestApi.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SessionBreakDTO
    {
        /// <summary>
        /// Initializes a new instance of the SessionBreakDTO class.
        /// </summary>
        public SessionBreakDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SessionBreakDTO class.
        /// </summary>
        public SessionBreakDTO(int? id = default(int?), System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), int? requestId = default(int?), SessionDTO session = default(SessionDTO))
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            RequestId = requestId;
            Session = session;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public int? RequestId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "session")]
        public SessionDTO Session { get; set; }

    }
}
