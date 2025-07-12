using Proxy.Entity;

namespace Proxy.Interface
{
    public interface IPaymentReceipt
    {
        public Task<Receipt> GetReceipt();
    }
}
