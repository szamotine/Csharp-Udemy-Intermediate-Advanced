using System.Collections.Generic;

namespace Csharp_Intermediate_Udemy.WorkflowEngineProject
{
    public class Workflow : IWorkflow
    {
        private readonly List<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
            _tasks.Add(new UploadVideo());
            _tasks.Add(new CallWebService());
            _tasks.Add(new SendEmail());
            _tasks.Add(new ChangeStatus());
        }

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
}
