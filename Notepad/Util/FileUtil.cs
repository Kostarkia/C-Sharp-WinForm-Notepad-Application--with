using Notepad.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad.Util
{
    public class FileUtil
    {
        public static string _oldText = "";

        public static bool _isModified;

        public static void Open(OpenFileDialog openFileDialog, RichTextBox note)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                note.Text = File.ReadAllText(openFileDialog.FileName);

                _oldText = File.ReadAllText(openFileDialog.FileName);

                _isModified = false;
            }
        }

        public static void Save(OpenFileDialog openFileDialog, RichTextBox note, NotepadScreen notepadScreen)
        {
            if (notepadScreen.Text == Resources.Undefined || notepadScreen.Text == Resources.Undefined + '*')
            {
                SaveAs(note, notepadScreen);

                _oldText = note.Text;

                _isModified = false;
            }
            else
            {
                File.WriteAllText(openFileDialog.FileName, note.Text);

                _oldText = note.Text;

                _isModified = false;
            }
        }

        public static void SaveAs(RichTextBox note, NotepadScreen notepadScreen)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveFileDialog.FileName.ToString());

                notepadScreen.Text = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);

                file.WriteLine(note.Text);
            }
        }
    }
}
