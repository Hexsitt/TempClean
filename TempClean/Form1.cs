using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Principal;
using System.Threading;
using System.Linq.Expressions;
using System.Timers;

namespace TempClean
{
    public partial class Form1 : Form
    {
        //Check if 3rd party directories exist.
        private string GetExpandedFolderPath(string folderPath)
        {
            return Environment.ExpandEnvironmentVariables(folderPath);
        }
        //Main folders to be cleaned
        private string[] MainFolders = {
            @"C:\Windows\Temp",
            Path.GetTempPath(),
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Windows\Webcache"),
            @"C:\Windows\Prefetch",
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Windows\INetCache"),
        };
        //Folders to be cleaned with Deep clean
        private string[] DeepClean = {
            @"C:\ProgramData\Microsoft\Windows Defender\Scans\TemporaryScans",
            @"C:\ProgramData\Package Cache",
            @"C:\Windows\Logs",
            @"C:\Windows\SoftwareDistribution\Download",
            @"C:\Windows\Installer"
        };
        //Folders to be cleaned with 3rd party clean
        private string[] thirdparty = {
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Office"),
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Adobe\Acrobat\DC\Temp"),
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Google\Chrome\User Data\Default\Cache"),
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Edge\User Data\Default\Cache"),
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\LocalLow\Sun\Java\Deployment\cache")
        };
        //Files/Folders to be cleaned with memory dumps clean
        private string[] memorydump = {
            @"C:\Windows\MEMORY.DMP",
            @"C:\Windows\minidump"
        };
        //Manual clean
        private string[] WinTemp = {
            @"C:\Windows\Temp"
        };

        private string[] LocalTemp = {
            Path.GetTempPath()
        };

        private string[] Webcache = {
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Windows\Webcache")
        };

        private string[] Prefetch = {
            @"C:\Windows\Prefetch"
        };

        private string[] INetCache = {
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Windows\INetCache"),
        };

        private string[] WinDefender = {
            @"C:\ProgramData\Microsoft\Windows Defender\Scans\TemporaryScans"
        };

        private string[] PackageCache = {
            @"C:\ProgramData\Package Cache"
        };

        private string[] WinLogs = {
            @"C:\Windows\Logs"
        };

        private string[] WinUpdates = {
            @"C:\Windows\SoftwareDistribution\Download"
        };

        private string[] WinInstallers = {
            @"C:\Windows\Installer"
        };

        //3rd party manual clean
        private string[] Office = {
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Office")
        };

        private string[] Adobe = {
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Adobe\Acrobat\DC\Temp")
        };

        private string[] Chrome = {
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Google\Chrome\User Data\Default\Cache")
        };

        private string[] Edge = {
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Edge\User Data\Default\Cache"),
        };

        private string[] Java = {
            Environment.ExpandEnvironmentVariables(@"%appdata%\..\LocalLow\Sun\Java\Deployment\cache")
        };

        //Memory dumps manual clean
        private string[] minidump = {
            @"C:\Windows\minidump"
        };

        private string[] MEMORYDMP = {
            @"C:\Windows\MEMORY.DMP"
        };
        private long totalSize;
        private long defaultFolderSize;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1; // 1
            timer1.Tick += Timer_Tick;
            timer1.Start();
            UpdateTotalSize();
            CalculateDefaultFolderSize();

            //Tool Tips, messages that appear when you hold the pointer above something
            string toolTipTerceirosText = "3rd party clean removes program folders that were separately installed\nby the user.";
            string toolTipMemDmpText = "Memory dump cleaning clears the memory dump files that Windows creates\nafter a critical Blue Screen of Death (BSoD) error. These files can be used on\nMicrosoft support to diagnose the cause of the error. If you already know the\ncause of the error, you can clean up these files.\n\nIf you don't have any memory dumps, this box won't be checkable.";
            toolTip3rdparty.SetToolTip(lblAbt3rd, toolTipTerceirosText);
            toolTipMemDmp.SetToolTip(lblAbtMemDmp, toolTipMemDmpText);

