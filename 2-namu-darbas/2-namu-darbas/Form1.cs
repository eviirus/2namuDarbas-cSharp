using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static _2_namu_darbas.TaskCollection;

namespace _2_namu_darbas
{
    //Try-catch implementacija
    //LINQ implementacija
    public partial class Form1 : Form
    {
        private TaskCollection tasks = new TaskCollection();
        private Stack<TaskCollection> history = new Stack<TaskCollection>();

        public Form1()
        {
            InitializeComponent();

            datePicker.MinDate = DateTime.Today;

            tasks.TaskAdded += Tasks_TaskAdded;
            tasks.TaskRemoved += Tasks_TaskRemoved;

            UpdateTaskStatistics();
        }

        private void Tasks_TaskAdded(object sender, TaskEventArgs e)
        {
            MessageBox.Show($"Task added: {e.Task.Title}", "Task Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshTaskList();
        }

        private void Tasks_TaskRemoved(object sender, TaskEventArgs e)
        {
            MessageBox.Show($"Task removed: {e.Task.Title}", "Task Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshTaskList();
        }

        private void SaveStateToHistory()
        {
            history.Push((TaskCollection)tasks.Clone());
        }

        private void UndoLastChange()
        {
            if (history.Count > 0)
            {
                tasks = history.Pop();
                RefreshTaskList();
            }
            else
            {
                MessageBox.Show("No actions to undo.", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAddTask(object sender, EventArgs e)
        {
            try
            {
                SaveStateToHistory();

                string title = nameInput.Text;
                string description = descriptionInput.Text;
                DateTime dueDate = datePicker.Value;

                if (dueDate < DateTime.Today)
                {
                    throw new InvalidTaskException("Due date cannot be earlier than today.");
                }

                var newTask = new TodoTask(title, description, dueDate);
                tasks.Add(newTask);

                RefreshTaskList();
                ClearInputFields();
            }
            catch (InvalidTaskException ex)
            {
                MessageBox.Show($"Invalid Task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DuplicateTaskException ex)
            {
                MessageBox.Show($"Duplicate Task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditTask(object sender, EventArgs e)
        {
            try
            {
                SaveStateToHistory();
                ValidateSelectedTask();

                var selectedTask = tasks[listBoxTasks.SelectedIndex];
                string newTitle = nameInput.Text;
                string newDescription = descriptionInput.Text;

                if (string.IsNullOrWhiteSpace(newTitle))
                {
                    throw new TaskOperationException("Task title cannot be empty.");
                }

                selectedTask.Title = newTitle;
                selectedTask.Description = newDescription;
                selectedTask.DueDate = datePicker.Value;

                RefreshTaskList();
                ClearInputFields();
            }
            catch (TaskOperationException ex)
            {
                MessageBox.Show($"Task Operation Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCompleteTask(object sender, EventArgs e)
        {
            try
            {
                SaveStateToHistory();
                ValidateSelectedTask();

                var selectedTask = tasks[listBoxTasks.SelectedIndex];
                if (selectedTask.IsCompleted)
                {
                    throw new TaskOperationException("Task is already marked as completed.");
                }

                selectedTask.IsCompleted = true;

                RefreshTaskList();
            }
            catch (TaskOperationException ex)
            {
                MessageBox.Show($"Task Operation Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteTask(object sender, EventArgs e)
        {
            try
            {
                SaveStateToHistory();

                int selectedIndex = listBoxTasks.SelectedIndex;
                tasks.RemoveAt(selectedIndex);

                RefreshTaskList();
                ClearInputFields();
            }
            catch (TaskNotFoundException ex)
            {
                MessageBox.Show($"Task Not Found: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshTaskList()
        {
            listBoxTasks.Items.Clear();

            foreach (var task in tasks)
            {
                string status = task.IsCompleted ? "[Completed] " : "";
                listBoxTasks.Items.Add(
                    $"{status}Title: {task.Title} \nDescription: {task.Description} \nDue: {task.DueDate.ToShortDateString()}"
                );
            }

            UpdateTaskStatistics();
        }

        private void ClearInputFields()
        {
            nameInput.Text = string.Empty;
            descriptionInput.Text = string.Empty;
            datePicker.Value = DateTime.Now;
        }

        private void ValidateSelectedTask()
        {
            if (listBoxTasks.SelectedIndex < 0)
            {
                throw new TaskOperationException("No task is selected. Please select a task to proceed.");
            }
        }

        private void UpdateTaskStatistics()
        {
            int totalTasks = tasks.Count;
            int completedTasks = 0;

            foreach (var task in tasks)
            {
                if (task.IsCompleted)
                {
                    completedTasks++;
                }
            }

            taskNumberDisplay.Text = $"Total Tasks: {totalTasks}";
            completedNumberDisplay.Text = $"Completed Tasks: {completedTasks}";
        }

        private void BtnUndo(object sender, EventArgs e)
        {
            UndoLastChange();
        }

        private void filterAscending(object sender, EventArgs e)
        {
            var sortedTasks = tasks.OrderBy(task => task.Title).ToList();

            listBoxTasks.Items.Clear();
            foreach (var task in sortedTasks)
            {
                string status = task.IsCompleted ? "[Completed] " : "";
                listBoxTasks.Items.Add(
                    $"{status}Title: {task.Title} \nDescription: {task.Description} \nDue: {task.DueDate.ToShortDateString()}"
                );
            }
        }

        private void filterDescending(object sender, EventArgs e)
        {
            var sortedTasks = tasks.OrderByDescending(task => task.Title).ToList();

            listBoxTasks.Items.Clear();
            foreach (var task in sortedTasks)
            {
                string status = task.IsCompleted ? "[Completed] " : "";
                listBoxTasks.Items.Add(
                    $"{status}Title: {task.Title} \nDescription: {task.Description} \nDue: {task.DueDate.ToShortDateString()}"
                );
            }
        }
    }
}
