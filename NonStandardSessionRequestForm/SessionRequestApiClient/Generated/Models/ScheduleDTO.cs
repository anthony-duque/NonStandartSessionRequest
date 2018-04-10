// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SessionRequestApi.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ScheduleDTO
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleDTO class.
        /// </summary>
        public ScheduleDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleDTO class.
        /// </summary>
        public ScheduleDTO(int? scheduleId = default(int?), int? sectionId = default(int?), string classDayOfWeek = default(string), string classStartTime = default(string), string classEndTime = default(string))
        {
            ScheduleId = scheduleId;
            SectionId = sectionId;
            ClassDayOfWeek = classDayOfWeek;
            ClassStartTime = classStartTime;
            ClassEndTime = classEndTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheduleId")]
        public int? ScheduleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sectionId")]
        public int? SectionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "classDayOfWeek")]
        public string ClassDayOfWeek { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "classStartTime")]
        public string ClassStartTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "classEndTime")]
        public string ClassEndTime { get; set; }

    }
}
