// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DataApi
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Users.
    /// </summary>
    public static partial class UsersExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscId'>
            /// </param>
            public static object GetByUscId(this IUsers operations, string uscId)
            {
                return operations.GetByUscIdAsync(uscId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetByUscIdAsync(this IUsers operations, string uscId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByUscIdWithHttpMessagesAsync(uscId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscId'>
            /// </param>
            /// <param name='user'>
            /// </param>
            public static object PutByUscIdUser(this IUsers operations, string uscId, FaoUser user)
            {
                return operations.PutByUscIdUserAsync(uscId, user).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscId'>
            /// </param>
            /// <param name='user'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PutByUscIdUserAsync(this IUsers operations, string uscId, FaoUser user, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutByUscIdUserWithHttpMessagesAsync(uscId, user, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscId'>
            /// </param>
            public static object DeleteByUscId(this IUsers operations, string uscId)
            {
                return operations.DeleteByUscIdAsync(uscId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteByUscIdAsync(this IUsers operations, string uscId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteByUscIdWithHttpMessagesAsync(uscId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscId'>
            /// </param>
            /// <param name='user'>
            /// </param>
            public static object PatchByUscIdUser(this IUsers operations, string uscId, FaoUser user)
            {
                return operations.PatchByUscIdUserAsync(uscId, user).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscId'>
            /// </param>
            /// <param name='user'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PatchByUscIdUserAsync(this IUsers operations, string uscId, FaoUser user, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchByUscIdUserWithHttpMessagesAsync(uscId, user, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object Get(this IUsers operations)
            {
                return operations.GetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAsync(this IUsers operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='user'>
            /// </param>
            public static object PostByUser(this IUsers operations, FaoUser user)
            {
                return operations.PostByUserAsync(user).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='user'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostByUserAsync(this IUsers operations, FaoUser user, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostByUserWithHttpMessagesAsync(user, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}