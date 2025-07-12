using COR.Abstract;

namespace COR
{
    public class TLProxy : Approver
    {
        protected Approver? realApprover;
        private bool isInitialized = false;
        public override async Task<Status> ApproveLeave(int numberOfDays)
        {
            if (!isInitialized)
            {
                isInitialized = true;
                _ = Task.Run(async () =>
                {
                    await Task.Delay(1000);
                    realApprover = new TL();
                    realApprover.SetNextApprover(this.NextApprover);
                    approval.Add("Main", "Request Initiated");
                    Status result = await realApprover.ApproveLeave(numberOfDays);
                    foreach (var kv in realApprover.CurrentStatus())
                    {
                        approval[kv.Key] = kv.Value;
                    }
                    finalStatus = result;
                });
            }

            return finalStatus;
        }
    }
}
