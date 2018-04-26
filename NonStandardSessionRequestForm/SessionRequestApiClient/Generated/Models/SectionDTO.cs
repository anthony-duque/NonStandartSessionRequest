// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SessionRequestApi.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SectionDTO
    {
        /// <summary>
        /// Initializes a new instance of the SectionDTO class.
        /// </summary>
        public SectionDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SectionDTO class.
        /// </summary>
        public SectionDTO(int? sectionId = default(int?), string sectionNumber = default(string), int? requestId = default(int?), string prefix = default(string), string title = default(string), string courseNumber = default(string), double? unitValue = default(double?), string instructorName = default(string), int? estimatedEnrollment = default(int?), string comments = default(string), int? incomeAccountNumber = default(int?), IList<ScheduleDTO> schedules = default(IList<ScheduleDTO>))
        {
            SectionId = sectionId;
            SectionNumber = sectionNumber;
            RequestId = requestId;
            Prefix = prefix;
            Title = title;
            CourseNumber = courseNumber;
            UnitValue = unitValue;
            InstructorName = instructorName;
            EstimatedEnrollment = estimatedEnrollment;
            Comments = comments;
            IncomeAccountNumber = incomeAccountNumber;
            Schedules = schedules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sectionId")]
        public int? SectionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sectionNumber")]
        public string SectionNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public int? RequestId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "courseNumber")]
        public string CourseNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unitValue")]
        public double? UnitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "instructorName")]
        public string InstructorName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "estimatedEnrollment")]
        public int? EstimatedEnrollment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomeAccountNumber")]
        public int? IncomeAccountNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schedules")]
        public IList<ScheduleDTO> Schedules { get; set; }

    }
}
