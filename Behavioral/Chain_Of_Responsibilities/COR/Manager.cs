using COR.Abstract;

namespace COR
{
    public class Manager : Approver
    {
        public override async Task<Status> ApproveLeave(int numberOfDays)
        {
            await Task.Delay(3000);
            if (numberOfDays < 3)
            {
                approval.Add("Manager", "Approved");
                finalStatus = Status.Approved;
                return finalStatus;
            }
            else if (NextApprover != null)
            {
                approval.Add("Manager", "Need HR Approval");
                Status result = await NextApprover.ApproveLeave(numberOfDays);
                MergeApproval(result);
                finalStatus = result;
                return finalStatus;
            }
            approval.Add("Manager", "Request Rejected");
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
