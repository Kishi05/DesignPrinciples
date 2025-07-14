using Builder.Abstract;
using Builder.Builder;
using Builder.Builder.Interface;
using Builder.Enum;
using Builder.Factory;

bool isValid = false;
int? paymentType = null;
int retryCounter = 1;
IPaymentBuilder? paymentMethodType = null;

try
{
    do
    {
        try
        {
            Console.WriteLine("Choose Payment Type");

            Console.WriteLine("(1)\tCredit Card\t(2)\tUPI");

            Console.WriteLine("Select Payment Type:");
            paymentType = int.Parse(Console.ReadLine());

            paymentMethodType = PaymentBuilderFactory.PaymentMethod((PaymentType)paymentType);

            if (paymentMethodType == null)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

        }
        catch (FormatException)
        {
            isValid = false;
        }
        catch (InvalidCastException)
        {
            isValid = false;
        }
        catch (ArgumentException)
        {
            Console.WriteLine($"Invalid payment type: {paymentType}\n");
            isValid = false;
        }

        if (retryCounter >= 3)
        {
            Console.WriteLine("Exceeded Max Retry Count");
            break;
        }

        retryCounter++;

    } while (!isValid);

    if (isValid)
    {
        Console.WriteLine();

        IPaymentBuilder paymentBuilder = paymentMethodType.Build();

        Payment? paymentMethod = null;

        if(paymentBuilder is not null)
        {
            bool isValidObject = false;

            if(paymentBuilder is CreditCardBuilder creditCardBuilder)
            {
                paymentMethod = creditCardBuilder.GetCardNumber()
                                                 .GetCardHolderName()
                                                 .GetExpirationDate()
                                                 .PaymentObject();
                isValidObject = true;
            }
            else if(paymentBuilder is UPIBuilder _UPIBuilder)
            {
                paymentMethod = _UPIBuilder.GetUPIID()
                                           .PaymentObject();
                isValidObject = true;
            }

            if (isValidObject)
            {
                paymentMethod.InitiatePayment();
                paymentMethod.ProcessPayment();
            }

        }

        Console.WriteLine("\nPayment Completed Successfully");

    }
}
catch (Exception ex)
{
    Console.WriteLine($"\nPayment Failed - {ex.Message}");
}