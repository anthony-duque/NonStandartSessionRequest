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
    /// Extension methods for Bursar.
    /// </summary>
    public static partial class BursarExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscid'>
            /// </param>
            /// <param name='term'>
            /// </param>
            public static IList<USCPEApiDTORnrAppsBursarTransaction> GetTransaction(this IBursar operations, string uscid, string term)
            {
                return operations.GetTransactionAsync(uscid, term).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscid'>
            /// </param>
            /// <param name='term'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<USCPEApiDTORnrAppsBursarTransaction>> GetTransactionAsync(this IBursar operations, string uscid, string term, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTransactionWithHttpMessagesAsync(uscid, term, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscid'>
            /// </param>
            /// <param name='term'>
            /// </param>
            public static USCPEApiDTORnrAppsBursarTerm GetTerm(this IBursar operations, string uscid, string term)
            {
                return operations.GetTermAsync(uscid, term).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscid'>
            /// </param>
            /// <param name='term'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<USCPEApiDTORnrAppsBursarTerm> GetTermAsync(this IBursar operations, string uscid, string term, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTermWithHttpMessagesAsync(uscid, term, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
