using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeNotev3.UserControls
{
    public partial class NotesPage : UserControl
    {
        public NotesPage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                rtbNote.SaveFile(saveFileDialog.FileName);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                rtbNote.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            rtbNote.Clear();
            rtbNote.Focus();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            rtbNote.Cut();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            rtbNote.Copy();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            rtbNote.Paste();
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
  
            string tag = Microsoft.VisualBasic.Interaction.InputBox("Enter the tag to add:", "Add Tag");

 
            if (!string.IsNullOrEmpty(tag))
            {
                rtbNote.SelectionFont = new Font(rtbNote.Font, FontStyle.Bold);
                rtbNote.SelectionColor = Color.Blue;
                rtbNote.SelectedText = $" [{tag}]";
                rtbNote.SelectionColor = rtbNote.ForeColor;
                rtbNote.SelectionFont = rtbNote.Font;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openImage.FileName = "";
            DialogResult result= openImage.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image img = Image.FromFile(openImage.FileName);
                Clipboard.SetImage(img);
                rtbNote.Paste();
                rtbNote.Focus();
            }
            else
            {
                rtbNote.Focus();
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {

        }

        private void btnFontFormat_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.ShowColor = true;

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                rtbNote.SelectionFont = dialog.Font;
                rtbNote.SelectionColor = dialog.Color;
            }
        }

        private void btnColorFormat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                rtbNote.SelectionColor = dialog.Color;
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            rtbNote.SelectionFont = new Font(rtbNote.Font,
                rtbNote.SelectionFont.Style ^ FontStyle.Bold);

            if (rtbNote.SelectionFont == null)
            {
                btnBold.CheckState = CheckState.Indeterminate;
                btnItalics.CheckState = CheckState.Indeterminate;
                btnUnderline.CheckState = CheckState.Indeterminate;
                btnStrikeout.CheckState = CheckState.Indeterminate;
                return;
            }
            btnBold.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Bold) == FontStyle.Bold;
            btnItalics.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Italic) == FontStyle.Italic;
            btnUnderline.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Underline) == FontStyle.Underline;
            btnStrikeout.Checked =
                (rtbNote.SelectionFont.Style & FontStyle.Underline) == FontStyle.Strikeout;
        }

        private void btnItalics_Click(object sender, EventArgs e)
        {
            rtbNote.SelectionFont = new Font(rtbNote.Font,
                rtbNote.SelectionFont.Style ^ FontStyle.Italic);

            if (rtbNote.SelectionFont == null)
            {
                btnBold.CheckState = CheckState.Indeterminate;
                btnItalics.CheckState = CheckState.Indeterminate;
                btnUnderline.CheckState = CheckState.Indeterminate;
                btnStrikeout.CheckState = CheckState.Indeterminate;
                return;
            }
            btnBold.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Bold) == FontStyle.Bold;
            btnItalics.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Italic) == FontStyle.Italic;
            btnUnderline.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Underline) == FontStyle.Underline;
            btnStrikeout.Checked =
                (rtbNote.SelectionFont.Style & FontStyle.Underline) == FontStyle.Strikeout;
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            rtbNote.SelectionFont = new Font(rtbNote.Font,
                rtbNote.SelectionFont.Style ^ FontStyle.Underline);

            if (rtbNote.SelectionFont == null)
            {
                btnBold.CheckState = CheckState.Indeterminate;
                btnItalics.CheckState = CheckState.Indeterminate;
                btnUnderline.CheckState = CheckState.Indeterminate;
                btnStrikeout.CheckState = CheckState.Indeterminate;
                return;
            }
            btnBold.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Bold) == FontStyle.Bold;
            btnItalics.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Italic) == FontStyle.Italic;
            btnUnderline.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Underline) == FontStyle.Underline;
            btnStrikeout.Checked =
                (rtbNote.SelectionFont.Style & FontStyle.Underline) == FontStyle.Strikeout;
        }

        private void btnStrikeout_Click(object sender, EventArgs e)
        {
            rtbNote.SelectionFont = new Font(rtbNote.Font,
                rtbNote.SelectionFont.Style ^ FontStyle.Strikeout);

            if (rtbNote.SelectionFont == null)
            {
                btnBold.CheckState = CheckState.Indeterminate;
                btnItalics.CheckState = CheckState.Indeterminate;
                btnUnderline.CheckState = CheckState.Indeterminate;
                btnStrikeout.CheckState = CheckState.Indeterminate;
                return;
            }
            btnBold.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Bold) == FontStyle.Bold;
            btnItalics.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Italic) == FontStyle.Italic;
            btnUnderline.Checked =
               (rtbNote.SelectionFont.Style & FontStyle.Underline) == FontStyle.Underline;
            btnStrikeout.Checked =
                (rtbNote.SelectionFont.Style & FontStyle.Underline) == FontStyle.Strikeout;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

    }
}

