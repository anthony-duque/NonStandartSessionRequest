// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DataApiClient
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for SessionRequest.
    /// </summary>
    public static partial class SessionRequestExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestId'>
            /// </param>
            public static object GetByRequestId(this ISessionRequest operations, int requestId)
            {
                return Task.Factory.StartNew(s => ((ISessionRequest)s).GetByRequestIdAsync(requestId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetByRequestIdAsync(this ISessionRequest operations, int requestId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByRequestIdWithHttpMessagesAsync(requestId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionDTO'>
            /// </param>
            public static object PostBySessionDTO(this ISessionRequest operations, Session sessionDTO)
            {
                return Task.Factory.StartNew(s => ((ISessionRequest)s).PostBySessionDTOAsync(sessionDTO), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionDTO'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostBySessionDTOAsync(this ISessionRequest operations, Session sessionDTO, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostBySessionDTOWithHttpMessagesAsync(sessionDTO, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
