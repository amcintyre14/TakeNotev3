namespace TakeNotev3.UserControls
{
    partial class TaskPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskPage));
            this.taskToolBar = new System.Windows.Forms.ToolStrip();
            this.btnAddTask = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveTask = new System.Windows.Forms.ToolStripButton();
            this.btnComplete = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.colTask = new System.Windows.Forms.ColumnHeader();
            this.colComplete = new System.Windows.Forms.ColumnHeader();
            this.taskToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskToolBar
            // 
            this.taskToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.taskToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTask,
            this.btnRemoveTask,
            this.btnComplete});
            this.taskToolBar.Location = new System.Drawing.Point(0, 0);
            this.taskToolBar.Name = "taskToolBar";
            this.taskToolBar.Size = new System.Drawing.Size(800, 25);
            this.taskToolBar.TabIndex = 0;
            this.taskToolBar.Text = "taskToolBar";
            // 
            // btnAddTask
            // 
            this.btnAddTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddTask.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTask.Image")));
            this.btnAddTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(23, 22);
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveTask.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveTask.Image")));
            this.btnRemoveTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(23, 22);
            this.btnRemoveTask.Text = "Remove Task";
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnComplete.Image = ((System.Drawing.Image)(resources.GetObject("btnComplete.Image")));
            this.btnComplete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(23, 22);
            this.btnComplete.Text = "Task Complete";
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.MinimumSize = new System.Drawing.Size(750, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 550);
            this.panel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colTask,
            this.colComplete});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(750, 550);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colDate
            // 
            this.colDate.Text = "Task";
            this.colDate.Width = 550;
            // 
            // colTask
            // 
            this.colTask.Text = "Date";
            this.colTask.Width = 100;
            // 
            // colComplete
            // 
            this.colComplete.Text = "Completed?";
            this.colComplete.Width = 100;
            // 
            // TaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.taskToolBar);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TaskPage";
            this.Size = new System.Drawing.Size(800, 600);
            this.taskToolBar.ResumeLayout(false);
            this.taskToolBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip taskToolBar;
        private ToolStripButton btnAddTask;
        private ToolStripButton btnRemoveTask;
        private ToolStripButton btnComplete;
        private Panel panel1;
        private ListView listView1;
        private ColumnHeader colDate;
        private ColumnHeader colTask;
        private ColumnHeader colComplete;
    }
}
