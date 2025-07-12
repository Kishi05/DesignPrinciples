namespace COR.Abstract
{
    public abstract class Approver
    {
        protected Approver NextApprover;
        protected static Dictionary<string, string> approval = new();
        protected Status finalStatus = Status.Pending;

        public void SetNextApprover(Approver nextApprover)
        {
            NextApprover = nextApprover;
        }
        public abstract Task<Status> ApproveLeave(int numberOfDays);

        public virtual Dictionary<string, string> CurrentStatus()
        {
            return approval;
        }
        public virtual Status GetStatus() => finalStatus;
    }
}
