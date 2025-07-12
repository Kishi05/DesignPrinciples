namespace COR.Abstract
{
    public abstract class Approver
    {
        protected Approver? FacadeApproverObj { get; set; }
        protected static Status? isApproved;
        protected Approver NextApprover;
        protected static Dictionary<string, string> approval = new Dictionary<string, string>();
        public void SetNextApprover(Approver nextApprover)
        {
            NextApprover = nextApprover;
        }
        public abstract Task<Status> ApproveLeave(int numberOfDays);

        public Dictionary<string, string> CurrentStatus()
        {
            return approval;
        }

        public Status? isRequestApproved()
        {
            return isApproved;
        }

        public Approver? GetRealApprover()
        {
            return FacadeApproverObj;
        }

    }
}
