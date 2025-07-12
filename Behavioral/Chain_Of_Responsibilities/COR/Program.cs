using COR;

var leaveFacade = new LeaveManagementFacade();
string? result;
int requestInProgress = 0;

do
{
    Console.WriteLine("\nLeave Management System");
    Console.WriteLine("1) Apply Leave\n2) Check Status\n3) Print Status\nEnter choice:");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            if (requestInProgress == 1)
            {
                Console.WriteLine("Leave request already in progress...");
            }
            else
            {
                Console.WriteLine("Enter number of leave days:");
                int days = int.Parse(Console.ReadLine());
                leaveFacade.ApplyLeaveAsync(days);
                requestInProgress = 1;
                Console.WriteLine("Leave request submitted. You can check status anytime.");
            }
            break;

        case 2:
            leaveFacade.GetStatus();
            break;

        case 3:
            leaveFacade.PrintStatus();
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    Console.WriteLine("\nContinue? (Y/N):");
    result = Console.ReadLine();
} while (result?.Equals("Y", StringComparison.OrdinalIgnoreCase) == true);