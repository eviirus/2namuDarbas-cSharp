using System;
using System.Collections;
using System.Collections.Generic;

namespace _2_namu_darbas
{
    //IEnumerable implementacija
    //Iteratoriaus implementacija
    //Generic tipo implementacija
    //Įvykių implementacija
    //ICloneable implementacija
    public class TaskCollection : IEnumerable<TodoTask>, ICloneable
    {
        private List<TodoTask> tasks = new List<TodoTask>();

        public event EventHandler<TaskEventArgs> TaskAdded;
        public event EventHandler<TaskEventArgs> TaskRemoved;

        public void Add(TodoTask task)
        {
            if (task == null || string.IsNullOrWhiteSpace(task.Title))
                throw new InvalidTaskException("Task title cannot be empty.");

            if (tasks.Exists(t => t.Title.Equals(task.Title, StringComparison.OrdinalIgnoreCase)))
                throw new DuplicateTaskException($"A task with the title '{task.Title}' already exists.");

            tasks.Add(task);

            TaskAdded?.Invoke(this, new TaskEventArgs(task));
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= tasks.Count)
                throw new TaskNotFoundException($"No task found at index {index}.");

            var removedTask = tasks[index];
            tasks.RemoveAt(index);

            TaskRemoved?.Invoke(this, new TaskEventArgs(removedTask));
        }

        public TodoTask this[int index]
        {
            get
            {
                if (index < 0 || index >= tasks.Count)
                    throw new TaskNotFoundException($"No task found at index {index}.");
                return tasks[index];
            }
        }

        public int Count => tasks.Count;

        public object Clone()
        {
            var clone = new TaskCollection();
            foreach (var task in tasks)
            {
                clone.Add((TodoTask)task.Clone());
            }
            return clone;
        }

        public IEnumerator<TodoTask> GetEnumerator()
        {
            return tasks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class TaskEventArgs : EventArgs
        {
            public TodoTask Task { get; }

            public TaskEventArgs(TodoTask task)
            {
                Task = task;
            }
        }
    }
}
