using System.Activities;
using System;
using Microsoft.Xrm.Sdk.Workflow;

namespace WorkflowCrmTeste
{

    public sealed class Activity : CodeActivity
    {
        protected override void Execute(CodeActivityContext context)
        {
            this.NewGuid.Set(context, Guid.NewGuid().ToString());
        }

        [Output("NewGuid")]
        public OutArgument NewGuid { get; set; }
    }
}