            toolTipWinTemp.SetToolTip(chkWinTemp, "C:\\Windows\\Temp");
            toolTipLocalTemp.SetToolTip(chkLocalTemp, "C:\\Users\\%user%\\AppData\\Local\\Temp");
            toolTipWebcache.SetToolTip(chkWebcache, "C:\\Users\\%user%\\AppData\\Local\\Microsoft\\Windows\\Webcache");
            toolTipPrefetch.SetToolTip(chkPrefetch, "C:\\Windows\\Prefetch");
            toolTipINetCache.SetToolTip(chkINetCache, "C:\\Users\\%user%\\AppData\\Local\\Microsoft\\Windows\\INetCache");

            toolTipDefender.SetToolTip(chkWinDefender, "C:\\ProgramData\\Microsoft\\Windows Defender\\TemporaryScans");
            toolTipPackageCache.SetToolTip(chkPackageCache, "C:\\ProgramData\\Package Cache");
            toolTipLogs.SetToolTip(chkWinLogs, "C:\\Windows\\Logs");
            toolTipUpdates.SetToolTip(chkWinUpdates, "C:\\Windows\\SoftwareDistribution\\Download");
            toolTipInstaller.SetToolTip(chkWinInstaller, "C:\\Windows\\Installer");

            toolTipOffice.SetToolTip(chkOffice, "C:\\Users\\%user%\\AppData\\Local\\Microsoft\\Office");
            toolTipAcrobat.SetToolTip(chkAcrobat, "C:\\Users\\%user%\\AppData\\Local\\Adobe\\Acrobat\\DC\\Temp");
            toolTipChrome.SetToolTip(chkChrome, "C:\\Users\\%user%\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache");
            toolTipEdge.SetToolTip(chkEdge, "C:\\Users\\%user%\\AppData\\Local\\Microsoft\\Edge\\User Data\\Default\\Cache");
            toolTipJava.SetToolTip(chkJava, "C:\\Users\\%user%\\AppData\\LocalLow\\Sun\\Java\\Deployment\\cache");

            toolTipMEMORYDMP.SetToolTip(chkMemDMP, "C:\\Windows\\MEMORY.DMP");
            toolTipminidump.SetToolTip(chkminidump, "C:\\Windows\\minidump");
        }
        //Check if 3rd party directories exist
        private void CheckDirectoryExistsAndDisableCheckbox(CheckBox checkBox, string path)
        {
            bool pathExists = Directory.Exists(path) || File.Exists(path);
            checkBox.Enabled = pathExists;
            checkBox.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckDirectoryExistsAndDisableCheckbox(chkOffice, GetExpandedFolderPath(@"%appdata%\..\Local\Microsoft\Office"));
            CheckDirectoryExistsAndDisableCheckbox(chkAcrobat, GetExpandedFolderPath(@"%appdata%\..\Local\Adobe\Acrobat\DC\Temp"));
            CheckDirectoryExistsAndDisableCheckbox(chkChrome, GetExpandedFolderPath(@"%appdata%\..\Local\Google\Chrome\User Data\Default\Cache"));
            CheckDirectoryExistsAndDisableCheckbox(chkEdge, GetExpandedFolderPath(@"%appdata%\..\Local\Microsoft\Edge\User Data\Default\Cache"));
            CheckDirectoryExistsAndDisableCheckbox(chkJava, GetExpandedFolderPath(@"%appdata%\..\LocalLow\Sun\Java\Deployment\cache"));
            CheckDirectoryExistsAndDisableCheckbox(chkMemDMP, (@"C:\Windows\MEMORY.DMP"));
            CheckDirectoryExistsAndDisableCheckbox(chkminidump, (@"C:\Windows\minidump"));

            string memoryDumpPath = @"C:\Windows\MEMORY.DMP";
            string minidumpPath = @"C:\Windows\minidump";

            if (!File.Exists(memoryDumpPath) && !Directory.Exists(minidumpPath))
            {
                chkMemDmpCln.Enabled = false;
            }

            CheckDirectoryExistsAndDisableCheckbox(chkMemDMP, memoryDumpPath);
            CheckDirectoryExistsAndDisableCheckbox(chkminidump, minidumpPath);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTotalSize();
            CalculateDefaultFolderSize();
        }

