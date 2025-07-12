using COR.Abstract;

namespace COR
{
    public class TL : Approver
    {
        public override async Task<Status> ApproveLeave(int numberOfDays)
        {
            await Task.Delay(3000);
            if(numberOfDays == 1)
            {
                approval.Add("TL", "Approved");
                finalStatus = Status.Approved;
                return finalStatus;
            }
            else if(NextApprover != null)
            {
                approval.Add("TL", "Escalated to Manager");
                Status result = await NextApprover.ApproveLeave(numberOfDays);
                MergeApproval(result);
                finalStatus = result;
                return finalStatus;
            }
            approval.Add("TL", "Request Rejected");
            finalStatus = Status.Rejected;
            return finalStatus;
        }

        private void MergeApproval(Status result)
        {
            if (NextApprover != null)
            {
                foreach (var kv in NextApprover.CurrentStatus())
                {
                    approval[kv.Key] = kv.Value;
                }
            }
        }

    }
}
