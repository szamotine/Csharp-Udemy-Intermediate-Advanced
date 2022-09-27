﻿using System.Collections.Generic;

namespace Csharp_Intermediate_Udemy.WorkflowEngineProject
{
    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }

}
