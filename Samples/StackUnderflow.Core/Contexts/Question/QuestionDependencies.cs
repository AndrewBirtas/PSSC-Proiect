using LanguageExt;
using StackUnderflow.Domain.Schema.Question.InviteTenantAdminOp;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackUnderflow.Domain.Schema.Question
{
    public class QuestionDependencies
    {
        public Func<string> GenerateInvitationToken { get; set; }
        public Func<InvitationLetter, TryAsync<InvitationAcknowledgement>> SendInvitationEmail { get; set; }
    }
}
