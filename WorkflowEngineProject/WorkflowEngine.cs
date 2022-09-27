

namespace Csharp_Intermediate_Udemy.WorkflowEngineProject
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (ITask i in workflow.GetTasks())
            {
                i.Execute();
            }
        }
    }

}
    

