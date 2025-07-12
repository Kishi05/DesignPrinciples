using COR.Abstract;

namespace COR
{
    public class TL : Approver
    {
        public override Task<Status> ApproveLeave(int numberOfDays)
        {
            Task.Delay(1000);
            if(numberOfDays == 1)
            {
                approval.Add("TL", "Approved");
                isApproved = Status.Approved;
                return Task.FromResult(Status.Approved);
            }
            else if(NextApprover != null)
            {
                isApproved = Status.Pending;
                approval.Add("TL", "Need Manager Approval");
                return NextApprover.ApproveLeave(numberOfDays);
            }
            isApproved = Status.Rejected;
            approval.Add("TL", "Request Rejected");
            return Task.FromResult(Status.Rejected);
        }
    }
}
