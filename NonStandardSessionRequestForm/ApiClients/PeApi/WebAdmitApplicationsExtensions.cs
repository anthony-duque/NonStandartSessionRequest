// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace PeApi
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WebAdmitApplications.
    /// </summary>
    public static partial class WebAdmitApplicationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='casId'>
            /// </param>
            /// <param name='associationName'>
            /// </param>
            /// <param name='cycleName'>
            /// </param>
            /// <param name='programCode'>
            /// </param>
            /// <param name='term'>
            /// </param>
            public static object GetFullApplication(this IWebAdmitApplications operations, string casId, string associationName, string cycleName, string programCode, string term)
            {
                return operations.GetFullApplicationAsync(casId, associationName, cycleName, programCode, term).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='casId'>
            /// </param>
            /// <param name='associationName'>
            /// </param>
            /// <param name='cycleName'>
            /// </param>
            /// <param name='programCode'>
            /// </param>
            /// <param name='term'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetFullApplicationAsync(this IWebAdmitApplications operations, string casId, string associationName, string cycleName, string programCode, string term, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFullApplicationWithHttpMessagesAsync(casId, associationName, cycleName, programCode, term, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applications'>
            /// </param>
            public static object PostInstitutionLoad(this IWebAdmitApplications operations, IList<USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONLOAD> applications)
            {
                return operations.PostInstitutionLoadAsync(applications).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applications'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostInstitutionLoadAsync(this IWebAdmitApplications operations, IList<USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONLOAD> applications, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostInstitutionLoadWithHttpMessagesAsync(applications, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='denRecs'>
            /// </param>
            public static object PostViterbiDens(this IWebAdmitApplications operations, IList<USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONLOADDEN> denRecs)
            {
                return operations.PostViterbiDensAsync(denRecs).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='denRecs'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostViterbiDensAsync(this IWebAdmitApplications operations, IList<USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONLOADDEN> denRecs, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostViterbiDensWithHttpMessagesAsync(denRecs, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='content'>
            /// </param>
            public static object PutInstitutionStartProcessingBySisTs(this IWebAdmitApplications operations, USCPEApiWebApiAreasWebAdmitModelsCustomInstitutionSendToSisTimeStamp content)
            {
                return operations.PutInstitutionStartProcessingBySisTsAsync(content).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='content'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PutInstitutionStartProcessingBySisTsAsync(this IWebAdmitApplications operations, USCPEApiWebApiAreasWebAdmitModelsCustomInstitutionSendToSisTimeStamp content, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutInstitutionStartProcessingBySisTsWithHttpMessagesAsync(content, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static object PutViterbiDenProcessedBySisTs(this IWebAdmitApplications operations, USCPEApiWebApiAreasWebAdmitModelsCustomViterbiDenProcessedBySisTimeStamp parameters)
            {
                return operations.PutViterbiDenProcessedBySisTsAsync(parameters).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PutViterbiDenProcessedBySisTsAsync(this IWebAdmitApplications operations, USCPEApiWebApiAreasWebAdmitModelsCustomViterbiDenProcessedBySisTimeStamp parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutViterbiDenProcessedBySisTsWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='content'>
            /// </param>
            public static object PutInstitutionIdentifiers(this IWebAdmitApplications operations, USCPEApiWebApiAreasWebAdmitModelsCustomApplicationIdentifiers content)
            {
                return operations.PutInstitutionIdentifiersAsync(content).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='content'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PutInstitutionIdentifiersAsync(this IWebAdmitApplications operations, USCPEApiWebApiAreasWebAdmitModelsCustomApplicationIdentifiers content, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutInstitutionIdentifiersWithHttpMessagesAsync(content, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applications'>
            /// </param>
            public static object PostCustomLoad(this IWebAdmitApplications operations, IList<USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONLOADC> applications)
            {
                return operations.PostCustomLoadAsync(applications).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applications'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostCustomLoadAsync(this IWebAdmitApplications operations, IList<USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONLOADC> applications, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostCustomLoadWithHttpMessagesAsync(applications, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='casId'>
            /// </param>
            public static object GetMatch(this IWebAdmitApplications operations, string casId)
            {
                return operations.GetMatchAsync(casId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='casId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetMatchAsync(this IWebAdmitApplications operations, string casId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMatchWithHttpMessagesAsync(casId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='showNulls'>
            /// </param>
            /// <param name='showAll'>
            /// </param>
            public static object GetQueue(this IWebAdmitApplications operations, bool? showNulls = default(bool?), bool? showAll = default(bool?))
            {
                return operations.GetQueueAsync(showNulls, showAll).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='showNulls'>
            /// </param>
            /// <param name='showAll'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetQueueAsync(this IWebAdmitApplications operations, bool? showNulls = default(bool?), bool? showAll = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetQueueWithHttpMessagesAsync(showNulls, showAll, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object GetViterbiDenQueue(this IWebAdmitApplications operations)
            {
                return operations.GetViterbiDenQueueAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetViterbiDenQueueAsync(this IWebAdmitApplications operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetViterbiDenQueueWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object GetCollegesNoCeeb(this IWebAdmitApplications operations)
            {
                return operations.GetCollegesNoCeebAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetCollegesNoCeebAsync(this IWebAdmitApplications operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCollegesNoCeebWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='casId'>
            /// </param>
            /// <param name='cycleName'>
            /// </param>
            public static object GetPrograms(this IWebAdmitApplications operations, string casId, string cycleName)
            {
                return operations.GetProgramsAsync(casId, cycleName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='casId'>
            /// </param>
            /// <param name='cycleName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetProgramsAsync(this IWebAdmitApplications operations, string casId, string cycleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetProgramsWithHttpMessagesAsync(casId, cycleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='casId'>
            /// </param>
            /// <param name='cycleName'>
            /// </param>
            /// <param name='associationName'>
            /// </param>
            /// <param name='collegeAttendedIdInternal'>
            /// </param>
            public static object GetCollegeIds(this IWebAdmitApplications operations, string casId, string cycleName, string associationName, string collegeAttendedIdInternal)
            {
                return operations.GetCollegeIdsAsync(casId, cycleName, associationName, collegeAttendedIdInternal).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='casId'>
            /// </param>
            /// <param name='cycleName'>
            /// </param>
            /// <param name='associationName'>
            /// </param>
            /// <param name='collegeAttendedIdInternal'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetCollegeIdsAsync(this IWebAdmitApplications operations, string casId, string cycleName, string associationName, string collegeAttendedIdInternal, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCollegeIdsWithHttpMessagesAsync(casId, cycleName, associationName, collegeAttendedIdInternal, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='college'>
            /// </param>
            public static object PutCollege(this IWebAdmitApplications operations, USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONCOLLEGE college)
            {
                return operations.PutCollegeAsync(college).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='college'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PutCollegeAsync(this IWebAdmitApplications operations, USCPEApiWebApiAreasWebAdmitModelsAPPLICATIONCOLLEGE college, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutCollegeWithHttpMessagesAsync(college, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}