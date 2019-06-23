using System;

namespace Interfaces_OOP_Exercises
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var activity in workflow.Get())
            {
                activity.Execute();
            }
        }
    }
}