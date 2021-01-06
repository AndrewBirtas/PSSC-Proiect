using System;
using System.Collections.Generic;
using System.Text;
using Access.Primitives.IO;
using LanguageExt;
using StackUnderflow.Domain.Schema.Question.CreateTenantOp;
using StackUnderflow.Domain.Schema.Question.InviteTenantAdminOp;
using static PortExt;
using static StackUnderflow.Domain.Schema.Question.CreateTenantOp.CreateTenantResult;
using static StackUnderflow.Domain.Schema.Question.InviteTenantAdminOp.InviteTenantAdminResult;

namespace StackUnderflow.Domain.Core
{
    public static class QuestionDomain
    {
        public static Port<ICreateTenantResult> CreateTenant(CreateTenantCmd command)
        {
            return NewPort<CreateTenantCmd, ICreateTenantResult>(command);
        }

        public static Port<IInviteTenantAdminResult> InviteTenantAdmin(InviteTenantAdminCmd command) => NewPort<InviteTenantAdminCmd, IInviteTenantAdminResult>(command);
    }
}

