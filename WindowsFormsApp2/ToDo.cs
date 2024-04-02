using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class ToDoItem
    {
        public string Key { get; private set; }
        public string Assignee { get; set; } //by default should be assigned to loged in user
        public string Title { get; set; }
        public string Tags { get; set; } // a coma saperated list of tags for the task
        public string Description { get; set; }
        public string ParentTaskKey { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean Completed { get; set; }

        public ToDoItem(string title, string description, string parentTaskKey, DateTime startDate, DateTime dueDate, DateTime endDate, string assignee, bool completed = false, String tags = "")
        {
            Key = DateTime.Now.ToString("yyMMddHHmmss");
            Title = title;
            Assignee = assignee;
            Description = description;
            Tags = tags;
            ParentTaskKey = parentTaskKey;
            StartDate = startDate;
            DueDate = dueDate;
            EndDate = endDate;
            Completed = completed; //Initialize the task as not compleated
        }

        public override string ToString()
        {
            return $"Key: {Key}, Title: {Title}, Description: {Description}, " +
                   $"ParentTaskKey: {ParentTaskKey}, StartDate: {StartDate}, EndDate: {EndDate}";
        }
    }
}
