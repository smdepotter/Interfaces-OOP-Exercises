using System;

namespace Interfaces_OOP_Exercises
{
    class Program
    {
        static void Main()
        {
            var workFlow = new Workflow();
            workFlow.AddActivity(new EncodeVideoActivity());

            var workFlowEngine = new WorkflowEngine();
            workFlowEngine.Run(workFlow);
        }
    }
}
