using COR.Abstract;

namespace COR
{
    public class HR : Approver
    {
        public override Task<Status> ApproveLeave(int numberOfDays)
        {
            if (numberOfDays < 5)
            {
                isApproved = Status.Approved;
                approval.Add("HR", "Approved");
                return Task.FromResult(Status.Approved);
            }
            isApproved = Status.Rejected;
            approval.Add("HR", "Request Rejected");
            return Task.FromResult(Status.Rejected);
        }
    }
}
