using NLog;
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

namespace WrpMp3Interface
{
    public partial class Form1 : Form
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "please select mp3wrap.exe (mp3wrap.exe)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtmp3wrap.Text = openFileDialog.FileName;


                }
            }
        }

        private async void btninput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtinput.Text = fbd.SelectedPath;

                }
            }
        }

        private async void btnoutput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtoutput.Text = fbd.SelectedPath;

                }
            }
        }

        private async void btnNumber_Click(object sender, EventArgs e)
        {
            txtlog.Clear();
            AddendLog("Start 3: Numbering");
            await Task.Run(() =>
            {
                string[] dirs = Directory.GetDirectories(txtoutput.Text, "*", SearchOption.TopDirectoryOnly);
                Console.WriteLine("The number of directories is {0}.", dirs.Length);
                var currentNumber = int.Parse(txtnostart.Text);
                foreach (string dir in dirs.OrderBy(d => d))
                {
                    logger.Info($"Number Directory: {dir}");
                    Directory.Move(dir, $"{txtoutput.Text}\\{currentNumber.ToString("00")}");
                    currentNumber++;
                }
            });
            AddendLog("End 3: Numbering");
        }

        private async void btnAlbum_Click(object sender, EventArgs e)
        {
            txtlog.Clear();
            AddendLog("Start 2: Album");
            await Task.Run(() =>
            {
                foreach (string dir in SearchForMp3Directory(txtinput.Text).OrderBy(d => d))
                {
                    var directoryname = dir.Split('\\').Last();
                    var outputdirectorygenerated = $"{txtoutput.Text}\\{directoryname}";
                    DirectoryCopy(dir, outputdirectorygenerated, false);
                    var currentNumber = 1;
                    foreach (var file in Directory.GetFiles(outputdirectorygenerated, "*.mp3").OrderBy(x => x))
                    {
                        logger.Info($"Move file: {file}");
                        logger.Info($"to file: {outputdirectorygenerated}/{currentNumber.ToString("000")}.mp3");
                        File.Move(file, $"{outputdirectorygenerated}/{currentNumber.ToString("000")}.mp3");
                        currentNumber++;
                    }
                }
            });
            AddendLog("End 2: Album");
        }


        private IEnumerable<string> SearchForMp3Directory(string dir)
        {
            bool mp3found = false;
            foreach (string f in Directory.GetFiles(dir))
            {
                if (f.EndsWith(".mp3"))
                {
                    yield return dir;
                    mp3found = true;
                    break;
                }
            }
            if (!mp3found)
            {
                foreach (string d in Directory.GetDirectories(dir))
                {
                    foreach (var result in SearchForMp3Directory(d))
                    {
                        yield return result;
                    }
                }
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private async void btnHoer_Click(object sender, EventArgs e)
        {
            txtlog.Clear();
            AddendLog("Start 1: Hörbuch");
            await Task.Run(() =>
            {
                foreach (string dir in SearchForMp3Directory(txtinput.Text).OrderBy(d => d))
                {
                    var directoryname = dir.Split('\\').Last();
                    var outputdirectorygenerated = $"{txtoutput.Text}\\{directoryname}";
                    DirectoryCopy(dir, outputdirectorygenerated, false);
                    var mp3files = Directory.GetFiles(outputdirectorygenerated, "*.mp3").OrderBy(x => x).ToList();
                    var mp3FilesQuoted = new List<string>();
                    foreach (var file in mp3files)
                    {
                        mp3FilesQuoted.Add("\"" + file + "\"");
                    }

                    var cmd = txtmp3wrap.Text + $"{outputdirectorygenerated}\\001.mp3 {string.Join(" ", mp3FilesQuoted.OrderBy(x => x))}";
                    logger.Info($"Run mp3wrap: {cmd}");
                    var proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = txtmp3wrap.Text,
                            Arguments = $"\"{outputdirectorygenerated}\\001.mp3\" {string.Join(" ", mp3FilesQuoted)}",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        }
                    };

                    proc.Start();
                    while (!proc.StandardOutput.EndOfStream)
                    {
                        string line = proc.StandardOutput.ReadLine();
                        logger.Info($"{line}");
                    }

                    foreach (var file in mp3files)
                    {
                        File.Delete(file);
                    }
                    if (File.Exists($"{outputdirectorygenerated}\\001_MP3WRAP.MP3"))
                    {
                        File.Move($"{outputdirectorygenerated}\\001_MP3WRAP.MP3", $"{outputdirectorygenerated}\\001.MP3");
                    }
                }
            });
            AddendLog("End 1: Hörbuch");
        }

        private void AddendLog(string s)
        {
            txtlog.Text = txtlog.Text + Environment.NewLine + s;
        }

        private void AddendTrace(string s)
        {

        }
    }
}