        //Code that calculates the folder size
        private void CalculateDefaultFolderSize()
        {
            defaultFolderSize = GetFolderSize(@"C:\Windows\Temp");
            defaultFolderSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Temp"));
            defaultFolderSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Windows\Webcache"));
            defaultFolderSize += GetFolderSize(@"C:\Windows\Prefetch");
            defaultFolderSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Windows\INetCache"));
        }
        private void UpdateTotalSize()
        {
            if (pnlMnlCln.Visible)
            {
                totalSize = 0;

                if (chkWinTemp.Checked)
                    totalSize += GetFolderSize(@"C:\Windows\Temp");

                if (chkLocalTemp.Checked)
                    totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Temp"));

                if (chkWebcache.Checked)
                    totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Windows\Webcache"));

                if (chkPrefetch.Checked)
                    totalSize += GetFolderSize(@"C:\Windows\Prefetch");

                if (chkINetCache.Checked)
                    totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Windows\INetCache"));

                if (chkWinDefender.Checked)
                    totalSize += GetFolderSize(@"C:\ProgramData\Microsoft\Windows Defender\TemporaryScans");

                if (chkPackageCache.Checked)
                    totalSize += GetFolderSize(@"C:\ProgramData\PackageCache");

                if (chkWinLogs.Checked)
                    totalSize += GetFolderSize(@"C:\Windows\Logs");

                if (chkWinUpdates.Checked)
                    totalSize += GetFolderSize(@"C:\Windows\SoftwareDistribution\Download");

                if (chkWinInstaller.Checked)
                    totalSize += GetFolderSize(@"C:\Windows\Installer");

                if (chkOffice.Checked)
                    totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Office"));

                if (chkAcrobat.Checked)
                    totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Adobe\Acrobat\DC\Temp"));

                if (chkChrome.Checked)
                    totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Google\Chrome\User Data\Default\Cache"));

                if (chkEdge.Checked)
                    totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Edge\User Data\Default\Cache"));

                if (chkJava.Checked)
                    totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\LocalLow\Sun\Java\Deployment\cache"));

                if (chkminidump.Checked)
                    totalSize += GetFolderSize(@"C:\Windows\minidump");

                if (chkMemDMP.Checked)
                    totalSize += GetFileSize(@"C:\Windows\MEMORY.DMP");

                lblFreSpc.Text = "Selected: " + FormatSize(totalSize);
            }
            else
            totalSize = defaultFolderSize;

            if (chkDpCln.Checked)
            {
                totalSize += GetFolderSize(@"C:\ProgramData\Microsoft\Windows Defender\TemporaryScans");
                totalSize += GetFolderSize(@"C:\ProgramData\PackageCache");
                totalSize += GetFolderSize(@"C:\Windows\Logs");
                totalSize += GetFolderSize(@"C:\Windows\SoftwareDistribution\Download");
                totalSize += GetFolderSize(@"C:\Windows\Installer");
            }

            if (chk3rdCln.Checked)
            {
                totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Office"));
                totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Adobe\Acrobat\DC\Temp"));
                totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Google\Chrome\User Data\Default\Cache"));
                totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\Local\Microsoft\Edge\User Data\Default\Cache"));
                totalSize += GetFolderSize(Environment.ExpandEnvironmentVariables(@"%appdata%\..\LocalLow\Sun\Java\Deployment\cache"));
            }

            if (chkMemDmpCln.Checked)
            {
                totalSize += GetFolderSize(@"C:\Windows\minidump");
                totalSize += GetFileSize(@"C:\Windows\MEMORY.DMP");
            }
            lblFreSpc.Text = "Selected: " + FormatSize(totalSize);
        }
        private long GetFolderSize(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                return 0;

            long size = 0;

            try
            {
                foreach (string file in Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories))
                {
                    try
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        size += fileInfo.Length;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // Ignore Unauthorized Access Exception for folder TempClean can't access
                    }
                    catch (FileNotFoundException)
                    {
                        // Ignore file not found
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Ignore Unauthorized Access Exception for folder TempClean can't access
            }
            catch (FileNotFoundException)
            {
                // Ignore file not found
            }

            return size;
        }

