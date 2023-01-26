
namespace Notepad
{
    partial class NotepadScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadScreen));
            this.menuStripNotepad = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxNotepad = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStripNotepad.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripNotepad
            // 
            this.menuStripNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.ToolStripMenuItemFormat});
            this.menuStripNotepad.Location = new System.Drawing.Point(0, 0);
            this.menuStripNotepad.Name = "menuStripNotepad";
            this.menuStripNotepad.Size = new System.Drawing.Size(596, 24);
            this.menuStripNotepad.TabIndex = 1;
            this.menuStripNotepad.Text = "menuStripNotepad";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNew,
            this.ToolStripMenuItemOpen,
            this.ToolStripMenuItemSave,
            this.ToolStripMenuItemSaveAs,
            this.ToolStripMenuItemPrint,
            this.ToolStripMenuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ToolStripMenuItemNew
            // 
            this.ToolStripMenuItemNew.Name = "ToolStripMenuItemNew";
            this.ToolStripMenuItemNew.Size = new System.Drawing.Size(114, 22);
            this.ToolStripMenuItemNew.Text = "New";
            this.ToolStripMenuItemNew.Click += new System.EventHandler(this.ToolStripMenuItemNew_Click);
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(114, 22);
            this.ToolStripMenuItemOpen.Text = "Open";
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // ToolStripMenuItemSave
            // 
            this.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(114, 22);
            this.ToolStripMenuItemSave.Text = "Save";
            this.ToolStripMenuItemSave.Click += new System.EventHandler(this.ToolStripMenuItemSave_Click);
            // 
            // ToolStripMenuItemSaveAs
            // 
            this.ToolStripMenuItemSaveAs.Name = "ToolStripMenuItemSaveAs";
            this.ToolStripMenuItemSaveAs.Size = new System.Drawing.Size(114, 22);
            this.ToolStripMenuItemSaveAs.Text = "Save As";
            this.ToolStripMenuItemSaveAs.Click += new System.EventHandler(this.ToolStripMenuItemSaveAs_Click);
            // 
            // ToolStripMenuItemPrint
            // 
            this.ToolStripMenuItemPrint.Name = "ToolStripMenuItemPrint";
            this.ToolStripMenuItemPrint.Size = new System.Drawing.Size(114, 22);
            this.ToolStripMenuItemPrint.Text = "Print";
            this.ToolStripMenuItemPrint.Click += new System.EventHandler(this.ToolStripMenuItemPrint_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(114, 22);
            this.ToolStripMenuItemExit.Text = "Exit";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUndo,
            this.ToolStripMenuItemRedo,
            this.ToolStripMenuItemCut,
            this.ToolStripMenuItemCopy,
            this.ToolStripMenuItemPaste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // ToolStripMenuItemUndo
            // 
            this.ToolStripMenuItemUndo.Name = "ToolStripMenuItemUndo";
            this.ToolStripMenuItemUndo.Size = new System.Drawing.Size(103, 22);
            this.ToolStripMenuItemUndo.Text = "Undo";
            this.ToolStripMenuItemUndo.Click += new System.EventHandler(this.ToolStripMenuItemUndo_Click);
            // 
            // ToolStripMenuItemRedo
            // 
            this.ToolStripMenuItemRedo.Name = "ToolStripMenuItemRedo";
            this.ToolStripMenuItemRedo.Size = new System.Drawing.Size(103, 22);
            this.ToolStripMenuItemRedo.Text = "Redo";
            this.ToolStripMenuItemRedo.Click += new System.EventHandler(this.ToolStripMenuItemRedo_Click);
            // 
            // ToolStripMenuItemCut
            // 
            this.ToolStripMenuItemCut.Name = "ToolStripMenuItemCut";
            this.ToolStripMenuItemCut.Size = new System.Drawing.Size(103, 22);
            this.ToolStripMenuItemCut.Text = "Cut";
            this.ToolStripMenuItemCut.Click += new System.EventHandler(this.ToolStripMenuItemCut_Click);
            // 
            // ToolStripMenuItemCopy
            // 
            this.ToolStripMenuItemCopy.Name = "ToolStripMenuItemCopy";
            this.ToolStripMenuItemCopy.Size = new System.Drawing.Size(103, 22);
            this.ToolStripMenuItemCopy.Text = "Copy";
            this.ToolStripMenuItemCopy.Click += new System.EventHandler(this.ToolStripMenuItemCopy_Click);
            // 
            // ToolStripMenuItemPaste
            // 
            this.ToolStripMenuItemPaste.Name = "ToolStripMenuItemPaste";
            this.ToolStripMenuItemPaste.Size = new System.Drawing.Size(103, 22);
            this.ToolStripMenuItemPaste.Text = "Paste";
            this.ToolStripMenuItemPaste.Click += new System.EventHandler(this.ToolStripMenuItemPaste_Click);
            // 
            // ToolStripMenuItemFormat
            // 
            this.ToolStripMenuItemFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.ToolStripMenuItemColor});
            this.ToolStripMenuItemFormat.Name = "ToolStripMenuItemFormat";
            this.ToolStripMenuItemFormat.Size = new System.Drawing.Size(57, 20);
            this.ToolStripMenuItemFormat.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemFont_Click);
            // 
            // ToolStripMenuItemColor
            // 
            this.ToolStripMenuItemColor.Name = "ToolStripMenuItemColor";
            this.ToolStripMenuItemColor.Size = new System.Drawing.Size(103, 22);
            this.ToolStripMenuItemColor.Text = "Color";
            this.ToolStripMenuItemColor.Click += new System.EventHandler(this.ToolStripMenuItemColor_Click);
            // 
            // richTextBoxNotepad
            // 
            this.richTextBoxNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxNotepad.Location = new System.Drawing.Point(0, 24);
            this.richTextBoxNotepad.Name = "richTextBoxNotepad";
            this.richTextBoxNotepad.Size = new System.Drawing.Size(596, 465);
            this.richTextBoxNotepad.TabIndex = 2;
            this.richTextBoxNotepad.Text = "";
            this.richTextBoxNotepad.TextChanged += new System.EventHandler(this.RichTextBoxNotepad_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // NotepadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 489);
            this.Controls.Add(this.richTextBoxNotepad);
            this.Controls.Add(this.menuStripNotepad);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripNotepad;
            this.Name = "NotepadScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Untitled";
            this.Load += new System.EventHandler(this.NotepadScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotepadScreen_KeyDown);
            this.menuStripNotepad.ResumeLayout(false);
            this.menuStripNotepad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripNotepad;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPrint;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRedo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFormat;
        private System.Windows.Forms.RichTextBox richTextBoxNotepad;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemColor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}

