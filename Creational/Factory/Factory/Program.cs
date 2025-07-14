using Factory.Abstract;
using Factory.Enum;
using Factory.Factory;

bool isValid = false;
int? paymentType = null;
int retryCounter = 1;
Payment? paymentMethod =  null;

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

            paymentMethod = PaymentFactory.PaymentMethod((PaymentType)paymentType);

            if(paymentMethod == null)
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

        if(retryCounter >= 3)
        {
            Console.WriteLine("Exceeded Max Retry Count");
            break;
        }

        retryCounter++;

    } while (!isValid);

    if (isValid)
    {
        Console.WriteLine();

        paymentMethod.PaymentDetails();
        paymentMethod.ProcessPayment();

        Console.WriteLine("\nPayment Completed Successfully");

    }
}
catch (Exception ex)
{
    Console.WriteLine($"\nPayment Failed - {ex.Message}");
}