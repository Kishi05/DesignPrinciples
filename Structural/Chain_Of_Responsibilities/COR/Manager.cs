using COR.Abstract;

namespace COR
{
    public class Manager : Approver
    {
        public override Task<Status> ApproveLeave(int numberOfDays)
        {
            if (numberOfDays < 3)
            {
                isApproved = Status.Approved;
                approval.Add("Manager", "Approved");
                return Task.FromResult(Status.Approved);
            }
            else if (NextApprover != null)
            {
                isApproved = Status.Pending;
                approval.Add("Manager", "Need HR Approval");
                return NextApprover.ApproveLeave(numberOfDays);
            }
            isApproved = Status.Rejected;
            approval.Add("Manager", "Request Rejected");
            return Task.FromResult(Status.Rejected);
        }
    }
}
