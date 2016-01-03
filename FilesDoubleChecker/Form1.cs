using FilesDoubleChecker.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesDoubleChecker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();


            if (result == DialogResult.OK)
            {
                Folder1Txt.Text = fbd.SelectedPath;
            }

        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            ScanFolder();
        }

        private void ScanFolder()
        {
            string Path1 = Folder1Txt.Text;
            string Path2 = Folder2Txt.Text;

            FilesStore.ListOfFiles = new List<FileObj>();

            FolderFilesChecker Dir = new FolderFilesChecker();
            Dir.scanFolder(Path1);
        }

        private void Folder2Btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                Folder2Txt.Text = fbd.SelectedPath;
            }
        }

        private void SaveCSVBtn_Click(object sender, EventArgs e)
        {
            string filePath = Folder1Txt.Text + @"\Content.csv";
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(FilesStore.ListOfFiles[0].toStringHeader());
            foreach (var item in FilesStore.ListOfFiles)
            {
                sb.AppendLine(item.toString());
            }
            File.AppendAllText(filePath, sb.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScanFolder();

            string filePath = Folder1Txt.Text + @"\ExactMatch.csv";
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(FilesStore.ListOfFiles[0].toStringHeader());

           //, x.size

            var countted = FilesStore.ListOfFiles.GroupBy(x => new { x.FileName }).Select(g => new { g.FirstOrDefault().FileName, Count = g.Count() }).Where(x => x.Count > 1);
            foreach (var dupItem in countted)
            {
                foreach (var item in FilesStore.ListOfFiles.Where(x => x.FileName == dupItem.FileName))
                {
                    sb.AppendLine(item.toString());
                }
            }

            File.AppendAllText(filePath, sb.ToString());
        }

        private void MoveToDelBtn_Click(object sender, EventArgs e)
        {
            MoveFile(DeleteFolderTxt.Text, FileToMoveTxt.Text);
        }

        private void MoveFile(string delFolder, string fileToMove)
        {

            try
            {
                var from = System.IO.Path.Combine(fileToMove);
                var to = System.IO.Path.Combine(delFolder, System.IO.Path.GetFileName(fileToMove));

                File.Move(from, to); // Try to move
                FileToMoveTxt.Text = "";
            }
            catch (IOException ex)
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteFile(FileToMoveTxt.Text);
        }

        private void DeleteFile( string fileToMove)
        {

            try
            {
                File.Delete(fileToMove);
                FileToMoveTxt.Text = "";
            }
            catch (IOException ex)
            {

            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            Process.Start("wmplayer.exe", System.IO.Path.GetFullPath(FileToMoveTxt.Text));
        }

        private void ClearDeleteBtn_Click(object sender, EventArgs e)
        {

        }


    }
}
