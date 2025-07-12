using COR.Abstract;

namespace COR
{
    public class LeaveManagementFacade
    {
        private Approver approver;
        public Approver Approver
        {
            get
            {
                if(approver == null)
                    approver = new TLProxy();
                return approver;
            }
            set
            {
                approver = value;
            }
        }
        public async void ApplyLeaveRequest(int numberOfDays)
        {
            Approver approver = new TLProxy();
            Manager manager = new Manager();
            HR hR = new HR();

            approver.SetNextApprover(manager);
            manager.SetNextApprover(hR);

            Approver = approver;

            await approver.ApproveLeave(numberOfDays);
        }
            
        public void GetStatus()
        {
            var realApprover = approver.GetRealApprover();
            Status? result = realApprover.isRequestApproved();
            switch (result)
            {
                case Status.Approved:
                    Console.WriteLine("Request Approved.");
                    break;
                case Status.Rejected:
                    Console.WriteLine("Request Rejected.");
                    break;
                case Status.Pending:
                    Console.WriteLine("Request Pending.");
                    break;
                default:
                    Console.WriteLine("In Queue. Yet to Initiate");
                    break;
            }

            Dictionary<string, string> status = realApprover.CurrentStatus();

            foreach (var state in status)
            {
                Console.WriteLine($"{state.Key} => {state.Value}");
            }

        }

    }
}
