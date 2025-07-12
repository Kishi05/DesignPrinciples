using Proxy.Entity;
using Proxy.Interface;

namespace Proxy
{
    public class PaymentReceipt : IPaymentReceipt
    {
        public async Task<Receipt> GetReceipt()
        {
            await Task.Delay(5000);
            Receipt receipt = new Receipt()
            {
                Confirmation = "AGSUY8K6DI"
            };
            return receipt;
        }
    }
}