        private long GetFileSize(string filePath)
        {
            if (!File.Exists(filePath))
                return 0;

            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length;
        }

        private string FormatSize(long sizeInBytes)
        {
            string[] sizeSuffixes = { "B", "KB", "MB", "GB", "TB" };
            int index = 0;
            double size = sizeInBytes;

            while (size >= 1024 && index < sizeSuffixes.Length - 1)
            {
                size /= 1024;
                index++;
            }

            return $"{size:0.##} {sizeSuffixes[index]}";
        }


        private void btnNrmlCln_Click(object sender, EventArgs e)
        {
            btnNrmlCln.BackColor = Color.FromArgb(0, 3, 100);
            btnNrmlCln.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 3, 100);

            btnMnlCln.BackColor = Color.FromArgb(26, 26, 26);
            btnMnlCln.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 7, 166);

            linklblCredits.LinkColor = Color.FromArgb(255,255,255);

            pnlMnlCln.Visible = pbCredits.Visible = false;

            chkWinTemp.Checked = chkLocalTemp.Checked = chkWebcache.Checked = chkPrefetch.Checked = chkINetCache.Checked = chkWinDefender.Checked = chkPackageCache.Checked = chkWinLogs.Checked = chkWinUpdates.Checked = chkWinInstaller.Checked = chkOffice.Checked = chkAcrobat.Checked = chkChrome.Checked = chkEdge.Checked = chkJava.Checked = chkMemDMP.Checked = chkminidump.Checked = false;
        }

        private void btnMnlCln_Click(object sender, EventArgs e)
        {
            pnlMnlCln.Visible = true;

            btnNrmlCln.BackColor = Color.FromArgb(26, 26, 26);
            btnNrmlCln.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 7, 166);

            btnMnlCln.BackColor = Color.FromArgb(0, 3, 100);
            btnMnlCln.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 3, 100);

            linklblCredits.LinkColor = Color.FromArgb(255, 255, 255);

            pbCredits.Visible = false;

            chkDpCln.Checked = chk3rdCln.Checked = chkMemDmpCln.Checked = false;
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            if (pnlMnlCln.Visible)
            {
                //Code that check if no checkboxes are check, and show a messagebox if it's true
                if (!chkWinTemp.Checked &&
                    !chkLocalTemp.Checked &&
                    !chkWebcache.Checked &&
                    !chkPrefetch.Checked &&
                    !chkINetCache.Checked &&
                    !chkWinDefender.Checked &&
                    !chkPackageCache.Checked &&
                    !chkWinLogs.Checked &&
                    !chkWinUpdates.Checked &&
                    !chkWinInstaller.Checked &&
                    !chkOffice.Checked &&
                    !chkAcrobat.Checked &&
                    !chkChrome.Checked &&
                    !chkEdge.Checked &&
                    !chkJava.Checked &&
                    !chkMemDMP.Checked &&
                    !chkminidump.Checked)

                //Messagebox if no checkbox are checked, the return command won't execute the next command
                {
                    MessageBox.Show("Please select at least one folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Code that temporarily disable the checkboxes/buttons
                btnClean.Enabled = chkWinTemp.Enabled = chkLocalTemp.Enabled = chkWebcache.Enabled = chkPrefetch.Enabled = chkINetCache.Enabled = chkWinDefender.Enabled = chkPackageCache.Enabled = chkWinLogs.Enabled = chkWinUpdates.Enabled = chkWinInstaller.Enabled = chkOffice.Enabled = chkAcrobat.Enabled = chkChrome.Enabled = chkEdge.Enabled = chkJava.Enabled = chkMemDMP.Enabled = chkminidump.Enabled = false;

                //Sets progressbar value to 100
                PBMain.Value = 100;

                //Check if checkboxes are enabled and clean the folders
                if (chkWinTemp.Checked)
                {
                    DeleteFolderContents(WinTemp);
                }

                if (chkLocalTemp.Checked)
                {
                    DeleteFolderContents(LocalTemp);
                }

                if (chkWebcache.Checked)
                {
                    DeleteFolderContents(Webcache);
                }

                if (chkPrefetch.Checked)
                {
                    DeleteFolderContents(Prefetch);
                }

                if (chkINetCache.Checked)
                {
                    DeleteFolderContents(INetCache);
                }

                if (chkWinDefender.Checked)
                {
                    DeleteFolderContents(WinDefender);
                }

                if (chkPackageCache.Checked)
                {
                    DeleteFolderContents(PackageCache);
                }

                if (chkWinLogs.Checked)
                {
                    DeleteFolderContents(WinLogs);
                }

                if (chkWinUpdates.Checked)
                {
                    DeleteFolderContents(WinUpdates);
                }

                if (chkWinInstaller.Checked)
                {
                    DeleteFolderContents(WinInstallers);
                }

                if (chkOffice.Checked)
                {
                    DeleteFolderContents(Office);
                }

                if (chkAcrobat.Checked)
                {
                    DeleteFolderContents(Adobe);
                }

                if (chkChrome.Checked)
                {
                    DeleteFolderContents(Chrome);
                }

                if (chkEdge.Checked)
                {
                    DeleteFolderContents(Edge);
                }

                if (chkJava.Checked)
                {
                    DeleteFolderContents(Java);
                }

                if (chkMemDMP.Checked)
                {
                    DeleteFolderContents(MEMORYDMP);
                }

                if (chkminidump.Checked)
                {
                    DeleteFolderContents(minidump);
                }

                //Cleanup completed messagebox
                MessageBox.Show("Cleanup completed successfully.\n\nNote: there will always be some size left as some files may be being used by the system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Turn on checkboxes back
                btnClean.Enabled = chkWinTemp.Enabled = chkLocalTemp.Enabled = chkWebcache.Enabled = chkPrefetch.Enabled = chkINetCache.Enabled = chkWinDefender.Enabled = chkPackageCache.Enabled = chkWinLogs.Enabled = chkWinUpdates.Enabled = chkWinInstaller.Enabled = chkOffice.Enabled = chkAcrobat.Enabled = chkChrome.Enabled = chkEdge.Enabled = chkJava.Enabled = chkMemDMP.Enabled = chkminidump.Enabled = true;

                //Uncheck the checkboxes
                chkWinTemp.Checked = chkLocalTemp.Checked = chkWebcache.Checked = chkPrefetch.Checked = chkINetCache.Checked = chkWinDefender.Checked = chkPackageCache.Checked = chkWinLogs.Checked = chkWinUpdates.Checked = chkWinInstaller.Checked = chkOffice.Checked = chkAcrobat.Checked = chkChrome.Checked = chkEdge.Checked = chkJava.Checked = chkMemDMP.Checked = chkminidump.Checked = false;

                PBMain.Value = 0; //Sets progressbar value to 0
            }
            else
            {
                btnClean.Enabled = chkDpCln.Enabled = chk3rdCln.Enabled = chkMemDmpCln.Enabled = false;

                PBMain.Value = 100; //Sets progressbar value to 100

                //Code that call DeleteFolderContents to delete the folders
                DeleteFolderContents(MainFolders);

                //Check if checkboxes are enabled and delete corresponding folders
                if (chkDpCln.Checked)
                {
                    DeleteFolderContents(DeepClean);
                }
                if (chk3rdCln.Checked)
                {
                    DeleteFolderContents(thirdparty);
                }
                if (chkMemDmpCln.Checked)
                {
                    DeleteFolderContents(memorydump);
                }

                //Cleanup completed messagebox
                MessageBox.Show("Cleanup completed successfully.\n\nNote: there will always be some size left as some files may be being used by the system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnClean.Enabled = chkDpCln.Enabled = chk3rdCln.Enabled = chkMemDmpCln.Enabled = true;
                chkDpCln.Checked = chk3rdCln.Checked = chkMemDmpCln.Checked = false;

                PBMain.Value = 0; //Sets progressbar value to 0

                string memoryDumpPath = @"C:\Windows\MEMORY.DMP";
                string minidumpPath = @"C:\Windows\minidump";

                if (!File.Exists(memoryDumpPath) && !Directory.Exists(minidumpPath))
                {
                    chkMemDmpCln.Enabled = false;
                }

                CheckDirectoryExistsAndDisableCheckbox(chkMemDMP, memoryDumpPath);
                CheckDirectoryExistsAndDisableCheckbox(chkminidump, minidumpPath);
            }
        }
        private void linklblCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnNrmlCln.BackColor = Color.FromArgb(26, 26, 26);
            btnNrmlCln.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 7, 166);

            btnMnlCln.BackColor = Color.FromArgb(26, 26, 26);
            btnMnlCln.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 7, 166);

            linklblCredits.LinkColor = Color.FromArgb(255, 0, 0);

            pbCredits.Visible = true;


            chkWinTemp.Checked = chkLocalTemp.Checked = chkWebcache.Checked = chkPrefetch.Checked = chkINetCache.Checked = chkWinDefender.Checked = chkPackageCache.Checked = chkWinLogs.Checked = chkWinUpdates.Checked = chkWinInstaller.Checked = chkOffice.Checked = chkAcrobat.Checked = chkChrome.Checked = chkEdge.Checked = chkJava.Checked = chkMemDMP.Checked = chkminidump.Checked = false;


            chkDpCln.Checked = chk3rdCln.Checked = chkMemDmpCln.Checked = false;
        }

        private void linklblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/Hexsitt/TempClean";

            // Open the page in the system default browser
            System.Diagnostics.Process.Start(url);
        }
        private void DeleteFolderContents(string[] paths)
        {
            foreach (string path in paths)
            {
                try
                {
                    // Check if the path is a directory
                    if (Directory.Exists(path))
                    {
                        DirectoryInfo directory = new DirectoryInfo(path);

                        // Remove read-only attribute of the files
                        foreach (FileInfo file in directory.GetFiles())
                        {
                            try
                            {
                                file.Attributes = FileAttributes.Normal;
                                file.Delete();
                            }
                            catch (IOException)
                            {
                                // Ignore files in use by the system
                            }
                        }

                        // Remove read-only attribute from the subdirectories
                        foreach (DirectoryInfo subDirectory in directory.GetDirectories())
                        {
                            DeleteFolderContents(new string[] { subDirectory.FullName });
                            try
                            {
                                subDirectory.Attributes = FileAttributes.Normal;
                                subDirectory.Delete();
                            }
                            catch (IOException)
                            {
                                // Ignore files in use by the system
                            }
                        }
                    }
                    else if (File.Exists(path)) // Check if the path is a file
                    {
                        File.SetAttributes(path, FileAttributes.Normal);
                        File.Delete(path);
                    }
                }
                catch (Exception)
                {
                    // Ignore errors
                }
            }
        }
    }
}