namespace TakeNotev3.UserControls
{
    partial class NotesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesPage));
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewNote = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFontFormat = new System.Windows.Forms.ToolStripButton();
            this.btnColorFormat = new System.Windows.Forms.ToolStripButton();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalics = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.btnStrikeout = new System.Windows.Forms.ToolStripButton();
            this.btnCut = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTag = new System.Windows.Forms.ToolStripButton();
            this.btnImage = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbNote
            // 
            this.rtbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNote.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbNote.Location = new System.Drawing.Point(25, 41);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(750, 530);
            this.rtbNote.TabIndex = 3;
            this.rtbNote.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewNote,
            this.btnSave,
            this.btnOpen,
            this.btnPrint,
            this.toolStripSeparator1,
            this.btnFontFormat,
            this.btnColorFormat,
            this.btnBold,
            this.btnItalics,
            this.btnUnderline,
            this.btnStrikeout,
            this.btnCut,
            this.btnCopy,
            this.btnPaste,
            this.toolStripSeparator2,
            this.btnTag,
            this.btnImage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewNote
            // 
            this.btnNewNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewNote.Image = ((System.Drawing.Image)(resources.GetObject("btnNewNote.Image")));
            this.btnNewNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(23, 22);
            this.btnNewNote.Text = "New Note";
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save Note";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "Open Note";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFontFormat
            // 
            this.btnFontFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFontFormat.Image = ((System.Drawing.Image)(resources.GetObject("btnFontFormat.Image")));
            this.btnFontFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFontFormat.Name = "btnFontFormat";
            this.btnFontFormat.Size = new System.Drawing.Size(23, 22);
            this.btnFontFormat.Text = "Font";
            this.btnFontFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFontFormat.Click += new System.EventHandler(this.btnFontFormat_Click);
            // 
            // btnColorFormat
            // 
            this.btnColorFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColorFormat.Image = ((System.Drawing.Image)(resources.GetObject("btnColorFormat.Image")));
            this.btnColorFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColorFormat.Name = "btnColorFormat";
            this.btnColorFormat.Size = new System.Drawing.Size(23, 22);
            this.btnColorFormat.Text = "Color";
            this.btnColorFormat.Click += new System.EventHandler(this.btnColorFormat_Click);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalics
            // 
            this.btnItalics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalics.Image = ((System.Drawing.Image)(resources.GetObject("btnItalics.Image")));
            this.btnItalics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalics.Name = "btnItalics";
            this.btnItalics.Size = new System.Drawing.Size(23, 22);
            this.btnItalics.Text = "Italic";
            this.btnItalics.Click += new System.EventHandler(this.btnItalics_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnStrikeout
            // 
            this.btnStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStrikeout.Image = ((System.Drawing.Image)(resources.GetObject("btnStrikeout.Image")));
            this.btnStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStrikeout.Name = "btnStrikeout";
            this.btnStrikeout.Size = new System.Drawing.Size(23, 22);
            this.btnStrikeout.Text = "Strikeout";
            this.btnStrikeout.Click += new System.EventHandler(this.btnStrikeout_Click);
            // 
            // btnCut
            // 
            this.btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCut.Image = ((System.Drawing.Image)(resources.GetObject("btnCut.Image")));
            this.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(23, 22);
            this.btnCut.Text = "Cut";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(23, 22);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(23, 22);
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTag
            // 
            this.btnTag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTag.Image = ((System.Drawing.Image)(resources.GetObject("btnTag.Image")));
            this.btnTag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(23, 22);
            this.btnTag.Text = "Add Tag";
            this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
            // 
            // btnImage
            // 
            this.btnImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(23, 22);
            this.btnImage.Text = "Insert Image";
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Rich Text Format|*.rtf";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Rich Text Format|*.rtf";
            // 
            // openImage
            // 
            this.openImage.FileName = "openImage";
            this.openImage.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            // 
            // NotesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtbNote);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "NotesPage";
            this.Size = new System.Drawing.Size(800, 600);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox rtbNote;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNewNote;
        private ToolStripButton btnSave;
        private ToolStripButton btnOpen;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCut;
        private ToolStripButton btnCopy;
        private ToolStripButton btnPaste;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnTag;
        private ToolStripButton btnImage;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripButton btnFontFormat;
        private ToolStripButton btnColorFormat;
        private ToolStripButton btnBold;
        private ToolStripButton btnItalics;
        private ToolStripButton btnUnderline;
        private ToolStripButton btnStrikeout;
        private OpenFileDialog openImage;
        private ToolStripButton btnPrint;
        private PrintDialog printDialog;
    }
}
