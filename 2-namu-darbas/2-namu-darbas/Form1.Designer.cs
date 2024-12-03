namespace _2_namu_darbas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.taskNumberDisplay = new System.Windows.Forms.Label();
            this.completedNumberDisplay = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(12, 226);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(544, 212);
            this.listBoxTasks.TabIndex = 0;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddTask.Location = new System.Drawing.Point(632, 330);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.BtnAddTask);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(713, 330);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(75, 23);
            this.btnEditTask.TabIndex = 2;
            this.btnEditTask.Text = "Edit task";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.BtnEditTask);
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCompleteTask.Location = new System.Drawing.Point(672, 374);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(116, 23);
            this.btnCompleteTask.TabIndex = 3;
            this.btnCompleteTask.Text = "Mark as Complete";
            this.btnCompleteTask.UseVisualStyleBackColor = false;
            this.btnCompleteTask.Click += new System.EventHandler(this.BtnCompleteTask);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteTask.Location = new System.Drawing.Point(713, 415);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 4;
            this.btnDeleteTask.Text = "Delete task";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.BtnDeleteTask);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Task list";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(12, 89);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(315, 96);
            this.descriptionInput.TabIndex = 6;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(356, 31);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Task description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose due date";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(12, 31);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(220, 20);
            this.nameInput.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Task name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Undo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnUndo);
            // 
            // taskNumberDisplay
            // 
            this.taskNumberDisplay.AutoSize = true;
            this.taskNumberDisplay.Location = new System.Drawing.Point(562, 226);
            this.taskNumberDisplay.Name = "taskNumberDisplay";
            this.taskNumberDisplay.Size = new System.Drawing.Size(87, 13);
            this.taskNumberDisplay.TabIndex = 13;
            this.taskNumberDisplay.Text = "Number of tasks:";
            // 
            // completedNumberDisplay
            // 
            this.completedNumberDisplay.AutoSize = true;
            this.completedNumberDisplay.Location = new System.Drawing.Point(562, 248);
            this.completedNumberDisplay.Name = "completedNumberDisplay";
            this.completedNumberDisplay.Size = new System.Drawing.Size(88, 13);
            this.completedNumberDisplay.TabIndex = 14;
            this.completedNumberDisplay.Text = "Completed tasks:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Filter A-Z";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.filterAscending);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Filter Z-A";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.filterDescending);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.completedNumberDisplay);
            this.Controls.Add(this.taskNumberDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnCompleteTask);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.listBoxTasks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label taskNumberDisplay;
        private System.Windows.Forms.Label completedNumberDisplay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

