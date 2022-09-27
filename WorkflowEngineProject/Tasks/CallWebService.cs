using System;

namespace Csharp_Intermediate_Udemy.WorkflowEngineProject
{
    public class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling Webservice...");
        }
    }

}
