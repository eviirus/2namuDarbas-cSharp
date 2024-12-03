using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_namu_darbas
{
    public class TodoTask : ICloneable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public TodoTask(string title, string description, DateTime dueDate, bool isCompleted = false)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }

        public object Clone()
        {
            return new TodoTask(Title, Description, DueDate, IsCompleted);
        }


        //Dekonstuktoriaus implementacija
        public void Deconstruct(out string title, out string description, out DateTime dueDate)
        {
            title = Title;
            description = Description;
            dueDate = DueDate;
        }

    }
}
