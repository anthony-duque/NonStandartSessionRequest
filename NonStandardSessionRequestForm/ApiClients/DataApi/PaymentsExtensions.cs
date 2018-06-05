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
    /// Extension methods for Payments.
    /// </summary>
    public static partial class PaymentsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscId'>
            /// </param>
            /// <param name='payment'>
            /// </param>
            public static object PostByUscIdPayment(this IPayments operations, string uscId, Payment payment)
            {
                return operations.PostByUscIdPaymentAsync(uscId, payment).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uscId'>
            /// </param>
            /// <param name='payment'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostByUscIdPaymentAsync(this IPayments operations, string uscId, Payment payment, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostByUscIdPaymentWithHttpMessagesAsync(uscId, payment, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
