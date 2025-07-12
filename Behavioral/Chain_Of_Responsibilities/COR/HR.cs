using COR.Abstract;

namespace COR
{
    public class HR : Approver
    {
        public override async Task<Status> ApproveLeave(int numberOfDays)
        {
            await Task.Delay(3000);
            if (numberOfDays < 5)
            {
                approval.Add("HR", "Approved");
                finalStatus = Status.Approved;
                return finalStatus;
            }
            approval.Add("HR", "Request Rejected");
            finalStatus = Status.Rejected;
            return finalStatus;
        }
    }
}
