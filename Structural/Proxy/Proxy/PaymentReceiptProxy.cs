using Proxy.Entity;
using Proxy.Interface;

namespace Proxy
{
    public class PaymentReceiptProxy : IPaymentReceipt
    {
        private static readonly Receipt receipt = new Receipt() { Confirmation = "Processing.." };
        private PaymentReceipt? _realPaymentReceipt { get; set; }
        private bool paymentInitiated = false;
        private bool paymentSuccess = false;
        private Receipt? _receipt;

        public Task<Receipt> GetReceipt()
        {
            //Console.WriteLine($"_recepit value : {_receipt?.ToString() ?? "null" }\n"); //UnComment If you want to test the flow

            if (paymentSuccess)
            {
                return Task.FromResult(_receipt);
            }
            else
            {
                if (!paymentInitiated)
                {
                    paymentInitiated = true;

                    _ = Task.Run(async () =>
                    {
                        if (_realPaymentReceipt == null)
                            _realPaymentReceipt = new PaymentReceipt();
                        Receipt result = await _realPaymentReceipt.GetReceipt();
                        Interlocked.Exchange(ref _receipt, result);
                        paymentSuccess = true;
                    });
                }
                return Task.FromResult(GetproxyReceipt());
            }
        }

        private Receipt GetproxyReceipt()
        {
            return receipt;
        }
    }
}
