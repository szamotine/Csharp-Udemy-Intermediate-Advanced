using System;

namespace Csharp_Intermediate_Udemy.WorkflowEngineProject
{
    public class UploadVideo : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Video...");
        }
    }

}
