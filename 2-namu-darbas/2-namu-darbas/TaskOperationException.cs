using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_namu_darbas
{
    //Išimties tipų implementacija
    public class TaskOperationException : Exception
    {
        public TaskOperationException() { }

        public TaskOperationException(string message) : base(message) { }

        public TaskOperationException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class InvalidTaskException : TaskOperationException
    {
        public InvalidTaskException() { }

        public InvalidTaskException(string message) : base(message) { }

        public InvalidTaskException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class TaskNotFoundException : TaskOperationException
    {
        public TaskNotFoundException() { }

        public TaskNotFoundException(string message) : base(message) { }

        public TaskNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class DuplicateTaskException : TaskOperationException
    {
        public DuplicateTaskException() { }

        public DuplicateTaskException(string message) : base(message) { }

        public DuplicateTaskException(string message, Exception innerException) : base(message, innerException) { }
    }
}
