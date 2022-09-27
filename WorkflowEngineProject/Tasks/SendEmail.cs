using System;

namespace Csharp_Intermediate_Udemy.WorkflowEngineProject
{
    public class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email...");
        }
    }

}
