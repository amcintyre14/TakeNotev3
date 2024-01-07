namespace TakeNotev3
{
    partial class TakeNote
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeNote));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainNav = new System.Windows.Forms.MenuStrip();
            this.btnNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTask = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.mainNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainNav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // mainNav
            // 
            this.mainNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNotes,
            this.btnGroups,
            this.btnTask});
            this.mainNav.Location = new System.Drawing.Point(0, 0);
            this.mainNav.Name = "mainNav";
            this.mainNav.Size = new System.Drawing.Size(800, 30);
            this.mainNav.TabIndex = 0;
            this.mainNav.Text = "mainNav";
            // 
            // btnNotes
            // 
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(50, 26);
            this.btnNotes.Text = "Notes";
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(57, 26);
            this.btnGroups.Text = "Groups";
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnTask
            // 
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(41, 26);
            this.btnTask.Text = "Task";
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 600);
            this.panel2.TabIndex = 1;
            // 
            // TakeNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 669);
            this.Name = "TakeNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakeNote";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainNav.ResumeLayout(false);
            this.mainNav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private MenuStrip mainNav;
        private ToolStripMenuItem btnNotes;
        private ToolStripMenuItem btnGroups;
        private ToolStripMenuItem btnTask;
        private Panel panel2;
    }
}