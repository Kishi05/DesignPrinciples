using Proxy;
using Proxy.Entity;
using Proxy.Interface;

IPaymentReceipt receiptProxy = new PaymentReceiptProxy();

Receipt proxy1 = await receiptProxy.GetReceipt();
Console.WriteLine(proxy1.ToString());

await Task.Delay(2000);

Receipt proxy2 = await receiptProxy.GetReceipt();
Console.WriteLine(proxy2.ToString());

await Task.Delay(2000);

Receipt proxy3 = await receiptProxy.GetReceipt();
Console.WriteLine(proxy3.ToString());

await Task.Delay(2000);

Receipt value = await receiptProxy.GetReceipt();
Console.WriteLine(value.ToString());