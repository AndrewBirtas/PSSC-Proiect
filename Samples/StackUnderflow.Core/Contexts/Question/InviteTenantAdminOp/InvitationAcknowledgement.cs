namespace StackUnderflow.Domain.Schema.Question.InviteTenantAdminOp
{
    public class InvitationAcknowledgement
    {
        public string Receipt { get; private set; }

        public InvitationAcknowledgement(string receipt)
        {
            Receipt = receipt;
        }
    }
}