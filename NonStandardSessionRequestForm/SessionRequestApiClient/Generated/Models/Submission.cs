// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SessionRequestApi.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Submission
    {
        /// <summary>
        /// Initializes a new instance of the Submission class.
        /// </summary>
        public Submission()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Submission class.
        /// </summary>
        public Submission(int? submissionId = default(int?), System.DateTime? lastUpdatedTimeStamp = default(System.DateTime?), string faoAction = default(string), System.DateTime? faoActionDate = default(System.DateTime?), string faoActionReason = default(string), string rnrAction = default(string), System.DateTime? rnrActionDate = default(System.DateTime?), string rnrActionReason = default(string), string burAction = default(string), System.DateTime? burActionDate = default(System.DateTime?), string burActionReason = default(string), int? requestId = default(int?), Session session = default(Session))
        {
            SubmissionId = submissionId;
            LastUpdatedTimeStamp = lastUpdatedTimeStamp;
            FaoAction = faoAction;
            FaoActionDate = faoActionDate;
            FaoActionReason = faoActionReason;
            RnrAction = rnrAction;
            RnrActionDate = rnrActionDate;
            RnrActionReason = rnrActionReason;
            BurAction = burAction;
            BurActionDate = burActionDate;
            BurActionReason = burActionReason;
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
        [JsonProperty(PropertyName = "submissionId")]
        public int? SubmissionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedTimeStamp")]
        public System.DateTime? LastUpdatedTimeStamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "faoAction")]
        public string FaoAction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "faoActionDate")]
        public System.DateTime? FaoActionDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "faoActionReason")]
        public string FaoActionReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rnrAction")]
        public string RnrAction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rnrActionDate")]
        public System.DateTime? RnrActionDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rnrActionReason")]
        public string RnrActionReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "burAction")]
        public string BurAction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "burActionDate")]
        public System.DateTime? BurActionDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "burActionReason")]
        public string BurActionReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public int? RequestId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "session")]
        public Session Session { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FaoAction != null)
            {
                if (FaoAction.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FaoAction", 50);
                }
                if (FaoAction.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "FaoAction", 0);
                }
            }
            if (RnrAction != null)
            {
                if (RnrAction.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "RnrAction", 50);
                }
                if (RnrAction.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "RnrAction", 0);
                }
            }
            if (BurAction != null)
            {
                if (BurAction.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "BurAction", 50);
                }
                if (BurAction.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "BurAction", 0);
                }
            }
            if (Session != null)
            {
                Session.Validate();
            }
        }
    }
}
