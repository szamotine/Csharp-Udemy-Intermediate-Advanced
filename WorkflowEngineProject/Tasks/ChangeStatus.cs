using System;

namespace Csharp_Intermediate_Udemy.WorkflowEngineProject
{
    public class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Changing status to \"Processing\"...");
        }
    }

}
