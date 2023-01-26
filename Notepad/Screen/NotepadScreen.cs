using Notepad.Properties;
using Notepad.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class NotepadScreen : Form
    {
        public NotepadScreen()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(this.NotepadScreen_KeyDown);
        }

        private void NotepadScreen_Load(object sender, EventArgs e)
        {
            this.Text = Resources.Undefined;
        }

        #region File
        private void ToolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            if (FileUtil._oldText != richTextBoxNotepad.Text)
            {
                var result =
                MessageBox.Show
                    (
                    string.Format(Resources.MessageBox_SaveChanges_Description, this.Text),
                    Resources.Notepad,
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information
                    );

                if (result == DialogResult.Cancel)
                    return;

                if (result == DialogResult.Yes)
                {
                    FileUtil.Save(openFileDialog, richTextBoxNotepad, this);
                }
                else
                {
                    this.Text = Resources.Undefined;

                    richTextBoxNotepad.Clear();
                }
            }
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            FileUtil.Open(openFileDialog, richTextBoxNotepad);



            this.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            FileUtil.Save(openFileDialog, richTextBoxNotepad, this);

            this.Text = this.Text.TrimEnd('*');
        }

        private void ToolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            FileUtil.SaveAs(richTextBoxNotepad, this);
        }

        private void ToolStripMenuItemPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString
               (
               richTextBoxNotepad.Text,
               new Font("Times New Roman", 14, FontStyle.Regular),
               Brushes.Black,
               new PointF(100, 100)
               );
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            if (FileUtil._oldText != richTextBoxNotepad.Text)
            {
                var result =
                  MessageBox.Show
                      (
                      string.Format(Resources.MessageBox_SaveChanges_Description, this.Text),
                      Resources.Notepad,
                      MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information
                      );

                if (result == DialogResult.Yes)
                {
                    FileUtil.Save(openFileDialog, richTextBoxNotepad, this);

                    Close();
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        #endregion

        #region Edit

        private void ToolStripMenuItemUndo_Click(object sender, EventArgs e)
        {
            richTextBoxNotepad.Undo();
        }

        private void ToolStripMenuItemRedo_Click(object sender, EventArgs e)
        {
            richTextBoxNotepad.Redo();
        }

        private void ToolStripMenuItemCut_Click(object sender, EventArgs e)
        {
            richTextBoxNotepad.Cut();
        }

        private void ToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            richTextBoxNotepad.Copy();
        }

        private void ToolStripMenuItemPaste_Click(object sender, EventArgs e)
        {
            richTextBoxNotepad.Paste();
        }

        #endregion

        #region Format

        private void ToolStripMenuItemFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxNotepad.Font = fontDialog.Font;
            }
        }

        private void ToolStripMenuItemColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxNotepad.ForeColor = colorDialog.Color;
            }
        }

        #endregion


        private void RichTextBoxNotepad_TextChanged(object sender, EventArgs e)
        {

            if (!FileUtil._isModified && richTextBoxNotepad.Text != FileUtil._oldText)
            {
                this.Text = this.Text + "*";

                FileUtil._isModified = true;
            }
            else if (richTextBoxNotepad.Text == FileUtil._oldText)
            {
                this.Text = this.Text.TrimEnd('*');

                FileUtil._isModified = false;
            }
        }

        private void NotepadScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                ToolStripMenuItemNew_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.O)
            {
                ToolStripMenuItemOpen_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                ToolStripMenuItemSave_Click(sender, e);
            }

            if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                ToolStripMenuItemSaveAs_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.P)
            {
                ToolStripMenuItemPrint_Click(sender, e);
            }

            if (e.Alt && e.KeyCode == Keys.F4)
            {
                ToolStripMenuItemExit_Click(sender, e);
            }
        }
    }
}
