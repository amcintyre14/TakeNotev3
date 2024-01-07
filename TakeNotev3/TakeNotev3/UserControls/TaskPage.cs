using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TakeNotev3.UserControls
{
    public partial class TaskPage : UserControl
    {
        // Declare class-level variables
        private List<Task> taskList;
        private string saveFilePath = Path.Combine(Application.UserAppDataPath, "tasks.json");

        public TaskPage()
        {
            InitializeComponent();

            // Load saved task data and populate ListView
            taskList = LoadTasksFromJson();
            PopulateListView();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            // Check if a task is selected
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a task to complete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update task in taskList
            int index = listView1.SelectedIndices[0];
            taskList[index].IsComplete = true;

            // Update ListViewItem in ListView
            listView1.Items[index].SubItems[2].Text = "Completed";
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            // Check if a task is selected
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a task to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Remove task from taskList and ListViewItem from ListView
            int index = listView1.SelectedIndices[0];
            taskList.RemoveAt(index);
            listView1.Items.RemoveAt(index);

            // Save updated taskList to file
            SaveTasksToJson();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Prompt user for task name
            string taskName = Microsoft.VisualBasic.Interaction.InputBox("Enter task name:", "Add Task");

            // Create new task object
            Task newTask = new Task(taskName);

            // Add task to taskList and ListViewItem to ListView
            taskList.Add(newTask);
            ListViewItem newItem = new ListViewItem(newTask.Name);
            newItem.SubItems.Add(newTask.DateAdded.ToShortDateString());
            newItem.SubItems.Add(newTask.IsComplete ? "Completed" : "");
            listView1.Items.Add(newItem);

            // Save updated taskList to file
            SaveTasksToJson();
        }

        private List<Task> LoadTasksFromJson()
        {
            // Attempt to load saved task data from file
            try
            {
                string jsonData = File.ReadAllText(saveFilePath);
                List<Task> tasks = JsonConvert.DeserializeObject<List<Task>>(jsonData);
                return tasks ?? new List<Task>();
            }
            catch
            {
                return new List<Task>();
            }
        }

        private void SaveTasksToJson()
        {
            // Serialize taskList to JSON and save to file
            string jsonData = JsonConvert.SerializeObject(taskList);
            File.WriteAllText(saveFilePath, jsonData);
        }

        private void PopulateListView()
        {
            // Add tasks from taskList to ListView
            foreach (Task task in taskList)
            {
                ListViewItem newItem = new ListViewItem(task.Name);
                newItem.SubItems.Add(task.DateAdded.ToShortDateString());
                newItem.SubItems.Add(task.IsComplete ? "Completed" : "");
                listView1.Items.Add(newItem);
            }
        }
    }

    public class Task
    {
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsComplete { get; set; }

        public Task(string name)
        {
            DateAdded = DateTime.Now;
            Name = name;
            IsComplete = false;
        }
    }
}