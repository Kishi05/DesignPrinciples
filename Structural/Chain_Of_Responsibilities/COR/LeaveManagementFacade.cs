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
        public void ApplyLeaveAsync(int numberOfDays)
        {
            Approver approver = new TLProxy();
            Manager manager = new Manager();
            HR hR = new HR();

            approver.SetNextApprover(manager);
            manager.SetNextApprover(hR);

            Approver = approver;

            _ = approver.ApproveLeave(numberOfDays);
        }

        public void GetStatus()
        {
            Console.WriteLine(Approver.GetStatus());
        }

        public void PrintStatus()
        {
            Console.WriteLine("\n--- Approval Trail ---");
            if (Approver.CurrentStatus().Any())
            {
                foreach (var kv in Approver.CurrentStatus())
                {
                    Console.WriteLine($"{kv.Key}: {kv.Value}");
                }
            }
            else
            {
                Console.WriteLine("Still Pending..");
            }
                Console.WriteLine($"\nCurrent Status: {Approver.GetStatus()}");
        }

    }
}
