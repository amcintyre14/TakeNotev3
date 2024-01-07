using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TakeNotev3.UserControls
{
    public partial class GroupsPage : UserControl
    {
     
        public List<FileGroup> groups;

        public GroupsPage()
        {
            InitializeComponent();

            // Load the data from a file
            LoadData();
            listView1.MouseClick += listView1_MouseClick;
            listView1.AllowDrop = true;
        }


        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            // Show a dialog box to get the name of the new group
            string groupName = Microsoft.VisualBasic.Interaction.InputBox("Enter the name of the new group:", "Add Group");

            // Check if the group name is valid
            if (!string.IsNullOrWhiteSpace(groupName))
            {
                // Check if the group name already exists
                if (listView1.Groups.Cast<ListViewGroup>().Any(g => g.Header == groupName))
                {
                    MessageBox.Show("A group with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new ListViewGroup and add it to the ListView control
                ListViewGroup newGroup = new ListViewGroup(groupName);
                newGroup.HeaderAlignment = HorizontalAlignment.Left;
                listView1.Groups.Add(newGroup);

                // Prompt the user to select files to add to the new group
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Add the selected files to the ListView control as sub items of the new group
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        try
                        {
                            string filePath = Path.GetFullPath(fileName);
                            if (File.Exists(filePath))
                            {
                                ListViewItem newItem = new ListViewItem(Path.GetFileName(filePath));
                                newItem.Tag = filePath;
                                newItem.Group = newGroup;
                                listView1.Items.Add(newItem);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Save the updated data to a file

                }
            }
            else
            {
                MessageBox.Show("Please enter a valid group name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SaveData();

        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            // Show a dialog box to let the user select one or more files
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Add the selected files to the ListView control as sub items of the selected group
                ListViewGroup selectedGroup = listView1.SelectedItems.Count > 0 ? listView1.SelectedItems[0].Group : null;
                foreach (string fileName in openFileDialog.FileNames)
                {
                    try
                    {
                        string filePath = Path.GetFullPath(fileName);
                        if (File.Exists(filePath))
                        {
                            ListViewItem newItem = new ListViewItem(Path.GetFileName(filePath));
                            newItem.Tag = filePath;

                            // If no group is selected, create a new
                            // group named "Ungrouped Files" and add the item to it
                            if (selectedGroup == null)
                            {
                                ListViewGroup ungroupedGroup = listView1.Groups["Ungrouped Files"] ?? new ListViewGroup("Ungrouped Files");
                                ungroupedGroup.HeaderAlignment = HorizontalAlignment.Left;
                                listView1.Groups.Add(ungroupedGroup);
                                newItem.Group = ungroupedGroup;
                            }
                            else
                            {
                                newItem.Group = selectedGroup;
                            }
                            listView1.Items.Add(newItem);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding file '{fileName}': {ex.Message}");
                    }
                }
            }
            SaveData();
 
        }
        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected item and its group
                ListViewItem selectedItem = listView1.SelectedItems[0];
                ListViewGroup selectedGroup = selectedItem.Group;

                // Remove the item from the ListView control
                listView1.Items.Remove(selectedItem);

                // Remove the file from the corresponding FileGroup object
                FileGroup fileGroup = groups.FirstOrDefault(g => g.Name == selectedGroup.Header);
                if (fileGroup != null)
                {
                    fileGroup.Files.Remove((string)selectedItem.Tag);
                }

                // Save the updated data to a file
                SaveData();
            }
            else
            {
                MessageBox.Show("Please select a file to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void SaveData()
        //{
        //    try
        //    {
        //        // Serialize the groups list to a JSON string
        //        string data = JsonConvert.SerializeObject(groups, Formatting.Indented);

        //// Write the JSON string to a file
        //string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //string filePath = Path.Combine(appDataFolder, "TakeNotev3", "groups.json");
        //Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        //        File.WriteAllText(filePath, data);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void SaveData()
        {
            try
            {
                // Serialize the groups list to a JSON string
                string data = JsonConvert.SerializeObject(groups, Formatting.Indented);

                // Write the JSON string to a file
                string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string filePath = Path.Combine(appDataFolder, "TakeNotev3", "groups.json");
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<FileGroup> LoadData()
        {
            try
            {
                // Read the JSON string from the file
                string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string filePath = Path.Combine(appDataFolder, "TakeNotev3", "groups.json");
                if (File.Exists(filePath))
                {
                    string data = File.ReadAllText(filePath);

                    // Deserialize the JSON string to a List<FileGroup> object
                    List<FileGroup> groups = JsonConvert.DeserializeObject<List<FileGroup>>(data);

                    return groups;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new List<FileGroup>();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem clickedItem = listView1.GetItemAt(e.X, e.Y);
                if (clickedItem != null && clickedItem.Tag != null && File.Exists((string)clickedItem.Tag))
                {
                    // Display file properties in a new pop-up window
                    string filePath = (string)clickedItem.Tag;
                    string fileName = Path.GetFileName(filePath);
                    FileAttributes attributes = File.GetAttributes(filePath);
                    long fileSize = new FileInfo(filePath).Length;
                    DateTime creationTime = File.GetCreationTime(filePath);
                    DateTime lastAccessTime = File.GetLastAccessTime(filePath);
                    DateTime lastWriteTime = File.GetLastWriteTime(filePath);
                    MessageBox.Show($"Name: {fileName}\nSize: {fileSize} bytes\nAttributes: {attributes}\nCreated: {creationTime}\nLast accessed: {lastAccessTime}\nLast modified: {lastWriteTime}", "File Properties");
                }
            }
        }

    }
}