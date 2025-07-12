using COR.Abstract;

namespace COR
{
    public class TLProxy : Approver
    {
        protected Approver realApprover;
        public async override Task<Status> ApproveLeave(int numberOfDays)
        {
            if(isApproved != null)
            {
                return isApproved.Value;
            }
            else if (realApprover == null)
            {
                _ = Task.Run(async () =>
                {
                    realApprover = new TL();
                    approval.Add("Main", "Request Initiated");
                    realApprover.SetNextApprover(this.NextApprover);
                    FacadeApproverObj = realApprover;
                    await realApprover.ApproveLeave(numberOfDays);
                });
            }
            return Status.Pending;
        }
    }
}
