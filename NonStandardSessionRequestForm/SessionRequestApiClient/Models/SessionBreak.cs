// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SessionRequestApi.Client.Models
{
    using Newtonsoft.Json;
    using SessionRequestApi.Client;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public partial class SessionBreak
    {
        /// <summary>
        /// Initializes a new instance of the SessionBreak class.
        /// </summary>
        public SessionBreak()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SessionBreak class.
        /// </summary>
        public SessionBreak(int? id = default(int?), System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), int? requestId = default(int?), Session session = default(Session))
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
        public Session Session { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != Id )
            {
                result.Add(new XElement("id", Id) );
            }
            if( null != StartDate )
            {
                result.Add(new XElement("startDate", StartDate) );
            }
            if( null != EndDate )
            {
                result.Add(new XElement("endDate", EndDate) );
            }
            if( null != RequestId )
            {
                result.Add(new XElement("requestId", RequestId) );
            }
            if( null != Session )
            {
                result.Add(Session.XmlSerialize(new XElement( "session" )));
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of SessionBreak
        /// </summary>
        internal static SessionBreak XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static SessionBreak XmlDeserialize(XElement payload)
        {
            var result = new SessionBreak();
            var deserializeId = XmlSerialization.ToDeserializer(e => (int?)e);
            int? resultId;
            if (deserializeId(payload, "id", out resultId))
            {
                result.Id = resultId;
            }
            var deserializeStartDate = XmlSerialization.ToDeserializer(e => (System.DateTime?)e);
            System.DateTime? resultStartDate;
            if (deserializeStartDate(payload, "startDate", out resultStartDate))
            {
                result.StartDate = resultStartDate;
            }
            var deserializeEndDate = XmlSerialization.ToDeserializer(e => (System.DateTime?)e);
            System.DateTime? resultEndDate;
            if (deserializeEndDate(payload, "endDate", out resultEndDate))
            {
                result.EndDate = resultEndDate;
            }
            var deserializeRequestId = XmlSerialization.ToDeserializer(e => (int?)e);
            int? resultRequestId;
            if (deserializeRequestId(payload, "requestId", out resultRequestId))
            {
                result.RequestId = resultRequestId;
            }
            var deserializeSession = XmlSerialization.ToDeserializer(e => Session.XmlDeserialize(e));
            Session resultSession;
            if (deserializeSession(payload, "session", out resultSession))
            {
                result.Session = resultSession;
            }
            return result;
        }
    }
}