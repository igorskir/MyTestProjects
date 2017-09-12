using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace FileRenamer
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            List<string> fileNames = new List<string>();
            string folderName = String.Empty;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                foreach (var path in Directory.GetFiles(fbd.SelectedPath))
                {
                    fileNames.Add(path);
                    // file name
                }
                folderName = fbd.SelectedPath;
            }

            FileRename(fileNames, folderName);

            Console.ReadLine();
        }


        static void FileRename(List<string> fn, string folderName)
        {

            foreach (var file in fn)
            {
                var smallName = System.IO.Path.GetFileName(file);
                if (smallName.Length < 7)
                {
                    smallName = "0" + smallName;
                }

                string newFileName = folderName + '\\' + smallName;
                Console.WriteLine("Old name: {0} New file name: {1}", file, newFileName);

                System.IO.File.Move(file, newFileName);
            }
        }

        //public static void ProcessDirectory(string targetDirectory)
        //{
        //    // Process the list of files found in the directory.
        //    string[] fileEntries = Directory.GetFiles(targetDirectory);
        //    foreach (string fileName in fileEntries)
        //        ProcessFile(fileName);
        //}

        //private static void ProcessFile(string fileName)
        //{
        //    Console.WriteLine("Processed file '{0}'.", fileName);
        //}
    }
}

