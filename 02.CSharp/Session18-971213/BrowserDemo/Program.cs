using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.IO;
using System.Diagnostics;

namespace BrowserDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var selectedDrive = DriveSelector();
            DirectorySelector(selectedDrive);

            Console.ReadKey();
        }
        #region Selector Methods
        static string DriveSelector()
        {
            Console.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                if(drives[i].IsReady)
                    Console.WriteLine($"{i + 1}.{drives[i].Name}\t({(drives[i].IsReady ? drives[i].VolumeLabel : "Not Ready")})\t\t{drives[i].TotalFreeSpace/1024/1024/1024}/{drives[i].TotalSize/1024/1024/1024}\t{drives[i].DriveFormat}\t{drives[i].DriveType}");
                else
                    Console.WriteLine($"{i + 1}.{drives[i].Name}\t({(drives[i].IsReady ? drives[i].VolumeLabel : "Not Ready")})");
            }
            Console.WriteLine("--------------------");
            Console.Write("Enter Item Number:");

            return drives[int.Parse(Console.ReadLine()) - 1].Name;
        }

        static void DirectorySelector(string _baseDirectoryPath)
        {
            Console.Clear();
            DirectoryInfo di = new DirectoryInfo(_baseDirectoryPath);
            DirectoryInfo[] subDirectories = di.GetDirectories();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0. ../");
            for (int i = 0; i < subDirectories.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {subDirectories[i].Name}");
            }

            FileInfo[] files = di.GetFiles();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{i + 1 + subDirectories.Length}. {files[i].Name} ({PersianDateTools.ToPersianDate(files[i].LastWriteTime)})");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("--------------------");
            Console.Write("Enter Item Number:");
            var selectedItem = int.Parse(Console.ReadLine());
            if (selectedItem <= subDirectories.Length)
            {
                if (selectedItem == 0)
                {
                    if (di.Parent != null)
                    {
                        DirectorySelector(di.Parent.FullName);
                    }
                    else
                    {
                        DirectorySelector(DriveSelector());
                    }
                }
                else
                {
                    DirectorySelector(subDirectories[selectedItem - 1].FullName);//Recursive
                }
            }
            else
            {
                Process.Start(files[selectedItem - subDirectories.Length - 1].FullName);
                DirectorySelector(di.FullName);
            }
        }
        #endregion
    }
}
