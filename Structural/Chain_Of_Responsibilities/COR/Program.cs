using COR;

LeaveManagementFacade leaveRequest = new LeaveManagementFacade();
//leaveRequest.ApplyLeaveRequest(3);
int leaveCount = 0;
string result;
do
{
    Console.WriteLine("Welcome to Leave Management System");
    Console.WriteLine("1) Apply Leave");
    Console.WriteLine("2) Check Status");

    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            if (leaveCount > 0)
            {
                Console.WriteLine("Request already in progress");
                break;
            }
            leaveRequest.ApplyLeaveRequest(5);
            break;
        case 2:
            leaveRequest.GetStatus();
            break;
        default:
            Console.WriteLine("Invalid Choice");
            break;
    }

    Console.WriteLine("Planning to wait ?! (Y/N)");
    result = Console.ReadLine();
} while (result.Equals("Y"));




